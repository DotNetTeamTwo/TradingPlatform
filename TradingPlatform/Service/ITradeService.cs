using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Models;

namespace TradingPlatform.Service
{
    public interface ITradeService
    {
        List<Trade> FindTradeByExecutionId(int executionId);
    }
}
