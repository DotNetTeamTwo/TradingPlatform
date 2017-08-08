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
    public class OrderController : Controller
    {
        public OrderController()
        {

        }
        // GET: Order
        public ActionResult ForwardAddOrder()
        {
            return View("AddOrder");
        }

        public ActionResult SubmitOrder()
        {
            string strategyId = Request.Form["strategyId"];
            string traderId = Request.Form["traderId"];
            string orderBookId = Request.Form["orderBookId"];
            string side = Request.Form["side"];
            string quantity = Request.Form["quantity"];
            string price = Request.Form["price"];

            Strategy strategy = new StrategyService().FindStrategyById(Convert.ToInt32(strategyId));
            Trader trader = new TraderService().FindTraderById(Convert.ToInt32(traderId));
            bool isBuy = false;
            if (side != null && side.Equals("B"))
                isBuy = true;
            OrderBook orderBook = new OrderBookService().FindOrderBookById(Convert.ToInt32(orderBookId));

            Order order = new Order();
            order.DateTime = DateTime.Now;
            order.Strategy = strategy;
            order.Trader = trader;
            order.Quantity = Convert.ToInt32(quantity);
            order.IsBuy = isBuy;
            order.OrderBook = orderBook;
            if (price != null)
            {
                order.Price = Convert.ToInt32(price);
            }

            Execution execution = MakeTrade(order);
            ViewData["orderExecution"] = execution;

            return View("ExecutionDetail");
        }

        private Execution MakeTrade(Order order)
        {
            return null;
        }
    }
}