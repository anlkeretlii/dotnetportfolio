using Microsoft.AspNetCore.Mvc;

namespace netcoreportfolyo.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
