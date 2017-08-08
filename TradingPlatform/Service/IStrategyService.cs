using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Models;

namespace TradingPlatform.Service
{
    public interface IStrategyService
    {
        void AddStrategy(Strategy strategy);
        void DeleteStrategyByName(string name);
        Strategy FindStrategyById(int strategyId);
        List<Strategy> FindAllStrategies();
    }
}
