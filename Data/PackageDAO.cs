using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DashboardAS.Models;

namespace DashboardAS.Data
{
    public class PackageDAO
    {
        public List<Package> GetAllPackages()
        {
            List<Package> packages = new List<Package>();
            
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT PackageName, Code, NoOfLessons, Price FROM PackageMJ ORDER BY Price";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        packages.Add(new Package
                        {
                            PackageName = reader.GetString(reader.GetOrdinal("PackageName")),
                            Code = reader.IsDBNull(reader.GetOrdinal("Code")) ? "" : reader.GetString(reader.GetOrdinal("Code")),
                            NoOfLessons = reader.GetInt32(reader.GetOrdinal("NoOfLessons")),
                            Price = reader.GetDecimal(reader.GetOrdinal("Price"))
                        });
                    }
                }
            }
            
            return packages;
        }
        
        public Package GetPackageByName(string packageName)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT PackageName, Code, NoOfLessons, Price FROM PackageMJ WHERE PackageName = @PackageName";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PackageName", packageName);
                conn.Open();
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Package
                        {
                            PackageName = reader.GetString(reader.GetOrdinal("PackageName")),
                            Code = reader.IsDBNull(reader.GetOrdinal("Code")) ? "" : reader.GetString(reader.GetOrdinal("Code")),
                            NoOfLessons = reader.GetInt32(reader.GetOrdinal("NoOfLessons")),
                            Price = reader.GetDecimal(reader.GetOrdinal("Price"))
                        };
                    }
                }
            }
            
            return null;
        }
    }
}
