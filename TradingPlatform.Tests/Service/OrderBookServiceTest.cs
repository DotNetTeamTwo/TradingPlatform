using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TradingPlatform.Service;
using TradingPlatform.Service.Impl;
using TradingPlatform.Models;

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
            OrderBook orderBook = new OrderBook { IsBit = false, Orders = null, Price = 23, Quantity = 35, Symbol = "Apple", Traders = null };
            service.AddOrderBooK(orderBook);
        }
    }
}
