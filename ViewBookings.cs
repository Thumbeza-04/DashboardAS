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
    public partial class ViewBookings : Form
    {
        public ViewBookings()
        {
            InitializeComponent();
        }

        private void ViewBookings_Load(object sender, EventArgs e)
        {
            lessonBookingMJTableAdapter.FillBy(mangerNEW.LessonBookingMJ);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void searchbookingsbox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
