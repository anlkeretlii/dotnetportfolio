using Microsoft.AspNetCore.Mvc;
using netcoreportfolyo.DAL.Context;
using netcoreportfolyo.DAL.Entities;

namespace netcoreportfolyo.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        
        public IViewComponentResult Invoke()
        {
            // Admin profil bilgilerini al
            var adminProfile = context.AdminProfiles.FirstOrDefault(x => x.IsActive);
            ViewBag.AdminProfile = adminProfile;

            // Site ayarlarını al
            var siteSettings = context.SiteSettings.FirstOrDefault();
            ViewBag.SiteSettings = siteSettings;

            // Okunmamış bildirimleri al
            var unreadNotifications = context.Notifications
                .Where(x => !x.IsRead)
                .OrderByDescending(x => x.CreatedDate)
                .Take(5)
                .ToList();
            
            ViewBag.UnreadNotificationCount = unreadNotifications.Count;

            return View(unreadNotifications);
        }
    }
}
