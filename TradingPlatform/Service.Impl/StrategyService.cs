using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TradingPlatform.Models;

namespace TradingPlatform.Service.Impl
{
    public class StrategyService : IStrategyService
    {
        private readonly DBContext context = new DBContext();

        public void AddStrategy(Strategy strategy)
        {
            context.Strategies.Add(strategy);
            context.SaveChanges();
        }

        public void DeleteStrategyByName(string name)
        {
            Strategy strategy = context.Strategies.Where(s => s.Name == name).First();
            if (strategy != null)
            {
                context.Strategies.Remove(strategy);
            }

            context.SaveChanges();
        }
    }
}