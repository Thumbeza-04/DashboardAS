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
            bool arch = false;
            // TODO: This line of code loads data into the 'dsAttendance21.Booking' table. You can move, or remove it, as needed.
            //this.bookingTableAdapter.Fill(this.dsAttendance21.Booking);
            // TODO: This line of code loads data into the 'dsAttendance21.Bookings' table. You can move, or remove it, as needed.
            //this.bookingsTableAdapter.Fill(this.dsAttendance21.Bookings);
            // TODO: This line of code loads data into the 'dsAttendance1.Booking' table. You can move, or remove it, as needed.
            //this.bookingTableAdapter.Fill(this.dsAttendance1.Booking);
            bookingTableAdapter.FillByInID(dsAttendance21.Booking, id);
            lessonAttendanceMJTableAdapter1.FillByLoad(dsAttendance21.LessonAttendanceMJ, id, arch);
            if (dataGridView2.CurrentRow != null)
            {
                int studentID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                button1.Enabled = IsStudentArchived(studentID);
            }
            else
            {
                button1.Enabled = false;
            }

        }
        SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi");
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {

            
            int ID = id;
                using (SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
                {
                    connec.Open();
                    SqlTransaction transaction = connec.BeginTransaction();

                    try
                    {

                        bool BT = false;
                        int att = 0;
                        int missed = 0;

                        SqlCommand command1 = new SqlCommand("Insert into LessonAttendanceMJ values( '" + (int)dataGridView1.CurrentRow.Cells[1].Value + "','" + dataGridView1.CurrentRow.Cells[2].Value + "','" + dataGridView1.CurrentRow.Cells[3].Value + "','" + ID + "', '" + dataGridView1.CurrentRow.Cells[4].Value + "','" + (int)dataGridView1.CurrentRow.Cells[5].Value + "','" + att + "', '" + missed + "' ,'" + (int)dataGridView1.CurrentRow.Cells[5].Value + "', '" + BT + "')", connec, transaction);
                        command1.ExecuteNonQuery();

                        SqlCommand command2 = new SqlCommand("Insert into StudentProgress values('" + (int)dataGridView1.CurrentRow.Cells[1].Value + "','" + dataGridView1.CurrentRow.Cells[2].Value + "','" + dataGridView1.CurrentRow.Cells[3].Value + "','" + ID + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "')", connec, transaction);
                        command2.ExecuteNonQuery();

                        transaction.Commit();
                        int instructorId = ID;


                        MessageBox.Show("Added to Attendance Registered");

                        Bind(instructorId);


                    }
                    catch
                    {
                        transaction.Rollback();
                        connec.Close();
                        MessageBox.Show("Student Already exists in the register", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
        }

        void Bind(int instructorId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM LessonAttendanceMJ WHERE InstructorID = @InstructorID AND IsArchived = 0", connec);
            command.Parameters.AddWithValue("@InstructorID", instructorId);

            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void AttendedBtn_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult Result = MessageBox.Show("Are you sure you want to mark lesson as attended? This action cannot be undone.", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Result == DialogResult.No)
                {
                    MessageBox.Show("Cancelled");
                }
                else if (Result == DialogResult.Yes)
                {


                    int ID = id;
                    String Attendance = "Present";
                    DateTime Date = DateTime.Now;
                    int allLess = (int)dataGridView2.CurrentRow.Cells[5].Value + (int)dataGridView2.CurrentRow.Cells[6].Value;
                    int Less = (int)dataGridView2.CurrentRow.Cells[4].Value;
                    if (Less == allLess)
                    {
                        MessageBox.Show("Student has attended all their lessons");
                    }
                    else
                    {
                        bool arch = false;
                        int up = 1;
                        connec.Open();
                        SqlTransaction transaction = connec.BeginTransaction();
                        try
                        {
                            int att = (int)dataGridView2.CurrentRow.Cells[5].Value + up;
                            int Total = (int)dataGridView2.CurrentRow.Cells[6].Value + att;
                            int rem = (int)dataGridView2.CurrentRow.Cells[4].Value - Total;


                            SqlCommand command1 = new SqlCommand("update LessonAttendanceMJ set StudentID = '" + (int)dataGridView2.CurrentRow.Cells[0].Value + "' ,StudentName ='" + dataGridView2.CurrentRow.Cells[1].Value + "' ,StudentSurname = '" + dataGridView2.CurrentRow.Cells[2].Value + "' ,InstructorID ='" + ID + "' ,PackageID = '" + dataGridView2.CurrentRow.Cells[3].Value + "',NumberofLessons ='" + (int)dataGridView2.CurrentRow.Cells[4].Value + "',Attended = '" + att + "',Missed ='" + (int)dataGridView2.CurrentRow.Cells[6].Value + "',Remaining = '" + rem + "',IsArchived = '" + arch + "' where StudentID = '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", connec, transaction);
                            command1.ExecuteNonQuery();

                            SqlCommand command2 = new SqlCommand("Insert into AttendanceSheet values ('" + ID + "','" + (int)dataGridView2.CurrentRow.Cells[0].Value + "','" + dataGridView2.CurrentRow.Cells[1].Value + "','" + dataGridView2.CurrentRow.Cells[2].Value + "','" + Attendance + "','" + Date + "')", connec, transaction);
                            command2.ExecuteNonQuery();
                            transaction.Commit();
                            connec.Close();

                            MessageBox.Show("Marked as attended");
                            int instructorId = ID;

                            Bind(instructorId);
                        }
                        catch
                        {
                            transaction.Rollback();
                            connec.Close();
                            MessageBox.Show("Unable to mark student");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
        }

        private void Missed_Click(object sender, EventArgs e)
        {
            try 
            { 

            DialogResult Result = MessageBox.Show("Are you sure you want to mark lesson as missed? This action cannot be undone.", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Result == DialogResult.No)
                {
                    MessageBox.Show("Cancelled");
                }
                else if (Result == DialogResult.Yes)
                {


                    int ID = id;
                    string Attendance = "Absent";
                    DateTime Date = DateTime.Now;
                    int allLess = (int)dataGridView2.CurrentRow.Cells[5].Value + (int)dataGridView2.CurrentRow.Cells[6].Value;
                    int Less = (int)dataGridView2.CurrentRow.Cells[4].Value;
                    if (Less == allLess)
                    {
                        MessageBox.Show("Student has attended all their lessons");
                    }
                    else
                    {
                        bool arch = false;
                        int up = 1;
                        connec.Open();
                        SqlTransaction transaction = connec.BeginTransaction();
                        try
                        {
                            int missed = (int)dataGridView2.CurrentRow.Cells[6].Value + up;
                            int Total = (int)dataGridView2.CurrentRow.Cells[5].Value + missed;
                            int rem = (int)dataGridView2.CurrentRow.Cells[4].Value - Total;


                            SqlCommand command1 = new SqlCommand("update LessonAttendanceMJ set StudentID = '" + (int)dataGridView2.CurrentRow.Cells[0].Value + "' ,StudentName ='" + dataGridView2.CurrentRow.Cells[1].Value + "' ,StudentSurname = '" + dataGridView2.CurrentRow.Cells[2].Value + "',InstructorID ='" + ID + "' ,PackageID = '" + dataGridView2.CurrentRow.Cells[3].Value + "',NumberofLessons ='" + (int)dataGridView2.CurrentRow.Cells[4].Value + "',Attended = '" + (int)dataGridView2.CurrentRow.Cells[5].Value + "',Missed ='" + missed + "',Remaining = '" + rem + "' ,IsArchived = '" + arch + "' where StudentID = '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", connec, transaction);
                            command1.ExecuteNonQuery();

                            SqlCommand command2 = new SqlCommand("Insert into AttendanceSheet values ('" + ID + "','" + (int)dataGridView2.CurrentRow.Cells[0].Value + "','" + dataGridView2.CurrentRow.Cells[1].Value + "','" + dataGridView2.CurrentRow.Cells[2].Value + "','" + Attendance + "','" + Date + "')", connec, transaction);
                            command2.ExecuteNonQuery();
                            transaction.Commit();
                            connec.Close();

                            MessageBox.Show("Marked as Missed");
                            int instructorId = ID;

                            Bind(instructorId);
                        }
                        catch
                        {
                            transaction.Rollback();
                            connec.Close();
                            MessageBox.Show("Unable to mark student");
                        }
                    }
                }    
            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try 
            {
                int ID = id;
            bookingTableAdapter.FillByIDate(dsAttendance21.Booking, ID, dateTimePicker1.Text);
            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
            
        }

        private void ArchiveBtn_Click(object sender, EventArgs e)
        {
            try
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
            }
        }

        private void activeBtn_CheckedChanged(object sender, EventArgs e)
        {
            
            int ID = id;
            bool arch = false;
            lessonAttendanceMJTableAdapter1.FillByLoad(dsAttendance21.LessonAttendanceMJ, ID, arch);
        }

        private void AllBtn_CheckedChanged(object sender, EventArgs e)
        {
            int ID = id;
            
            lessonAttendanceMJTableAdapter1.FillByID(dsAttendance21.LessonAttendanceMJ, ID);
        }

        private void LoadAttendanceData()
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
        }

        private List<int> GetArchivedStudentIds()
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
        }
        private void archBtn_CheckedChanged(object sender, EventArgs e)
        {
            LoadAttendanceData();
            HighlightArchivedRows();

        }

        private bool IsStudentArchived(int studentID)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
           
        
                if (dataGridView2.CurrentRow != null)
                {
                    int studentID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                    button1.Enabled = IsStudentArchived(studentID);
                }
                else
                {
                    button1.Enabled = false;
                }
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            lessonAttendanceMJTableAdapter1.FillBySearch(dsAttendance21.LessonAttendanceMJ, (int)dataGridView1.CurrentRow.Cells[1].Value, id);
            dataGridView2.DataSource = dsAttendance21.LessonAttendanceMJ;

        }

        private void ReloadBookings(int instructorId)
        {
            
            SqlCommand command = new SqlCommand("SELECT * FROM Booking WHERE InstructorID = @InstructorID", connec);
            command.Parameters.AddWithValue("@InstructorID", instructorId);

            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            int instructorId = id;
            Bind(instructorId);
            bookingTableAdapter.FillByInID(dsAttendance21.Booking, id);
        }

       
    }
}
