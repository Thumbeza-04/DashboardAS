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
        private bool showArchived = false;

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
                DataTable dt = studentDAO.GetStudentsWithLessonCount(showArchived);
                
                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dt;
                
                // Format the grid
                FormatDataGridView();
                
                // Update button visibility based on selection and archived status
                UpdateButtonVisibility();
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
                DataTable dt = studentDAO.SearchStudents(searchTerm, showArchived);
                
                // Update the DataGridView with search results
                dataGridView1.DataSource = dt;
                
                // Refresh the grid formatting
                FormatDataGridView();
                
                // Update button visibility
                UpdateButtonVisibility();
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
            
            // Add selection changed event handler
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged; // Remove first to prevent duplicates
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
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

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to archive.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the selected student's ID and current status
                int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StudentID"].Value);
                string currentStatus = dataGridView1.SelectedRows[0].Cells["Status"].Value?.ToString() ?? "";
                string studentName = dataGridView1.SelectedRows[0].Cells["FullName"].Value?.ToString() ?? "";

                // Check if already archived
                if (currentStatus.Equals("Archived", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This student is already archived.", "Already Archived", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Confirm archiving
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to archive student '{studentName}'?\n\nThis will hide them from the default view but they can be reactivated later.",
                    "Confirm Archive",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (studentDAO.ArchiveStudent(studentId))
                    {
                        MessageBox.Show($"Student '{studentName}' has been archived successfully.", "Archive Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopulateStudentsTable(); // Refresh the grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to archive student. Please try again.", "Archive Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error archiving student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReactivate_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to reactivate.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the selected student's ID and current status
                int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StudentID"].Value);
                string currentStatus = dataGridView1.SelectedRows[0].Cells["Status"].Value?.ToString() ?? "";
                string studentName = dataGridView1.SelectedRows[0].Cells["FullName"].Value?.ToString() ?? "";

                // Check if not archived
                if (!currentStatus.Equals("Archived", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This student is not archived.", "Not Archived", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Confirm reactivation
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to reactivate student '{studentName}'?\n\nThis will restore them to active status.",
                    "Confirm Reactivation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (studentDAO.ReactivateStudent(studentId))
                    {
                        MessageBox.Show($"Student '{studentName}' has been reactivated successfully.", "Reactivation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopulateStudentsTable(); // Refresh the grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to reactivate student. Please try again.", "Reactivation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reactivating student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxShowArchived_CheckedChanged(object sender, EventArgs e)
        {
            showArchived = checkBoxShowArchived.Checked;
            PopulateStudentsTable(); // Refresh the data with new filter
        }

        private void UpdateButtonVisibility()
        {
            bool hasSelection = dataGridView1.SelectedRows.Count > 0;
            bool isArchived = false;

            if (hasSelection)
            {
                string currentStatus = dataGridView1.SelectedRows[0].Cells["Status"].Value?.ToString() ?? "";
                isArchived = currentStatus.Equals("Archived", StringComparison.OrdinalIgnoreCase);
            }

            // Show/hide buttons based on selection and status
            buttonArchive.Visible = hasSelection && !isArchived;
            buttonReactivate.Visible = hasSelection && isArchived;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonVisibility();
        }
    }
}
