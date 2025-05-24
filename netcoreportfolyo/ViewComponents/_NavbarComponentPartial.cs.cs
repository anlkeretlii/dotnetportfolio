using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace netcoreportfolyo.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
