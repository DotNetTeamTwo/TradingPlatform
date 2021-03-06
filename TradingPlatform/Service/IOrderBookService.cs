﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Models;

namespace TradingPlatform.Service
{
    public interface IOrderBookService
    {
        void AddOrderBooK(OrderBook orderBook);
        OrderBook FindOrderBookById(int orderBookId);
        List<OrderBook> FindOrderBookBySymbol(string symbol);
        List<OrderBook> FindAllOrderBooks();
        List<OrderBook> FindAllDistinctBooks();
    }
}
