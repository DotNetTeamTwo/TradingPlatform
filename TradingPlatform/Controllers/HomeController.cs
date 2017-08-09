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
            List<OrderBook> orderBooks = orderBookService.FindAllDistinctBooks();
            List<Strategy> strategies = strategyService.FindAllStrategies();
            Trader trader = traderService.FindTraderByName("lx");

            ViewData["orderBooks"] = orderBooks;
            ViewData["strategies"] = strategies;
            ViewData["trader"] = trader;

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