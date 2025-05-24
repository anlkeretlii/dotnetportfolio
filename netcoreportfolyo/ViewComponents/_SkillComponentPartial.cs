using Microsoft.AspNetCore.Mvc;

namespace netcoreportfolyo.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
