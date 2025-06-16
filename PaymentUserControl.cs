using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DashboardAS.Data;

namespace DashboardAS
{
    public partial class PaymentUserControl : UserControl
    {
        private PaymentDAO paymentDAO;

        public PaymentUserControl()
        {
            InitializeComponent();
            paymentDAO = new PaymentDAO();
        }        private void PaymentUserControl_Load(object sender, EventArgs e)
        {
            // Initialize title and subtitle
            label1.Text = "Payments";
            label2.Text = "Manage payment information";
            
            // Load dashboard statistics
            LoadPaymentStatistics();
            
            // Populate the payments grid
            PopulatePaymentsTable();
        }
        
        private void LoadPaymentStatistics()
        {
            try
            {
                decimal totalRevenue = paymentDAO.GetTotalRevenue();
                decimal outstandingAmount = paymentDAO.GetOutstandingAmount();
                
                // Update dashboard cards with real data
                label3.Text = $"R{totalRevenue:F2}";  // Total Revenue
                label4.Text = $"R{outstandingAmount:F2}";  // Outstanding
                label5.Text = "0";  // This could be other metrics like refunds
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payment statistics: {ex.Message}");
                // Set default values
                label3.Text = "R0.00";
                label4.Text = "R0.00";
                label5.Text = "0";
            }
        }
        
        private void PopulatePaymentsTable()
        {
            try
            {                // Load payment data from database
                DataTable dt = paymentDAO.GetPaymentsForDisplay();
                
                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dt;
                
                // Format the grid
                dataGridView1.BorderStyle = BorderStyle.None;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dataGridView1.BackgroundColor = Color.White;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payment data: {ex.Message}", "Database Error", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Load with empty data table as fallback
                dataGridView1.DataSource = new DataTable();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
