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
            // TODO: This line of code loads data into the 'dSAttendance2.LA_Sheet' table. You can move, or remove it, as needed.
            //this.lA_SheetTableAdapter.Fill(this.dSAttendance2.LA_Sheet);
            bookingsTableAdapter.FillByID(dsAttendance21.Bookings, id);
            lA_SheetTableAdapter.FillById(dSAttendance2.LA_Sheet, id);
            // TODO: This line of code loads data into the 'dsAttendance21.Bookings' table. You can move, or remove it, as needed.
            //this.bookingsTableAdapter.Fill(this.dsAttendance21.Bookings);
            //bool arch = false;
            // TODO: This line of code loads data into the 'dsAttendance21.Booking' table. You can move, or remove it, as needed.
            //this.bookingTableAdapter.Fill(this.dsAttendance21.Booking);
            // TODO: This line of code loads data into the 'dsAttendance21.Bookings' table. You can move, or remove it, as needed.
            //this.bookingsTableAdapter.Fill(this.dsAttendance21.Bookings);
            // TODO: This line of code loads data into the 'dsAttendance1.Booking' table. You can move, or remove it, as needed.
            //this.bookingTableAdapter.Fill(this.dsAttendance1.Booking);
            /*bookingTableAdapter.FillByInID(dsAttendance21.Booking, id);
            lessonAttendanceMJTableAdapter1.FillByLoad(dsAttendance21.LessonAttendanceMJ, id, arch);
            if (dataGridView2.CurrentRow != null)
            {
                int studentID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                button1.Enabled = IsStudentArchived(studentID);
            }
            else
            {
                button1.Enabled = false;
            }*/

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
            bookingsTableAdapter.FillByDate(dsAttendance21.Bookings, dateTimePicker1.Text,ID);
            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
            
        }

        private void ArchiveBtn_Click(object sender, EventArgs e)
        {
            /*try
            {


                int ID = id;
                int Studentid = (int)dataGridView2.CurrentRow.Cells[0].Value;
                bool isArchived = false;

                using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
                using (SqlCommand checkCmd = new SqlCommand("SELECT IsArchived FROM LessonAttendanceMJ WHERE StudentID = @StudentID", con))
                {
                    checkCmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = Studentid;
                    con.Open();
                    object result = checkCmd.ExecuteScalar();
                    con.Close();

                    if (result != null && result != DBNull.Value)
                    {
                        isArchived = Convert.ToBoolean(result);
                    }
                }
                if (isArchived)
                {
                    MessageBox.Show("This student is already archived.");
                    return;
                }



                DialogResult Result = MessageBox.Show("THIS ACTION CANNOT BE UNDONE!Are you sure you want to Archive.", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Result == DialogResult.No)
                {
                    MessageBox.Show("Archive cancelled");
                }
                else
                {

                    int StudentID = (int)dataGridView2.CurrentRow.Cells[0].Value;
                    connec.Open();
                    SqlCommand comm = new SqlCommand("UPDATE LessonAttendanceMJ SET IsArchived =1 WHERE StudentID = @StudentID", connec);
                    comm.Parameters.AddWithValue("@StudentID", StudentID);
                    comm.ExecuteNonQuery();
                    connec.Close();
                    int instructorId = ID;

                    Bind(instructorId);

                    MessageBox.Show("Archived");
                }

            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }*/
        }

        private void activeBtn_CheckedChanged(object sender, EventArgs e)
        {
            
            //int ID = id;
            //bool arch = false;
            //lessonAttendanceMJTableAdapter1.FillByLoad(dsAttendance21.LessonAttendanceMJ, ID, arch);
        }

        private void AllBtn_CheckedChanged(object sender, EventArgs e)
        {
            //int ID = id;
            
            //lessonAttendanceMJTableAdapter1.FillByID(dsAttendance21.LessonAttendanceMJ, ID);
        }

        /*private void LoadAttendanceData()
        {
            int instructorId = id; // Or however you're storing it
            bool showArchived = archBtn.Checked;

            string query = showArchived
                ? "SELECT * FROM LessonAttendanceMJ WHERE InstructorID = @InstructorID"
                : "SELECT * FROM LessonAttendanceMJ WHERE InstructorID = @InstructorID AND IsArchived = 0";

            using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@InstructorID", SqlDbType.Int).Value = instructorId;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView2.DataSource = dt;

               
            }
        }*/

        /*private List<int> GetArchivedStudentIds()
        {
            List<int> archivedIds = new List<int>();

            using (SqlConnection conn = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            {
                string query = "SELECT StudentID FROM LessonAttendanceMJ WHERE IsArchived = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        archivedIds.Add(reader.GetInt32(0)); 
                    }
                }
            }

            return archivedIds;
        }

        private void HighlightArchivedRows()
        {
            List<int> archivedIds = GetArchivedStudentIds();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!row.IsNewRow)
                {
                    int studentId = Convert.ToInt32(row.Cells[0].Value);

                    if (archivedIds.Contains(studentId))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;

                    }
                }
            }
        }*/
        private void archBtn_CheckedChanged(object sender, EventArgs e)
        {
            //LoadAttendanceData();
            //HighlightArchivedRows();

        }

        /*private bool IsStudentArchived(int studentID)
        {
            bool isArchived = false;

            string query = "SELECT IsArchived FROM LessonAttendanceMJ WHERE StudentID = @StudentID";

            using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = studentID;

                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                if (result != null && result != DBNull.Value)
                {
                    isArchived = Convert.ToBoolean(result);
                }
            }

            return isArchived;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
            {



                if (dataGridView2.CurrentRow == null)
                {
                    MessageBox.Show("Please select a student to unarchive.");
                    return;
                }

                int studentID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);

                string query = "UPDATE LessonAttendanceMJ SET IsArchived = 0 WHERE StudentID = @StudentID";

                using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = studentID;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Student has been unarchived.");
                LoadAttendanceData(); // Refresh the grid

            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }*/
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
           
        
                /*if (dataGridView2.CurrentRow != null)
                {
                    int studentID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                    button1.Enabled = IsStudentArchived(studentID);
                }
                else
                {
                    button1.Enabled = false;
                }*/
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            lA_SheetTableAdapter.FillBySearch(dSAttendance2.LA_Sheet, (int)dataGridView1.CurrentRow.Cells[1].Value, id);
            dataGridView2.DataSource = dSAttendance2.LA_Sheet;

        }

        private void ReloadBookings(int instructorId)
        {
            
            /*SqlCommand command = new SqlCommand("SELECT * FROM Booking WHERE InstructorID = @InstructorID", connec);
            command.Parameters.AddWithValue("@InstructorID", instructorId);

            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;*/

        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
           int instructorId = id;
            BindGrid(instructorId);
            bookingsTableAdapter.FillByID(dsAttendance21.Bookings, id);
        }

       
    }
}
