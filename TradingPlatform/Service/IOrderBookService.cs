using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Models;

namespace TradingPlatform.Service
{
    interface IOrderBookService
    {
        void AddOrderBooK(OrderBook orderBook);
        List<OrderBook> FindOrderBookBySymbol();
        List<OrderBook> FindAllOrderBooks();
    }
}
