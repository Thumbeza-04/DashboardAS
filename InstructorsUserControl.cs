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
    public partial class InstructorsUserControl : UserControl
    {
        private InstructorDAO instructorDAO;        public InstructorsUserControl()
        {
            InitializeComponent();
            instructorDAO = new InstructorDAO();
            
            // Wire up placeholder text events
            textBoxSearch.Enter += textBoxSearch_Enter;
            textBoxSearch.Leave += textBoxSearch_Leave;
        }

        private void InstructorsUserControl_Load(object sender, EventArgs e)
        {
            // Load instructor data
            InitializeInstructorsView();
        }        private void InitializeInstructorsView()
        {            // Set the title and subtitle
            label1.Text = "Instructors";
            label2.Text = "Search Instructor:";
            
            // Set placeholder text for search box
            textBoxSearch.Text = "";
            textBoxSearch.ForeColor = Color.Gray;
            
            // Add instructors data grid setup
            SetupInstructorsGrid();
            
            // Add event handlers for buttons
        }private void SetupInstructorsGrid()
        {
            try
            {
                // Load instructor data from database with vehicle information
                DataTable dt = instructorDAO.GetInstructorsWithVehicleInfo();
                
                // Set the data source for the DataGridView
                dataGridView1.DataSource = dt;
                
                // Format the DataGridView
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading instructor data: {ex.Message}", "Database Error", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Load with empty data table as fallback
                dataGridView1.DataSource = new DataTable();
            }
        }
          private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Perform search using the current text in the search box
            PerformSearch();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Add functionality would open a form to add a new instructor
            MessageBox.Show("Add instructor form would open here.", "Add Instructor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }          private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Edit functionality would open a form to edit the selected instructor
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string instructorId = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                MessageBox.Show("Edit form for Instructor " + instructorId + " would open here.", "Edit Instructor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an instructor to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // Perform search when text changes
            PerformSearch();
        }
        
        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            // Remove placeholder text when user clicks on the textbox
            if (textBoxSearch.Text == "Enter search term...")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }
        
        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            // Add placeholder text back if textbox is empty
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Enter search term...";
                textBoxSearch.ForeColor = Color.Gray;
            }
        }        private void PerformSearch()
        {
            try
            {
                string searchTerm = textBoxSearch.Text.Trim();
                
                // Don't search if it's the placeholder text
                if (searchTerm == "Enter search term...")
                {
                    searchTerm = "";
                }
                
                // Use the search method if there's a search term, otherwise load all instructors
                DataTable dt = instructorDAO.SearchInstructors(searchTerm);
                
                // Update the DataGridView with search results
                dataGridView1.DataSource = dt;
                
                // Refresh the grid formatting
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error performing search: {ex.Message}", "Search Error", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void FormatDataGridView()
        {
            // Format the DataGridView (extracted from SetupInstructorsGrid for reuse)
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 9);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.LightGray;
        }
    }
}
