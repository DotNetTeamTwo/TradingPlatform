using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TradingPlatform.Models;
using TradingPlatform.Service;
using TradingPlatform.Service.Impl;

namespace TradingPlatform.Controllers
{
    public class HomeController : Controller
    {
        private IOrderBookService service = new OrderBookService();

        public ActionResult Index()
        {
            List<OrderBook> orderBooks = service.FindAllOrderBooks();
            ViewData["orderBooks"] = orderBooks;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}