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
    public partial class ViewStaff : Form
    {
        public ViewStaff()
        {
            InitializeComponent();
        }

        private void ViewStaff_Load(object sender, EventArgs e)
        {
            staffMJTableAdapter1.Fill(managerDataSet1.StaffMJ);
        }

        private void searchstaffbox_TextChanged(object sender, EventArgs e)
        {
            staffMJTableAdapter1.FillByStaffSurname(managerDataSet1.StaffMJ, searchstaffbox.Text);
        }
    }
}
