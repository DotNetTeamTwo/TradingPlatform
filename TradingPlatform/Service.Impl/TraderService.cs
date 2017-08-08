using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TradingPlatform.Models;

namespace TradingPlatform.Service.Impl
{
    public class TraderService : ITraderService
    {
        private readonly DBContext context = new DBContext();

        public void AddTrader(Trader Trader)
        {
            context.Traders.Add(Trader);
            context.SaveChanges();
        }

        public Trader FindTraderByName(string name)
        {
            return context.Traders.Where(s => s.Name == name).First();
        }

        public void UpdateTrader(Trader Trader)
        {
            context.Traders.Add(Trader);
            context.Entry(Trader).State = EntityState.Modified;

            context.SaveChanges();
        }
    }
}