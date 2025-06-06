﻿using Microsoft.AspNetCore.Mvc;
using netcoreportfolyo.DAL.Context;

namespace netcoreportfolyo.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x => x.isRead == false).Count();
            ViewBag.v4 = context.Messages.Where(x => x.isRead == true).Count();
            return View();
        }
    }
}
