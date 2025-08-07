using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardAS
{
    public partial class ManagerDB : Form
    {
        public ManagerDB()
        {
            InitializeComponent();
        }

        private void viewbookingsbtn_Click(object sender, EventArgs e)
        {
            ViewBookings viewbookings = new ViewBookings();
            viewbookings.Show();
        }

        private void viewinstructorsbtn_Click(object sender, EventArgs e)
        {
            ViewInstructors viewInstructors = new ViewInstructors();
            viewInstructors.Show();

        }

        private void viewvehiclesbtn_Click(object sender, EventArgs e)
        {
            ViewVehicles viewVehicles = new ViewVehicles();
            viewVehicles.Show();
        }

        private void viewstaffbtn_Click(object sender, EventArgs e)
        {
            ViewStaff viewStaff = new ViewStaff();
            viewStaff.Show();
        }
    }
}
