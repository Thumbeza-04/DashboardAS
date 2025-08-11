using DashboardAS.Data;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardAS
{
    public partial class CalendarUserControl : UserControl
    {
        private LessonBookingDAO bookingDAO = new LessonBookingDAO();
        private DataTable lessonsTable;
        
        public CalendarUserControl()
        {
            InitializeComponent();
            
            // Initialize the calendar
            InitializeMonthCalendar();
        }        private void CalendarUserControl_Load(object sender, EventArgs e)
        {
            // Load calendar data
            label1.Text = "Calendar";
            label2.Text = "Scheduled Appointments:";
            
            // Load lessons for the selected date
            LoadLessonsForDate(monthCalendar1.SelectionStart.Date);
            
            // Attach event handlers
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            buttonAddLesson.Click += ButtonAddLesson_Click;
            buttonCancelBooking.Click += ButtonCancelBooking_Click;
        }

        private void ButtonCancelBooking_Click(object sender, EventArgs e)
        {
            CancelSelectedBooking();
        }
        
        private void InitializeMonthCalendar()
        {
            // Configure the month calendar
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.ShowTodayCircle = true;
            monthCalendar1.ShowWeekNumbers = false;
            
            // Set bold dates to indicate lessons
            SetBoldDatesForLessons();
        }
        
        private void SetBoldDatesForLessons()
        {
            // In a real app, this would query a database for dates with lessons
            // Here we're just setting some example dates as bold
            DateTime today = DateTime.Today;
            DateTime[] boldDates = new DateTime[] {
                today,
                today.AddDays(1),
                today.AddDays(3),
                today.AddDays(5),
                today.AddDays(7),
                today.AddDays(10)
            };
            
            monthCalendar1.BoldedDates = boldDates;
        }
        
        private void LoadLessonsForSelectedDate(DateTime selectedDate)
        {
            // Create a table for the lessons
            lessonsTable = new DataTable();
            lessonsTable.Columns.Add("Time", typeof(string));
            lessonsTable.Columns.Add("Student", typeof(string));
            lessonsTable.Columns.Add("Instructor", typeof(string));
            lessonsTable.Columns.Add("Status", typeof(string));
            
            // In a real app, this would load data from a database filtered by the selected date
            // Here we're just showing sample data
            string dateString = selectedDate.ToString("yyyy-MM-dd");
            if (selectedDate.Date == DateTime.Today.Date)
            {
                lessonsTable.Rows.Add("9:00 AM", "John Smith", "David Miller", "Confirmed");
                lessonsTable.Rows.Add("10:30 AM", "Emma Brown", "Jessica Davis", "Confirmed");
                lessonsTable.Rows.Add("1:00 PM", "Michael Johnson", "Robert Taylor", "Pending");
            }
            else if (selectedDate.Date == DateTime.Today.AddDays(1).Date)
            {
                lessonsTable.Rows.Add("9:30 AM", "Sarah Williams", "Amanda Harris", "Confirmed");
                lessonsTable.Rows.Add("11:00 AM", "David Thompson", "Thomas Wilson", "Confirmed");
            }
            else if (selectedDate.Date == DateTime.Today.AddDays(3).Date)
            {
                lessonsTable.Rows.Add("2:00 PM", "Lisa Adams", "Robert Taylor", "Confirmed");
            }
            
            // Set the data source for the grid
            dataGridView1.DataSource = lessonsTable;
              // Format the grid
            FormatDataGridView();            // Update the date label
            label3.Text = "Lessons for " + selectedDate.ToString("MMMM d, yyyy");
        }
          private void FormatDataGridView()
        {
            // Format the DataGridView
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
            
            // Add formatting based on status
            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Apply conditional formatting based on status
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Status"] != null && row.Cells["Status"].Value != null)
                {
                    string status = row.Cells["Status"].Value.ToString();
                    switch (status.ToLower())
                    {
                        case "cancelled":
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                            row.DefaultCellStyle.ForeColor = Color.DarkRed;
                            break;
                        case "confirmed":
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            row.DefaultCellStyle.ForeColor = Color.DarkGreen;
                            break;
                        case "scheduled":
                            row.DefaultCellStyle.BackColor = Color.LightBlue;
                            row.DefaultCellStyle.ForeColor = Color.DarkBlue;
                            break;
                        case "pending":
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                            row.DefaultCellStyle.ForeColor = Color.DarkOrange;
                            break;
                        default:
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                            break;
                    }
                }
            }
        }
        
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            LoadLessonsForDate(monthCalendar1.SelectionStart.Date);
        }        private void ButtonAddLesson_Click(object sender, EventArgs e)
        {
            // Navigate to Book Lesson page with the selected date
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;
            
            // Debug message - remove this after testing
            MessageBox.Show($"Selected date from calendar: {selectedDate:MMMM d, yyyy}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Get the parent Form1 and call the navigation method
            Form1 parentForm = this.FindForm() as Form1;
            if (parentForm != null)
            {
                parentForm.NavigateToBookLessonWithDate(selectedDate);
            }
            else
            {
                // Fallback message if parent form is not found
                MessageBox.Show($"Parent Form1 not found. Selected date: {selectedDate:MMMM d, yyyy}", 
                    "Debug Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }        private void LoadLessonsForDate(DateTime date)
        {
            DataTable dt = bookingDAO.GetBookingsForDisplay();
            // Filter by date and exclude cancelled bookings
            DataView dv = dt.DefaultView;
            dv.RowFilter = $"Convert(Date, 'System.DateTime') = '#{date:yyyy-MM-dd}#' AND Status <> 'Cancelled'";
            dataGridView1.DataSource = dv.ToTable();
            label3.Text = $"Lessons for {date:MMMM d, yyyy}";
            
            // Add context menu for cancellation if not already added
            if (dataGridView1.ContextMenuStrip == null)
            {
                SetupDataGridViewContextMenu();
            }
        }

        private void SetupDataGridViewContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            
            ToolStripMenuItem cancelMenuItem = new ToolStripMenuItem("Cancel Booking");
            cancelMenuItem.Click += CancelBooking_Click;
            contextMenu.Items.Add(cancelMenuItem);
            
            ToolStripMenuItem refreshMenuItem = new ToolStripMenuItem("Refresh");
            refreshMenuItem.Click += RefreshGrid_Click;
            contextMenu.Items.Add(refreshMenuItem);
            
            dataGridView1.ContextMenuStrip = contextMenu;
            
            // Also add double-click event for easier cancellation
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CancelSelectedBooking();
            }
        }

        private void CancelBooking_Click(object sender, EventArgs e)
        {
            CancelSelectedBooking();
        }

        private void RefreshGrid_Click(object sender, EventArgs e)
        {
            LoadLessonsForDate(monthCalendar1.SelectionStart.Date);
        }

        private void CancelSelectedBooking()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to cancel.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            
            // Get booking details
            if (selectedRow.Cells["BookingID"] == null || selectedRow.Cells["BookingID"].Value == null)
            {
                MessageBox.Show("Cannot identify the booking to cancel.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int bookingId = Convert.ToInt32(selectedRow.Cells["BookingID"].Value);
            string currentStatus = selectedRow.Cells["Status"]?.Value?.ToString() ?? "";
            string studentName = selectedRow.Cells["Student"]?.Value?.ToString() ?? "Unknown";
            string instructorName = selectedRow.Cells["Instructor"]?.Value?.ToString() ?? "Unknown";
            string dateStr = selectedRow.Cells["Date"]?.Value?.ToString() ?? "Unknown";
            string timeStr = selectedRow.Cells["Time"]?.Value?.ToString() ?? "Unknown";

            // Check if already cancelled
            if (currentStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("This booking is already cancelled.", "Already Cancelled", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm cancellation
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to cancel this booking?\n\n" +
                $"Student: {studentName}\n" +
                $"Instructor: {instructorName}\n" +
                $"Date: {dateStr}\n" +
                $"Time: {timeStr}\n" +
                $"Current Status: {currentStatus}",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Update booking status to cancelled
                    bool success = bookingDAO.UpdateBookingStatus(bookingId, "Cancelled");
                    
                    if (success)
                    {
                        MessageBox.Show($"Booking cancelled successfully!\n\nBooking ID: {bookingId}\nStudent: {studentName}", 
                            "Cancellation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Refresh the grid to show updated status
                        LoadLessonsForDate(monthCalendar1.SelectionStart.Date);
                        
                        // Update the selected row's status immediately for visual feedback
                        selectedRow.Cells["Status"].Value = "Cancelled";
                        selectedRow.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        MessageBox.Show("Failed to cancel the booking. Please try again.", 
                            "Cancellation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error cancelling booking: {ex.Message}", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
