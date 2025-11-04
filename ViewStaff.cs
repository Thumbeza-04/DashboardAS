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
    public partial class ViewStaff : Form
    {
        public ViewStaff()
        {
            InitializeComponent();
        }

        private void ViewStaff_Load(object sender, EventArgs e)
        {

            mJstaffTableAdapter1.Fill(generalStaff1.MJstaff);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            BindActiveStaff();
            BindArchivedStaff();


        }
        void BindData()
        {

            SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi");
            SqlCommand command = new SqlCommand(" Select * from MJstaff", con);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void searchstaffbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void INSERTbtn_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string staffidCheckQuery = "SELECT COUNT (*)  FROM MJstaff Where staddid=Astaffid";
                using (SqlCommand staffidCheckCmd = new SqlCommand(staffidCheckQuery, con))
                {
                    staffidCheckCmd.Parameters.AddWithValue("@staffid", staffIdTxtB.Text.Trim());
                    int staffidExists = (int)staffidCheckCmd.ExecuteScalar();
                    if (staffidExists == 0)
                    {
                        MessageBox.Show("StaffID already exists , please enter a unique StaffID");
                        return;
                    }
                }


                SqlCommand command = new SqlCommand("Insert into MJstaff values( @staffid, @staffname, @staffsurname, @staffemail, @staffcellnumber, @idno, @gender, @streetnumber, @streetname, @city, @postalcode, @role, @status)", con);

                command.Parameters.AddWithValue("@staffid", int.Parse(staffIdTxtB.Text));
                command.Parameters.AddWithValue("@staffname", sNameTxtB.Text);
                command.Parameters.AddWithValue("@staffsurname", sSurnameTxtB.Text);
                command.Parameters.AddWithValue("@staffemail", textBox1.Text);
                command.Parameters.AddWithValue("@staffcellnumber", cellTxtB.Text);
                command.Parameters.AddWithValue("@idno", identityTxtB.Text);
                command.Parameters.AddWithValue("@gender", comboBox1.Text);
                command.Parameters.AddWithValue("@streetnumber", int.Parse(streetNumberTxt.Text));
                command.Parameters.AddWithValue("@streetname", streetNameTxtB.Text);
                command.Parameters.AddWithValue("@city", cityTxtB.Text);
                command.Parameters.AddWithValue("@postalcode", int.Parse(codeTxtB.Text));
                command.Parameters.AddWithValue("@role", comboBox2.Text);
                command.Parameters.AddWithValue("@status", comboBox3.Text);

                command.ExecuteNonQuery();
                con.Close();
                BindActiveStaff();
                BindArchivedStaff();
                MessageBox.Show("You have Entered a new staff member");

            }

        }


        private void UPDATEbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi");

                con.Open();
                SqlCommand command = new SqlCommand("Update MJstaff SET staffname = @staffname , staffsurname = @staffsurname,  staffemail = @staffemail , staffcellnumber = @staffcellnumber , idno = @idno , gender = @gender , streetnumber = @streetnumber , streetname = @streetname, city = @city , postalcode = @postalcode , role = @role , status = @status Where staffid = @staffid ", con);
                command.Parameters.AddWithValue("@staffid", int.Parse(staffIdTxtB.Text));
                command.Parameters.AddWithValue("@staffname", sNameTxtB.Text);
                command.Parameters.AddWithValue("@staffsurname", sSurnameTxtB.Text);
                command.Parameters.AddWithValue("@staffemail", textBox1.Text);
                command.Parameters.AddWithValue("@staffcellnumber", cellTxtB.Text);
                command.Parameters.AddWithValue("@idno", identityTxtB.Text);
                command.Parameters.AddWithValue("@gender", comboBox1.Text);
                command.Parameters.AddWithValue("@streetnumber", int.Parse(streetNumberTxt.Text));
                command.Parameters.AddWithValue("@streetname", streetNameTxtB.Text);
                command.Parameters.AddWithValue("@city", cityTxtB.Text);
                command.Parameters.AddWithValue("@postalcode", int.Parse(codeTxtB.Text));
                command.Parameters.AddWithValue("@role", comboBox2.Text);
                command.Parameters.AddWithValue("@status", comboBox3.Text);

                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("You have Updated Staff Member's Information.");
                BindActiveStaff();
                BindArchivedStaff();

            }
            catch (Exception)
            {
                MessageBox.Show("Information Not updated, cannot change staffId");
            }
        }
    
    

        
        private void ARCHIVEbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi");
                con.Open();

                // Replace with the actual staffid you want to archive
                string staffId = staffIdTxtB.Text;

                SqlCommand command = new SqlCommand(
                    "UPDATE MJstaff SET status = @status WHERE staffid = @staffid", con);
                command.Parameters.AddWithValue("@status", "archived");
                command.Parameters.AddWithValue("@staffid", staffId);

                int rowsAffected = command.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Staff member archived.");
                    BindActiveStaff();
                    BindArchivedStaff();
                    
                }
                else
                {
                    MessageBox.Show("Archive failed: No staff found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Archive failed: " + ex.Message);
            }
        

        
            
        }
        private void LoadArchivedStaff()
        {
            using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MJstaff WHERE status = 'archived'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
            }
        }

        private void ARCHIVEbtn_Click_1(object sender, EventArgs e)
        {
            string staffid = staffIdTxtB.Text;
            string status = comboBox3.Text;

            if(status == "Inactive")
            {
                MessageBox.Show("You are about to archive a Staff Member", "Warning");

            }
            else
            {
                MessageBox.Show("Staff Member must be Inactive to Archive");
            }
            BindActiveStaff();
            BindArchivedStaff();
        }

        private void BindActiveStaff()
        {
            using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MJstaff WHERE Status= 'Active'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void BindArchivedStaff()
        {
            using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MJstaff WHERE Status= 'Inactive'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 )
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                staffIdTxtB.Text = row.Cells[0].Value.ToString();
                sNameTxtB.Text = row.Cells[1].Value.ToString();
                sSurnameTxtB.Text = row.Cells[2].Value.ToString();
                textBox1.Text = row.Cells[3].Value.ToString();
                cellTxtB.Text = row.Cells[4].Value.ToString();
                identityTxtB.Text = row.Cells[5].Value.ToString();
                comboBox1.Text = row.Cells[6].Value.ToString();
                streetNumberTxt.Text = row.Cells[7].Value.ToString();
                streetNameTxtB.Text = row.Cells[8].Value.ToString();
                cityTxtB.Text = row.Cells[9].Value.ToString();
                codeTxtB.Text = row.Cells[10].Value.ToString();
                comboBox2.Text = row.Cells[11].Value.ToString();
                comboBox3.Text = row.Cells[12].Value.ToString();
            }
           
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                staffIdTxtB.Text = row.Cells[0].Value.ToString();
                sNameTxtB.Text = row.Cells[1].Value.ToString();
                sSurnameTxtB.Text = row.Cells[2].Value.ToString();
                textBox1.Text = row.Cells[3].Value.ToString();
                cellTxtB.Text = row.Cells[4].Value.ToString();
                identityTxtB.Text = row.Cells[5].Value.ToString();
                comboBox1.Text = row.Cells[6].Value.ToString();
                streetNumberTxt.Text = row.Cells[7].Value.ToString();
                streetNameTxtB.Text = row.Cells[8].Value.ToString();
                cityTxtB.Text = row.Cells[9].Value.ToString();
                codeTxtB.Text = row.Cells[10].Value.ToString();
                comboBox2.Text = row.Cells[11].Value.ToString();
                comboBox3.Text = row.Cells[12].Value.ToString();
            }
            
            


            
        }
    }
}
