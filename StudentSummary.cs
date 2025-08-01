using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DashboardAS
{
    public partial class StudentSummary : Form
    {
        public StudentSummary(int ID)
        {
            InitializeComponent();
            label1.Text = ID.ToString();
        }

        private void StudentSummary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSAttendance.F_Outcome' table. You can move, or remove it, as needed.
            this.f_OutcomeTableAdapter.Fill(this.dSAttendance.F_Outcome);
            // TODO: This line of code loads data into the 'dSAttendance.F_LessonAttendance' table. You can move, or remove it, as needed.
            f_LessonAttendanceTableAdapter.FillById(dSAttendance.F_LessonAttendance, int.Parse(label1.Text));


        }
        SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi");
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        void BindData()
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            f_LessonAttendanceTableAdapter.FillByStuID(dSAttendance.F_LessonAttendance, int.Parse(textBox1.Text));
        }
    }
}
