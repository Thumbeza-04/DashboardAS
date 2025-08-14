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
using DashboardAS.Data;
using DashboardAS.Models;

namespace DashboardAS
{    public partial class BookLessonUserControl : UserControl
    {
        private LessonBookingDAO bookingDAO = new LessonBookingDAO();
        private StudentDAO studentDAO = new StudentDAO();
        private InstructorDAO instructorDAO = new InstructorDAO();
        private VehicleDAO vehicleDAO = new VehicleDAO();
        private PackageDAO packageDAO = new PackageDAO();
        private PaymentDAO paymentDAO = new PaymentDAO();

        public BookLessonUserControl()
        {
            InitializeComponent();
        }        private void BookLessonUserControl_Load(object sender, EventArgs e)
        {
            // Initialize book lesson content
            label1.Text = "Book a Lesson";
            label2.Text = "Fill in the details below to schedule a new lesson for a student";
            
            // Set minimum date to today to prevent selecting past dates
            dateTimePicker1.MinDate = DateTime.Today;
            
            // Populate combo boxes with sample data
            PopulateComboBoxes();
        }private void PopulateComboBoxes()
        {
            try
            {
                // Populate students combo box
                comboBoxStudent.Items.Clear();
                comboBoxStudent.DisplayMember = "FullName";
                comboBoxStudent.ValueMember = "StudentID";
                var students = studentDAO.GetAllStudents();
                foreach (var student in students)
                {
                    comboBoxStudent.Items.Add(student);
                }
                
                // Populate instructors combo box
                comboBoxInstructor.Items.Clear();
                comboBoxInstructor.DisplayMember = "FullName";
                comboBoxInstructor.ValueMember = "InstructorID";
                var instructors = instructorDAO.GetAllInstructors();
                foreach (var instructor in instructors)
                {
                    comboBoxInstructor.Items.Add(instructor);
                }                // Populate time slots combo box using TimeSlotDAO
                comboBoxTime.Items.Clear();
                comboBoxTime.DisplayMember = "TimeRange";
                comboBoxTime.ValueMember = "TimeSlotID";
                
                try 
                {
                    var timeSlotDAO = new DashboardAS.Data.TimeSlotDAO();
                    var timeSlots = timeSlotDAO.GetAllTimeSlots();
                    foreach (var timeSlot in timeSlots)
                    {
                        comboBoxTime.Items.Add(timeSlot);
                    }
                }
                catch (Exception ex)
                {
                    // Fallback to manual TimeSlot creation if database access fails
                    MessageBox.Show($"Could not load time slots from database: {ex.Message}. Using default time slots.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    var timeSlots = new List<TimeSlot>
                    {
                        new TimeSlot { TimeSlotID = 1, StartTime = new TimeSpan(8, 0, 0), EndTime = new TimeSpan(9, 0, 0) },
                        new TimeSlot { TimeSlotID = 2, StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(10, 0, 0) },
                        new TimeSlot { TimeSlotID = 3, StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(11, 0, 0) },
                        new TimeSlot { TimeSlotID = 4, StartTime = new TimeSpan(11, 0, 0), EndTime = new TimeSpan(12, 0, 0) },
                        new TimeSlot { TimeSlotID = 5, StartTime = new TimeSpan(12, 0, 0), EndTime = new TimeSpan(13, 0, 0) },
                        new TimeSlot { TimeSlotID = 6, StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(14, 0, 0) },
                        new TimeSlot { TimeSlotID = 7, StartTime = new TimeSpan(14, 0, 0), EndTime = new TimeSpan(15, 0, 0) },
                        new TimeSlot { TimeSlotID = 8, StartTime = new TimeSpan(15, 0, 0), EndTime = new TimeSpan(16, 0, 0) },
                        new TimeSlot { TimeSlotID = 9, StartTime = new TimeSpan(16, 0, 0), EndTime = new TimeSpan(17, 0, 0) }
                    };
                    
                    foreach (var timeSlot in timeSlots)
                    {
                        comboBoxTime.Items.Add(timeSlot);
                    }
                }            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        // Method to set the selected date from external source (like Calendar)
        public void SetSelectedDate(DateTime selectedDate)
        {
            // Ensure the selected date is not in the past
            if (selectedDate < DateTime.Today)
            {
                selectedDate = DateTime.Today;
            }
            dateTimePicker1.Value = selectedDate;
        }// Method to clear all input fields
        private void ClearInputs()
        {
            comboBoxStudent.SelectedIndex = -1;
            comboBoxInstructor.SelectedIndex = -1;
            comboBoxTime.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }        // Method to check if a student already has a lesson booked on a specific date
        private bool IsStudentBookedOnDate(int studentId, DateTime date)
        {
            try
            {
                // Use a more direct database query for better accuracy
                using (var conn = Data.DatabaseConnection.GetConnection())
                {
                    string query = @"
                        SELECT COUNT(*) 
                        FROM LessonBookingMJ 
                        WHERE StudentID = @StudentID 
                        AND CAST(Date AS DATE) = CAST(@Date AS DATE) 
                        AND Status IN ('Scheduled', 'Confirmed')";
                    
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    cmd.Parameters.AddWithValue("@Date", date.Date);
                    
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    
                    System.Diagnostics.Debug.WriteLine($"Direct DB query: Student {studentId} has {count} bookings on {date:yyyy-MM-dd}");
                    
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                // Fallback to original method if direct query fails
                System.Diagnostics.Debug.WriteLine($"Direct query failed, using fallback: {ex.Message}");
                
                var existingBookings = bookingDAO.GetAllBookings();
                
                // Debug: Show total bookings count
                System.Diagnostics.Debug.WriteLine($"Total bookings found: {existingBookings.Count}");
                
                // Debug: Show all bookings for this student
                var studentBookings = existingBookings.Where(b => b.StudentID.HasValue && b.StudentID.Value == studentId).ToList();
                System.Diagnostics.Debug.WriteLine($"Student {studentId} has {studentBookings.Count} existing bookings");
                
                foreach (var booking in studentBookings)
                {
                    System.Diagnostics.Debug.WriteLine($"Existing booking: Date={booking.Date:yyyy-MM-dd}, Status={booking.Status}");
                }
                
                // Check for conflicts
                var conflictingBookings = existingBookings.Where(b => b.StudentID.HasValue && 
                                                                     b.StudentID.Value == studentId && 
                                                                     b.Date.Date == date.Date && 
                                                                     (b.Status == "Scheduled" || b.Status == "Confirmed")).ToList();
                
                System.Diagnostics.Debug.WriteLine($"Conflicting bookings found: {conflictingBookings.Count} for date {date:yyyy-MM-dd}");
                
                return conflictingBookings.Any();
            }
        }        // Method to check if an instructor is busy at a specific time
        private bool IsInstructorBusyAtTime(int instructorId, DateTime date, int timeSlotId)
        {
            try
            {
                // Use a direct database query for better accuracy
                using (var conn = Data.DatabaseConnection.GetConnection())
                {
                    string query = @"
                        SELECT COUNT(*) 
                        FROM LessonBookingMJ 
                        WHERE InstructorID = @InstructorID 
                        AND CAST(Date AS DATE) = CAST(@Date AS DATE) 
                        AND TimeSlotID = @TimeSlotID
                        AND Status IN ('Scheduled', 'Confirmed')";
                    
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@InstructorID", instructorId);
                    cmd.Parameters.AddWithValue("@Date", date.Date);
                    cmd.Parameters.AddWithValue("@TimeSlotID", timeSlotId);
                    
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    
                    System.Diagnostics.Debug.WriteLine($"Direct DB query: Instructor {instructorId} has {count} bookings at time slot {timeSlotId} on {date:yyyy-MM-dd}");
                    
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                // Fallback to original method if direct query fails
                System.Diagnostics.Debug.WriteLine($"Direct instructor query failed, using fallback: {ex.Message}");
                
                var existingBookings = bookingDAO.GetAllBookings();
                return existingBookings.Any(b => b.InstructorID.HasValue && 
                                                b.InstructorID.Value == instructorId && 
                                                b.Date.Date == date.Date && 
                                                b.TimeSlotID.HasValue &&
                                                b.TimeSlotID.Value == timeSlotId &&
                                                (b.Status == "Scheduled" || b.Status == "Confirmed"));
            }
        }
        

        private void label6_Click(object sender, EventArgs e)
        {

        }        private void buttonBookLesson_Click(object sender, EventArgs e)
        {            
            try
            {
                // Basic field validation
                if (comboBoxStudent.SelectedItem == null || comboBoxInstructor.SelectedItem == null || comboBoxTime.SelectedItem == null)
                {
                    MessageBox.Show("Please select student, instructor, and time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                var student = comboBoxStudent.SelectedItem as Student;
                var instructor = comboBoxInstructor.SelectedItem as Instructor;
                var selectedTimeSlot = comboBoxTime.SelectedItem as TimeSlot;
                
                DateTime selectedDate = dateTimePicker1.Value.Date;
                
                // Validation 1: Check if the selected date is in the past
                if (selectedDate < DateTime.Today)
                {
                    MessageBox.Show("Cannot book lessons for past dates. Please select a current or future date.", 
                        "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }                // Validation 2: Check if student has paid for their package
                if (!string.IsNullOrEmpty(student.PackageName))
                {
                    try
                    {
                        Package studentPackage = packageDAO.GetPackageByName(student.PackageName);
                        if (studentPackage != null && studentPackage.Price > 0)
                        {
                            decimal totalPaid = paymentDAO.GetTotalPaymentsByStudent(student.StudentID);
                            if (totalPaid < studentPackage.Price)
                            {
                                decimal amountDue = studentPackage.Price - totalPaid;
                                DialogResult paymentResult = MessageBox.Show(
                                    $"Student {student.FullName} has not fully paid for their package.\n\n" +
                                    $"Package: {studentPackage.PackageName}\n" +
                                    $"Package Price: R{studentPackage.Price:F2}\n" +
                                    $"Amount Paid: R{totalPaid:F2}\n" +
                                    $"Amount Due: R{amountDue:F2}\n\n" +
                                    "Payment is required before booking lessons.\n\n" +
                                    $"Confirm payment for {student.FullName}?",
                                    "Payment Required",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information);

                                if (paymentResult == DialogResult.Yes)
                                {
                                    // Show payment dialog
                                    ShowPaymentDialog(student);
                                    
                                    // Re-check payment after dialog
                                    decimal newTotalPaid = paymentDAO.GetTotalPaymentsByStudent(student.StudentID);
                                    if (newTotalPaid < studentPackage.Price)
                                    {
                                        MessageBox.Show("Payment is still incomplete. Lesson booking cancelled.", 
                                            "Booking Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Lesson booking cancelled. Payment is required before booking lessons.", 
                                        "Booking Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                        }
                        else if (studentPackage == null)
                        {
                            MessageBox.Show($"Package '{student.PackageName}' not found in database. Please contact support to resolve this issue.", 
                                "Package Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else if (studentPackage.Price <= 0)
                        {
                            MessageBox.Show($"Package '{student.PackageName}' has invalid price data. Please contact support to resolve this issue.", 
                                "Package Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error checking payment status: {ex.Message}\n\nBooking cancelled for safety. Please try again or contact support.", 
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"Student {student.FullName} does not have a package assigned. Please assign a package before booking lessons.", 
                        "No Package", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validation 3: Check if student already has a lesson on the same day
                System.Diagnostics.Debug.WriteLine($"Checking if student {student.StudentID} is already booked on {selectedDate:yyyy-MM-dd}");
                bool studentAlreadyBooked = IsStudentBookedOnDate(student.StudentID, selectedDate);
                if (studentAlreadyBooked)
                {
                    MessageBox.Show($"Student {student.FullName} already has a lesson booked on {selectedDate:MMMM d, yyyy}. Students can only have one lesson per day.", 
                        "Booking Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Student {student.StudentID} is available on {selectedDate:yyyy-MM-dd}");
                }
                // Validation 4: Check if instructor is available at the selected time
                if (IsInstructorBusyAtTime(instructor.InstructorID, selectedDate, selectedTimeSlot.TimeSlotID))
                {
                    MessageBox.Show($"Instructor {instructor.FullName} is not available at {selectedTimeSlot.TimeRange} on {selectedDate:MMMM d, yyyy}. Please select a different time or instructor.", 
                        "Instructor Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // All validations passed, proceed with booking
                LessonBooking booking = new LessonBooking
                {
                    StudentID = student.StudentID,
                    InstructorID = instructor.InstructorID,
                    VehicleID = instructor.LicensePlateID, // Use instructor's license plate as VehicleID
                    PackageID = student.PackageName, // Use student's package name as PackageID
                    TimeSlotID = selectedTimeSlot.TimeSlotID,
                    Date = selectedDate,
                    Time = selectedTimeSlot.StartTime, // Use the start time from the time slot
                    Status = "Scheduled"
                };
                    int bookingId = bookingDAO.AddBooking(booking);
                if (bookingId > 0)
                {
                    System.Diagnostics.Debug.WriteLine($"Booking created successfully with ID: {bookingId} for Student {student.StudentID} on {selectedDate:yyyy-MM-dd}");
                    MessageBox.Show("Lesson booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Clear form inputs after successful booking
                    ClearInputs();
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Failed to create booking for Student {student.StudentID} on {selectedDate:yyyy-MM-dd}");
                    MessageBox.Show("Failed to book lesson.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error booking lesson: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPaymentDialog(Student student)
        {
            try
            {
                PaymentResult result = PaymentDialog.ShowPaymentDialog(this, student);
                
                if (result.Success)
                {
                    MessageBox.Show(
                        $"Payment processed successfully!\n\n" +
                        $"Student: {student.FullName}\n" +
                        $"Payment ID: {result.PaymentID}\n\n" +
                        "You can now proceed with booking the lesson.",
                        "Payment Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else if (!result.Cancelled && !string.IsNullOrEmpty(result.Error))
                {
                    MessageBox.Show($"Payment failed: {result.Error}", "Payment Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // If cancelled, no message needed as user intentionally cancelled
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening payment dialog: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DebugPackageData(string packageName)
        {
            try
            {
                using (var conn = Data.DatabaseConnection.GetConnection())
                {
                    string query = "SELECT PackageName, Code, NoOfLessons, Price FROM PackageMJ WHERE PackageName = @PackageName";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PackageName", packageName);
                    
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            System.Diagnostics.Debug.WriteLine($"=== Package Debug Info for '{packageName}' ===");
                            
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string fieldName = reader.GetName(i);
                                object value = reader.GetValue(i);
                                string valueType = value?.GetType().Name ?? "NULL";
                                System.Diagnostics.Debug.WriteLine($"{fieldName}: {value} (Type: {valueType})");
                            }
                            
                            System.Diagnostics.Debug.WriteLine("=== End Debug Info ===");
                        }
                        else
                        {
                            System.Diagnostics.Debug.WriteLine($"Package '{packageName}' not found in database");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Debug error: {ex.Message}");
            }
        }
    }
}
