using Microsoft.AspNetCore.Mvc;
using netcoreportfolyo.DAL.Context;

namespace netcoreportfolyo.ViewComponents
{
    public class SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
