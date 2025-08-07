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
    public partial class ViewInstructors : Form
    {
        public ViewInstructors()
        {
            InitializeComponent();
        }

        private void ViewInstructors_Load(object sender, EventArgs e)
        {
            instructorMJTableAdapter1.Fill(managerDataSet1.InstructorMJ);
        }

        private void searchinstructorsbox_TextChanged(object sender, EventArgs e)
        {
            instructorMJTableAdapter1.FillByLastName(managerDataSet1.InstructorMJ, searchinstructorsbox.Text);
        }
    }
}
