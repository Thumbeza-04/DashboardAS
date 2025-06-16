using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DashboardAS.Models;

namespace DashboardAS.Data
{
    public class PaymentDAO
    {
        public List<Payment> GetAllPayments()
        {
            List<Payment> payments = new List<Payment>();
            
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        p.PaymentID, p.BookingID, p.PaymentDate, p.AmountPaid, 
                        p.AmountDue, p.PaymentMethod,
                        s.Name + ' ' + s.Surname AS StudentName,
                        pkg.PackageName
                    FROM PaymentMJ p
                    LEFT JOIN LessonBookingMJ lb ON p.BookingID = lb.BookingID
                    LEFT JOIN StudentMJ s ON lb.StudentID = s.StudentID
                    LEFT JOIN PackageMJ pkg ON lb.PackageID = pkg.PackageName
                    ORDER BY p.PaymentDate DESC";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        payments.Add(new Payment
                        {
                            PaymentID = reader.GetInt32(reader.GetOrdinal("PaymentID")),
                            BookingID = reader.IsDBNull(reader.GetOrdinal("BookingID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("BookingID")),
                            PaymentDate = reader.GetDateTime(reader.GetOrdinal("PaymentDate")),
                            AmountPaid = reader.GetDecimal(reader.GetOrdinal("AmountPaid")),
                            AmountDue = reader.GetDecimal(reader.GetOrdinal("AmountDue")),
                            PaymentMethod = reader.IsDBNull(reader.GetOrdinal("PaymentMethod")) ? "" : reader.GetString(reader.GetOrdinal("PaymentMethod")),
                            StudentName = reader.IsDBNull(reader.GetOrdinal("StudentName")) ? "" : reader.GetString(reader.GetOrdinal("StudentName")),
                            PackageName = reader.IsDBNull(reader.GetOrdinal("PackageName")) ? "" : reader.GetString(reader.GetOrdinal("PackageName"))
                        });
                    }
                }
            }
            
            return payments;
        }
        
        public DataTable GetPaymentsForDisplay()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        p.PaymentID,
                        s.Name + ' ' + s.Surname AS Student,
                        pkg.PackageName AS Package,
                        p.PaymentDate,
                        p.AmountPaid,
                        p.AmountDue,
                        p.PaymentMethod,
                        CASE WHEN p.AmountDue > 0 THEN 'Outstanding' ELSE 'Paid' END AS Status
                    FROM PaymentMJ p
                    LEFT JOIN LessonBookingMJ lb ON p.BookingID = lb.BookingID
                    LEFT JOIN StudentMJ s ON lb.StudentID = s.StudentID
                    LEFT JOIN PackageMJ pkg ON lb.PackageID = pkg.PackageName
                    ORDER BY p.PaymentDate DESC";
                
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        
        public int AddPayment(Payment payment)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO PaymentMJ (BookingID, PaymentDate, AmountPaid, AmountDue, PaymentMethod)
                    VALUES (@BookingID, @PaymentDate, @AmountPaid, @AmountDue, @PaymentMethod);
                    SELECT SCOPE_IDENTITY();";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookingID", (object)payment.BookingID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate);
                cmd.Parameters.AddWithValue("@AmountPaid", payment.AmountPaid);
                cmd.Parameters.AddWithValue("@AmountDue", payment.AmountDue);
                cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod ?? "");
                
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        
        public decimal GetTotalRevenue()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT ISNULL(SUM(AmountPaid), 0) FROM PaymentMJ";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                
                return (decimal)cmd.ExecuteScalar();
            }
        }
        
        public decimal GetOutstandingAmount()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT ISNULL(SUM(AmountDue), 0) FROM PaymentMJ WHERE AmountDue > 0";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                
                return (decimal)cmd.ExecuteScalar();
            }
        }
    }
}
