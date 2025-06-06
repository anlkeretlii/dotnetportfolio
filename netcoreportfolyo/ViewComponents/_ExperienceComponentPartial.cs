﻿using Microsoft.AspNetCore.Mvc;
using netcoreportfolyo.DAL.Context;

namespace netcoreportfolyo.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
