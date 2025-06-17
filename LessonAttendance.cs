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
    public partial class LessonAttendance : Form
    {
        public LessonAttendance(int InID)
        {
            InitializeComponent();
            IDLbl1.Text = InID.ToString();
        }

        private void LessonAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsAttendance1.Booking' table. You can move, or remove it, as needed.
            //this.bookingTableAdapter.Fill(this.dsAttendance1.Booking);
            bookingTableAdapter.FillByInID(dsAttendance1.Booking, int.Parse(IDLbl1.Text));
            f_LessonAttendanceTableAdapter1.FillById(dsAttendance1.F_LessonAttendance, int.Parse(IDLbl1.Text));
        }
        SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi");
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            int att = 0;
            int missed = 0;
            connec.Open();
            SqlCommand command = new SqlCommand("Insert into F_LessonAttendance values( '" + (int)dataGridView1.CurrentRow.Cells[1].Value + "','" + (int)dataGridView1.CurrentRow.Cells[2].Value + "','" + dataGridView1.CurrentRow.Cells[4].Value + "','" + (int)dataGridView1.CurrentRow.Cells[9].Value + "', '" + att + "', '" + missed + "' ,'" + dataGridView1.CurrentRow.Cells[9].Value + "')", connec);
            command.ExecuteNonQuery();
            connec.Close();
            MessageBox.Show("Registered");
            BindData();
        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("Select * from F_LessonAttendance", connec);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void AttendedBtn_Click(object sender, EventArgs e)
        {
            int allLess = (int)dataGridView2.CurrentRow.Cells[4].Value + (int)dataGridView2.CurrentRow.Cells[5].Value;
            int Less = (int)dataGridView2.CurrentRow.Cells[3].Value;
            if (Less == allLess)
            {
                MessageBox.Show("Student has attended all their lessons");
            }
            else
            {
                int up = 1;
                int att = (int)dataGridView2.CurrentRow.Cells[4].Value + up;
                int Total = (int)dataGridView2.CurrentRow.Cells[4].Value + att;
                int rem = (int)dataGridView2.CurrentRow.Cells[3].Value - Total;

                connec.Open();
                SqlCommand command = new SqlCommand("update F_LessonAttendance set StudentID = '" + (int)dataGridView2.CurrentRow.Cells[0].Value + "' ,InstructorID ='" + (int)dataGridView2.CurrentRow.Cells[1].Value + "' ,PackageID = '" + dataGridView2.CurrentRow.Cells[2].Value + "',NumberofLessons ='" + (int)dataGridView2.CurrentRow.Cells[3].Value + "',Attended = '" + att + "',Missed ='" + (int)dataGridView2.CurrentRow.Cells[5].Value + "',Remaining = '" + rem + "' where StudentID = '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", connec);
                command.ExecuteNonQuery();
                connec.Close();

                MessageBox.Show("Mark as attended");
                BindData();
            }
        }

        private void Missed_Click(object sender, EventArgs e)
        {
            int allLess = (int)dataGridView2.CurrentRow.Cells[4].Value + (int)dataGridView2.CurrentRow.Cells[5].Value;
            int Less = (int)dataGridView2.CurrentRow.Cells[3].Value;
            if (Less == allLess)
            {
                MessageBox.Show("Student has attended all their lessons");
            }
            else
            {
                int up = 1;
                
                int missed = (int)dataGridView2.CurrentRow.Cells[5].Value + up;
                int Total = (int)dataGridView2.CurrentRow.Cells[4].Value + missed;
                int rem = (int)dataGridView2.CurrentRow.Cells[3].Value - Total;

                connec.Open();
                SqlCommand command = new SqlCommand("update F_LessonAttendance set StudentID = '" + (int)dataGridView2.CurrentRow.Cells[0].Value + "' ,InstructorID ='" + (int)dataGridView2.CurrentRow.Cells[1].Value + "' ,PackageID = '" + dataGridView2.CurrentRow.Cells[2].Value + "',NumberofLessons ='" + (int)dataGridView2.CurrentRow.Cells[3].Value + "',Attended = '" + dataGridView2.CurrentRow.Cells[4].Value + "',Missed ='" + missed + "',Remaining = '" + rem + "' where StudentID = '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", connec);
                command.ExecuteNonQuery();
                connec.Close();

                MessageBox.Show("Mark as attended");
                BindData();
            }
        }
    }
}
