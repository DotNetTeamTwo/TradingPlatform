using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TradingPlatform.Models;
using TradingPlatform.Service;
using TradingPlatform.Service.Impl;

namespace TradingPlatform.Tests.Service
{
    [TestClass]
    public class OrderServiceTest
    {
        [TestMethod]
        public void TestAddOrder()
        {
            Trader trader = new TraderService().FindTraderById(1);
            Strategy strategy = new StrategyService().FindStrategyById(1);
            OrderBook orderBook = new OrderBookService().FindOrderBookById(1);

            Order order = new Order { DateTime = DateTime.Now, Execution = null, IsBuy = true,Price = 12.3, Quantity = 12, Trader = trader };

            new OrderService().AddOrder(order);
        }
    }
}
