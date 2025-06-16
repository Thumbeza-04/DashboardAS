using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DashboardAS.Models;

namespace DashboardAS.Data
{
    public class TimeSlotDAO
    {
        public List<TimeSlot> GetAllTimeSlots()
        {
            List<TimeSlot> timeSlots = new List<TimeSlot>();
            
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT TimeSlotID, StartTime, EndTime
                    FROM TimeSlotMJ
                    ORDER BY StartTime";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        timeSlots.Add(new TimeSlot
                        {
                            TimeSlotID = reader.GetInt32(reader.GetOrdinal("TimeSlotID")),
                            StartTime = reader.GetTimeSpan(reader.GetOrdinal("StartTime")),
                            EndTime = reader.GetTimeSpan(reader.GetOrdinal("EndTime"))
                        });
                    }
                }
            }
            
            return timeSlots;
        }
        
        public TimeSlot GetTimeSlotById(int timeSlotId)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT TimeSlotID, StartTime, EndTime
                    FROM TimeSlotMJ
                    WHERE TimeSlotID = @TimeSlotID";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TimeSlotID", timeSlotId);
                conn.Open();
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new TimeSlot
                        {
                            TimeSlotID = reader.GetInt32(reader.GetOrdinal("TimeSlotID")),
                            StartTime = reader.GetTimeSpan(reader.GetOrdinal("StartTime")),
                            EndTime = reader.GetTimeSpan(reader.GetOrdinal("EndTime"))
                        };
                    }
                }
            }
            
            return null;
        }
    }
}
