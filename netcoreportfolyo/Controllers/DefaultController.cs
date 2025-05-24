using Microsoft.AspNetCore.Mvc;

namespace netcoreportfolyo.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
