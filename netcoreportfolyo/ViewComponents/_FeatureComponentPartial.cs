using Microsoft.AspNetCore.Mvc;

namespace netcoreportfolyo.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
} 
