using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TradingPlatform.Models;
using TradingPlatform.Service;
using TradingPlatform.Service.Impl;
using TradingPlatform.Util.Strategy;

namespace TradingPlatform.Controllers
{
    public class OrderController : Controller
    {
        private IExecutionService executionService = new ExecutionService();
        private IOrderService orderService = new OrderService();
        private ITraderService traderService = new TraderService();
        // GET: Order
        public ActionResult ForwardAddOrder()
        {
            return View("AddOrder");
        }

        //Deal with the order
        public ActionResult SubmitOrder()
        {
            string strategyId = Request.Form["strategyId"];
            string traderId = Request.Form["traderId"];
            string orderBookId = Request.Form["orderBookId"];
            string side = Request.Form["side"];
            string quantity = Request.Form["quantity"];
            string price = Request.Form["price"];

            //Strategy strategy = new StrategyService().FindStrategyById(Convert.ToInt32(strategyId));
            Trader trader = new TraderService().FindTraderById(Convert.ToInt32(traderId));
            bool isBuy = false;
            if (side != null && side.Equals("B"))
                isBuy = true;
            //OrderBook orderBook = new OrderBookService().FindOrderBookById(Convert.ToInt32(orderBookId));

            Order order = new Order();
            order.DateTime = DateTime.Now;
            order.StrategyId = Convert.ToInt32(strategyId);
            order.Trader = trader;
            order.Quantity = Convert.ToInt32(quantity);
            order.IsBuy = isBuy;
            order.OrderBookId = Convert.ToInt32(orderBookId);
            if (price != null)
            {
                order.Price = Convert.ToInt32(price);
            }

            orderService.AddOrder(order);
            //int id  = orderService.GetOrderId(order);

            Execution execution = MakeTrade(order);
            executionService.AddExecution(execution);



            ViewData["orderExecution"] = execution;

            return View("OrderDetail");
        }

        private Execution MakeTrade(Order order)
        {
            string strategyName = new StrategyService().FindStrategyById(order.StrategyId).Name;
            if (strategyName == "IOC")
            {
                IOCStrategy ioc = new IOCStrategy();
                return ioc.buyorsell(order);
            }
            else if (strategyName == "MRKT")
            {
                MarketPriceStrategy mk = new MarketPriceStrategy();
                return mk.buyorsell(order);
            }
            else if (strategyName == "FOK")
            {
                FOKStrategy fok = new FOKStrategy();
                return fok.buyorsell(order);
            }
            else if (strategyName == "GTC")
            {
                return null;
            }
            else
                return null;
        }

        public ActionResult OrderHistory()
        {
            Trader trader = traderService.FindTraderByName("lixing");
            List<Order> orderHistory = orderService.FindOrderByTrader(trader);
                                     
            ViewData["orderHistory"] = orderHistory;

            return View();
        }

        public JsonResult SearchStock()
        {
            string stockName = Request.Form["stockName"];
            return Json(new Trader { Name = "lixing", Gender = "Male", Id = 1 });
        }
    }
}