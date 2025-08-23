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
        private int id;
        public StudentSummary(int ID)
        {
            InitializeComponent();
            id = ID;
        }

        private void StudentSummary_Load(object sender, EventArgs e)
        {
            bool arch = false;
            // TODO: This line of code loads data into the 'dsAttendance21.LessonAttendanceMJ' table. You can move, or remove it, as needed.
            //this.lessonAttendanceMJTableAdapter.Fill(this.dsAttendance21.LessonAttendanceMJ);
            lessonAttendanceMJTableAdapter.FillByLoad(dsAttendance21.LessonAttendanceMJ, id, arch);

        }
        SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi");

       




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
                
            
            
        }

    

       

       

       

       
    }
}
