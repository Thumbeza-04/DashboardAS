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
    public partial class ViewStudentProgress : Form
    {
        private int id;
        public ViewStudentProgress(int InstrId)
        {
            InitializeComponent();
            id = InstrId;
        }

        private void ViewStudentProgress_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsAttendance21.StudentProgress' table. You can move, or remove it, as needed.
            //this.studentProgressTableAdapter.Fill(this.dsAttendance21.StudentProgress);
            studentProgressTableAdapter.FillByID(dsAttendance21.StudentProgress, id);
        }
    }
}
