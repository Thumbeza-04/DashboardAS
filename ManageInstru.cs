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
    public partial class ManageInstru : Form
    {
        public ManageInstru()
        {
            InitializeComponent();
        }

        private void ManageInstru_Load(object sender, EventArgs e)
        {
            bool arch = false;
            // TODO: This line of code loads data into the 'dsManager1.LessonAttendanceMJ' table. You can move, or remove it, as needed.
            //this.lessonAttendanceMJTableAdapter.Fill(this.dsManager1.LessonAttendanceMJ);
            // TODO: This line of code loads data into the 'dsManager1.Booking' table. You can move, or remove it, as needed.
            //this.bookingTableAdapter.Fill(this.dsManager1.Booking);
            bookingTableAdapter.Fill(dsManager1.Booking);
            lessonAttendanceMJTableAdapter.FillByArch(dsManager1.LessonAttendanceMJ, arch);

        }
        SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi");
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            {
                connec.Open();
                SqlTransaction transaction = connec.BeginTransaction();

                try
                {

                    bool BT = false;
                    int att = 0;
                    int missed = 0;

                    SqlCommand command1 = new SqlCommand("Insert into LessonAttendanceMJ values( '" + (int)dataGridView1.CurrentRow.Cells[1].Value + "','" + dataGridView1.CurrentRow.Cells[2].Value + "','" + dataGridView1.CurrentRow.Cells[3].Value + "','" + (int)dataGridView1.CurrentRow.Cells[4].Value + "', '" + dataGridView1.CurrentRow.Cells[5].Value + "','" + (int)dataGridView1.CurrentRow.Cells[6].Value + "','" + att + "', '" + missed + "' ,'" + (int)dataGridView1.CurrentRow.Cells[6].Value + "', '" + BT + "')", connec, transaction);
                    command1.ExecuteNonQuery();

                    SqlCommand command2 = new SqlCommand("Insert into StudentProgress values('" + (int)dataGridView1.CurrentRow.Cells[1].Value + "','" + dataGridView1.CurrentRow.Cells[2].Value + "','" + dataGridView1.CurrentRow.Cells[3].Value + "','" + (int)dataGridView1.CurrentRow.Cells[4].Value + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "')", connec, transaction);
                    command2.ExecuteNonQuery();

                    transaction.Commit();
                    


                    MessageBox.Show("Added to Attendance Registered");

                    Bind();


                }
                catch
                {
                    transaction.Rollback();
                    connec.Close();
                    MessageBox.Show("Student Already exists in the register", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void Bind()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM LessonAttendanceMJ WHERE IsArchived = 0", connec);
            

            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AttendedBtn_Click(object sender, EventArgs e)
        {
            int allLess = (int)dataGridView2.CurrentRow.Cells[6].Value + (int)dataGridView2.CurrentRow.Cells[7].Value;
            int Less = (int)dataGridView2.CurrentRow.Cells[5].Value;
            if (Less == allLess)
            {
                MessageBox.Show("Student has attended all their lessons");
            }
            else
            {
                bool arch = false;
                int up = 1;
                int att = (int)dataGridView2.CurrentRow.Cells[6].Value + up;
                int Total = (int)dataGridView2.CurrentRow.Cells[7].Value + att;
                int rem = (int)dataGridView2.CurrentRow.Cells[5].Value - Total;

                connec.Open();
                SqlCommand command = new SqlCommand("update LessonAttendanceMJ set StudentID = '" + (int)dataGridView2.CurrentRow.Cells[0].Value + "' ,StudentName ='" + dataGridView2.CurrentRow.Cells[1].Value + "' ,StudentSurname = '" + dataGridView2.CurrentRow.Cells[2].Value + "' ,InstructorID ='" + (int)dataGridView2.CurrentRow.Cells[3].Value + "' ,PackageID = '" + dataGridView2.CurrentRow.Cells[4].Value + "',NumberofLessons ='" + (int)dataGridView2.CurrentRow.Cells[5].Value + "',Attended = '" + att + "',Missed ='" + (int)dataGridView2.CurrentRow.Cells[7].Value + "',Remaining = '" + rem + "',IsArchived = '" + arch + "' where StudentID = '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", connec);
                command.ExecuteNonQuery();
                connec.Close();

                MessageBox.Show("Marked as attended");
                

                Bind();
            }
        }
    }
}
