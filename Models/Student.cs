using System;
namespace DashboardAS.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string IDNo { get; set; }
        public string Gender { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Status { get; set; }
        public string PackageName { get; set; } // Foreign key reference to PackageMJ
        public string FullName => $"{Name} {Surname}";
        public string FullAddress => $"{StreetNumber} {StreetName}, {City}, {PostalCode}";
    }
}
