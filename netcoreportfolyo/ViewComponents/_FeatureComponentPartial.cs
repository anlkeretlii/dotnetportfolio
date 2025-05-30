using Microsoft.AspNetCore.Mvc;
using netcoreportfolyo.DAL.Context;

namespace netcoreportfolyo.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
} 
