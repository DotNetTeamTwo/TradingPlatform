using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TradingPlatform.Models
{
    [Table("Trader")]
    public class Trader
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        //public virtual ICollection<Order> Orders { get; set; }
    }
}