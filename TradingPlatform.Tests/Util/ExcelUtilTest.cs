using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TradingPlatform.Util;

namespace TradingPlatform.Tests.Util
{
    [TestClass]
    public class ExcelUtilTest
    {
        [TestMethod]
        public void TestParseExcel()
        {
            ExcelUtil.ParseExcel("../../test.xlsx");
        }
    }
}
