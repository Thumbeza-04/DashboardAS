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

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManagerDB_Load(object sender, EventArgs e)
        {

        }
        private void Loadform(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }

            var form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            this.MainPanel.Controls.Add(form);
            this.MainPanel.Tag = form;

            form.Show();
        }

        private void viewbookingsbtn_Click(object sender, EventArgs e)
        {
            Loadform(new ViewBookings());
        }

        private void viewinstructorsbtn_Click(object sender, EventArgs e)
        {
            Loadform(new ViewInstructors());
        }

        private void viewvehiclesbtn_Click(object sender, EventArgs e)
        {
            Loadform(new ViewVehicles());
        }

        private void viewstaffbtn_Click(object sender, EventArgs e)
        {
            Loadform(new ViewStaff());
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Loadform(new Reports());
        }
    }
}
