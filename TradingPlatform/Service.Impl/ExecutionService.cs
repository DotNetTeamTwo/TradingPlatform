using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TradingPlatform.Models;

namespace TradingPlatform.Service.Impl
{
    public class ExecutionService : IExecutionService
    {
        private readonly DBContext context = new DBContext();
        public void AddExecution(Execution execution)
        {
            context.Executions.Add(execution);
            context.SaveChanges();
        }

        public Execution FindExecutionByOrderId(int orderId)
        {
            return context.Executions.Where(s => s.Order.Id == orderId).First();
        }
    }
}