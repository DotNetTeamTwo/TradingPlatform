using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TradingPlatform.Models;

namespace TradingPlatform.Service.Impl
{
    public class OrderService : IOrderService
    {
        private readonly DBContext context = new DBContext();

        public void AddOrder(Order order)
        {
            context.Orders.Add(order);
        }

        public List<Order> FindAll()
        {
            return context.Orders.ToList();
        }

        public List<Order> FindOrderByTrader(Trader trader)
        {
            return context.Orders.Where(s => s.Trader.Name == trader.Name).ToList();
        }
    }
}