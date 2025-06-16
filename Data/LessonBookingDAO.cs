using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DashboardAS.Models;

namespace DashboardAS.Data
{
    public class LessonBookingDAO
    {
        public List<LessonBooking> GetAllBookings()
        {
            List<LessonBooking> bookings = new List<LessonBooking>();
            
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {                string query = @"
                    SELECT 
                        lb.BookingID, lb.StudentID, lb.InstructorID, lb.VehicleID, 
                        lb.PackageID, lb.TimeSlotID, lb.Date, lb.Time, lb.Status,
                        s.Name + ' ' + s.Surname AS StudentName,
                        i.FirstName + ' ' + i.LastName AS InstructorName,
                        v.Make AS VehicleMake,
                        p.PackageName,
                        ts.TimeSlotLabel
                    FROM LessonBookingMJ lb
                    LEFT JOIN StudentMJ s ON lb.StudentID = s.StudentID
                    LEFT JOIN InstructorMJ i ON lb.InstructorID = i.InstructorID
                    LEFT JOIN VehicleMJ v ON lb.VehicleID = v.LicensePlateID
                    LEFT JOIN PackageMJ p ON lb.PackageID = p.PackageName
                    LEFT JOIN TimeSlotMJ ts ON lb.TimeSlotID = ts.TimeSlotID
                    ORDER BY lb.Date DESC, lb.Time DESC";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {                        bookings.Add(new LessonBooking
                        {
                            BookingID = reader.GetInt32(reader.GetOrdinal("BookingID")),
                            StudentID = reader.IsDBNull(reader.GetOrdinal("StudentID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("StudentID")),
                            InstructorID = reader.IsDBNull(reader.GetOrdinal("InstructorID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("InstructorID")),
                            VehicleID = reader.IsDBNull(reader.GetOrdinal("VehicleID")) ? "" : reader.GetString(reader.GetOrdinal("VehicleID")),
                            PackageID = reader.IsDBNull(reader.GetOrdinal("PackageID")) ? "" : reader.GetString(reader.GetOrdinal("PackageID")),
                            TimeSlotID = reader.IsDBNull(reader.GetOrdinal("TimeSlotID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("TimeSlotID")),
                            Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                            Time = reader.GetTimeSpan(reader.GetOrdinal("Time")),
                            Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? "" : reader.GetString(reader.GetOrdinal("Status")),
                            StudentName = reader.IsDBNull(reader.GetOrdinal("StudentName")) ? "" : reader.GetString(reader.GetOrdinal("StudentName")),
                            InstructorName = reader.IsDBNull(reader.GetOrdinal("InstructorName")) ? "" : reader.GetString(reader.GetOrdinal("InstructorName")),
                            VehicleMake = reader.IsDBNull(reader.GetOrdinal("VehicleMake")) ? "" : reader.GetString(reader.GetOrdinal("VehicleMake")),
                            PackageName = reader.IsDBNull(reader.GetOrdinal("PackageName")) ? "" : reader.GetString(reader.GetOrdinal("PackageName")),
                            TimeSlotLabel = reader.IsDBNull(reader.GetOrdinal("TimeSlotLabel")) ? "" : reader.GetString(reader.GetOrdinal("TimeSlotLabel"))
                        });
                    }
                }
            }
            
            return bookings;
        }
        
        public DataTable GetBookingsForDisplay()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {                string query = @"
                    SELECT 
                        lb.BookingID,
                        s.Name + ' ' + s.Surname AS Student,
                        i.FirstName + ' ' + i.LastName AS Instructor,
                        v.Make + ' (' + v.LicensePlateID + ')' AS Vehicle,
                        p.PackageName AS Package,
                        lb.Date,
                        lb.Time,
                        lb.Status
                    FROM LessonBookingMJ lb
                    LEFT JOIN StudentMJ s ON lb.StudentID = s.StudentID
                    LEFT JOIN InstructorMJ i ON lb.InstructorID = i.InstructorID
                    LEFT JOIN VehicleMJ v ON lb.VehicleID = v.LicensePlateID
                    LEFT JOIN PackageMJ p ON lb.PackageID = p.PackageName
                    ORDER BY lb.Date DESC, lb.Time DESC";
                
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        
        public int AddBooking(LessonBooking booking)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {                string query = @"
                    INSERT INTO LessonBookingMJ (StudentID, InstructorID, VehicleID, PackageID, 
                                                TimeSlotID, Date, Time, Status)
                    VALUES (@StudentID, @InstructorID, @VehicleID, @PackageID, 
                            @TimeSlotID, @Date, @Time, @Status);
                    SELECT SCOPE_IDENTITY();";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", (object)booking.StudentID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@InstructorID", (object)booking.InstructorID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@VehicleID", (object)booking.VehicleID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PackageID", (object)booking.PackageID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TimeSlotID", (object)booking.TimeSlotID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Date", booking.Date);
                cmd.Parameters.AddWithValue("@Time", booking.Time);
                cmd.Parameters.AddWithValue("@Status", booking.Status ?? "Scheduled");
                
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        
        public bool UpdateBookingStatus(int bookingId, string status)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE LessonBookingMJ SET Status = @Status WHERE BookingID = @BookingID";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookingID", bookingId);
                cmd.Parameters.AddWithValue("@Status", status);
                
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        
        public List<LessonBooking> GetUpcomingBookings(int days = 7)
        {
            List<LessonBooking> bookings = new List<LessonBooking>();
            
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {                string query = @"
                    SELECT 
                        lb.BookingID, lb.Date, lb.Time, lb.Status,
                        s.Name + ' ' + s.Surname AS StudentName,
                        i.FirstName + ' ' + i.LastName AS InstructorName,
                        v.Make AS VehicleMake
                    FROM LessonBookingMJ lb
                    LEFT JOIN StudentMJ s ON lb.StudentID = s.StudentID
                    LEFT JOIN InstructorMJ i ON lb.InstructorID = i.InstructorID
                    LEFT JOIN VehicleMJ v ON lb.VehicleID = v.LicensePlateID
                    WHERE lb.Date BETWEEN @StartDate AND @EndDate
                        AND lb.Status IN ('Scheduled', 'Confirmed')
                    ORDER BY lb.Date, lb.Time";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StartDate", DateTime.Today);
                cmd.Parameters.AddWithValue("@EndDate", DateTime.Today.AddDays(days));
                
                conn.Open();
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {                        bookings.Add(new LessonBooking
                        {
                            BookingID = reader.GetInt32(reader.GetOrdinal("BookingID")),
                            Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                            Time = reader.GetTimeSpan(reader.GetOrdinal("Time")),
                            Status = reader.GetString(reader.GetOrdinal("Status")),
                            StudentName = reader.IsDBNull(reader.GetOrdinal("StudentName")) ? "" : reader.GetString(reader.GetOrdinal("StudentName")),
                            InstructorName = reader.IsDBNull(reader.GetOrdinal("InstructorName")) ? "" : reader.GetString(reader.GetOrdinal("InstructorName")),
                            VehicleMake = reader.IsDBNull(reader.GetOrdinal("VehicleMake")) ? "" : reader.GetString(reader.GetOrdinal("VehicleMake"))
                        });
                    }
                }
            }
            
            return bookings;
        }
        
        public int AddLessonBooking(LessonBooking booking)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"INSERT INTO LessonBookingMJ (StudentID, InstructorID, Date,Time, Status)
                                 VALUES (@StudentID, @InstructorID, @LessonDate, @LessonTime, @Status);
                                 SELECT SCOPE_IDENTITY();";                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", booking.StudentID);
                cmd.Parameters.AddWithValue("@InstructorID", booking.InstructorID);
                cmd.Parameters.AddWithValue("@LessonDate", booking.Date);
                cmd.Parameters.AddWithValue("@LessonTime", booking.Time);
                cmd.Parameters.AddWithValue("@Status", booking.Status ?? "Booked");
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null && int.TryParse(result.ToString(), out int id) ? id : -1;
            }
        }
    }
}
