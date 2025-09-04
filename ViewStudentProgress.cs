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
            this.temporaryStudentsTableAdapter.Fill(this.dSAttendance22.TemporaryStudents);
            // TODO: This line of code loads data into the 'dSAttendance2.TempStudent' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dSAttendance2.TempStudent' table. You can move, or remove it, as needed.
            //this.tempStudentTableAdapter1.Fill(this.dSAttendance2.TempStudent);
            int ID = id;
            
            bool arch = false;
            // TODO: This line of code loads data into the 'dSManager.TempStudent' table. You can move, or remove it, as needed.
            //this.tempStudentTableAdapter.Fill(this.dSManager.TempStudent);
            // TODO: This line of code loads data into the 'dsAttendance21.StudentProgress' table. You can move, or remove it, as needed.
            //this.studentProgressTableAdapter.Fill(this.dsAttendance21.StudentProgress);
            tempStudentTableAdapter1.FillByidArch(dSAttendance2.TempStudent, id, arch);
        }
        SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi");

        void Bind(int instructorId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM TemporaryStudent WHERE InstructorID = @InstructorID AND IsArchived = 0", connec);
            command.Parameters.AddWithValue("@InstructorID", instructorId);

            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void attBtn_Click(object sender, EventArgs e)
        {
            int StudentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            int BookingID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            String Attended = "Present"; 

            using (SqlConnection conn = new SqlConnection("Data Source = 146.230.177.46; User ID = WstGrp24; Password = 6wefi"))
            {
                conn.Open();

                string query = @"SELECT Remaining FROM LessonAttendanceMJ WHERE StudentID = @StudentID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);
                    object result = cmd.ExecuteScalar();

                    if (result != null && Convert.ToInt32(result) == 0)
                    {
                        MessageBox.Show("No lessons remaining for this student.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            SqlCommand command1 = new SqlCommand(
                                @"UPDATE LessonAttendanceMJ 
                          SET Attended = Attended + 1, Remaining = Remaining - 1 
                          WHERE StudentID = @StudentID", conn, transaction);
                            command1.Parameters.AddWithValue("@StudentID", StudentID);
                            command1.ExecuteNonQuery();

                            SqlCommand command2 = new SqlCommand(
                                @"UPDATE TemporaryStudents 
                          SET Attendance = @Attended 
                          WHERE BookingID = @BookingID", conn, transaction);
                            command2.Parameters.AddWithValue("@BookingID", BookingID);
                            command2.Parameters.AddWithValue("@Attended", Attended);
                            command2.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Marked as attended", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Unable to mark student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }


        }

        private void MissedBtn_Click(object sender, EventArgs e)
        {
            int StudentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            int BookingID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            String Attended = "Absent";

            using (SqlConnection conn = new SqlConnection("Data Source = 146.230.177.46; User ID = WstGrp24; Password = 6wefi"))
            {
                conn.Open();

                string query = @"SELECT Remaining FROM LessonAttendanceMJ WHERE StudentID = @StudentID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);
                    object result = cmd.ExecuteScalar();

                    if (result != null && Convert.ToInt32(result) == 0)
                    {
                        MessageBox.Show("No lessons remaining for this student.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            SqlCommand command1 = new SqlCommand(
                                @"UPDATE LessonAttendanceMJ 
                          SET Missed = Missed + 1, Remaining = Remaining - 1 
                          WHERE StudentID = @StudentID", conn, transaction);
                            command1.Parameters.AddWithValue("@StudentID", StudentID);
                            command1.ExecuteNonQuery();

                            SqlCommand command2 = new SqlCommand(
                                @"UPDATE TemporaryStudents 
                          SET Attendance = @Attended 
                          WHERE BookingID = @BookingID", conn, transaction);
                            command2.Parameters.AddWithValue("@BookingID", BookingID);
                            command2.Parameters.AddWithValue("@Attended", Attended);
                            command2.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Marked as Missed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Unable to mark student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }
    }
}
