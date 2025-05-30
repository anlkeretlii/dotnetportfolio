using Microsoft.AspNetCore.Mvc;

namespace netcoreportfolyo.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
