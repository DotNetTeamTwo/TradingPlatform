using Microsoft.VisualStudio.TestTools.UnitTesting;
using TradingPlatform.Models;

namespace TradingPlatform.Tests.Model
{
    [TestClass]
    public class ModelTest
    {
        [TestMethod]
        public void CreateDatabase()
        {
            using (DBContext context = new DBContext())
            {
                context.Traders.Add(new Trader { Id = 1, Gender = "Male", Name = "lixing"});
                context.SaveChanges();

                Trader Trader = context.Traders.Find(1);
                context.SaveChanges();

                Assert.IsNotNull(Trader);
            }
        }

        [TestMethod]
        public void test()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
