using System;

namespace DashboardAS.Models
{
    public class LessonAttendance
    {
        public int AttandanceID { get; set; }
        public int? InstructorID { get; set; }
        public int? StudentID { get; set; }
        public int? BookingID { get; set; }
        public DateTime Date { get; set; }
        public string AttendanceStatus { get; set; }
        
        // Navigation properties for display
        public string InstructorName { get; set; }
        public string StudentName { get; set; }
    }
}
