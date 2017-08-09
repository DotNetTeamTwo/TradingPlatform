using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TradingPlatform.Models;
using TradingPlatform.Service.Impl;

namespace TradingPlatform.Util.Strategy
{
    public class FOKStrategy
    {
        public Execution buyorsell(Order order)
        {
            OrderBook orderBook = order.OrderBook;
            List<OrderBook> orderBookList = new OrderBookService().FindOrderBookBySymbol(orderBook.Symbol);
            if (order.IsBuy)
            {
                var total = 0;
                foreach (OrderBook Q in orderBookList)
                {
                    if (order.Price == Q.Price)
                    {
                        total += Q.Quantity;
                    }

                }
                Execution exection = new Execution();
                exection.Trades = new List<Trade>();

                if (order.Quantity > total)
                {
                    exection.Trades.Add(new Trade { Id = order.Id, Price = order.Price, Quantity = order.Quantity, IsSuccess = false });
                }
                else
                {
                    int i = 0;
                    exection.Trades.Add(new Trade { Id = i, Price = order.Price, Quantity = order.Quantity, IsSuccess = true });
                    i++;
                }
                return (new Execution { Order = order, DateTime = DateTime.Now, Trades = exection.Trades });
            }

            //卖
            else
            {
                var total = 0;
                foreach (OrderBook Q in orderBookList)
                {
                    if (order.Price == Q.Price)
                    {
                        total += Q.Quantity;
                    }

                }
                Execution exection = new Execution();
                exection.Trades = new List<Trade>();

                if (order.Quantity > total)
                {
                    exection.Trades.Add(new Trade { Id = order.Id, Price = order.Price, Quantity = order.Quantity, IsSuccess = false });
                }
                else
                {
                    int i = 0;
                    exection.Trades.Add(new Trade { Id = i, Price = order.Price, Quantity = order.Quantity, IsSuccess = true });
                    i++;
                }
                return (new Execution { Order = order, DateTime = DateTime.Now, Trades = exection.Trades });
            }
        }
    }
}