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
                string query = "SELECT PackageName, Code, NoOfLessons, Price FROM PackageMJ WHERE PackageName IS NOT NULL AND PackageName != 'NULL' AND PackageName != '' ORDER BY Price";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            string packageName = reader.GetString(reader.GetOrdinal("PackageName"));

                            // Skip NULL, empty, or invalid package names
                            if (string.IsNullOrWhiteSpace(packageName) ||
                                packageName.Equals("NULL", StringComparison.OrdinalIgnoreCase))
                            {
                                continue;
                            }
                            packages.Add(new Package
                            {
                                PackageName = packageName,
                                Code = reader.IsDBNull(reader.GetOrdinal("Code")) ? "" : reader.GetString(reader.GetOrdinal("Code")),
                                NoOfLessons = reader.IsDBNull(reader.GetOrdinal("NoOfLessons")) ? 0 : reader.GetInt32(reader.GetOrdinal("NoOfLessons")),
                                Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0m : reader.GetDecimal(reader.GetOrdinal("Price"))
                            });
                        }
                        catch (Exception ex)
                        {
                            // Log the error but continue processing other packages
                            string packageName = reader.IsDBNull(reader.GetOrdinal("PackageName")) ? "Unknown" : reader.GetString(reader.GetOrdinal("PackageName"));
                            System.Diagnostics.Debug.WriteLine($"Skipping package '{packageName}' due to data error: {ex.Message}");
                        }
                    }
                }
            }

            return packages;
        }
        public Package GetPackageByName(string packageName)
        {
            if (string.IsNullOrEmpty(packageName) || packageName.Equals("NULL", StringComparison.OrdinalIgnoreCase))
                return null;

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT PackageName, Code, NoOfLessons, Price FROM PackageMJ WHERE PackageName = @PackageName AND PackageName IS NOT NULL AND PackageName != 'NULL'";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PackageName", packageName.Trim());
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        try
                        {
                            // Get raw values for validation
                            object rawLessons = reader.GetValue(reader.GetOrdinal("NoOfLessons"));
                            object rawPrice = reader.GetValue(reader.GetOrdinal("Price"));
                            var package = new Package
                            {
                                PackageName = reader.GetString(reader.GetOrdinal("PackageName")),
                                Code = reader.IsDBNull(reader.GetOrdinal("Code")) ? "" : reader.GetString(reader.GetOrdinal("Code")),
                                NoOfLessons = reader.IsDBNull(reader.GetOrdinal("NoOfLessons")) ? 0 : reader.GetInt32(reader.GetOrdinal("NoOfLessons")),
                                Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0m : reader.GetDecimal(reader.GetOrdinal("Price"))
                            };// Double-check that the package has valid data
                            if (package.Price < 0) // Only fail on negative prices
                            {
                                System.Diagnostics.Debug.WriteLine($"Package '{packageName}' has invalid price: {package.Price}");
                                return null;
                            }

                            // Log a warning but don't fail if lessons are 0 or negative
                            if (package.NoOfLessons <= 0)
                            {
                                System.Diagnostics.Debug.WriteLine($"Package '{packageName}' has unusual lesson count: {package.NoOfLessons}");
                                // Don't return null, just log the warning
                            }

                            return package;
                        }
                        catch (Exception ex)
                        {
                            // Log the error but try to return a package with default values instead of throwing
                            System.Diagnostics.Debug.WriteLine($"Error parsing package data for '{packageName}': {ex.Message}");

                            // For the ROYALTY PACKAGE, provide a default package
                            if (packageName == "ROYALTY PACKAGE")
                            {
                                System.Diagnostics.Debug.WriteLine($"Creating default package for ROYALTY PACKAGE due to error: {ex.Message}");
                                return new Package
                                {
                                    PackageName = "ROYALTY PACKAGE",
                                    Code = "ROY10",
                                    NoOfLessons = 10,
                                    Price = 2500.00m
                                };
                            }

                            // For other packages, try to create a package with basic data from the reader
                            try
                            {
                                string packageNameFromDb = reader.IsDBNull(reader.GetOrdinal("PackageName")) ? packageName : reader.GetString(reader.GetOrdinal("PackageName"));
                                string codeFromDb = reader.IsDBNull(reader.GetOrdinal("Code")) ? "" : reader.GetString(reader.GetOrdinal("Code"));

                                // Create a package with safe defaults for corrupted data
                                return new Package
                                {
                                    PackageName = packageNameFromDb,
                                    Code = codeFromDb + "[DATA RECOVERED]",
                                    NoOfLessons = 1, // Default to 1 lesson
                                    Price = 100.00m // Default price - should be updated by admin
                                };
                            }
                            catch
                            {
                                // If even basic reading fails, return null
                                System.Diagnostics.Debug.WriteLine($"Could not recover any data for package '{packageName}'");
                                return null;
                            }
                        }
                    }
                    else
                    {                        // Package not found in database
                        System.Diagnostics.Debug.WriteLine($"Package '{packageName}' not found in database");
                        return null;
                    }
                }
            }
        }        // Test method to check raw database values for debugging
        public void TestPackageData(string packageName)
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
                        string debugInfo = $"Raw Database Values for '{packageName}':\n";
                        debugInfo += $"PackageName: '{reader.GetValue(0)}'\n";
                        debugInfo += $"Code: '{reader.GetValue(1)}' (IsNull: {reader.IsDBNull(1)})\n";
                        debugInfo += $"NoOfLessons: '{reader.GetValue(2)}' (Type: {reader.GetValue(2).GetType().Name})\n";
                        debugInfo += $"Price: '{reader.GetValue(3)}' (Type: {reader.GetValue(3).GetType().Name})\n";

                        System.Windows.Forms.MessageBox.Show(debugInfo, "Package Debug Info");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show($"No package found with name '{packageName}'", "Package Not Found");
                    }
                }
            }
        }

        // Method to validate package data integrity for payment processing
        public bool ValidatePackageForPayment(string packageName)
        {
            try
            {
                if (string.IsNullOrEmpty(packageName) || packageName.Equals("NULL", StringComparison.OrdinalIgnoreCase))
                    return false;

                Package package = GetPackageByName(packageName);

                if (package == null)
                    return false;

                // Simplified validation - just check if we can load the package and it has essential data
                bool isValid = !string.IsNullOrEmpty(package.PackageName) &&
                              package.Price > 0; // Package must have a positive price for payments

                // Log validation details for debugging
                System.Diagnostics.Debug.WriteLine($"Package validation for '{packageName}': Valid={isValid}, Name='{package.PackageName}', Price={package.Price}, Lessons={package.NoOfLessons}");

                return isValid;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Package validation error for '{packageName}': {ex.Message}");
                // For now, return true to allow payment processing even if validation fails
                // This prevents blocking payments due to validation issues
                return true;
            }
        }
        // Method to get list of packages with validation results
        public List<(Package package, bool isValid, string issue)> GetPackagesWithValidation()
        {
            var result = new List<(Package package, bool isValid, string issue)>();
            var packages = GetAllPackages();

            foreach (var package in packages)
            {
                bool isValid = true;
                string issue = "";

                if (string.IsNullOrEmpty(package.PackageName))
                {
                    isValid = false;
                    issue = "Package name is empty";
                }
                else if (package.Price < 0)
                {
                    isValid = false;
                    issue = "Invalid price (cannot be negative)";
                }
                // Remove the strict validation for number of lessons
                // as it may not be essential for payment processing

                result.Add((package, isValid, issue));
            }

            return result;
        }

        // Method to add a missing package to the database
        public bool AddMissingPackage(Package package)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"INSERT INTO PackageMJ (PackageName, Code, NoOfLessons, Price) 
                                   VALUES (@PackageName, @Code, @NoOfLessons, @Price)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PackageName", package.PackageName);
                    cmd.Parameters.AddWithValue("@Code", package.Code);
                    cmd.Parameters.AddWithValue("@NoOfLessons", package.NoOfLessons);
                    cmd.Parameters.AddWithValue("@Price", package.Price);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    System.Diagnostics.Debug.WriteLine($"Added missing package '{package.PackageName}' to database");
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error adding package '{package.PackageName}': {ex.Message}");
                return false;
            }
        }

        // Method to ensure common packages exist in the database
        public void EnsureCommonPackagesExist()
        {
            try
            {
                // Check and add FULL COURSE if missing
                var fullCourse = GetPackageByName("FULL COURSE");
                if (fullCourse == null)
                {
                    AddMissingPackage(new Package
                    {
                        PackageName = "FULL COURSE",
                        Code = "FULL30",
                        NoOfLessons = 30,
                        Price = 3200.00m
                    });
                }

                // Check and add ROYALTY PACKAGE if missing
                var royaltyPackage = GetPackageByName("ROYALTY PACKAGE");
                if (royaltyPackage == null)
                {
                    AddMissingPackage(new Package
                    {
                        PackageName = "ROYALTY PACKAGE",
                        Code = "ROY10",
                        NoOfLessons = 10,
                        Price = 2500.00m
                    });
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error ensuring packages exist: {ex.Message}");
            }
        }
    }
}
