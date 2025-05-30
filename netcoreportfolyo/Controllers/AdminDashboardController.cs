using Microsoft.AspNetCore.Mvc;
using netcoreportfolyo.DAL.Context;
using netcoreportfolyo.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace netcoreportfolyo.Controllers
{
    public class AdminDashboardController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            // Dashboard ana sayfa istatistikleri
            ViewBag.TotalMessages = context.Messages.Count();
            ViewBag.UnreadMessages = context.Messages.Where(x => x.isRead == false).Count();
            ViewBag.ReadMessages = context.Messages.Where(x => x.isRead == true).Count();
            ViewBag.TotalSkills = context.Skills.Count();
            ViewBag.TotalExperiences = context.Experiences.Count();
            ViewBag.TotalPortfolios = context.Portfolios.Count();
            ViewBag.TotalTestimonials = context.Testimonials.Count();
            ViewBag.TotalToDoItems = context.ToDoLists.Count();
            ViewBag.CompletedToDoItems = context.ToDoLists.Where(x => x.Status == true).Count();
            ViewBag.PendingToDoItems = context.ToDoLists.Where(x => x.Status == false).Count();
            ViewBag.TotalNotifications = context.Notifications.Count();
            ViewBag.UnreadNotifications = context.Notifications.Where(x => x.IsRead == false).Count();

            // Son mesajlar
            ViewBag.RecentMessages = context.Messages.OrderByDescending(x => x.SendDate).Take(5).ToList();
            
            // Son bildirimler
            ViewBag.RecentNotifications = context.Notifications.OrderByDescending(x => x.CreatedDate).Take(5).ToList();

            // Son yapılacak işler
            ViewBag.RecentToDoItems = context.ToDoLists.OrderByDescending(x => x.Date).Take(5).ToList();

            return View();
        }

        public IActionResult SystemInfo()
        {
            // Sistem bilgileri
            ViewBag.ServerTime = DateTime.Now;
            ViewBag.AppName = "Portfolio Admin Panel";
            ViewBag.Version = "1.0.0";
            return View();
        }

        public IActionResult QuickActions()
        {
            return View();
        }

        // CRUD İşlemleri için Dashboard metodları

        // About Management
        public IActionResult AboutManagement()
        {
            var abouts = context.Abouts.ToList();
            return View(abouts);
        }

        // Contact Management  
        public IActionResult ContactManagement()
        {
            var contacts = context.Contacts.ToList();
            return View(contacts);
        }

        // Feature Management
        public IActionResult FeatureManagement()
        {
            var features = context.Features.ToList();
            return View(features);
        }

        // Portfolio Management
        public IActionResult PortfolioManagement()
        {
            var portfolios = context.Portfolios.ToList();
            return View(portfolios);
        }

        // Skill Management
        public IActionResult SkillManagement()
        {
            var skills = context.Skills.ToList();
            return View(skills);
        }

        // Social Media Management
        public IActionResult SocialMediaManagement()
        {
            var socialMedias = context.SocialMedias.ToList();
            return View(socialMedias);
        }

        // Testimonial Management
        public IActionResult TestimonialManagement()
        {
            var testimonials = context.Testimonials.ToList();
            return View(testimonials);
        }

        // Admin Profile Management
        public IActionResult AdminProfileManagement()
        {
            var adminProfiles = context.AdminProfiles.ToList();
            return View(adminProfiles);
        }

        // Site Settings Management
        public IActionResult SiteSettingsManagement()
        {
            var siteSettings = context.SiteSettings.FirstOrDefault();
            if (siteSettings == null)
            {
                siteSettings = new SiteSettings();
            }
            return View(siteSettings);
        }

        [HttpPost]
        public IActionResult UpdateSiteSettings(SiteSettings siteSettings)
        {
            var existingSettings = context.SiteSettings.FirstOrDefault();
            if (existingSettings != null)
            {
                context.SiteSettings.Update(siteSettings);
            }
            else
            {
                context.SiteSettings.Add(siteSettings);
            }
            context.SaveChanges();
            return RedirectToAction("SiteSettingsManagement");
        }

        // Notification Management
        public IActionResult NotificationManagement()
        {
            var notifications = context.Notifications.OrderByDescending(x => x.CreatedDate).ToList();
            return View(notifications);
        }

        [HttpPost]
        public IActionResult CreateNotification(string title, string description, string type)
        {
            var notification = new Notification
            {
                Title = title,
                Description = description,
                NotificationType = type,
                CreatedDate = DateTime.Now,
                IsRead = false,
                IconClass = GetIconClassByType(type)
            };
            context.Notifications.Add(notification);
            context.SaveChanges();
            return RedirectToAction("NotificationManagement");
        }

        public IActionResult MarkNotificationAsRead(int id)
        {
            var notification = context.Notifications.Find(id);
            if (notification != null)
            {
                notification.IsRead = true;
                context.SaveChanges();
            }
            return RedirectToAction("NotificationManagement");
        }

        public IActionResult DeleteNotification(int id)
        {
            var notification = context.Notifications.Find(id);
            if (notification != null)
            {
                context.Notifications.Remove(notification);
                context.SaveChanges();
            }
            return RedirectToAction("NotificationManagement");
        }

        // Backup ve Export işlemleri
        public IActionResult DataManagement()
        {
            ViewBag.LastBackupDate = DateTime.Now.AddDays(-2); // Örnek
            return View();
        }

        public IActionResult ExportData(string dataType)
        {
            // Veri export işlemleri burada yapılabilir
            TempData["Message"] = $"{dataType} verileri başarıyla export edildi.";
            return RedirectToAction("DataManagement");
        }

        // Yardımcı metotlar
        private string GetIconClassByType(string type)
        {
            return type switch
            {
                "success" => "fa fa-check-circle",
                "warning" => "fa fa-exclamation-triangle",
                "danger" => "fa fa-times-circle",
                "info" => "fa fa-info-circle",
                _ => "fa fa-bell"
            };
        }

        // Analytics sayfası
        public IActionResult Analytics()
        {
            // Grafik verileri
            ViewBag.MonthlyMessages = GetMonthlyMessageStats();
            ViewBag.SkillDistribution = GetSkillDistribution();
            ViewBag.PortfolioCategories = GetPortfolioCategories();
            
            return View();
        }

        private List<object> GetMonthlyMessageStats()
        {
            var stats = new List<object>();
            for (int i = 5; i >= 0; i--)
            {
                var date = DateTime.Now.AddMonths(-i);
                var count = context.Messages.Where(m => m.SendDate.Month == date.Month && m.SendDate.Year == date.Year).Count();
                stats.Add(new { Month = date.ToString("MMM yyyy"), Count = count });
            }
            return stats;
        }

        private List<object> GetSkillDistribution()
        {
            return context.Skills.GroupBy(s => s.Title)
                          .Select(g => new { Skill = g.Key, Count = g.Count() })
                          .ToList<object>();
        }

        private List<object> GetPortfolioCategories()
        {
            return context.Portfolios.GroupBy(p => p.Title)
                          .Select(g => new { Category = g.Key, Count = g.Count() })
                          .ToList<object>();
        }
    }
} 