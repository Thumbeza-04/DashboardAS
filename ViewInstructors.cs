using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardAS
{
    public partial class ViewInstructors : Form
    {
        public ViewInstructors()
        {
            InitializeComponent();
        }

        private void ViewInstructors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'instructorsVehicles1.InstructorMJ' table. You can move, or remove it, as needed.
            this.instructorMJTableAdapter.Fill(this.instructorsVehicles1.InstructorMJ);
            // TODO: This line of code loads data into the 'instructorsVehicles1.VehicleMJ' table. You can move, or remove it, as needed.
            this.vehicleMJTableAdapter.Fill(this.instructorsVehicles1.VehicleMJ);
            instructorMJTableAdapter1.Fill(managerDataSet1.InstructorMJ);
        }
        void BindData()
        {

            SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi");
            SqlCommand command = new SqlCommand(" Select * from InstructorMJ", con);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void searchinstructorsbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void INSERTbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi");

                con.Open();

                // 1. Check if this vehicle is already assigned to an instructor
                string checkQuery = "SELECT COUNT(*) FROM InstructorMJ WHERE licenseplateid = @licenseplateid";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@licenseplateid", comboBox1.Text);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Vehicle not available");
                    con.Close();
                    return;
                }

                SqlCommand command = new SqlCommand("Insert into InstructorMJ values( @licenseplateid, @licensenumber,@expertiselevel ,  @firstname, @lastname, @gender, @contactnumber, @email)", con);

                command.Parameters.AddWithValue("@licenseplateid", comboBox1.Text);
                command.Parameters.AddWithValue("@licensenumber", licenseNotxtB.Text);
                command.Parameters.AddWithValue("@expertiselevel", comboBox2.Text);
                command.Parameters.AddWithValue("@firstname", firstNameTxtB.Text);
                command.Parameters.AddWithValue("@lastname", LastnametxtB.Text);
                command.Parameters.AddWithValue("@gender", comboBox3.Text);
                command.Parameters.AddWithValue("@contactnumber", contactNumberTxtB.Text);
                command.Parameters.AddWithValue("@email", emailTxtB.Text);
                

                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("You have Entered a new Instructor ");
                BindData();

            }
            catch (Exception)
            {
                MessageBox.Show("New Instructor not added");
            }
        }

        private void UPDATEbtn_Click(object sender, EventArgs e)
        {
        }
    }
}
