using System.Collections.Generic;
using System.Web.Mvc;
using TradingPlatform.Models;
using TradingPlatform.Service;
using TradingPlatform.Service.Impl;

namespace TradingPlatform.Controllers
{
    public class HomeController : Controller
    {
        private IOrderBookService orderBookService = new OrderBookService();
        private IStrategyService strategyService = new StrategyService();
        private ITraderService traderService = new TraderService();

        public ActionResult Index()
        {
            List<OrderBook> orderBooks = orderBookService.FindAllOrderBooks();
            List<OrderBook> symbols = orderBookService.FindAllDistinctBooks();
            List<Strategy> strategies = strategyService.FindAllStrategies();
            Trader trader = traderService.FindTraderByName("lx");

            ViewData["orderBooks"] = orderBooks;
            ViewData["symbols"] = symbols;
            ViewData["strategies"] = strategies;
            ViewData["trader"] = trader;

            return View();
        }

        public ActionResult ForwardLogin()
        {
            return View("Login");
        }

        // GET: Login
        public void Login()
        {
            string username = Request.Form["username"];
            string password = Request.Form["password"];

            Trader trader = traderService.FindTraderByName(username);
            Session["trader"] = trader;

            Response.Redirect("/home/Index");
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