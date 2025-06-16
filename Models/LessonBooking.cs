using System;

namespace DashboardAS.Models
{    public class LessonBooking
    {
        public int BookingID { get; set; }
        public int? StudentID { get; set; }
        public int? InstructorID { get; set; }
        public string VehicleID { get; set; }
        public string PackageID { get; set; }
        public int? TimeSlotID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Status { get; set; }
        
        // Navigation properties for display
        public string StudentName { get; set; }
        public string InstructorName { get; set; }
        public string VehicleMake { get; set; }
        public string PackageName { get; set; }
        public string TimeSlotLabel { get; set; }
        
        public string FormattedDateTime => $"{Date:yyyy-MM-dd} {Time:hh\\:mm}";
    }
}
