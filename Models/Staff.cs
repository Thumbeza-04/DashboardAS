using System;

namespace DashboardAS.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public string StaffSurname { get; set; }
        public string StaffEmail { get; set; }
        public string StaffCellNumber { get; set; }
        public string IDNo { get; set; }
        public string Gender { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        
        public string FullName => $"{StaffName} {StaffSurname}";
        public string FullAddress => $"{StreetNumber} {StreetName}, {City}, {PostalCode}";
    }
}
