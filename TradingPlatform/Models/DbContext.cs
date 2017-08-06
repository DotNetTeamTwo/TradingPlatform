using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TradingPlatform.Models
{
    public class DBContext : DbContext
    {
        public DBContext()    // : base("name=SQLServerConnectionString")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DbContext>());
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Trader> Traders { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<MarketData> MarketDatas { get; set; }
        public DbSet<Strategy> Strategies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MarketData>().HasRequired(s => s.Stock).WithMany(s => s.MarketDatas);
            modelBuilder.Entity<Trade>().HasRequired(s => s.Stock).WithMany(s => s.Trades);
            modelBuilder.Entity<Trade>().HasRequired(s => s.Stragety).WithMany(s => s.Trades);
            modelBuilder.Entity<Trade>().HasRequired(s => s.Trader).WithMany(s => s.Trades);

            base.OnModelCreating(modelBuilder);
        }
    }
}