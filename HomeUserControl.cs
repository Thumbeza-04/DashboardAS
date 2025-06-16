using DashboardAS.Data;
using DashboardAS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardAS
{
    public partial class HomeUserControl : UserControl
    {
        private StudentDAO studentDAO;
        private LessonBookingDAO bookingDAO;
        private InstructorDAO instructorDAO;

        public HomeUserControl()
        {
            InitializeComponent();
            studentDAO = new StudentDAO();
            bookingDAO = new LessonBookingDAO();
            instructorDAO = new InstructorDAO();
        }        
        private void HomeUserControl_Load(object sender, EventArgs e)
        {
            // Initialize title and subtitle
            label1.Text = "Dashboard";
            label2.Text = "Welcome, receptionist!";
            
            // Load dashboard statistics
            LoadDashboardStatistics();
            
            // Populate the upcoming lessons grid
            PopulateUpcomingLessons();
        }
        
        private void LoadDashboardStatistics()
        {
            try
            {
                // Get upcoming lessons count
                var upcomingLessons = bookingDAO.GetUpcomingBookings(7);
                label3.Text = upcomingLessons.Count.ToString();
                
                // Get total students count
                var students = studentDAO.GetAllStudents();
                label4.Text = students.Count.ToString();

                // Get total instructors count
                var instructors = instructorDAO.GetAllInstructors();
                label5.Text = instructors.Count.ToString();
            }
            catch (Exception ex)
            {
                // Set default values on error
                label3.Text = "0";
                label4.Text = "0"; 
                label5.Text = "0";
                MessageBox.Show($"Error loading dashboard statistics: {ex.Message}");
            }
        }
        
        private void PopulateUpcomingLessons()
        {
            try
            {
                // Get upcoming lessons from database
                var upcomingBookings = bookingDAO.GetUpcomingBookings(7);
                
                // Create a DataTable to hold upcoming lesson data
                DataTable dt = new DataTable();
                
                // Add columns
                dt.Columns.Add("Time", typeof(string));
                dt.Columns.Add("Student", typeof(string));
                dt.Columns.Add("Instructor", typeof(string));
                dt.Columns.Add("Status", typeof(string));
                
                // Add data from database
                foreach (var booking in upcomingBookings)
                {
                    dt.Rows.Add(
                        booking.FormattedDateTime,
                        booking.StudentName,
                        booking.InstructorName,
                        booking.Status
                    );
                }
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
                MessageBox.Show($"Error loading upcoming lessons: {ex.Message}", "Database Error", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Load with empty data table as fallback
                dataGridView1.DataSource = new DataTable();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panelInstructors_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
