using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
        //SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi");
        





        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            studentMJTableAdapter.FillBySearch(dSAttendance2.StudentMJ, textBox1.Text);

        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            studentProgressTableAdapter1.FillByStu(dsAttendance21.StudentProgress, (int)dataGridView2.CurrentRow.Cells[0].Value);
            dataGridView1.DataSource = dsAttendance21.StudentProgress;

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

        private void RatingsBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Do you want to proceed with this action?",
            "Confirmation Required",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Please select a skill, rating, and student.");
                    return;
                }

                int studentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string skillColumn = comboBox1.SelectedItem.ToString();
                string rating = comboBox2.SelectedItem.ToString();
                DialogResult result2 = MessageBox.Show(
            $"Do you want to Update {skillColumn} to {rating} for student {studentID}" ,
            "Confirmation Required",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                    //string connStr = ConfigurationManager.ConnectionStrings["Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"].ConnectionString;
                    using (SqlConnection conn = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
                    {
                        string query = $"UPDATE StudentProgress SET [{skillColumn}] = @Rating WHERE StudentID = @StudentID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Rating", rating);
                            cmd.Parameters.AddWithValue("@StudentID", studentID);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Rating updated.");
                            conn.Close();
                        }
                    }

                    BindGrid(); // Refresh grid
                }
                else if (result2 == DialogResult.No)
                {
                    MessageBox.Show("Action was cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Action was cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void CommentBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Do you want to proceed with this action?",
           "Confirmation Required",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dataGridView1.CurrentRow == null || textBox2.Text.Trim() == " ")
                {
                    MessageBox.Show("Select a student and enter a comment.");
                    return;
                }

                int studentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string newComment = textBox2.Text.Trim();
                string timestampedComment = $"[{DateTime.Now:yyyy-MM-dd HH:mm}] {newComment}";
                

                using (SqlConnection conn = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi"))
                {
                    string query = @"
                    UPDATE StudentProgress
                    SET Comments = @NewComment + CHAR(13) + CHAR(10) + ISNULL(Comments, '')
                    WHERE StudentID = @StudentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewComment", timestampedComment);
                        cmd.Parameters.AddWithValue("@StudentID", studentID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Comment added.");
                        conn.Close();
                    }
                }

                textBox2.Text = " ";
                BindGrid(); // Optional: refresh grid
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Action was cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }

}
