using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Models;

namespace TradingPlatform.Service
{
    public interface IMonitoredStockService
    {
        void AddMonitoredStock(int traderId, int orderBookId);
        void DeleteMonitoredStock(int traderId, int orderBookId);
        List<OrderBook> FindMonitoredStockByTrader(int traderId);
    }
}
