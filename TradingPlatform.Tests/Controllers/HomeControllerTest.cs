using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TradingPlatform;
using TradingPlatform.Controllers;
using TradingPlatform.Models;

namespace TradingPlatform.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreateDatabase()
        {
            using (DBContext context = new DBContext())
            {
                context.Traders.Add(new Trader { Id = 1, Gender = "Male", Name = "lixing", Orders = null, OrderBooks = null });
                context.SaveChanges();

                Trader Trader = context.Traders.Find(1);
                context.SaveChanges();

                Assert.IsNotNull(Trader);
            }
        }
    }
}
