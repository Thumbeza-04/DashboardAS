using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DashboardAS.Models;

namespace DashboardAS.Data
{
    public class StudentDAO
    {
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT StudentID, Name, Surname, Email, PhoneNumber, IDNo, Gender, 
                           StreetNumber, StreetName, City, PostalCode, Status, PackageName
                    FROM StudentMJ
                    ORDER BY Name, Surname";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            StudentID = reader.GetInt32(reader.GetOrdinal("StudentID")),
                            Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? "" : reader.GetString(reader.GetOrdinal("Name")),
                            Surname = reader.IsDBNull(reader.GetOrdinal("Surname")) ? "" : reader.GetString(reader.GetOrdinal("Surname")),
                            Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? "" : reader.GetString(reader.GetOrdinal("Email")),
                            PhoneNumber = reader.IsDBNull(reader.GetOrdinal("PhoneNumber")) ? "" : reader.GetString(reader.GetOrdinal("PhoneNumber")),
                            IDNo = reader.IsDBNull(reader.GetOrdinal("IDNo")) ? "" : reader.GetString(reader.GetOrdinal("IDNo")),
                            Gender = reader.IsDBNull(reader.GetOrdinal("Gender")) ? "" : reader.GetString(reader.GetOrdinal("Gender")),
                            StreetNumber = reader.IsDBNull(reader.GetOrdinal("StreetNumber")) ? "" : reader.GetString(reader.GetOrdinal("StreetNumber")),
                            StreetName = reader.IsDBNull(reader.GetOrdinal("StreetName")) ? "" : reader.GetString(reader.GetOrdinal("StreetName")),
                            City = reader.IsDBNull(reader.GetOrdinal("City")) ? "" : reader.GetString(reader.GetOrdinal("City")),
                            PostalCode = reader.IsDBNull(reader.GetOrdinal("PostalCode")) ? "" : reader.GetString(reader.GetOrdinal("PostalCode")),
                            Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? "" : reader.GetString(reader.GetOrdinal("Status")),
                            PackageName = reader.IsDBNull(reader.GetOrdinal("PackageName")) ? "" : reader.GetString(reader.GetOrdinal("PackageName"))
                        });
                    }
                }
            }

            return students;
        }

        public Student GetStudentById(int studentId)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT StudentID, Name, Surname, Email, PhoneNumber, IDNo, Gender, 
                           StreetNumber, StreetName, City, PostalCode, Status, PackageName
                    FROM StudentMJ
                    WHERE StudentID = @StudentID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Student
                        {
                            StudentID = reader.GetInt32(reader.GetOrdinal("StudentID")),
                            Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? "" : reader.GetString(reader.GetOrdinal("Name")),
                            Surname = reader.IsDBNull(reader.GetOrdinal("Surname")) ? "" : reader.GetString(reader.GetOrdinal("Surname")),
                            Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? "" : reader.GetString(reader.GetOrdinal("Email")),
                            PhoneNumber = reader.IsDBNull(reader.GetOrdinal("PhoneNumber")) ? "" : reader.GetString(reader.GetOrdinal("PhoneNumber")),
                            IDNo = reader.IsDBNull(reader.GetOrdinal("IDNo")) ? "" : reader.GetString(reader.GetOrdinal("IDNo")),
                            Gender = reader.IsDBNull(reader.GetOrdinal("Gender")) ? "" : reader.GetString(reader.GetOrdinal("Gender")),
                            StreetNumber = reader.IsDBNull(reader.GetOrdinal("StreetNumber")) ? "" : reader.GetString(reader.GetOrdinal("StreetNumber")),
                            StreetName = reader.IsDBNull(reader.GetOrdinal("StreetName")) ? "" : reader.GetString(reader.GetOrdinal("StreetName")),
                            City = reader.IsDBNull(reader.GetOrdinal("City")) ? "" : reader.GetString(reader.GetOrdinal("City")),
                            PostalCode = reader.IsDBNull(reader.GetOrdinal("PostalCode")) ? "" : reader.GetString(reader.GetOrdinal("PostalCode")),
                            Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? "" : reader.GetString(reader.GetOrdinal("Status")),
                            PackageName = reader.IsDBNull(reader.GetOrdinal("PackageName")) ? "" : reader.GetString(reader.GetOrdinal("PackageName"))
                        };
                    }
                }
            }

            return null;
        }

        public int AddStudent(Student student)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO StudentMJ (Name, Surname, Email, PhoneNumber, IDNo, Gender, 
                                          StreetNumber, StreetName, City, PostalCode, Status, PackageName)
                    VALUES (@Name, @Surname, @Email, @PhoneNumber, @IDNo, @Gender, 
                            @StreetNumber, @StreetName, @City, @PostalCode, @Status, @PackageName);
                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", student.Name ?? "");
                cmd.Parameters.AddWithValue("@Surname", student.Surname ?? "");
                cmd.Parameters.AddWithValue("@Email", student.Email ?? "");
                cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber ?? "");
                cmd.Parameters.AddWithValue("@IDNo", student.IDNo ?? "");
                cmd.Parameters.AddWithValue("@Gender", student.Gender ?? "");
                cmd.Parameters.AddWithValue("@StreetNumber", student.StreetNumber ?? "");
                cmd.Parameters.AddWithValue("@StreetName", student.StreetName ?? "");
                cmd.Parameters.AddWithValue("@City", student.City ?? "");
                cmd.Parameters.AddWithValue("@PostalCode", student.PostalCode ?? "");
                cmd.Parameters.AddWithValue("@Status", student.Status ?? "Active");
                cmd.Parameters.AddWithValue("@PackageName", (object)student.PackageName ?? DBNull.Value);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null && int.TryParse(result.ToString(), out int id) ? id : -1;
            }
        }

        public bool UpdateStudent(Student student)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    UPDATE StudentMJ 
                    SET Name = @Name, Surname = @Surname, Email = @Email, 
                        PhoneNumber = @PhoneNumber, IDNo = @IDNo, Gender = @Gender, 
                        StreetNumber = @StreetNumber, StreetName = @StreetName, 
                        City = @City, PostalCode = @PostalCode, Status = @Status, PackageName = @PackageName
                    WHERE StudentID = @StudentID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
                cmd.Parameters.AddWithValue("@Name", student.Name ?? "");
                cmd.Parameters.AddWithValue("@Surname", student.Surname ?? "");
                cmd.Parameters.AddWithValue("@Email", student.Email ?? "");
                cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber ?? "");
                cmd.Parameters.AddWithValue("@IDNo", student.IDNo ?? "");
                cmd.Parameters.AddWithValue("@Gender", student.Gender ?? "");
                cmd.Parameters.AddWithValue("@StreetNumber", student.StreetNumber ?? "");
                cmd.Parameters.AddWithValue("@StreetName", student.StreetName ?? "");
                cmd.Parameters.AddWithValue("@City", student.City ?? "");
                cmd.Parameters.AddWithValue("@PostalCode", student.PostalCode ?? "");
                cmd.Parameters.AddWithValue("@Status", student.Status ?? "");
                cmd.Parameters.AddWithValue("@PackageName", (object)student.PackageName ?? DBNull.Value);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteStudent(int studentId)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "DELETE FROM StudentMJ WHERE StudentID = @StudentID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", studentId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public DataTable GetStudentsWithLessonCount()
        {
            // Call the overloaded method with default parameter (exclude archived)
            return GetStudentsWithLessonCount(false);
        }

        public DataTable SearchStudents(string searchTerm)
        {
            // Call the overloaded method with default parameter (exclude archived)
            return SearchStudents(searchTerm, false);
        }

        public DataTable GetStudentsWithPackageDetails()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        s.StudentID,
                        s.Name + ' ' + s.Surname AS FullName,
                        s.PhoneNumber,
                        s.Email,
                        s.Gender,
                        s.StreetNumber + ' ' + s.StreetName + ', ' + s.City + ', ' + s.PostalCode AS FullAddress,
                        s.Status,
                        s.PackageName,
                        p.NoOfLessons,
                        p.Price AS PackagePrice,
                        COUNT(lb.BookingID) AS LessonsBooked
                    FROM StudentMJ s
                    LEFT JOIN PackageMJ p ON s.PackageName = p.PackageName
                    LEFT JOIN LessonBookingMJ lb ON s.StudentID = lb.StudentID
                    GROUP BY s.StudentID, s.Name, s.Surname, s.PhoneNumber, s.Email, s.Gender, 
                             s.StreetNumber, s.StreetName, s.City, s.PostalCode, s.Status, 
                             s.PackageName, p.NoOfLessons, p.Price
                    ORDER BY s.Name, s.Surname";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public List<Student> GetStudentsByPackage(string packageName)
        {
            List<Student> students = new List<Student>();

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT StudentID, Name, Surname, Email, PhoneNumber, IDNo, Gender, 
                           StreetNumber, StreetName, City, PostalCode, Status, PackageName
                    FROM StudentMJ
                    WHERE PackageName = @PackageName
                    ORDER BY Name, Surname";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PackageName", packageName);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            StudentID = reader.GetInt32(reader.GetOrdinal("StudentID")),
                            Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? "" : reader.GetString(reader.GetOrdinal("Name")),
                            Surname = reader.IsDBNull(reader.GetOrdinal("Surname")) ? "" : reader.GetString(reader.GetOrdinal("Surname")),
                            Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? "" : reader.GetString(reader.GetOrdinal("Email")),
                            PhoneNumber = reader.IsDBNull(reader.GetOrdinal("PhoneNumber")) ? "" : reader.GetString(reader.GetOrdinal("PhoneNumber")),
                            IDNo = reader.IsDBNull(reader.GetOrdinal("IDNo")) ? "" : reader.GetString(reader.GetOrdinal("IDNo")),
                            Gender = reader.IsDBNull(reader.GetOrdinal("Gender")) ? "" : reader.GetString(reader.GetOrdinal("Gender")),
                            StreetNumber = reader.IsDBNull(reader.GetOrdinal("StreetNumber")) ? "" : reader.GetString(reader.GetOrdinal("StreetNumber")),
                            StreetName = reader.IsDBNull(reader.GetOrdinal("StreetName")) ? "" : reader.GetString(reader.GetOrdinal("StreetName")),
                            City = reader.IsDBNull(reader.GetOrdinal("City")) ? "" : reader.GetString(reader.GetOrdinal("City")),
                            PostalCode = reader.IsDBNull(reader.GetOrdinal("PostalCode")) ? "" : reader.GetString(reader.GetOrdinal("PostalCode")),
                            Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? "" : reader.GetString(reader.GetOrdinal("Status")),
                            PackageName = reader.IsDBNull(reader.GetOrdinal("PackageName")) ? "" : reader.GetString(reader.GetOrdinal("PackageName"))
                        });
                    }
                }
            }

            return students;
        }

        // Method to get students with valid package assignments
        public List<Student> GetStudentsWithValidPackages(PackageDAO packageDAO)
        {
            var allStudents = GetAllStudents();
            var validStudents = new List<Student>();
            foreach (var student in allStudents)
            {
                // Skip students with NULL, empty, or invalid package names
                if (!string.IsNullOrEmpty(student.PackageName) &&
                    !student.PackageName.Equals("NULL", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        if (packageDAO.ValidatePackageForPayment(student.PackageName))
                        {
                            validStudents.Add(student);
                        }
                    }
                    catch
                    {
                        // Skip students with invalid packages
                        continue;
                    }
                }
            }

            return validStudents;
        }

        // Method to get students with package validation details
        public List<(Student student, bool hasValidPackage, string issue)> GetStudentsWithPackageValidation(PackageDAO packageDAO)
        {
            var result = new List<(Student student, bool hasValidPackage, string issue)>();
            var students = GetAllStudents();

            foreach (var student in students)
            {
                bool hasValidPackage = true;
                string issue = "";
                if (string.IsNullOrEmpty(student.PackageName) ||
                  student.PackageName.Equals("NULL", StringComparison.OrdinalIgnoreCase))
                {
                    hasValidPackage = false;
                    issue = "No package assigned";
                }
                else
                {
                    try
                    {
                        if (!packageDAO.ValidatePackageForPayment(student.PackageName))
                        {
                            hasValidPackage = false;
                            issue = $"Invalid package: {student.PackageName}";
                        }
                    }
                    catch (Exception ex)
                    {
                        hasValidPackage = false;
                        issue = $"Package validation error: {ex.Message}";
                    }
                }

                result.Add((student, hasValidPackage, issue));
            }

            return result;
        }

        // Archive a student by setting their status to "Archived"
        public bool ArchiveStudent(int studentId)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE StudentMJ SET Status = 'Archived' WHERE StudentID = @StudentID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", studentId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Reactivate a student by setting their status back to "Active"
        public bool ReactivateStudent(int studentId)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE StudentMJ SET Status = 'Active' WHERE StudentID = @StudentID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", studentId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Get students with lesson count, optionally including archived students
        public DataTable GetStudentsWithLessonCount(bool includeArchived = false)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string whereClause = includeArchived ? "" : "WHERE s.Status <> 'Archived'";
                
                string query = $@"
                    SELECT 
                        s.StudentID,
                        s.Name + ' ' + s.Surname AS FullName,
                        s.PhoneNumber,
                        s.Email,
                        COUNT(lb.BookingID) AS LessonsBooked,
                        s.Status,
                        s.PackageName,
                        p.NoOfLessons AS NoOfPackageLessons
                    FROM StudentMJ s
                    LEFT JOIN LessonBookingMJ lb ON s.StudentID = lb.StudentID
                    LEFT JOIN PackageMJ p ON s.PackageName = p.PackageName
                    {whereClause}
                    GROUP BY s.StudentID, s.Name, s.Surname, s.PhoneNumber, s.Email, s.Status, s.PackageName, p.NoOfLessons
                    ORDER BY s.Name, s.Surname";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Search students with option to include archived
        public DataTable SearchStudents(string searchTerm, bool includeArchived = false)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string whereClause = includeArchived ? "" : "AND s.Status <> 'Archived'";
                
                string query = $@"
                    SELECT 
                        s.StudentID,
                        s.Name + ' ' + s.Surname AS FullName,
                        s.PhoneNumber,
                        s.Email,
                        s.Gender,
                        s.StreetNumber + ' ' + s.StreetName + ', ' + s.City + ', ' + s.PostalCode AS FullAddress,
                        COUNT(lb.BookingID) AS LessonsBooked,
                        s.Status,
                        s.PackageName
                    FROM StudentMJ s
                    LEFT JOIN LessonBookingMJ lb ON s.StudentID = lb.StudentID
                    WHERE (@SearchTerm IS NULL OR @SearchTerm = '' OR
                           s.Email LIKE '%' + @SearchTerm + '%' OR
                           s.Gender LIKE '%' + @SearchTerm + '%' OR
                           s.Status LIKE '%' + @SearchTerm + '%' OR
                           s.PackageName LIKE '%' + @SearchTerm + '%' OR
                           (s.Name + ' ' + s.Surname) LIKE '%' + @SearchTerm + '%' OR
                           (s.StreetNumber + ' ' + s.StreetName + ', ' + s.City + ', ' + s.PostalCode) LIKE '%' + @SearchTerm + '%')
                    {whereClause}
                    GROUP BY s.StudentID, s.Name, s.Surname, s.PhoneNumber, s.Email, s.Gender, 
                             s.StreetNumber, s.StreetName, s.City, s.PostalCode, s.Status, s.PackageName
                    ORDER BY s.Name, s.Surname";

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
