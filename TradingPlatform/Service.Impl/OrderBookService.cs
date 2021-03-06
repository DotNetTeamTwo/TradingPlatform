﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TradingPlatform.Models;

namespace TradingPlatform.Service.Impl
{
    public class OrderBookService : IOrderBookService
    {
        private readonly DBContext context = new DBContext();
        public void AddOrderBooK(OrderBook orderBook)
        {
            context.OrderBooks.Add(orderBook);
            context.SaveChanges();
        }

        public List<OrderBook> FindAllOrderBooks()
        {
            return context.OrderBooks.ToList();
        }

        public List<OrderBook> FindAllDistinctBooks()
        {
            List<OrderBook> nonDuplicate = new List<OrderBook>();

            foreach (OrderBook orderBook in context.OrderBooks)
            {
                if (!nonDuplicate.Exists(x => orderBook.Symbol == x.Symbol))
                {
                    nonDuplicate.Add(orderBook);
                }
            }
            return nonDuplicate;
        }

        public OrderBook FindOrderBookById(int orderBookId)
        {
            return context.OrderBooks.Where(s => s.Id == orderBookId).First();
        }

        public List<OrderBook> FindOrderBookBySymbol(string symbol)
        {
            return context.OrderBooks.Where(s => s.Symbol == symbol).ToList();
        }
    }
}