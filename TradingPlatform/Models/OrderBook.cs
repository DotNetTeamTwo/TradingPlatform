using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TradingPlatform.Models
{
    [Table("OrderBook")]
    public class OrderBook
    {
        [Key]
        public int Id { get; set; }
        public string Symbol { get; set; }
        public double Price { get; set; }
        public bool IsBit { get; set; }
        public int Quantity { get; set; }
    }
}