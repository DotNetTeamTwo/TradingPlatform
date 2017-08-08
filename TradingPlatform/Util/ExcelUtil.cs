using System;
using System.Collections.Generic;

using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
using System.Data;

namespace TradingPlatform.Util
{
    public class ExcelUtil
    {
        public static List<List<string>> ParseExcel(string filename)
        {
            var ext = Path.GetExtension(filename).ToLower();

            using (FileStream fs = File.OpenRead(filename))
            {
                IWorkbook wk;
                if (ext.Contains("xlsx"))
                    wk = new XSSFWorkbook(fs);
                else
                    wk = new HSSFWorkbook(fs);

                ISheet sheet = wk.GetSheetAt(0);
                List<List<string>> list = new List<List<string>>();

                for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)
                {
                    IRow row = sheet.GetRow(i);
                    if (row == null)
                        break;
                    List<string> rowList = new List<string>();
                    for (int j = row.FirstCellNum; j < row.LastCellNum; j++)
                    {
                        ICell cell = row.GetCell(j);
                        string cellValue = null;
                        if (cell != null)
                        {
                            switch(cell.CellType)
                            {
                                case CellType.Boolean:
                                    cellValue = cell.BooleanCellValue.ToString();
                                    break;
                                case CellType.Numeric:
                                    cellValue = cell.NumericCellValue.ToString();
                                    break;
                                case CellType.String:
                                    cellValue = cell.StringCellValue;
                                    break;
                                default:
                                    cellValue = "";
                                    break;
                            }
                        }
                        rowList.Add(cellValue);
                    }

                    list.Add(rowList);
                }
                return list;
            }
        }
    }
}