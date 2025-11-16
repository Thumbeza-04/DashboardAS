using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
            // TODO: This line of code loads data into the 'dSAttendance22.TemporaryStudents' table. You can move, or remove it, as needed.
            //this.temporaryStudentsTableAdapter.Fill(this.dSAttendance22.TemporaryStudents);
            // TODO: This line of code loads data into the 'dSAttendance2.TempStudent' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dSAttendance2.TempStudent' table. You can move, or remove it, as needed.
            //this.tempStudentTableAdapter1.Fill(this.dSAttendance2.TempStudent);
            int ID = id;
            
            bool arch = false;
            // TODO: This line of code loads data into the 'dSManager.TempStudent' table. You can move, or remove it, as needed.
            //this.tempStudentTableAdapter.Fill(this.dSManager.TempStudent);
            // TODO: This line of code loads data into the 'dsAttendance21.StudentProgress' table. You can move, or remove it, as needed.
            //this.studentProgressTableAdapter.Fill(this.dsAttendance21.StudentProgress);
            //temporaryStudentsTableAdapter.FillByIdArch(dSAttendance22.TemporaryStudents, ID, arch);
            //WireRadioButtons(this);
            
        }
        SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi");

        void Bind(int instructorId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM TemporaryStudents WHERE InstructorID = @InstructorID AND IsArchived = 0", connec);
            command.Parameters.AddWithValue("@InstructorID", instructorId);

            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void attBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void MissedBtn_Click(object sender, EventArgs e)
        {
            
         }

        //Evaluations

        //SqlConnection connection = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi");
        private bool isLoadingRatings = false;

        private void Savebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
           

        }

  
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}
