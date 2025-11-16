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
            // TODO: This line of code loads data into the 'dSAttendance2.StudentProgress' table. You can move, or remove it, as needed.
            this.studentProgressTableAdapter1.Fill(this.dSAttendance2.StudentProgress);
            // TODO: This line of code loads data into the 'dSAttendance2.StudentMJ' table. You can move, or remove it, as needed.
            this.studentMJTableAdapter.Fill(this.dSAttendance2.StudentMJ);
            bool arch = false;
            // TODO: This line of code loads data into the 'dsAttendance21.LessonAttendanceMJ' table. You can move, or remove it, as needed.
            //this.lessonAttendanceMJTableAdapter.Fill(this.dsAttendance21.LessonAttendanceMJ);
            //lessonAttendanceMJTableAdapter.FillByLoad(dsAttendance21.LessonAttendanceMJ, id, arch);

           

        }
        SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi");
        





        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //lessonAttendanceMJTableAdapter.FillByIDNAME(dsAttendance21.LessonAttendanceMJ,id, textBox1.Text);

        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Do you want to proceed with this action?",
            "Confirmation Required",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                { 
                int StuID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                string studentName = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                string studentSurname = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                studentProgressTableAdapter1.InsertQuery(StuID, studentName, studentSurname);
                    BindGrid();
                }
                catch
                {
                    MessageBox.Show("Student already exists", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Action was cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BindGrid()
        {

            using (SqlConnection conn = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            {
                string query = @"
                    SELECT * 
                    FROM StudentProgress ";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
              
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }

}
