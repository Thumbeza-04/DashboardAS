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
        private int id;
        public LessonAttendance(int InID)
        {
  
            InitializeComponent();
            id = InID;
        }

        private void LessonAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsAttendance21.Booking' table. You can move, or remove it, as needed.
            //this.bookingTableAdapter.Fill(this.dsAttendance21.Booking);
            // TODO: This line of code loads data into the 'dsAttendance21.Bookings' table. You can move, or remove it, as needed.
            //this.bookingsTableAdapter.Fill(this.dsAttendance21.Bookings);
            // TODO: This line of code loads data into the 'dsAttendance1.Booking' table. You can move, or remove it, as needed.
            //this.bookingTableAdapter.Fill(this.dsAttendance1.Booking);
            bookingTableAdapter.FillByInID(dsAttendance21.Booking, id);
            lessonAttendanceMJTableAdapter1.FillByID(dsAttendance21.LessonAttendanceMJ, id);
        }
        SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi");
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            int ID = id;
            try
            {
                

                int att = 0;
                int missed = 0;
                connec.Open();
                SqlCommand command = new SqlCommand("Insert into LessonAttendanceMJ values( '" + (int)dataGridView1.CurrentRow.Cells[1].Value + "','" + dataGridView1.CurrentRow.Cells[2].Value + "','" + dataGridView1.CurrentRow.Cells[3].Value + "','" + ID + "', '" + dataGridView1.CurrentRow.Cells[4].Value + "','" + (int)dataGridView1.CurrentRow.Cells[5].Value + "','" + att + "', '" + missed + "' ,'" + (int)dataGridView1.CurrentRow.Cells[5].Value + "')", connec);
                command.ExecuteNonQuery();
                connec.Close();
                MessageBox.Show("Registered");
                int instructorId = ID;

                Bind(instructorId);
            }
            catch
            {
                connec.Close();
                MessageBox.Show("Student Already exists in the register","ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        void Bind(int instructorId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM LessonAttendanceMJ WHERE InstructorID = @InstructorID", connec);
            command.Parameters.AddWithValue("@InstructorID", instructorId);

            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void AttendedBtn_Click(object sender, EventArgs e)
        {
            int ID = id;
            int allLess = (int)dataGridView2.CurrentRow.Cells[5].Value + (int)dataGridView2.CurrentRow.Cells[6].Value;
            int Less = (int)dataGridView2.CurrentRow.Cells[4].Value;
            if (Less == allLess)
            {
                MessageBox.Show("Student has attended all their lessons");
            }
            else
            {
                int up = 1;
                int att = (int)dataGridView2.CurrentRow.Cells[5].Value + up;
                int Total = (int)dataGridView2.CurrentRow.Cells[6].Value + att;
                int rem = (int)dataGridView2.CurrentRow.Cells[4].Value - Total;

                connec.Open();
                SqlCommand command = new SqlCommand("update LessonAttendanceMJ set StudentID = '" + (int)dataGridView2.CurrentRow.Cells[0].Value + "' ,StudentName ='" +dataGridView2.CurrentRow.Cells[1].Value+"' ,StudentSurname = '"+dataGridView2.CurrentRow.Cells[2].Value+"' ,InstructorID ='" + ID + "' ,PackageID = '" + dataGridView2.CurrentRow.Cells[3].Value + "',NumberofLessons ='" + (int)dataGridView2.CurrentRow.Cells[4].Value + "',Attended = '" + att + "',Missed ='" + (int)dataGridView2.CurrentRow.Cells[6].Value + "',Remaining = '" + rem + "' where StudentID = '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", connec);
                command.ExecuteNonQuery();
                connec.Close();

                MessageBox.Show("Marked as attended");
                int instructorId = ID;

                Bind(instructorId);
            }
        }

        private void Missed_Click(object sender, EventArgs e)
        {
            int ID = id;
            int allLess = (int)dataGridView2.CurrentRow.Cells[5].Value + (int)dataGridView2.CurrentRow.Cells[6].Value;
            int Less = (int)dataGridView2.CurrentRow.Cells[4].Value;
            if (Less == allLess)
            {
                MessageBox.Show("Student has attended all their lessons");
            }
            else
            {
                int up = 1;
                
                int missed = (int)dataGridView2.CurrentRow.Cells[6].Value + up;
                int Total = (int)dataGridView2.CurrentRow.Cells[5].Value + missed;
                int rem = (int)dataGridView2.CurrentRow.Cells[4].Value - Total;

                connec.Open();
                SqlCommand command = new SqlCommand("update LessonAttendanceMJ set StudentID = '" + (int)dataGridView2.CurrentRow.Cells[0].Value + "' ,StudentName ='"+dataGridView2.CurrentRow.Cells[1].Value+"' ,StudentSurname = '"+dataGridView2.CurrentRow.Cells[2].Value+"',InstructorID ='" + ID + "' ,PackageID = '" + dataGridView2.CurrentRow.Cells[3].Value + "',NumberofLessons ='" + (int)dataGridView2.CurrentRow.Cells[4].Value + "',Attended = '" + (int)dataGridView2.CurrentRow.Cells[5].Value + "',Missed ='" + missed + "',Remaining = '" + rem + "' where StudentID = '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", connec);
                command.ExecuteNonQuery();
                connec.Close();

                MessageBox.Show("Marked as Missed");
                int instructorId = ID;

                Bind(instructorId);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int ID = id;
            bookingTableAdapter.FillByIDate(dsAttendance21.Booking, ID, dateTimePicker1.Text);
        }
    }
}
