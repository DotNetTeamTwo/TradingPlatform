using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TradingPlatform.Service;
using TradingPlatform.Service.Impl;

namespace TradingPlatform.Tests.Service
{
    [TestClass]
    public class TradeServiceTest
    {
        private ITradeService service;
        [TestInitialize]
        public void init()
        {
            service = new TradeService();
        }

        [TestMethod]
        public void TestFindTradeByExecutionId()
        {
            //todo
        }
    }
}
