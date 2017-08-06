using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TradingPlatform.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ticker { get; set; }

        public virtual ICollection<MarketData> MarketDatas { get; set; }
        public virtual ICollection<Trade> Trades { get; set; }
    }
}