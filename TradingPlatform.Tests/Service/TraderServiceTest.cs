using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TradingPlatform.Service;
using TradingPlatform.Service.Impl;
using TradingPlatform.Models;

namespace TradingPlatform.Tests.Service
{
    [TestClass]
    public class TraderServiceTest
    {
        private TraderService service;
        
        [TestInitialize]
        public void init()
        {
            service = new TraderService();
        }

        [TestMethod]
        public void TestAddTrader()
        {
            Trader trader1 = new Trader { Name = "lx", Gender = "Male"};
            Trader trader2 = new Trader { Name = "zsl", Gender = "Female"};

            service.AddTrader(trader1);
            service.AddTrader(trader2);
        }

        [TestMethod]
        public void TestFindTraderByName()
        {
            Trader trader = service.FindTraderByName("lx");

            Assert.IsNotNull(trader);
        }
    }
}
