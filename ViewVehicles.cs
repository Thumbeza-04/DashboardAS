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
    public partial class ViewVehicles : Form
    {
        public ViewVehicles()
        {
            InitializeComponent();
        }

        private void ViewVehicles_Load(object sender, EventArgs e)
        {
            vehicleMJTableAdapter.FillBy(mangerNEW.VehicleMJ);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindActive();
            BindInactive();

        }

        private void searchvehiclesbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void INSERTbtn_Click(object sender, EventArgs e)
        {
           
        }
        void BindData()
        {

            SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi");
            SqlCommand command = new SqlCommand(" Select * from VehicleMJ", con);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void UPDATEbtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand comm = new SqlCommand("Update VehicleMJ set TransmissionType = @transmissiontype, fueltype=@fueltype, make=@make, vehicletype=@vehicletype, status=@status WHERE licenseplateid=@licenseplateid", con);

               comm.Parameters.AddWithValue("@licenseplateid", licensePlateTxtB.Text.Trim());
                comm.Parameters.AddWithValue("@transmissiontype", comboBox1.Text.Trim());
                comm.Parameters.AddWithValue("@fueltype", comboBox2.Text.Trim());
                comm.Parameters.AddWithValue("@make", makeTxtB.Text.Trim());
                comm.Parameters.AddWithValue("@vehicletype", comboBox3.Text.Trim());
                comm.Parameters.AddWithValue("@status", comboBox4.Text.Trim());


                int rowsAffected = comm.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("No Record was Updated");
                }
                else
                {
                    MessageBox.Show("Update successful!");
                }

                BindInactive();
                BindActive();
                con.Close();
            }
        }

        private void ARCHIVEbtn_Click(object sender, EventArgs e)
        {
          
        }

        private void BindActive()
        {
            string connectionString = "Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM VehicleMJ WHERE  Status = 'Active'", con);
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM VehicleMJ WHERE  Status = 'Inactive'", con);
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

                licensePlateTxtB.Text = row.Cells[0].Value.ToString();
                comboBox1.Text = row.Cells[1].Value.ToString();
                comboBox2.Text = row.Cells[2].Value.ToString();
                makeTxtB.Text = row.Cells[3].Value.ToString();
                comboBox3.Text = row.Cells[4].Value.ToString();
                comboBox4.Text = row.Cells[5].Value.ToString();
                

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                licensePlateTxtB.Text = row.Cells[0].Value.ToString();
                comboBox1.Text = row.Cells[1].Value.ToString();
                comboBox2.Text = row.Cells[2].Value.ToString();
                makeTxtB.Text = row.Cells[3].Value.ToString();
                comboBox3.Text = row.Cells[4].Value.ToString();
                comboBox4.Text = row.Cells[5].Value.ToString();


            }
        }
    }
}
