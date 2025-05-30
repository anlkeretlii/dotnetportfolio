namespace netcoreportfolyo.DAL.Entities
{
    public class AdminProfile
    {
        public int AdminProfileId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
    }
} 