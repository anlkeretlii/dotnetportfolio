namespace netcoreportfolyo.DAL.Entities
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconClass { get; set; }
        public string NotificationType { get; set; } // success, warning, danger, info
        public DateTime CreatedDate { get; set; }
        public bool IsRead { get; set; }
        public string LinkUrl { get; set; }
    }
} 