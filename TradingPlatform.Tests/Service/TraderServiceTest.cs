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
            //Trader trader3 = new Trader { Gender = "Male", Name = "lixing" };

            service.AddTrader(trader1);
            service.AddTrader(trader2);
           // service.AddTrader(trader3);
        }

        [TestMethod]
        public void TestFindTraderByName()
        {
            Trader trader = service.FindTraderByName("lx");

            Assert.IsNotNull(trader);
        }
    }
}
