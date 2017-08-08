using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Models;

namespace TradingPlatform.Service
{
    public interface ITraderService
    {
        void AddTrader(Trader Trader);
        void UpdateTrader(Trader Trader);
        Trader FindTraderByName(string name);
        Trader FindTraderById(int traderId);
    }
}
