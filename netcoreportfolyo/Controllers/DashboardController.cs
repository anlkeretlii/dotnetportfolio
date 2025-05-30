using Microsoft.AspNetCore.Mvc;

namespace netcoreportfolyo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
