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
            temporaryStudentsTableAdapter.FillByIdArch(dSAttendance22.TemporaryStudents, ID, arch);
            WireRadioButtons(this);
            
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
            try
            {



                DialogResult Result = MessageBox.Show("Are you sure you want to mark lesson as attended? This action cannot be undone.", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Result == DialogResult.No)
                {
                    MessageBox.Show("Cancelled");
                }
                else if (Result == DialogResult.Yes)
                {
                    string status = dataGridView1.CurrentRow.Cells[4].Value?.ToString()?.Trim();
                    try
                    {


                        if (status == "Present" || status == "Absent")
                        {
                            MessageBox.Show("Already marked, select new student");
                        }
                        else
                        {




                            int StudentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                            int BookingID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                            String Attended = "Present";
                            DateTime Date = DateTime.Now;
                            int InId = id;

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

                                            SqlCommand command3 = new SqlCommand("Insert into AttendanceSheet values ('" + InId + "','" + (int)dataGridView1.CurrentRow.Cells[1].Value + "','" + dataGridView1.CurrentRow.Cells[2].Value + "','" + dataGridView1.CurrentRow.Cells[3].Value + "','" + Attended + "','" + Date + "')", conn, transaction);
                                            command3.ExecuteNonQuery();
                                            transaction.Commit();
                                            conn.Close();
                                            MessageBox.Show("Marked as attended", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Bind(InId);
                                        }
                                        catch (Exception ex)
                                        {
                                            transaction.Rollback();
                                            conn.Close();
                                            MessageBox.Show("Unable to mark student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }

                            }
                        }



                    }
                    catch
                    {
                        MessageBox.Show("Unable to mark");
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error! Please try again.");
            }
        }

        private void MissedBtn_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult Result = MessageBox.Show("Are you sure you want to mark student as attended? This action cannot be undone.", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Result == DialogResult.No)
                {
                    MessageBox.Show("Cancelled");
                }
                else if (Result == DialogResult.Yes)
                {
                    string status = dataGridView1.CurrentRow.Cells[4].Value?.ToString()?.Trim();
                    try
                    {


                        if (status == "Present" || status == "Absent")
                        {
                            MessageBox.Show("Already marked, select new student");
                        }
                        else
                        {



                            int StudentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                            int BookingID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                            String Attended = "Absent";
                            DateTime Date = DateTime.Now;
                            int InId = id;

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

                                            SqlCommand command3 = new SqlCommand("Insert into AttendanceSheet values ('" + InId + "','" + (int)dataGridView1.CurrentRow.Cells[1].Value + "','" + dataGridView1.CurrentRow.Cells[2].Value + "','" + dataGridView1.CurrentRow.Cells[3].Value + "','" + Attended + "','" + Date + "')", conn, transaction);
                                            command3.ExecuteNonQuery();

                                            transaction.Commit();
                                            conn.Close();
                                            MessageBox.Show("Marked as Missed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Bind(InId);
                                        }
                                        catch (Exception ex)
                                        {
                                            transaction.Rollback();
                                            conn.Close();
                                            MessageBox.Show("Unable to mark student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Unable to mark");
                    } 
                }
            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
         }

        //Evaluations

        //SqlConnection connection = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi");
        private bool isLoadingRatings = false;

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(StuIdLbl.Text);
                string comment = CommentTxt.Text.Trim();


                string query = "UPDATE StudentProgress SET Comments = @Comments WHERE StudentID = @StudentID";
                using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@Comments", SqlDbType.VarChar).Value = comment;
                        cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = studentID;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();


                        MessageBox.Show("Comment saved.");

                    }

                }
            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
               StuIdLbl.Text = (string)dataGridView1.CurrentRow.Cells[1].Value.ToString();
            NameLbl.Text = (string)dataGridView1.CurrentRow.Cells[2].Value.ToString();
            SNameLbl.Text = (string)dataGridView1.CurrentRow.Cells[3].Value.ToString();

            int studentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            LoadStudentRatings(studentID);
            LoadStudentComment(studentID);
            }
            catch
            {
                MessageBox.Show("Error!Please try again.");
            }
            
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb == null || !rb.Checked) return;

            GroupBox group = rb.Parent as GroupBox;
            if (group == null) return;

            string attribute = group.Text.Replace(" ", "");
            string rating = rb.Text;
            int studentID = Convert.ToInt32(StuIdLbl.Text);

            string query = $"UPDATE StudentProgress SET {attribute} = @Rating WHERE StudentID = @StudentID";

            using (SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            using (SqlCommand cmd = new SqlCommand(query, connec))
            {
                cmd.Parameters.Add("@Rating", SqlDbType.VarChar).Value = rating;
                cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = studentID;

                connec.Open();
                cmd.ExecuteNonQuery();
                connec.Close();
            }
            if (!isLoadingRatings)
            {
                MessageBox.Show($"{attribute} updated to {rating}.");
            }

        }

        private void WireRadioButtons(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is RadioButton rb)
                {
                    rb.CheckedChanged += radioButton_CheckedChanged;
                }


                if (ctrl.HasChildren)
                {
                    WireRadioButtons(ctrl);
                }
            }
        }

        private void ApplyRatingsRecursive(Control parent, SqlDataReader reader)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is GroupBox gb && gb.Name != "groupBox1" && gb.Name != "groupBox2")
                {
                    string columnName = gb.Text.Replace(" ", "");

                    if (reader.HasColumn1(columnName) && !reader.IsDBNull(reader.GetOrdinal(columnName)))
                    {
                        string rating = reader[columnName].ToString();

                        foreach (Control child in gb.Controls)
                        {
                            if (child is RadioButton rb && rb.Text == rating)
                            {
                                rb.Checked = true;
                            }
                        }
                    }
                }

                if (ctrl.HasChildren)
                {
                    ApplyRatingsRecursive(ctrl, reader);
                }
            }
        }

        private void LoadStudentRatings(int studentID)
        {
            isLoadingRatings = true;
            string query = "SELECT * FROM StudentProgress WHERE StudentID = @StudentID";

            using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = studentID;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ApplyRatingsRecursive(this, reader); // or use a specific container like panel1
                }

                reader.Close();
            }
            isLoadingRatings = false;
        }
        private void LoadStudentComment(int studentID)
        {
            string query = "SELECT Comments FROM StudentProgress WHERE StudentID = @StudentID";

            using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = studentID;
                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                CommentTxt.Text = result != null && result != DBNull.Value ? result.ToString() : "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            temporaryStudentsTableAdapter.FillByIdName(dSAttendance22.TemporaryStudents, id, textBox1.Text);
        }
    }

    public static class SqlDataReaderExtension
    {
        public static bool HasColumn1(this SqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}
