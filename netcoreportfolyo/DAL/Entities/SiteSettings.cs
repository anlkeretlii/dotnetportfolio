namespace netcoreportfolyo.DAL.Entities
{
    public class SiteSettings
    {
        public int SiteSettingsId { get; set; }
        public string SiteName { get; set; }
        public string LogoUrl { get; set; }
        public string AdminPanelTitle { get; set; }
        public string FaviconUrl { get; set; }
        public string SearchPlaceholder { get; set; }
        public bool IsMaintenanceMode { get; set; }
        public string MaintenanceMessage { get; set; }
    }
} 