﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TradingPlatform.Models;
using TradingPlatform.Service.Impl;

namespace TradingPlatform.Util.Strategy
{
    public class MarketPriceStrategy
    {
        public Execution buyorsell(Order order)
        {
            OrderBook orderBook = order.OrderBook;
            List<OrderBook> orderBookList = new OrderBookService().FindOrderBookBySymbol(orderBook.Symbol);
            if (order.IsBuy)
            {
                orderBookList.Sort(delegate (OrderBook x, OrderBook y)
                {
                    return x.Price.CompareTo(y.Price);
                });
                var total = 0;
                foreach (OrderBook Q in orderBookList)
                {
                    total += Q.Quantity;
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
                    while (order.Quantity > 0)
                    {

                        if (order.Quantity < orderBookList[i].Quantity)
                        {
                            exection.Trades.Add(new Trade { Id = i, Price = orderBookList[i].Price, Quantity = order.Quantity, IsSuccess = true });
                        }
                        else
                        {
                            exection.Trades.Add(new Trade { Id = i, Price = orderBookList[i].Price, Quantity = orderBookList[i].Quantity, IsSuccess = true });
                        }
                        order.Quantity = order.Quantity - orderBookList[i].Quantity;
                        i++;
                    }
                }
                return (new Execution { Order = order, DateTime = DateTime.Now, Trades = exection.Trades });
            }
            //卖
            else
            {
                orderBookList.Sort(delegate (OrderBook x, OrderBook y)
                {
                    return y.Price.CompareTo(x.Price);
                });
                var total = 0;
                foreach (OrderBook Q in orderBookList)
                {
                    total += Q.Quantity;
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
                    while (order.Quantity > 0)
                    {

                        if (order.Quantity < orderBookList[i].Quantity)
                        {
                            exection.Trades.Add(new Trade { Id = i, Price = orderBookList[i].Price, Quantity = order.Quantity, IsSuccess = true });
                        }
                        else
                        {
                            exection.Trades.Add(new Trade { Id = i, Price = orderBookList[i].Price, Quantity = orderBookList[i].Quantity, IsSuccess = true });
                        }
                        order.Quantity = order.Quantity - orderBookList[i].Quantity;
                        i++;
                    }
                }
                return (new Execution { Order = order, DateTime = DateTime.Now, Trades = exection.Trades });
            }
        }

    }
}