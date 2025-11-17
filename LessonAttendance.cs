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
           
            string status = "Confirmed";
            bookingsTableAdapter.FillByIDS(dsAttendance21.Bookings, id,status);
            lA_SheetTableAdapter.FillById(dSAttendance2.LA_Sheet, id);
           

        }
        SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi");


        private void BindGrid(int instructorID)
        {

            using (SqlConnection conn = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            {
                string query = @"
                    SELECT * 
                    FROM LA_Sheet 
            WHERE InstructorID = @InstructorID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@InstructorID", instructorID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView2.DataSource = dt;
            }
        }

        private void AttendedBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Do you want to proceed with this action?",
            "Confirmation Required",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DateTime bookingDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);


                if (bookingDate.Date > DateTime.Today)
                {
                    MessageBox.Show("You cannot mark attendance for a future booking.",
                                    "Invalid Operation",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    
                }
                else
                {

                    // Proceed with the action
                    using (SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
                    {
                        DateTime date = DateTime.Now;
                        string attendance = "Present";
                        connec.Open();
                        SqlCommand command1 = new SqlCommand(
                        @"INSERT INTO LA_Sheet 
                (BookingID,StudentID, StudentName, StudentSurname, InstructorID, BookingDate, BookingTime, Attendance, Date,PackageID) 
                VALUES 
                (@BookingID, @StudentID, @StudentName, @StudentSurname,@InstructorID, @BookingDate, @BookingTime, @Attendance, @Date, @PackageID)", connec);

                        // Add parameters safely
                        command1.Parameters.AddWithValue("@BookingID", (int)dataGridView1.CurrentRow.Cells[0].Value);
                        command1.Parameters.AddWithValue("@StudentID", (int)dataGridView1.CurrentRow.Cells[1].Value);
                        command1.Parameters.AddWithValue("@StudentName", dataGridView1.CurrentRow.Cells[2].Value);
                        command1.Parameters.AddWithValue("@StudentSurname", dataGridView1.CurrentRow.Cells[3].Value);
                        command1.Parameters.AddWithValue("@InstructorID", id);
                        command1.Parameters.AddWithValue("@BookingDate", dataGridView1.CurrentRow.Cells[4].Value);
                        command1.Parameters.AddWithValue("@BookingTime", dataGridView1.CurrentRow.Cells[5].Value);
                        command1.Parameters.AddWithValue("@Attendance", attendance);
                        command1.Parameters.AddWithValue("@Date", date);
                        command1.Parameters.AddWithValue("@PackageID", dataGridView1.CurrentRow.Cells[6].Value);

                        // Execute
                        command1.ExecuteNonQuery();
                        connec.Close();
                        BindGrid(id);
                    }
                }
            }
            else if (result == DialogResult.Cancel)
            {
                // Cancel the action
                connec.Close();
                MessageBox.Show("Action was cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Missed_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Do you want to proceed with this action?",
            "Confirmation Required",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DateTime bookingDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);


                if (bookingDate.Date > DateTime.Today)
                {
                    MessageBox.Show("You cannot mark attendance for a future booking.",
                                    "Invalid Operation",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                }
                else
                {
                    // Proceed with the action
                    using (SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
                    {
                        DateTime date = DateTime.Now;
                        string attendance = "Absent";
                        connec.Open();
                        SqlCommand command1 = new SqlCommand(
                        @"INSERT INTO LA_Sheet 
                (BookingID,StudentID, StudentName, StudentSurname, InstructorID, BookingDate, BookingTime, Attendance, Date,PackageID) 
                VALUES 
                (@BookingID, @StudentID, @StudentName, @StudentSurname,@InstructorID, @BookingDate, @BookingTime, @Attendance, @Date, @PackageID)", connec);

                        // Add parameters safely
                        command1.Parameters.AddWithValue("@BookingID", (int)dataGridView1.CurrentRow.Cells[0].Value);
                        command1.Parameters.AddWithValue("@StudentID", (int)dataGridView1.CurrentRow.Cells[1].Value);
                        command1.Parameters.AddWithValue("@StudentName", dataGridView1.CurrentRow.Cells[2].Value);
                        command1.Parameters.AddWithValue("@StudentSurname", dataGridView1.CurrentRow.Cells[3].Value);
                        command1.Parameters.AddWithValue("@InstructorID", id);
                        command1.Parameters.AddWithValue("@BookingDate", dataGridView1.CurrentRow.Cells[4].Value);
                        command1.Parameters.AddWithValue("@BookingTime", dataGridView1.CurrentRow.Cells[5].Value);
                        command1.Parameters.AddWithValue("@Attendance", attendance);
                        command1.Parameters.AddWithValue("@Date", date);
                        command1.Parameters.AddWithValue("@PackageID", dataGridView1.CurrentRow.Cells[6].Value);

                        // Execute
                        command1.ExecuteNonQuery();
                        connec.Close();
                        BindGrid(id);
                    }
                }
            }
            else if (result == DialogResult.No)
            {
                // Cancel the action
                connec.Close();
                MessageBox.Show("Action was cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try 
            {
                int ID = id;
                string status = "Confirmed";
                bookingsTableAdapter.FillByDateS(dsAttendance21.Bookings,ID, dateTimePicker1.Text,status);
            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
            
        }

        

        

        

       

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
           
        
               
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            lA_SheetTableAdapter.FillBySearch(dSAttendance2.LA_Sheet, (int)dataGridView1.CurrentRow.Cells[1].Value, id);
            dataGridView2.DataSource = dSAttendance2.LA_Sheet;

        }

       

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
           int instructorId = id;
            string status = "Confirmed";
            BindGrid(instructorId);
            bookingsTableAdapter.FillByIDS(dsAttendance21.Bookings, id, status);
        }

       
    }
}
