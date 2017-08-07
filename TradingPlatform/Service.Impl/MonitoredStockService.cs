using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TradingPlatform.Models;

namespace TradingPlatform.Service.Impl
{
    public class MonitoredStockService : IMonitoredStockService
    {
        public void AddMonitoredStock(int traderId, int orderBookId)
        {
            throw new NotImplementedException();
        }

        public void DeleteMonitoredStock(int traderId, int orderBookId)
        {
            throw new NotImplementedException();
        }

        public List<OrderBook> FindMonitoredStockByTrader(int traderId)
        {
            throw new NotImplementedException();
        }
    }
}