using System;

namespace DashboardAS.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int? BookingID { get; set; }
        public int? StudentID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }
        
        // Navigation properties for display
        public string StudentName { get; set; }
        
        public string RatingStars => new string('★', Rating) + new string('☆', 5 - Rating);
    }
}
