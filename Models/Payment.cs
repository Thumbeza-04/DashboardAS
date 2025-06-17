using System;

namespace DashboardAS.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int? StudentID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal AmountDue { get; set; }
        public string PaymentMethod { get; set; }

        // Navigation properties for display (not stored in DB)
        public string StudentName { get; set; }
        public string PackageName { get; set; } // Retrieved from Student table

        public decimal TotalAmount => AmountPaid + AmountDue;
        public string PaymentStatus => AmountDue > 0 ? "Outstanding" : "Paid";
    }
}
