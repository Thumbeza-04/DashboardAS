using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DashboardAS.Data;

namespace DashboardAS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Initialize database
            if (DatabaseInitializer.InitializeDatabase())
            {
                Application.Run(new Form4());
            }
            else
            {
                MessageBox.Show("Failed to initialize database. Application will exit.", 
                               "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
