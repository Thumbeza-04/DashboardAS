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
        public StudentSummary(int ID)
        {
            InitializeComponent();
            label1.Text = ID.ToString();
        }

        private void StudentSummary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSAttendance.F_Outcome' table. You can move, or remove it, as needed.
            //this.f_OutcomeTableAdapter.Fill(this.dSAttendance.F_Outcome);
            // TODO: This line of code loads data into the 'dSAttendance.F_LessonAttendance' table. You can move, or remove it, as needed.
          
        }
        SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi");

        void Bind(int instructorId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM OutcomeMJ WHERE InstructorID = @InstructorID", connec);
            command.Parameters.AddWithValue("@InstructorID", instructorId);

            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
                
            
            
        }

        private void recordBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if ((int)dataGridView2.CurrentRow.Cells[7].Value != 0)
                {
                    MessageBox.Show("Student has not completed all their lessons");
                }
                else if (dataGridView2.CurrentRow.Cells[8].Value == null)
                {
                    MessageBox.Show("Select the outcome");
                }
                else
                {


                    connec.Open();
                    SqlCommand command = new SqlCommand("Insert into OutcomeMJ values( '" + (int)dataGridView2.CurrentRow.Cells[0].Value + "','" + dataGridView2.CurrentRow.Cells[1].Value + "','" + dataGridView2.CurrentRow.Cells[2].Value + "','" + (int)dataGridView2.CurrentRow.Cells[3].Value + "','" + dataGridView2.CurrentRow.Cells[4].Value + "','" + (int)dataGridView2.CurrentRow.Cells[5].Value + "','" + (int)dataGridView2.CurrentRow.Cells[6].Value + "','" + dataGridView2.CurrentRow.Cells[8].Value + "' )", connec);
                    command.ExecuteNonQuery();
                    connec.Close();
                    MessageBox.Show("Recorded");
                    int instructorId = (int)dataGridView2.CurrentRow.Cells[3].Value;

                    Bind(instructorId);
                }
            }
            catch
            {
                connec.Close();
                MessageBox.Show("Outcome Already Recorded", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
