﻿using Microsoft.AspNetCore.Mvc;

namespace netcoreportfolyo.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
