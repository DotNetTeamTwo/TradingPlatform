using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TradingPlatform.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public bool IsBuy { get; set; }
        public DateTime DateTime { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public int StrategyId { get; set; }
        public int ExecutionId { get; set; }
        public int OrderBookId { get; set; }
        //public int TraderId { get; set; }

        //public virtual Strategy Strategy { get; set; }
        public virtual Execution Execution { get; set; }
        //public virtual OrderBook OrderBook { get; set; }
        public virtual Trader Trader { get; set; }
    }
}