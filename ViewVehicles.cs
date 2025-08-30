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
            BindData();

        }

        private void searchvehiclesbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void INSERTbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi");

                con.Open();
                SqlCommand command = new SqlCommand("Insert into VehicleMJ values (@licenseplateid , @transmissiontype, @fueltype, @make, @vehicletype ) ", con);

                command.Parameters.AddWithValue("@licenseplateid", licensePlateTxtB.Text);
                command.Parameters.AddWithValue("@transmissiontype", comboBox1.Text);
                command.Parameters.AddWithValue("@fueltype", comboBox2.Text);
                command.Parameters.AddWithValue("@make", makeTxtB.Text);
                command.Parameters.AddWithValue("@vehicletype", comboBox3.Text);

                command.ExecuteNonQuery();

                con.Close();
                MessageBox.Show(" New Vehicle has been inserted");
                BindData();
            }
            catch (Exception)
            {
                MessageBox.Show("Vehicle Not added. License Plate ID has to be unique");
            }
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
            try
            {
                SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp24;Persist Security Info=True;User ID=WstGrp24;Password=6wefi");

                con.Open();
                SqlCommand command = new SqlCommand("Update VehicleMJ Set transmissiontype = @transmissiontype , fueltype = @fueltype , make = @make , vehicletype = @vehicletype Where licenseplateid = @licenseplateid ", con);

                command.Parameters.AddWithValue("@licenseplateid", licensePlateTxtB.Text);
                command.Parameters.AddWithValue("@transmissiontype", comboBox1.Text);
                command.Parameters.AddWithValue("@fueltype", comboBox2.Text);
                command.Parameters.AddWithValue("@make", makeTxtB.Text);
                command.Parameters.AddWithValue("@vehicletype", comboBox3.Text);

                command.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Vehicle updated");
                BindData();
            }

            catch (Exception)
            {
                MessageBox.Show("Vehicle not Updated");
            }
        }

        private void ARCHIVEbtn_Click(object sender, EventArgs e)
        {
            string licensePlateID = licensePlateTxtB.Text.Trim();
            if (string.IsNullOrEmpty(licensePlateID))
            {
                MessageBox.Show("Please enter a License Plate ID.");
                return;
            }

            // Find the selected row in the active vehicles grid
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == licensePlateID)
                {
                    // Get all vehicle data (adjust indexes as needed)
                    string transmissionType = row.Cells[1].Value?.ToString();
                    string fuelType = row.Cells[2].Value?.ToString();
                    string make = row.Cells[3].Value?.ToString();
                    string vehicleType = row.Cells[4].Value?.ToString();

                    // Remove from active vehicles table in database
                    using (SqlConnection conn = new SqlConnection("Data Source = 146.230.177.46; Initial Catalog = WstGrp24; Persist Security Info = True; User ID = WstGrp24; Password = 6wefi"))
                    {
                        conn.Open();
                        // Delete from main table
                        string deleteQuery = "DELETE FROM VehicleMJ WHERE LicensePlateID = @LicensePlateID";
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@LicensePlateID", licensePlateID);
                            cmd.ExecuteNonQuery();
                        }

                        // Insert into archive table (create the archive table if not exists)
                        string insertQuery = @"INSERT INTO ArchivedVehicles
                    (LicensePlateID, TransmissionType, FuelType, Make, VehicleType)
                    VALUES (@LicensePlateID, @TransmissionType, @FuelType, @Make, @VehicleType)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@LicensePlateID", licensePlateID);
                            cmd.Parameters.AddWithValue("@TransmissionType", transmissionType);
                            cmd.Parameters.AddWithValue("@FuelType", fuelType);
                            cmd.Parameters.AddWithValue("@Make", make);
                            cmd.Parameters.AddWithValue("@VehicleType", vehicleType);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Remove from DataGridView (UI)
                    dataGridView1.Rows.Remove(row);

                    // Add to archives grid (UI)
                    dataGridView2.Rows.Add(licensePlateID, transmissionType, fuelType, make, vehicleType);

                    MessageBox.Show("Vehicle archived successfully.");
                    break;
                }

            }
        }
        
        
    }
}
