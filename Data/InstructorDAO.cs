using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DashboardAS.Models;

namespace DashboardAS.Data
{
    public class InstructorDAO
    {
        public List<Instructor> GetAllInstructors()
        {
            List<Instructor> instructors = new List<Instructor>();
            
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT InstructorID, LicensePlateID, LicenseNumber, ExpertiseLevel, 
                           FirstName, LastName, Gender, ContactNumber, Email
                    FROM InstructorMJ
                    ORDER BY FirstName, LastName";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        instructors.Add(new Instructor
                        {
                            InstructorID = reader.GetInt32(reader.GetOrdinal("InstructorID")),
                            LicensePlateID = reader.IsDBNull(reader.GetOrdinal("LicensePlateID")) ? "" : reader.GetString(reader.GetOrdinal("LicensePlateID")),
                            LicenseNumber = reader.IsDBNull(reader.GetOrdinal("LicenseNumber")) ? "" : reader.GetString(reader.GetOrdinal("LicenseNumber")),
                            ExpertiseLevel = reader.IsDBNull(reader.GetOrdinal("ExpertiseLevel")) ? "" : reader.GetString(reader.GetOrdinal("ExpertiseLevel")),
                            FirstName = reader.IsDBNull(reader.GetOrdinal("FirstName")) ? "" : reader.GetString(reader.GetOrdinal("FirstName")),
                            LastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? "" : reader.GetString(reader.GetOrdinal("LastName")),
                            Gender = reader.IsDBNull(reader.GetOrdinal("Gender")) ? "" : reader.GetString(reader.GetOrdinal("Gender")),
                            ContactNumber = reader.IsDBNull(reader.GetOrdinal("ContactNumber")) ? "" : reader.GetString(reader.GetOrdinal("ContactNumber")),
                            Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? "" : reader.GetString(reader.GetOrdinal("Email"))
                        });
                    }
                }
            }
            
            return instructors;
        }
        
        public DataTable GetInstructorsWithVehicleInfo()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        i.InstructorID,
                        i.FirstName + ' ' + i.LastName AS FullName,
                        i.ContactNumber,
                        i.Email,
                        i.LicenseNumber,
                        i.ExpertiseLevel,
                        v.Make + ' (' + v.LicensePlateID + ')' AS Vehicle
                    FROM InstructorMJ i
                    LEFT JOIN VehicleMJ v ON i.LicensePlateID = v.LicensePlateID
                    ORDER BY i.FirstName, i.LastName";
                
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        
        public int AddInstructor(Instructor instructor)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO InstructorMJ (LicensePlateID, LicenseNumber, ExpertiseLevel, 
                                             FirstName, LastName, Gender, ContactNumber, Email)
                    VALUES (@LicensePlateID, @LicenseNumber, @ExpertiseLevel, 
                            @FirstName, @LastName, @Gender, @ContactNumber, @Email);
                    SELECT SCOPE_IDENTITY();";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LicensePlateID", (object)instructor.LicensePlateID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LicenseNumber", instructor.LicenseNumber ?? "");
                cmd.Parameters.AddWithValue("@ExpertiseLevel", instructor.ExpertiseLevel ?? "");
                cmd.Parameters.AddWithValue("@FirstName", instructor.FirstName ?? "");
                cmd.Parameters.AddWithValue("@LastName", instructor.LastName ?? "");
                cmd.Parameters.AddWithValue("@Gender", instructor.Gender ?? "");
                cmd.Parameters.AddWithValue("@ContactNumber", instructor.ContactNumber ?? "");
                cmd.Parameters.AddWithValue("@Email", instructor.Email ?? "");
                
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        
        public bool UpdateInstructor(Instructor instructor)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    UPDATE InstructorMJ 
                    SET LicensePlateID = @LicensePlateID, LicenseNumber = @LicenseNumber, 
                        ExpertiseLevel = @ExpertiseLevel, FirstName = @FirstName, 
                        LastName = @LastName, Gender = @Gender, 
                        ContactNumber = @ContactNumber, Email = @Email
                    WHERE InstructorID = @InstructorID";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@InstructorID", instructor.InstructorID);
                cmd.Parameters.AddWithValue("@LicensePlateID", (object)instructor.LicensePlateID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LicenseNumber", instructor.LicenseNumber ?? "");
                cmd.Parameters.AddWithValue("@ExpertiseLevel", instructor.ExpertiseLevel ?? "");
                cmd.Parameters.AddWithValue("@FirstName", instructor.FirstName ?? "");
                cmd.Parameters.AddWithValue("@LastName", instructor.LastName ?? "");
                cmd.Parameters.AddWithValue("@Gender", instructor.Gender ?? "");
                cmd.Parameters.AddWithValue("@ContactNumber", instructor.ContactNumber ?? "");
                cmd.Parameters.AddWithValue("@Email", instructor.Email ?? "");
                
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        
        public DataTable SearchInstructors(string searchTerm)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        i.InstructorID,
                        i.FirstName + ' ' + i.LastName AS FullName,
                        i.ContactNumber,
                        i.Email,
                        i.LicenseNumber,
                        i.ExpertiseLevel,
                        v.Make + ' (' + v.LicensePlateID + ')' AS Vehicle
                    FROM InstructorMJ i
                    LEFT JOIN VehicleMJ v ON i.LicensePlateID = v.LicensePlateID
                    WHERE (@SearchTerm IS NULL OR @SearchTerm = '' OR
                           i.LicenseNumber LIKE '%' + @SearchTerm + '%' OR
                           i.ExpertiseLevel LIKE '%' + @SearchTerm + '%' OR
                           (i.FirstName + ' ' + i.LastName) LIKE '%' + @SearchTerm + '%' OR
                           i.Email LIKE '%' + @SearchTerm + '%')
                    ORDER BY i.FirstName, i.LastName";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SearchTerm", searchTerm ?? "");
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
