using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TradingPlatform.Models
{
    public class Trade
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public bool IsBuy { get; set; }
        public DateTime Date { get; set; }

        public virtual Strategy Stragety { get; set; }
        public virtual Trader Trader { get; set; }
        public virtual Stock Stock { get; set; }
    }
}