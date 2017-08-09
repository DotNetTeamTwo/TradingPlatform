using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TradingPlatform.Service;
using TradingPlatform.Service.Impl;
using TradingPlatform.Models;
using TradingPlatform.Util;

namespace TradingPlatform.Tests.Service
{
    [TestClass]
    public class OrderBookServiceTest
    {
        private IOrderBookService service;

        [TestInitialize]
        public void init()
        {
            service = new OrderBookService();
        }

        [TestMethod]
        public void TestAddOrderBook()
        {
            //OrderBook orderBook = new OrderBook { IsBit = false, Orders = null, Price = 23, Quantity = 35, Symbol = "Apple", Traders = null };
            //service.AddOrderBooK(orderBook);
            List<List<string>> lists = ExcelUtil.ParseExcel("../../test.xlsx");
            for (int i = 0; i < lists.Count; i++)
            {
                bool isBit = false;
                if (lists[i][1].Equals("B"))
                    isBit = true;
                double price = Convert.ToDouble(lists[i][2]);
                int quantity = Convert.ToInt32(lists[i][3]);
                string symbol = lists[i][0];
                OrderBook orderBook = new OrderBook { IsBit = isBit, Price = price, Quantity = quantity, Symbol = symbol };
                service.AddOrderBooK(orderBook);
            }
        }
    }
}
