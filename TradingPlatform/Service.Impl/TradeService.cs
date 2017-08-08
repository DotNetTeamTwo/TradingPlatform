using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TradingPlatform.Models;

namespace TradingPlatform.Service.Impl
{
    public class TradeService : ITradeService
    {
        private readonly DBContext context = new DBContext();

        public List<Trade> FindTradeByExecutionId(int executionId)
        {
            return context.Executions.Where(s => s.Id == executionId).First().Trades.ToList();
        }
    }
}