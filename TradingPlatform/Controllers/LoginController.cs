using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using TradingPlatform.Models;
using TradingPlatform.Service.Impl;

namespace TradingPlatform.Controllers
{
    public class LoginController : Controller
    {
        private TraderService traderService = new TraderService();
        // GET: Login
        public void Login()
        {
            string username = Request.Form["username"];
            string password = Request.Form["password"];

            Trader trader = traderService.FindTraderByName(username);
            Session["trader"] = trader;

            Response.Redirect("/home/Index");
        }
    }
}