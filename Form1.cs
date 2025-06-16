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
{    public partial class Form1 : System.Windows.Forms.Form
    {
        // Create instances of user controls
        private HomeUserControl homeControl;
        private BookLessonUserControl bookLessonControl;
        private StudentsUserControl studentsControl;
        private InstructorsUserControl instructorsControl;
        private CalendarUserControl calendarControl;
        private PaymentUserControl paymentControl;
        
        // Add a Panel to hold content
        private Panel contentPanel;
        
        // Focus color for selected button
        private Color focusColor = Color.FromArgb(0, 122, 204); // Bright blue
        
        // Navigation toggle state
        private bool navPanelVisible = true;
        
        public Form1()
        {
            InitializeComponent();
            
            // Add a resize event handler
            this.Resize += Form1_Resize;
            
            // Create content panel that will hold our user controls
            contentPanel = new Panel();
            contentPanel.Dock = DockStyle.None; 
            contentPanel.BackColor = Color.White;
            contentPanel.Location = new Point(207, 64); // Position after left nav and below top header
            contentPanel.Size = new Size(this.ClientSize.Width - 207, this.ClientSize.Height - 64);
            contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentPanel.Name = "contentPanel";
            this.Controls.Add(contentPanel);
            
            // Initialize user controls
            homeControl = new HomeUserControl();
            bookLessonControl = new BookLessonUserControl();
            studentsControl = new StudentsUserControl();
            instructorsControl = new InstructorsUserControl();
            calendarControl = new CalendarUserControl();
            paymentControl = new PaymentUserControl();
            
            // Add user controls to content panel, not panel3
            contentPanel.Controls.Add(homeControl);
            contentPanel.Controls.Add(bookLessonControl);
            contentPanel.Controls.Add(studentsControl);
            contentPanel.Controls.Add(instructorsControl);
            contentPanel.Controls.Add(calendarControl);
            contentPanel.Controls.Add(paymentControl);
            
            // Set dock style
            homeControl.Dock = DockStyle.Fill;
            bookLessonControl.Dock = DockStyle.Fill;
            studentsControl.Dock = DockStyle.Fill;
            instructorsControl.Dock = DockStyle.Fill;
            calendarControl.Dock = DockStyle.Fill;
            paymentControl.Dock = DockStyle.Fill;
            
            // Initially hide all controls
            homeControl.Visible = false;
            bookLessonControl.Visible = false;
            studentsControl.Visible = false;
            instructorsControl.Visible = false;
            calendarControl.Visible = false;
            paymentControl.Visible = false;
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Hide the default controls that are part of the form's design view
            // These are being replaced by our user controls
            if (label1 != null) label1.Visible = false;
            if (label2 != null) label2.Visible = false;
            if (label3 != null) label3.Visible = false;
            if (label4 != null) label4.Visible = false;
            if (label5 != null) label5.Visible = false;            if (label6 != null) label6.Visible = false;
            if (label7 != null) label7.Visible = false;
            if (label8 != null) label8.Visible = false;
            if (label9 != null) label9.Visible = false;
            if (dataGridView1 != null) dataGridView1.Visible = false;
            if (panel6 != null) panel6.Visible = false;
            if (panel7 != null) panel7.Visible = false;
            if (panel8 != null) panel8.Visible = false;
            
            // Make sure our content panel is on top
            contentPanel.BringToFront();
            
            // Show home screen by default
            ShowHomeScreen();

            pictureBox1.ContextMenuStrip = contextMenuStrip1;

        }
          private void ResetButtonColors()
        {
            button1.BackColor = Color.Black;  // Home
            button2.BackColor = Color.Black;  // Students
            button3.BackColor = Color.Black;  // Book a Lesson
            button4.BackColor = Color.Black;  // Instructors
            button5.BackColor = Color.Black;  // Calendar
            button6.BackColor = Color.Black;  // Payment
        }
        
        private void HideAllControls()
        {
            homeControl.Visible = false;
            bookLessonControl.Visible = false;
            studentsControl.Visible = false;
            instructorsControl.Visible = false;
            calendarControl.Visible = false;
            paymentControl.Visible = false;
        }
        private void ShowHomeScreen()
        {
            ResetButtonColors();
            HideAllControls();
            
            button1.BackColor = focusColor; // Highlight this button
            homeControl.Visible = true;
            
            // Page title is now managed by the user control
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ShowHomeScreen();
        }        private void button2_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            HideAllControls();
            
            button2.BackColor = focusColor; // Highlight this button
            studentsControl.Visible = true;
            
            // Page title is now managed by the user control
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            HideAllControls();
            
            button3.BackColor = focusColor; // Highlight this button
            bookLessonControl.Visible = true;
            
            // Page title is now managed by the user control
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            HideAllControls();
            
            button4.BackColor = focusColor; // Highlight this button
            instructorsControl.Visible = true;
            
            // Page title is now managed by the user control
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            HideAllControls();
            
            button5.BackColor = focusColor; // Highlight this button
            calendarControl.Visible = true;
            
            // Page title is now managed by the user control
        }        private void button6_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            HideAllControls();
            
            button6.BackColor = focusColor; // Highlight this button
            paymentControl.Visible = true;
            
            // Page title is now managed by the user control
        }        // Public method to navigate to Book Lesson page with a specific date
        public void NavigateToBookLessonWithDate(DateTime selectedDate)
        {
            ResetButtonColors();
            HideAllControls();
            
            button3.BackColor = focusColor; // Highlight the Book Lesson button
            bookLessonControl.Visible = true;
            
            // Set the selected date in the BookLessonUserControl
            bookLessonControl.SetSelectedDate(selectedDate);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // No action needed
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // No action needed
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // No action needed
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // No action needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // No action needed
        }        private void pictureBox1_Click(object sender, EventArgs e)
        {
            navPanelVisible = !navPanelVisible;
            
            // Toggle visibility of navigation buttons
            button1.Visible = navPanelVisible;
            button2.Visible = navPanelVisible;
            button3.Visible = navPanelVisible;
            button4.Visible = navPanelVisible;
            button5.Visible = navPanelVisible;
            button6.Visible = navPanelVisible;
            
            // Toggle visibility of navigation icons
            pictureBox2.Visible = navPanelVisible;
            pictureBox3.Visible = navPanelVisible;
            pictureBox4.Visible = navPanelVisible;
            pictureBox5.Visible = navPanelVisible;
            pictureBox6.Visible = navPanelVisible;
            pictureBox7.Visible = navPanelVisible;
            
            // Toggle visibility of panel5 (bottom empty space)
            panel5.Visible = navPanelVisible;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // No action needed
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Logout functionality
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form2 loginForm = new Form2();
                loginForm.Show();
                this.Close();            }
        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Update the content panel size when the form is resized
            if (contentPanel != null)
            {
                contentPanel.Size = new Size(this.ClientSize.Width - 207, this.ClientSize.Height - 64);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       
       
        

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(pictureBox11, new Point(0, pictureBox11.Height));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    Form4 loginForm = new Form4();  // Replace with your login form class name
                    loginForm.Show();
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            {
                {
                    string helpText =
                @"*** Driving School Booking System – Receptionist Guide ***

This form is used by the Receptionist to manage student bookings, instructors, payments, and lesson tracking.

--- SYSTEM FUNCTIONALITY ---

1. **Student Management**
   - Add new students with valid ID and contact information.
   - View or update existing student profiles.
   - Monitor student status (Active / Archived).

2. **Lesson Booking**
   - Book lessons by selecting the student, instructor, vehicle, timeslot, and package.
   - Each package includes a set number of lessons.
   - Ensure time slots do not overlap and instructors are available.

3. **Payment Processing**
   - Record payments for each booking.
   - Track amount paid, due, and payment method.

4. **Attendance**
   - Instructors can mark lesson attendance.
   - Receptionist can view or print attendance records if needed.

5. **Reviews**
   - Students can leave a review per booking.
   - View reviews to assess service quality.

6. **Archive Students**
   - The **Archive button** is used **when a student has completed all their lessons for a purchased package**.
   - Archiving helps to keep the system clean and focuses on active students only.
   - Archived students can be reactivated later if they purchase a new package.

7. **Logout and Exit**
   - Use the user icon menu to Logout or Exit the application safely.

For further support, contact your system administrator.
";
                    MessageBox.Show(helpText, "Help - Receptionist Guide", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}


