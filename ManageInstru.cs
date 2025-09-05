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
            // TODO: This line of code loads data into the 'dsManager1.AttendanceSheet' table. You can move, or remove it, as needed.
            this.attendanceSheetTableAdapter.Fill(this.dsManager1.AttendanceSheet);
            // TODO: This line of code loads data into the 'dsManager1.StudentProgress' table. You can move, or remove it, as needed.
            //this.studentProgressTableAdapter.Fill(this.dsManager1.StudentProgress);
            // TODO: This line of code loads data into the 'dSAttendance2.InstructorMJ' table. You can move, or remove it, as needed.
            this.instructorMJTableAdapter.Fill(this.dSAttendance2.InstructorMJ);
            // TODO: This line of code loads data into the 'dsManager1.TemporaryStudents' table. You can move, or remove it, as needed.
            //this.temporaryStudentsTableAdapter.Fill(this.dsManager1.TemporaryStudents);
            // TODO: This line of code loads data into the 'dsManager1.TempStudent' table. You can move, or remove it, as needed.
            //this.tempStudentTableAdapter.Fill(this.dsManager1.TempStudent);
            // TODO: This line of code loads data into the 'dsManager1.TempStudents' table. You can move, or remove it, as needed.
            //this.tempStudentsTableAdapter.Fill(this.dsManager1.TempStudents);
            // TODO: This line of code loads data into the 'dsManager1.LessonBookingMJ' table. You can move, or remove it, as needed.
            this.lessonBookingMJTableAdapter.Fill(this.dsManager1.LessonBookingMJ);
            bool arch = false;
            // TODO: This line of code loads data into the 'dsManager1.LessonAttendanceMJ' table. You can move, or remove it, as needed.
            //this.lessonAttendanceMJTableAdapter.Fill(this.dsManager1.LessonAttendanceMJ);
            // TODO: This line of code loads data into the 'dsManager1.Booking' table. You can move, or remove it, as needed.
            //this.bookingTableAdapter.Fill(this.dsManager1.Booking);
            bookingTableAdapter.Fill(dsManager1.Booking);
            studentProgressTableAdapter.Fill(dsManager1.StudentProgress);
            lessonAttendanceMJTableAdapter.FillByArch(dsManager1.LessonAttendanceMJ, arch);
            temporaryStudentsTableAdapter.FillByArch(dsManager1.TemporaryStudents, arch);

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
                LoadAttendanceData();
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



                DialogResult Result = MessageBox.Show("This action CANNOT be UNDONE! Are you sure you want to Archive.", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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


                    Bind();

                    MessageBox.Show("Archived");
                }
            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
        }

        private void LoadAttendanceData()
        {
           
            bool showArchived = archBtn.Checked;

            string query = showArchived
                ? "SELECT * FROM LessonAttendanceMJ "
                : "SELECT * FROM LessonAttendanceMJ WHERE IsArchived = 0";

            using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                

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
                        archivedIds.Add(reader.GetInt32(0)); // Assumes StudentID is int
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

        private void LoadTemp()
        {

            bool showArchived = checkBox1.Checked;

            string query = showArchived
                ? "SELECT * FROM TemporaryStudents "
                : "SELECT * FROM TemporaryStudents WHERE IsArchived = 0";

            using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView4.DataSource = dt;


            }
        }

        private List<int> GetArchivedStudentIds1()
        {
            List<int> archivedIds = new List<int>();

            using (SqlConnection conn = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            {
                string query = "SELECT BookingID FROM TemporaryStudents WHERE IsArchived = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        archivedIds.Add(reader.GetInt32(0)); // Assumes StudentID is int
                    }
                }
            }

            return archivedIds;
        }

        private void HighlightArchivedRows1()
        {
            List<int> archivedIds = GetArchivedStudentIds1();

            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                if (!row.IsNewRow)
                {
                    int BookingId = Convert.ToInt32(row.Cells[0].Value);

                    if (archivedIds.Contains(BookingId))
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

        private bool IsStudentArchived2(int BookingID)
        {
            bool isArchived = false;

            string query = "SELECT IsArchived FROM TemporaryStudents WHERE BookingID = @BookingID";

            using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@BookingID", SqlDbType.Int).Value = BookingID;

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

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
            
        }
      

        bool IsInstructorAvailable(int instructorId, DateTime date, TimeSpan time)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            {
                string query = @"SELECT COUNT(*) FROM LessonBookingMJ 
                         WHERE InstructorID = @InstructorId AND Date = @Date AND Time = @Time";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@InstructorId", instructorId);
                cmd.Parameters.AddWithValue("@Date", date.Date);
                cmd.Parameters.AddWithValue("@Time", time);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count == 0; // True if available
            }
        }

        void UpdateInstructorInBooking(int bookingId, int newInstructorId)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            {
                string query = @"UPDATE LessonBookingMJ SET InstructorID = @NewInstructorId WHERE BookingID = @BookingId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NewInstructorId", newInstructorId);
                cmd.Parameters.AddWithValue("@BookingId", bookingId);

                conn.Open();
                cmd.ExecuteNonQuery();

               
            }
        }
        void UpdateInstructorInAttendance(int studentId, int newInstructorId)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            {
                string query = @"UPDATE LessonAttendanceMJ SET InstructorID = @NewInstructorId 
                         WHERE StudentID = @StudentId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NewInstructorId", newInstructorId);
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                conn.Open();
                cmd.ExecuteNonQuery();

                Bind();
            }
        }

        private bool StudentExistsInAttendance(int studentId)
        {
            using (SqlConnection conn = new SqlConnection("Data Source = 146.230.177.46; User ID = WstGrp24; Password = 6wefi"))
            {
                string query = "SELECT COUNT(*) FROM LessonAttendanceMJ WHERE StudentID = @StudentID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    conn.Open();

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }



        private void reassignBtn_Click(object sender, EventArgs e)
        {
            try
            {


                DateTime bookingDate = (DateTime)dataGridView1.CurrentRow.Cells[7].Value;
                TimeSpan startTime = (TimeSpan)dataGridView1.CurrentRow.Cells[8].Value;

                DateTime startbookingDateTime = bookingDate + startTime;
                DateTime endbookingDateTime = startbookingDateTime.AddHours(1);


                if (endbookingDateTime <= DateTime.Now)
                {
                    MessageBox.Show("Reassignment cancelled: Booking passed.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {



                    DialogResult result = MessageBox.Show(
                    "Do you want to Reassign Booking?",
                    "Confirm Reassignment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("Permanent reassignment cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (result == DialogResult.Yes)
                    {
                        int newInstructorId = int.Parse(comboBox1.Text);
                        DateTime date = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value);
                        TimeSpan time = (TimeSpan)dataGridView1.CurrentRow.Cells[8].Value;

                        if (IsInstructorAvailable(newInstructorId, date, time))
                        {
                            int bookingId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                            int studentId = (int)dataGridView1.CurrentRow.Cells[1].Value;
                            UpdateInstructorInBooking(bookingId, newInstructorId);
                            this.bookingTableAdapter.Fill(dsManager1.Booking);
                            UpdateInstructorInAttendance(studentId, newInstructorId);
                            MessageBox.Show("Instructor Reassigned successfully");



                        }
                        else
                        {
                            MessageBox.Show("Instructor unavailable");
                        }
                    }



                }
            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
        }

        void BindData()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM TemporaryStudents WHERE IsArchived = 0", connec);


            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView4.DataSource = dt;
        }



        private void archiiveBtn_Click(object sender, EventArgs e)
        {
            try
            {


                int BookingID = (int)dataGridView4.CurrentRow.Cells[0].Value;
                bool isArchived = false;

                using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
                using (SqlCommand checkCmd = new SqlCommand("SELECT IsArchived FROM TemporaryStudents WHERE BookingID = @BookingID", con))
                {
                    checkCmd.Parameters.Add("@BookingID", SqlDbType.Int).Value = BookingID;
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

                    int BookingId = (int)dataGridView4.CurrentRow.Cells[0].Value;
                    connec.Open();
                    SqlCommand comm = new SqlCommand("UPDATE TemporaryStudents SET IsArchived =1 WHERE BookingID = @BookingID", connec);
                    comm.Parameters.AddWithValue("@BookingID", BookingId);
                    comm.ExecuteNonQuery();
                    connec.Close();


                    LoadTemp();

                    MessageBox.Show("Archived");
                }
            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
        }

        private void ReactBtn_Click(object sender, EventArgs e)
        {
            try
            {


                if (dataGridView4.CurrentRow == null)
                {
                    MessageBox.Show("Please select a student to unarchive.");
                    return;
                }

                int BookingID = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value);

                string query = "UPDATE TemporaryStudents SET IsArchived = 0 WHERE BookingID = BookingID";

                using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@BookingID", SqlDbType.Int).Value = BookingID;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Student has been unarchived.");
                LoadTemp();
            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
        }
        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
            if (dataGridView4.CurrentRow != null)
            {
                int BookingID = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value);
                ReactBtn.Enabled = IsStudentArchived2(BookingID);
            }
            else
            {
                ReactBtn.Enabled = false;
            }
            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoadTemp();
            HighlightArchivedRows1();
        }

        void InsertTemp(int bookingId,int InstructorID, int StudentID,string StudentName,String StudentSurname)
        {
            bool arch = false;

            using (SqlConnection conn = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            {
                conn.Open();
                SqlCommand Command = new SqlCommand("INSERT into TemporaryStudents values ('" + bookingId + "','" + StudentID + "','" + StudentName + "','" + StudentSurname + "','" + InstructorID + "','" + null + "','"+arch+"')", conn);
                Command.Parameters.AddWithValue("@InstructorID", InstructorID);
             
                Command.ExecuteNonQuery();
                conn.Close();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                DateTime bookingDate = (DateTime)dataGridView1.CurrentRow.Cells[7].Value;
                TimeSpan startTime = (TimeSpan)dataGridView1.CurrentRow.Cells[8].Value;

                DateTime startbookingDateTime = bookingDate + startTime;
                DateTime endbookingDateTime = startbookingDateTime.AddHours(1);


                if (endbookingDateTime <= DateTime.Now)
                {
                    MessageBox.Show("Reassignment cancelled: Booking passed.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {


                    DialogResult result = MessageBox.Show(
                    "Do you want to Reassign Booking?",
                    "Confirm Reassignment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("Booking reassignment cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (result == DialogResult.Yes)
                    {

                        int newInstructorId = int.Parse(comboBox1.Text);
                        DateTime date = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value);
                        TimeSpan time = (TimeSpan)dataGridView1.CurrentRow.Cells[8].Value;
                        int StudentID = (int)dataGridView1.CurrentRow.Cells[1].Value;

                        if (IsInstructorAvailable(newInstructorId, date, time))
                        {
                            if (!StudentExistsInAttendance(StudentID))
                            {
                                MessageBox.Show("Student not found in Attendance Register.Add Student to Attendance Register", "Missing Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            else
                            {
                                int bookingId = (int)dataGridView1.CurrentRow.Cells[0].Value;

                                string StudentName = (string)dataGridView1.CurrentRow.Cells[2].Value;
                                string StudentSurname = (string)dataGridView1.CurrentRow.Cells[3].Value;

                                UpdateInstructorInBooking(bookingId, newInstructorId);
                                this.bookingTableAdapter.Fill(dsManager1.Booking);
                                InsertTemp(bookingId, newInstructorId, StudentID, StudentName, StudentSurname);
                                this.temporaryStudentsTableAdapter.Fill(dsManager1.TemporaryStudents);


                                MessageBox.Show("Booking Reassigned successfully, student added to the Temporary register!");
                            }




                        }
                        else
                        {
                            MessageBox.Show("Instructor unavailable");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            temporaryStudentsTableAdapter.FillByName(dsManager1.TemporaryStudents, textBox1.Text);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
            lessonAttendanceMJTableAdapter.FillByStuID(dsManager1.LessonAttendanceMJ, (int)dataGridView1.CurrentRow.Cells[0].Value);
            dataGridView2.DataSource = dsManager1.LessonAttendanceMJ;
            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            bookingTableAdapter.FillByDate(dsManager1.Booking, dateTimePicker1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            studentProgressTableAdapter.FillByName(dsManager1.StudentProgress, textBox2.Text);
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            Bind();
            bookingTableAdapter.Fill(dsManager1.Booking);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            bookingTableAdapter.FillByDate(dsManager1.Booking, dateTimePicker2.Text);
            attendanceSheetTableAdapter.FillByDate(dsManager1.AttendanceSheet, dateTimePicker2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            attendanceSheetTableAdapter.FillByName(dsManager1.AttendanceSheet, textBox3.Text);
            bookingTableAdapter.FillByName(dsManager1.Booking, textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentProgressTableAdapter.Fill(dsManager1.StudentProgress);
            attendanceSheetTableAdapter.Fill(dsManager1.AttendanceSheet);
        }
    }
}
