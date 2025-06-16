using System;

namespace DashboardAS.Models
{
    public class UserLogin
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public int? StaffID { get; set; }
        
        // Navigation property for display
        public string StaffName { get; set; }
    }
}
