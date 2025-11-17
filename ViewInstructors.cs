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
            instructorMJTableAdapter2.FillBy(mangerNEW.InstructorMJ);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            BindActive();
            BindInactive();


        }
        void BindData()
        {

            //SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi");
            //SqlCommand command = new SqlCommand(" Select * from InstructorMJ", con);
            //SqlDataAdapter da = new SqlDataAdapter(command);
            //DataTable table = new DataTable();
            //da.Fill(table);
            //dataGridView1.DataSource = table;
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

            
        }









        

        private void UPDATEbtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // 1. Check that LicensePlateID exists in VehicleMJ and is Active
                string licenseCheckQuery = "SELECT Status FROM VehicleMJ WHERE licenseplateid = @licenseplateid";
                using (SqlCommand licenseCheckCmd = new SqlCommand(licenseCheckQuery, con))
                {
                    licenseCheckCmd.Parameters.AddWithValue("@licenseplateid", textBox1.Text.Trim());
                    var result = licenseCheckCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("License PlateID does not exist in the Vehicle records. Please enter a valid License PlateID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string vehicleStatus = result.ToString();
                    if (vehicleStatus != "Active")
                    {
                        MessageBox.Show("Cannot allocate vehicle because the vehicle is inactive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                //2. Check if LicensePlateID already  assigned to an active instructor 
                string InstructorCheckQuery = "SELECT COUNT(*) FROM InstructorMJ WHERE licenseplateid = @licenseplateid AND Status = 'Active'";
                using (SqlCommand checkcmd = new SqlCommand(InstructorCheckQuery, con))
                {
                    checkcmd.Parameters.AddWithValue("@licenseplateid", textBox1.Text.Trim());
                    int count = (int)checkcmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show(" License Plate ID has already been allocated to another active instructor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string insertQuery = @"UPDATE InstructorMJ 
                                 SET LicensePlateID = @licenseplateid,
                                     LicenseNumber = @licensenumber,
                                     ExpertiseLevel = @expertiselevel,
                                     FirstName = @firstname,
                                     LastName = @lastname,
                                     Gender = @gender,
                                     ContactNumber = @contactnumber,
                                     Email = @email,
                                     Status = @status
                                 WHERE InstructorID = @instructorid";
                using (SqlCommand comm = new SqlCommand(insertQuery, con))
                {
                    comm.Parameters.AddWithValue("@licenseplateid", textBox1.Text.Trim());
                    comm.Parameters.AddWithValue("@licensenumber", licenseNotxtB.Text.Trim());
                    comm.Parameters.AddWithValue("@expertiselevel", comboBox1.Text.Trim());
                    comm.Parameters.AddWithValue("@firstname", firstNameTxtB.Text.Trim());
                    comm.Parameters.AddWithValue("@lastname", LastnametxtB.Text.Trim());
                    comm.Parameters.AddWithValue("@gender", comboBox3.Text);
                    comm.Parameters.AddWithValue("@contactnumber", contactNumberTxtB.Text.Trim());
                    comm.Parameters.AddWithValue("@email", emailTxtB.Text.Trim());
                    comm.Parameters.AddWithValue("@status", comboBox2.Text.Trim());
                    comm.Parameters.AddWithValue("@instructorid",instructorIDtxtB.Text.Trim());

                    comm.ExecuteNonQuery();

                }

                con.Close();
                MessageBox.Show("You have Entered a new Instructor ");
                BindActive();
                BindInactive();
            }
        }

        private void ARCHIVEbtn_Click(object sender, EventArgs e)
        {
            string instructorid = instructorIDtxtB.Text;
            string status = comboBox2.Text;

            if (status == "Inactive")
            {
                MessageBox.Show(" You are about to Archive an Inactive member, you can undo this by Update");
            }
            else
            {
                MessageBox.Show("To Archive the instructor has to be inactive ");
            }
            BindActive();
            BindInactive();

        }
        private void BindActive()
        {
            string connectionString = "Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM InstructorMJ WHERE  Status = 'Active'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void BindInactive()
        {
            string connectionString = "Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM InstructorMJ WHERE  Status = 'Inactive'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                instructorIDtxtB.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                licenseNotxtB.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
                firstNameTxtB.Text = row.Cells[4].Value.ToString();
                LastnametxtB.Text = row.Cells[5].Value.ToString();
                comboBox3.Text = row.Cells[6].Value.ToString();
                contactNumberTxtB.Text = row.Cells[7].Value.ToString();
                emailTxtB.Text = row.Cells[8].Value.ToString();
                comboBox2.Text = row.Cells[9].Value.ToString();

            }
        }




        private void dataGridView2_CellClick_(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                instructorIDtxtB.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                licenseNotxtB.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
                firstNameTxtB.Text = row.Cells[4].Value.ToString();
                LastnametxtB.Text = row.Cells[5].Value.ToString();
                comboBox3.Text = row.Cells[6].Value.ToString();
                contactNumberTxtB.Text = row.Cells[7].Value.ToString();
                emailTxtB.Text = row.Cells[8].Value.ToString();
                comboBox2.Text = row.Cells[9].Value.ToString();

            }
        }
    }
}
