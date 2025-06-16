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
using DashboardAS.Models;

namespace DashboardAS
{
    public partial class StudentsUserControl : UserControl
    {
        private StudentDAO studentDAO;

        public StudentsUserControl()
        {
            InitializeComponent();
            studentDAO = new StudentDAO();
        }private void StudentsUserControl_Load(object sender, EventArgs e)
        {
            // Initialize title and subtitle
            label1.Text = "Students";
            label2.Text = "Manage students";
            
            // Load student data
            PopulateStudentsTable();
        }        private void PopulateStudentsTable()
        {
            try
            {
                // Load student data from database with lesson count
                DataTable dt = studentDAO.GetStudentsWithLessonCount();
                
                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dt;
                
                // Format the grid
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}", "Database Error", 
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
        
        
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // Perform search when text changes
            PerformSearch();
        }
        
        private void PerformSearch()
        {
            try
            {
                string searchTerm = textBoxSearch.Text.Trim();
                
                // Use the search method if there's a search term, otherwise load all students
                DataTable dt = studentDAO.SearchStudents(searchTerm);
                
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
        }          private void FormatDataGridView()
        {
            // Format the DataGridView (extracted for reuse)
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            
            // Change AutoSizeColumnsMode to allow horizontal scrolling
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
            // Enable scrollbars
            dataGridView1.ScrollBars = ScrollBars.Both;
            
            // Enable full row selection
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false; // Allow only single row selection
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            using (Form3 addStudentForm = new Form3()){
          if (addStudentForm.ShowDialog() == DialogResult.OK)
            {
                 PopulateStudentsTable(); // Refresh the grid only if a student was added
            }
            // Hide the current user control
           }
        }        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the selected student's ID
                int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StudentID"].Value);
                
                // Get the full student data from the database
                Student selectedStudent = studentDAO.GetStudentById(studentId);
                
                if (selectedStudent != null)
                {
                    // Open Form3 in edit mode with the selected student
                    using (Form3 editStudentForm = new Form3(selectedStudent))
                    {
                        if (editStudentForm.ShowDialog() == DialogResult.OK)
                        {
                            PopulateStudentsTable(); // Refresh the grid only if student was updated
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Could not load student data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error editing student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
