using System;

namespace DashboardAS.Models
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string LicensePlateID { get; set; }
        public string LicenseNumber { get; set; }
        public string ExpertiseLevel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        
        public string FullName => $"{FirstName} {LastName}";
    }
}
