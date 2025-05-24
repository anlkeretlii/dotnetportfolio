using Microsoft.AspNetCore.Mvc;

namespace netcoreportfolyo.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
        