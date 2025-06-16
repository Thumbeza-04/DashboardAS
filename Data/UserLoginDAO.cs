using System;
using System.Data.SqlClient;
using DashboardAS.Models;

namespace DashboardAS.Data
{
    public class UserLoginDAO
    {
        /// <summary>
        /// Authenticates a user with username and password
        /// </summary>
        /// <param name="username">Username to authenticate</param>
        /// <param name="password">Password to authenticate</param>
        /// <returns>UserLogin object if authentication successful, null otherwise</returns>
        public static UserLogin AuthenticateUser(string username, string password)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    
                    string query = @"
                        SELECT ul.UserID, ul.Username, ul.PasswordHash, ul.Role, ul.StaffID, s.StaffName as StaffName
                        FROM UserLoginMJ ul
                        LEFT JOIN StaffMJ s ON ul.StaffID = s.StaffID
                        WHERE ul.Username = @Username AND ul.PasswordHash = @Password";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new UserLogin
                                {
                                    UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                    Username = reader.IsDBNull(reader.GetOrdinal("Username")) ? "" : reader.GetString(reader.GetOrdinal("Username")),
                                    PasswordHash = reader.IsDBNull(reader.GetOrdinal("PasswordHash")) ? "" : reader.GetString(reader.GetOrdinal("PasswordHash")),
                                    Role = reader.IsDBNull(reader.GetOrdinal("Role")) ? "" : reader.GetString(reader.GetOrdinal("Role")),
                                    StaffID = reader.IsDBNull(reader.GetOrdinal("StaffID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("StaffID")),
                                    StaffName = reader.IsDBNull(reader.GetOrdinal("StaffName")) ? null : reader.GetString(reader.GetOrdinal("StaffName"))
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Log SQL-specific exceptions
                System.Diagnostics.Debug.WriteLine($"SQL Authentication error: {sqlEx.Message}");
                System.Diagnostics.Debug.WriteLine($"SQL Error Number: {sqlEx.Number}");
                throw new Exception($"Database authentication error: {sqlEx.Message}", sqlEx);
            }
            catch (Exception ex)
            {
                // Log the exception if you have logging in place
                System.Diagnostics.Debug.WriteLine($"Authentication error: {ex.Message}");
                throw new Exception("Authentication failed due to database error.", ex);
            }
            
            return null; // Authentication failed
        }
        
        /// <summary>
        /// Gets user information by username
        /// </summary>
        /// <param name="username">Username to look up</param>
        /// <returns>UserLogin object if found, null otherwise</returns>
        public static UserLogin GetUserByUsername(string username)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    
                    string query = @"
                        SELECT ul.UserID, ul.Username, ul.PasswordHash, ul.Role, ul.StaffID, s.StaffName as StaffName
                        FROM UserLoginMJ ul
                        LEFT JOIN StaffMJ s ON ul.StaffID = s.StaffID
                        WHERE ul.Username = @Username";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new UserLogin
                                {
                                    UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                    Username = reader.IsDBNull(reader.GetOrdinal("Username")) ? "" : reader.GetString(reader.GetOrdinal("Username")),
                                    PasswordHash = reader.IsDBNull(reader.GetOrdinal("PasswordHash")) ? "" : reader.GetString(reader.GetOrdinal("PasswordHash")),
                                    Role = reader.IsDBNull(reader.GetOrdinal("Role")) ? "" : reader.GetString(reader.GetOrdinal("Role")),
                                    StaffID = reader.IsDBNull(reader.GetOrdinal("StaffID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("StaffID")),
                                    StaffName = reader.IsDBNull(reader.GetOrdinal("StaffName")) ? null : reader.GetString(reader.GetOrdinal("StaffName"))
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                System.Diagnostics.Debug.WriteLine($"SQL Error getting user: {sqlEx.Message}");
                System.Diagnostics.Debug.WriteLine($"SQL Error Number: {sqlEx.Number}");
                throw new Exception($"Database error retrieving user: {sqlEx.Message}", sqlEx);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error getting user: {ex.Message}");
                throw new Exception("Failed to retrieve user information.", ex);
            }
            
            return null;
        }
    }
}