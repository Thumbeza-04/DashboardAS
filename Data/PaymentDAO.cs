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
                        p.PaymentID, p.StudentID, p.PaymentDate, p.AmountPaid, 
                        p.AmountDue, p.PaymentMethod,
                        s.Name + ' ' + s.Surname AS StudentName,
                        s.PackageName
                    FROM PaymentMJ p
                    LEFT JOIN StudentMJ s ON p.StudentID = s.StudentID
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
                            StudentID = reader.IsDBNull(reader.GetOrdinal("StudentID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("StudentID")),
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
                        s.PackageName AS Package,
                        p.PaymentDate,
                        p.AmountPaid,
                        p.AmountDue,
                        p.PaymentMethod,
                        CASE WHEN p.AmountDue > 0 THEN 'Outstanding' ELSE 'Paid' END AS Status
                    FROM PaymentMJ p
                    LEFT JOIN StudentMJ s ON p.StudentID = s.StudentID
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
                    INSERT INTO PaymentMJ (StudentID, PaymentDate, AmountPaid, AmountDue, PaymentMethod)
                    VALUES (@StudentID, @PaymentDate, @AmountPaid, @AmountDue, @PaymentMethod);
                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", (object)payment.StudentID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate);
                cmd.Parameters.AddWithValue("@AmountPaid", payment.AmountPaid);
                cmd.Parameters.AddWithValue("@AmountDue", payment.AmountDue);
                cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod ?? "");

                conn.Open(); return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public Payment GetPaymentById(int paymentId)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        p.PaymentID, p.StudentID, p.PaymentDate, p.AmountPaid, 
                        p.AmountDue, p.PaymentMethod,
                        s.Name + ' ' + s.Surname AS StudentName,
                        s.PackageName
                    FROM PaymentMJ p
                    LEFT JOIN StudentMJ s ON p.StudentID = s.StudentID
                    WHERE p.PaymentID = @PaymentID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PaymentID", paymentId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Payment
                        {
                            PaymentID = reader.GetInt32(reader.GetOrdinal("PaymentID")),
                            StudentID = reader.IsDBNull(reader.GetOrdinal("StudentID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("StudentID")),
                            PaymentDate = reader.GetDateTime(reader.GetOrdinal("PaymentDate")),
                            AmountPaid = reader.GetDecimal(reader.GetOrdinal("AmountPaid")),
                            AmountDue = reader.GetDecimal(reader.GetOrdinal("AmountDue")),
                            PaymentMethod = reader.IsDBNull(reader.GetOrdinal("PaymentMethod")) ? "" : reader.GetString(reader.GetOrdinal("PaymentMethod")),
                            StudentName = reader.IsDBNull(reader.GetOrdinal("StudentName")) ? "" : reader.GetString(reader.GetOrdinal("StudentName")),
                            PackageName = reader.IsDBNull(reader.GetOrdinal("PackageName")) ? "" : reader.GetString(reader.GetOrdinal("PackageName"))
                        };
                    }
                }
            }

            return null;
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
        public decimal GetTotalPaymentsByStudent(int studentId)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT ISNULL(SUM(p.AmountPaid), 0) 
                    FROM PaymentMJ p
                    WHERE p.StudentID = @StudentID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                conn.Open();

                return (decimal)cmd.ExecuteScalar();
            }
        }
        public List<Payment> GetPaymentsByStudent(int studentId)
        {
            List<Payment> payments = new List<Payment>();

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        p.PaymentID, p.StudentID, p.PaymentDate, p.AmountPaid, 
                        p.AmountDue, p.PaymentMethod,
                        s.Name + ' ' + s.Surname AS StudentName,
                        s.PackageName
                    FROM PaymentMJ p
                    LEFT JOIN StudentMJ s ON p.StudentID = s.StudentID
                    WHERE p.StudentID = @StudentID
                    ORDER BY p.PaymentDate DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        payments.Add(new Payment
                        {
                            PaymentID = reader.GetInt32(reader.GetOrdinal("PaymentID")),
                            StudentID = reader.IsDBNull(reader.GetOrdinal("StudentID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("StudentID")),
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
        public bool UpdatePayment(Payment payment)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    UPDATE PaymentMJ 
                    SET StudentID = @StudentID, 
                        PaymentDate = @PaymentDate, 
                        AmountPaid = @AmountPaid, 
                        AmountDue = @AmountDue, 
                        PaymentMethod = @PaymentMethod
                    WHERE PaymentID = @PaymentID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PaymentID", payment.PaymentID);
                cmd.Parameters.AddWithValue("@StudentID", (object)payment.StudentID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate);
                cmd.Parameters.AddWithValue("@AmountPaid", payment.AmountPaid);
                cmd.Parameters.AddWithValue("@AmountDue", payment.AmountDue);
                cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod ?? "");

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeletePayment(int paymentId)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "DELETE FROM PaymentMJ WHERE PaymentID = @PaymentID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PaymentID", paymentId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public int GetPaymentsToday()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT COUNT(*) 
                    FROM PaymentMJ 
                    WHERE CAST(PaymentDate AS DATE) = CAST(GETDATE() AS DATE)";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                return (int)cmd.ExecuteScalar();
            }
        }

        public bool IsStudentFullyPaid(int studentId)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        CASE 
                            WHEN ISNULL(SUM(p.AmountPaid), 0) >= pkg.Price THEN 1 
                            ELSE 0 
                        END AS IsFullyPaid
                    FROM StudentMJ s
                    LEFT JOIN PaymentMJ p ON s.StudentID = p.StudentID
                    LEFT JOIN PackageMJ pkg ON s.PackageName = pkg.PackageName
                    WHERE s.StudentID = @StudentID
                    GROUP BY pkg.Price";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                conn.Open();

                object result = cmd.ExecuteScalar();
                return result != null && Convert.ToBoolean(result);
            }
        }
    }
}
