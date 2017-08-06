using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TradingPlatform.Models
{
    public class MarketData
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double Open { get; set; }
        public int Volume { get; set; }
        public DateTime Datetime { get; set; }

        public virtual Stock Stock { get; set; }
    }
}