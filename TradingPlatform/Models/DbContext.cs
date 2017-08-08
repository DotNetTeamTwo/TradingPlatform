using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TradingPlatform.Models
{
    public class DBContext : DbContext
    {
        public DBContext() : base("name=DBContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DBContext>());
        }

        public DbSet<Execution> Executions { get; set; }
        public DbSet<Trader> Traders { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Strategy> Strategies { get; set; }
        public DbSet<OrderBook> OrderBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasRequired(s => s.Trader).WithMany(s => s.Orders);
            modelBuilder.Entity<Order>().HasRequired(s => s.Strategy).WithMany(s => s.Orders);
            modelBuilder.Entity<Order>().HasRequired(s => s.OrderBook).WithMany(s => s.Orders);
            modelBuilder.Entity<Trade>().HasRequired(s => s.Execution).WithMany(s => s.Trades);

            modelBuilder.Entity<Execution>().HasRequired(s => s.Order).WithOptional(s => s.Execution);
            modelBuilder.Entity<Trader>().HasMany(s => s.OrderBooks).WithMany(s => s.Traders).Map
                (s => {
                    s.MapLeftKey("TraderId");
                    s.MapRightKey("OrderBookId");
                    s.ToTable("MonitoredStock");
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}