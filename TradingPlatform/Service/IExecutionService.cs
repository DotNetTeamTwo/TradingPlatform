using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Models;

namespace TradingPlatform.Service
{
    interface IExecutionService
    {
        Execution FindExecutionByOrderId(int orderId);
        void AddExecution(Execution execution);
    }
}
