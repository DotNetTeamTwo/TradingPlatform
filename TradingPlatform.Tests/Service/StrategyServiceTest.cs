using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TradingPlatform.Service;
using TradingPlatform.Service.Impl;
using TradingPlatform.Models;

namespace TradingPlatform.Tests.Service
{
    [TestClass]
    public class StrategyServiceTest
    {
        private IStrategyService service;

        [TestInitialize]
        public void init()
        {
            service = new StrategyService();
        }

        [TestMethod]
        public void TestAddStrategy()
        {
            Strategy strategy1 = new Strategy { Name = "FOK" };
            Strategy strategy2 = new Strategy { Name = "IOC" };

            service.AddStrategy(strategy1);
            service.AddStrategy(strategy2);
        }
    }
}
