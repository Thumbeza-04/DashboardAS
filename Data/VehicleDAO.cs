using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DashboardAS.Models;

namespace DashboardAS.Data
{
    public class VehicleDAO
    {
        public List<Vehicle> GetAllVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT LicensePlateID, TransmissionType, FuelType, Make, VehicleType 
                    FROM VehicleMJ 
                    ORDER BY Make";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        vehicles.Add(new Vehicle
                        {
                            LicensePlateID = reader.GetString(reader.GetOrdinal("LicensePlateID")),
                            TransmissionType = reader.IsDBNull(reader.GetOrdinal("TransmissionType")) ? "" : reader.GetString(reader.GetOrdinal("TransmissionType")),
                            FuelType = reader.IsDBNull(reader.GetOrdinal("FuelType")) ? "" : reader.GetString(reader.GetOrdinal("FuelType")),
                            Make = reader.IsDBNull(reader.GetOrdinal("Make")) ? "" : reader.GetString(reader.GetOrdinal("Make")),
                            VehicleType = reader.IsDBNull(reader.GetOrdinal("VehicleType")) ? "" : reader.GetString(reader.GetOrdinal("VehicleType"))
                        });
                    }
                }
            }
            
            return vehicles;
        }
        
        public List<Vehicle> GetAvailableVehicles()
        {
            // For now, return all vehicles. Later can be enhanced to check availability
            return GetAllVehicles();
        }
    }
}
