﻿using Microsoft.AspNetCore.Mvc;
using netcoreportfolyo.DAL.Context;

namespace netcoreportfolyo.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Inbox()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
        public IActionResult ChangeIsReadToTrue(int id)
        {
            var value = context.Messages.Find(id);
            value.isRead = true;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult ChangeIsReadToFalse(int id)
        {
            var value = context.Messages.Find(id);
            value.isRead = false;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id);
            context.Messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult MessageDetail(int id)
        {
            var value = context.Messages.Find(id);
            return View(value);
        }
    }
}
