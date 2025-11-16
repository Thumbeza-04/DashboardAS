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
            bool arch = false;
            // TODO: This line of code loads data into the 'dsAttendance21.LessonAttendanceMJ' table. You can move, or remove it, as needed.
            //this.lessonAttendanceMJTableAdapter.Fill(this.dsAttendance21.LessonAttendanceMJ);
            //lessonAttendanceMJTableAdapter.FillByLoad(dsAttendance21.LessonAttendanceMJ, id, arch);

            WireRadioButtons(this);

        }
        SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi");
        private bool isLoadingRatings = false;





        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //lessonAttendanceMJTableAdapter.FillByIDNAME(dsAttendance21.LessonAttendanceMJ,id, textBox1.Text);

        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                StuIdLbl.Text = (string)dataGridView2.CurrentRow.Cells[0].Value.ToString();
            NameLbl.Text = (string)dataGridView2.CurrentRow.Cells[1].Value.ToString();
            SNameLbl.Text = (string)dataGridView2.CurrentRow.Cells[2].Value.ToString();

            int studentID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
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
            if(!isLoadingRatings)
            {
                MessageBox.Show($"{attribute} updated to {rating}.");
            }
            
        }

        private void PRB1_CheckedChanged(object sender, EventArgs e)
        {
            
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

                    if (reader.HasColumn(columnName) && !reader.IsDBNull(reader.GetOrdinal(columnName)))
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
    }







    public static class SqlDataReaderExtensions
    {
        public static bool HasColumn(this SqlDataReader reader, string columnName)
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
