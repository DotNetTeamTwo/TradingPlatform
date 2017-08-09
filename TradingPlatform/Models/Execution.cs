using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TradingPlatform.Models
{
    [Table("Execution")]
    public class Execution
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual ICollection<Trade> Trades { get; set; }
    }
}