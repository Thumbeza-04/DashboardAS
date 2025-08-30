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
            try
            {
                SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi");

                con.Open();
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
                MessageBox.Show("You have Entered a new staff member");
                BindData();

            }
            catch (Exception)
            {
                MessageBox.Show("New Staff Member Not Added");
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
                BindData();

            }
            catch(Exception)
            {
                MessageBox.Show("Information Not updated, cannot changed staffId");
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Show archived records
                LoadArchivedStaff();
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

    }
}
