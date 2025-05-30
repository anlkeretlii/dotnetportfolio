using Microsoft.AspNetCore.Mvc;

namespace netcoreportfolyo.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
