using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TradingPlatform.Models
{
    public class Trader
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Trade> Trades { get; set; }
    }
}