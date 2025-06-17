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
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["WstGrp24"]?.ConnectionString;
                if (string.IsNullOrEmpty(connectionString))
                {
                    // Fallback connection string for design time or if config is missing
                    connectionString = "Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi";
                }
            }
            catch
            {
                // Fallback for design time
                connectionString = "Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi";
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static string ConnectionString => connectionString;
    }
}
