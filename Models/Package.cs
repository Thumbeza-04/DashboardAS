using System;

namespace DashboardAS.Models
{
    public class Package
    {
        public string PackageName { get; set; }
        public string Code { get; set; }
        public int NoOfLessons { get; set; }
        public decimal Price { get; set; }
        
        public string DisplayText => $"{PackageName} ({NoOfLessons} lessons) - R{Price:F2}";
    }
}
