using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DashboardAS.Data
{
    public static class DatabaseConnection
    {
        private static string connectionString;
        
        static DatabaseConnection()
        {
            connectionString = ConfigurationManager.ConnectionStrings["WstGrp24"].ConnectionString;
        }
        
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        
        public static string ConnectionString => connectionString;
    }
}
