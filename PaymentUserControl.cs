using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DashboardAS.Data;
using DashboardAS.Models;

namespace DashboardAS
{
    public partial class PaymentUserControl : UserControl
    {
        private PaymentDAO paymentDAO;
        private StudentDAO studentDAO;
        private LessonBookingDAO lessonBookingDAO;
        private PackageDAO packageDAO; public PaymentUserControl()
        {
            InitializeComponent();

            // Only initialize DAOs at runtime, not at design time
            if (!this.DesignMode)
            {
                paymentDAO = new PaymentDAO();
                studentDAO = new StudentDAO();
                lessonBookingDAO = new LessonBookingDAO();
                packageDAO = new PackageDAO();
            }
        }
        private void PaymentUserControl_Load(object sender, EventArgs e)
        {
            // Initialize title and subtitle
            label1.Text = "Payments";
            label2.Text = "Track revenue, outstanding amounts and payment history";

            // Only load data at runtime, not at design time
            if (!this.DesignMode && paymentDAO != null)
            {
                // Set up search textbox placeholder
                if (textBoxSearch != null)
                {
                    textBoxSearch.ForeColor = Color.Gray;
                    textBoxSearch.Text = "Search payments (student name, amount, method...)";
                    textBoxSearch.Enter += TextBoxSearch_Enter;
                    textBoxSearch.Leave += TextBoxSearch_Leave;
                }

                // Load dashboard statistics
                LoadPaymentStatistics();

                // Populate the payments grid
                PopulatePaymentsTable();
            }
        }
        private void LoadPaymentStatistics()
        {
            try
            {
                decimal totalRevenue = paymentDAO.GetTotalRevenue();
                decimal outstandingAmount = paymentDAO.GetOutstandingAmount();
                int paymentsToday = paymentDAO.GetPaymentsToday();

                // Update dashboard cards with real data
                label3.Text = $"R{totalRevenue:F2}";  // Total Revenue
                label4.Text = $"R{outstandingAmount:F2}";  // Outstanding Amount
                label5.Text = paymentsToday.ToString();  // Payments Today Count
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
                ApplyDataGridViewFormatting();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payment data: {ex.Message}", "Database Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Load with empty data table as fallback
                dataGridView1.DataSource = new DataTable();
            }
        }

        private void ApplyDataGridViewFormatting()
        {
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
        // COMMENTED OUT: Make Payment button functionality removed
        // The payment functionality is now handled through the registration and lesson booking forms
        // using the reusable PaymentDialog class
        /*
        private void button2_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode && paymentDAO != null)
            {
                ShowMakePaymentDialog();
            }
        }
        */
        // COMMENTED OUT: ShowMakePaymentDialog method - replaced with reusable PaymentDialog
        /*
        private void ShowMakePaymentDialog()
        {
            try
            {
                // First check if there are any packages in the system
                var allPackages = packageDAO.GetAllPackages();
                if (allPackages.Count == 0)
                {
                    MessageBox.Show("No packages are configured in the system.\n" +
                                   "Please add packages before processing payments.",
                                   "No Packages Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create the payment dialog form
                using (Form paymentDialog = new Form())
                {
                    paymentDialog.Text = "Make Payment";
                    paymentDialog.Size = new Size(480, 350);
                    paymentDialog.StartPosition = FormStartPosition.CenterParent;
                    paymentDialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                    paymentDialog.MaximizeBox = false;
                    paymentDialog.MinimizeBox = false;

                    // Create controls
                    Label lblStudent = new Label { Text = "Student:", Location = new Point(20, 20), Size = new Size(80, 23) };
                    ComboBox cmbStudent = new ComboBox
                    {
                        Location = new Point(110, 20),
                        Size = new Size(300, 23),
                        DropDownStyle = ComboBoxStyle.DropDownList
                    }; Label lblAmount = new Label { Text = "Amount Paid:", Location = new Point(20, 60), Size = new Size(80, 23) };
                    NumericUpDown nudAmountPaid = new NumericUpDown
                    {
                        Location = new Point(110, 60),
                        Size = new Size(120, 23),
                        DecimalPlaces = 2,
                        Maximum = 999999,
                        Minimum = 0
                    };
                    // Add tooltip to inform about payment limits
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(nudAmountPaid, "Enter payment amount. Must be greater than zero and cannot exceed the remaining balance owed."); Label lblAmountDue = new Label { Text = "Amount Due:", Location = new Point(20, 100), Size = new Size(80, 23) };
                    NumericUpDown nudAmountDue = new NumericUpDown
                    {
                        Location = new Point(110, 100),
                        Size = new Size(120, 23),
                        DecimalPlaces = 2,
                        Maximum = 999999,
                        Minimum = 0,
                        ReadOnly = true, // Make it read-only since it's calculated automatically
                        BackColor = Color.LightGray
                    };

                    // Add labels to show package info
                    Label lblPackageInfo = new Label
                    {
                        Text = "Package Info:",
                        Location = new Point(250, 60),
                        Size = new Size(80, 23)
                    };
                    Label lblPackageDetails = new Label
                    {
                        Text = "Select a student",
                        Location = new Point(250, 80),
                        Size = new Size(180, 40),
                        ForeColor = Color.Blue
                    };

                    Label lblMethod = new Label { Text = "Payment Method:", Location = new Point(20, 140), Size = new Size(100, 23) };
                    ComboBox cmbPaymentMethod = new ComboBox
                    {
                        Location = new Point(130, 140),
                        Size = new Size(150, 23),
                        DropDownStyle = ComboBoxStyle.DropDownList
                    };

                    Label lblDate = new Label { Text = "Payment Date:", Location = new Point(20, 180), Size = new Size(100, 23) };
                    DateTimePicker dtpPaymentDate = new DateTimePicker
                    {
                        Location = new Point(130, 180),
                        Size = new Size(200, 23),
                        Value = DateTime.Now
                    }; Button btnSave = new Button
                    {
                        Text = "Save Payment",
                        Location = new Point(120, 260),
                        Size = new Size(100, 35),
                        BackColor = Color.Green,
                        ForeColor = Color.White,
                        DialogResult = DialogResult.OK
                    };

                    Button btnCancel = new Button
                    {
                        Text = "Cancel",
                        Location = new Point(230, 260),
                        Size = new Size(100, 35),
                        BackColor = Color.Gray,
                        ForeColor = Color.White,
                        DialogResult = DialogResult.Cancel
                    };                    // Populate payment methods
                    cmbPaymentMethod.Items.AddRange(new string[] { "Cash", "Card", "EFT", "Bank Transfer" });
                    cmbPaymentMethod.SelectedIndex = 0;// Load students first - include all students for now, filter during validation
                    List<Student> allStudents = studentDAO.GetAllStudents();

                    if (allStudents.Count == 0)
                    {
                        MessageBox.Show("No students found in the system.",
                                       "No Students", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    cmbStudent.DisplayMember = "FullName";
                    cmbStudent.ValueMember = "StudentID";
                    cmbStudent.DataSource = allStudents;// Add event handler to automatically calculate remaining amount due
                    nudAmountPaid.ValueChanged += (s, args) =>
                    {
                        if (cmbStudent.SelectedValue != null && cmbStudent.SelectedValue.ToString() != "System.Data.DataRowView" && nudAmountPaid.Enabled)
                        {
                            int studentId = (int)cmbStudent.SelectedValue;
                            Student selectedStudent = allStudents.FirstOrDefault(st => st.StudentID == studentId);
                            if (selectedStudent != null &&
                                !string.IsNullOrEmpty(selectedStudent.PackageName) &&
                                !selectedStudent.PackageName.Equals("NULL", StringComparison.OrdinalIgnoreCase))
                            {
                                try
                                {
                                    Package studentPackage = packageDAO.GetPackageByName(selectedStudent.PackageName);
                                    if (studentPackage != null)
                                    {
                                        decimal totalPaid = paymentDAO.GetTotalPaymentsByStudent(studentId);
                                        decimal newAmountDue = Math.Max(0, studentPackage.Price - totalPaid - nudAmountPaid.Value);
                                        nudAmountDue.Value = newAmountDue;

                                        // Check if this payment would complete the package
                                        bool willCompletePayment = (totalPaid + nudAmountPaid.Value) >= studentPackage.Price;

                                        // Update package details with current payment amount
                                        if (willCompletePayment && nudAmountPaid.Value > 0)
                                        {
                                            lblPackageDetails.Text = $"Package: {studentPackage.PackageName}\n" +
                                                                   $"Total Price: R{studentPackage.Price:F2}\n" +
                                                                   $"Already Paid: R{totalPaid:F2}\n" +
                                                                   $"Current Payment: R{nudAmountPaid.Value:F2}\n" +
                                                                   $"PAYMENT WILL BE COMPLETE ✓";
                                            lblPackageDetails.ForeColor = Color.Green;
                                        }
                                        else
                                        {
                                            lblPackageDetails.Text = $"Package: {studentPackage.PackageName}\n" +
                                                                   $"Total Price: R{studentPackage.Price:F2}\n" +
                                                                   $"Already Paid: R{totalPaid:F2}\n" +
                                                                   $"Current Payment: R{nudAmountPaid.Value:F2}\n" +
                                                                   $"Remaining: R{newAmountDue:F2}";
                                            lblPackageDetails.ForeColor = Color.Blue;
                                        }
                                    }
                                }
                                catch
                                {
                                    // If calculation fails, keep current value
                                }
                            }
                        }
                    };// Load bookings when student changes
                    cmbStudent.SelectedIndexChanged += (s, args) =>
                    {
                        if (cmbStudent.SelectedValue != null && cmbStudent.SelectedValue.ToString() != "System.Data.DataRowView")
                        {
                            int studentId = (int)cmbStudent.SelectedValue;                            // Get student's package for pricing
                            Student selectedStudent = allStudents.FirstOrDefault(st => st.StudentID == studentId); if (selectedStudent != null &&
                                !string.IsNullOrEmpty(selectedStudent.PackageName) &&
                                !selectedStudent.PackageName.Equals("NULL", StringComparison.OrdinalIgnoreCase))
                            {
                                try
                                {
                                    Package studentPackage = packageDAO.GetPackageByName(selectedStudent.PackageName);
                                    if (studentPackage != null)
                                    {
                                        // Calculate amount due based on package price
                                        decimal totalPaid = paymentDAO.GetTotalPaymentsByStudent(studentId);
                                        decimal amountDue = Math.Max(0, studentPackage.Price - totalPaid);
                                        // Check if student has already paid in full
                                        bool isFullyPaid = totalPaid >= studentPackage.Price;
                                        bool hasAmountDue = amountDue > 0;

                                        // Update the amount due field
                                        nudAmountDue.Value = amountDue;
                                        // Update package info display with payment status
                                        if (isFullyPaid || !hasAmountDue)
                                        {
                                            lblPackageDetails.Text = $"Package: {studentPackage.PackageName}\n" +
                                                                   $"Total Price: R{studentPackage.Price:F2}\n" +
                                                                   $"Already Paid: R{totalPaid:F2}\n" +
                                                                   $"PAYMENT COMPLETE ✓";
                                            lblPackageDetails.ForeColor = Color.Green;

                                            // Disable payment input fields
                                            nudAmountPaid.Enabled = false;
                                            nudAmountPaid.Value = 0;
                                            nudAmountPaid.Maximum = 0;
                                            btnSave.Enabled = false;
                                            btnSave.Text = "Payment Complete";
                                            btnSave.BackColor = Color.Gray;
                                        }
                                        else
                                        {
                                            string packageInfo = $"Package: {studentPackage.PackageName}\n" +
                                                               $"Total Price: R{studentPackage.Price:F2}\n" +
                                                               $"Already Paid: R{totalPaid:F2}\n" +
                                                               $"Amount Due: R{amountDue:F2}";

                                            // Check if data was automatically corrected
                                            if (studentPackage.Code.Contains("[DATA FIXED]"))
                                            {
                                                packageInfo += "\n⚠️ Note: Package data was automatically corrected";
                                                lblPackageDetails.ForeColor = Color.Orange;
                                            }
                                            else
                                            {
                                                lblPackageDetails.ForeColor = Color.Blue;
                                            }

                                            lblPackageDetails.Text = packageInfo;

                                            // Enable payment input fields and set maximum to amount owed
                                            nudAmountPaid.Enabled = true;
                                            nudAmountPaid.Maximum = amountDue;
                                            nudAmountPaid.Minimum = 0.01m; // Minimum payment of 1 cent
                                            btnSave.Enabled = true;
                                            btnSave.Text = "Save Payment";
                                            btnSave.BackColor = Color.Green;
                                        }
                                        // Reset amount paid to 0 when student changes
                                        nudAmountPaid.Value = 0;
                                    }
                                    else
                                    {
                                        // Package not found in database
                                        nudAmountDue.Value = 0;
                                        lblPackageDetails.Text = $"Package: {selectedStudent.PackageName}\n" +
                                                               $"Status: Not found in database\n" +
                                                               $"Please contact support to add this package.";
                                        lblPackageDetails.ForeColor = Color.Orange;

                                        // Allow manual payment entry for missing packages
                                        nudAmountPaid.Enabled = true;
                                        nudAmountPaid.Maximum = 999999; // Allow manual entry
                                        nudAmountPaid.Minimum = 0.01m;
                                        btnSave.Enabled = true;
                                        btnSave.Text = "Save Payment";
                                        btnSave.BackColor = Color.Orange;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    // Show specific error details for debugging
                                    nudAmountDue.Value = 0;
                                    lblPackageDetails.Text = $"Error loading package '{selectedStudent.PackageName}':\n{ex.Message}";
                                    lblPackageDetails.ForeColor = Color.Red;

                                    // Allow payment with manual entry
                                    nudAmountPaid.Enabled = true;
                                    nudAmountPaid.Maximum = 999999;
                                    nudAmountPaid.Minimum = 0.01m;
                                    btnSave.Enabled = true;
                                    btnSave.Text = "Save Payment";
                                    btnSave.BackColor = Color.Orange;

                                    // Log detailed error for debugging
                                    System.Diagnostics.Debug.WriteLine($"Detailed error for {selectedStudent.FullName}: {ex}");
                                }
                            }
                            else
                            {
                                // No package assigned to student or package name is empty
                                nudAmountDue.Value = 0;
                                if (selectedStudent == null)
                                {
                                    lblPackageDetails.Text = "Student not found";
                                }
                                else if (string.IsNullOrEmpty(selectedStudent.PackageName))
                                {
                                    lblPackageDetails.Text = "No package assigned to this student.\n" +
                                                           "Please assign a package before making payments.";
                                }
                                else
                                {
                                    lblPackageDetails.Text = $"Package '{selectedStudent.PackageName}' processing error";
                                }
                                lblPackageDetails.ForeColor = Color.Red;
                                nudAmountPaid.Enabled = false;
                                nudAmountPaid.Maximum = 0;
                                nudAmountPaid.Minimum = 0;
                                btnSave.Enabled = false;
                                btnSave.Text = "No Package";
                                btnSave.BackColor = Color.Gray;

                            }
                        }
                    };

                    // Trigger the initial load of bookings
                    if (cmbStudent.Items.Count > 0)
                    {
                        cmbStudent.SelectedIndex = 0;
                    }                    // Add controls to form
                    paymentDialog.Controls.AddRange(new Control[]
                    {                        lblStudent, cmbStudent,
                        lblAmount, nudAmountPaid, lblAmountDue, nudAmountDue,
                        lblPackageInfo, lblPackageDetails,
                        lblMethod, cmbPaymentMethod, lblDate, dtpPaymentDate,
                        btnSave, btnCancel
                    });

                    // Handle save button click
                    btnSave.Click += (s, args) =>
                    {
                        if (ValidatePaymentForm(cmbStudent, nudAmountPaid, nudAmountDue))
                        {
                            try
                            {
                                Payment newPayment = new Payment
                                {
                                    StudentID = (int)cmbStudent.SelectedValue,
                                    PaymentDate = dtpPaymentDate.Value,
                                    AmountPaid = nudAmountPaid.Value,
                                    AmountDue = nudAmountDue.Value,
                                    PaymentMethod = cmbPaymentMethod.SelectedItem.ToString()
                                };

                                int paymentId = paymentDAO.AddPayment(newPayment);

                                MessageBox.Show($"Payment saved successfully! Payment ID: {paymentId}",
                                               "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refresh the payments grid and statistics
                                PopulatePaymentsTable();
                                LoadPaymentStatistics();

                                paymentDialog.DialogResult = DialogResult.OK;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error saving payment: {ex.Message}",
                                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    };

                    // Show the dialog
                    paymentDialog.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening payment dialog: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */
        // COMMENTED OUT: ValidatePaymentForm method - part of removed make payment functionality
        /*
        private bool ValidatePaymentForm(ComboBox cmbStudent, NumericUpDown nudAmountPaid, NumericUpDown nudAmountDue)
        {
            if (cmbStudent.SelectedValue == null)
            {
                MessageBox.Show("Please select a student.", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nudAmountPaid.Value == 0)
            {
                MessageBox.Show("Please enter a payment amount greater than zero.",
                               "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if payment amount is reasonable
            if (nudAmountPaid.Value < 0)
            {
                MessageBox.Show("Amount paid cannot be negative.",
                               "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if student has an amount due and validate payment doesn't exceed it
            int studentId = (int)cmbStudent.SelectedValue;
            try
            {
                var students = studentDAO.GetAllStudents();
                Student selectedStudent = students.FirstOrDefault(st => st.StudentID == studentId);
                if (selectedStudent != null &&
                    !string.IsNullOrEmpty(selectedStudent.PackageName) &&
                    !selectedStudent.PackageName.Equals("NULL", StringComparison.OrdinalIgnoreCase))
                {
                    Package studentPackage = packageDAO.GetPackageByName(selectedStudent.PackageName);
                    if (studentPackage != null)
                    {
                        decimal totalPaid = paymentDAO.GetTotalPaymentsByStudent(studentId);
                        decimal amountOwed = Math.Max(0, studentPackage.Price - totalPaid);
                        // Check if there's actually an amount due (use a small threshold for decimal precision)
                        const decimal PAYMENT_THRESHOLD = 0.01m; // 1 cent threshold
                        if (amountOwed < PAYMENT_THRESHOLD)
                        {
                            MessageBox.Show(
                                $"This student has no outstanding balance.\n\n" +
                                $"Package: {studentPackage.PackageName}\n" +
                                $"Package Price: R{studentPackage.Price:F2}\n" +
                                $"Total Paid: R{totalPaid:F2}\n" +
                                $"Amount Due: R{amountOwed:F2}\n\n" +
                                "No payment is required at this time.",
                                "No Amount Due",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


                            return false;
                        }

                        // Check if payment amount exceeds what is owed (with tolerance)
                        if (nudAmountPaid.Value > (amountOwed + PAYMENT_THRESHOLD))
                        {
                            MessageBox.Show(
                                $"Payment amount cannot exceed the amount owed.\n\n" +
                                $"Package: {studentPackage.PackageName}\n" +
                                $"Package Price: R{studentPackage.Price:F2}\n" +
                                $"Already Paid: R{totalPaid:F2}\n" +
                                $"Amount Owed: R{amountOwed:F2}\n" +
                                $"Attempted Payment: R{nudAmountPaid.Value:F2}\n\n" +
                                $"Please enter an amount of R{amountOwed:F2} or less.",
                                "Payment Amount Too High",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);


                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Package information not found for this student.",
                                       "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("This student does not have a package assigned.",
                                   "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch
            {
                // If validation fails, block the payment for safety
                MessageBox.Show("Could not validate payment. Please try again or contact support.",
                               "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        */

        // COMMENTED OUT: DebugStudentPackageInfo method - part of removed make payment functionality
        /*
        // Debug method to help identify package issues
        private void DebugStudentPackageInfo(Student student)
        {
            try
            {
                string debugInfo = $"Student Debug Info:\n";
                debugInfo += $"StudentID: {student.StudentID}\n";
                debugInfo += $"Name: {student.Name} {student.Surname}\n";
                debugInfo += $"PackageName: '{student.PackageName}'\n";
                debugInfo += $"PackageName IsNullOrEmpty: {string.IsNullOrEmpty(student.PackageName)}\n";

                if (!string.IsNullOrEmpty(student.PackageName))
                {
                    Package package = packageDAO.GetPackageByName(student.PackageName);
                    debugInfo += $"Package Found: {package != null}\n";
                    if (package != null)
                    {
                        debugInfo += $"Package Price: R{package.Price:F2}\n";
                        decimal totalPaid = paymentDAO.GetTotalPaymentsByStudent(student.StudentID);
                        debugInfo += $"Total Paid: R{totalPaid:F2}\n";
                        decimal amountDue = Math.Max(0, package.Price - totalPaid);
                        debugInfo += $"Amount Due: R{amountDue:F2}\n";
                    }
                }

                MessageBox.Show(debugInfo, "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Debug Error: {ex.Message}", "Debug Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        private void buttonGenerateReceipt_Click(object sender, EventArgs e)
        {
            // Check if a payment row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payment to generate a receipt.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the selected payment's ID
                int paymentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PaymentID"].Value);

                // Get the payment details from the database
                Payment selectedPayment = paymentDAO.GetPaymentById(paymentId);

                if (selectedPayment != null)
                {
                    // Show receipt preview dialog
                    ShowReceiptPreview(selectedPayment);
                }
                else
                {
                    MessageBox.Show("Could not load payment data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowReceiptPreview(Payment payment)
        {
            // Create a form to show the receipt preview
            Form receiptForm = new Form();
            receiptForm.Text = "Receipt Preview";
            receiptForm.Size = new Size(600, 700);
            receiptForm.StartPosition = FormStartPosition.CenterParent;
            receiptForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            receiptForm.MaximizeBox = false;
            receiptForm.MinimizeBox = false;

            // Create a panel for the receipt content
            Panel receiptPanel = new Panel();
            receiptPanel.Size = new Size(560, 550);
            receiptPanel.Location = new Point(10, 10);
            receiptPanel.BackColor = Color.White;
            receiptPanel.BorderStyle = BorderStyle.FixedSingle;

            // Create receipt content
            CreateReceiptContent(receiptPanel, payment);

            // Create buttons for actions
            Button printButton = new Button();
            printButton.Text = "Print Receipt";
            printButton.Size = new Size(120, 35);
            printButton.Location = new Point(150, 580);
            printButton.BackColor = Color.Green;
            printButton.ForeColor = Color.White;
            printButton.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            printButton.Click += (s, e) => PrintReceipt(receiptPanel, payment);

            Button saveButton = new Button();
            saveButton.Text = "Save as PDF";
            saveButton.Size = new Size(120, 35);
            saveButton.Location = new Point(280, 580);
            saveButton.BackColor = Color.Blue;
            saveButton.ForeColor = Color.White;
            saveButton.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            saveButton.Click += (s, e) => SaveReceiptAsPDF(receiptPanel, payment);

            Button closeButton = new Button();
            closeButton.Text = "Close";
            closeButton.Size = new Size(80, 35);
            closeButton.Location = new Point(410, 580);
            closeButton.BackColor = Color.Gray;
            closeButton.ForeColor = Color.White;
            closeButton.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            closeButton.Click += (s, e) => receiptForm.Close();

            // Add controls to form
            receiptForm.Controls.Add(receiptPanel);
            receiptForm.Controls.Add(printButton);
            receiptForm.Controls.Add(saveButton);
            receiptForm.Controls.Add(closeButton);

            // Show the form
            receiptForm.ShowDialog();
        }

        private void CreateReceiptContent(Panel panel, Payment payment)
        {
            panel.Controls.Clear();            // Get student information
            Student student = null;
            if (payment.StudentID.HasValue)
            {
                student = studentDAO.GetStudentById(payment.StudentID.Value);
            }
            string studentName = student != null ? $"{student.Name} {student.Surname}" : "Unknown Student";            // Header
            Label headerLabel = new Label();
            headerLabel.Text = "TLG DRIVING SCHOOL RECEIPT";
            headerLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            headerLabel.ForeColor = Color.DarkBlue;
            headerLabel.Size = new Size(400, 30);
            headerLabel.Location = new Point(80, 20);
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(headerLabel);

            // School info
            Label schoolInfo = new Label();
            schoolInfo.Text = "TLG Driving School\nPhone: (011) 123-4567\nEmail: info@tlgdriving.co.za";
            schoolInfo.Font = new Font("Arial", 10);
            schoolInfo.Size = new Size(300, 60);
            schoolInfo.Location = new Point(130, 60);
            schoolInfo.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(schoolInfo);

            // Separator line
            Panel line1 = new Panel();
            line1.BackColor = Color.Black;
            line1.Size = new Size(500, 2);
            line1.Location = new Point(30, 140);
            panel.Controls.Add(line1);

            // Receipt details
            int yPos = 160;

            // Receipt number and date
            Label receiptNoLabel = new Label();
            receiptNoLabel.Text = $"Receipt No: R{payment.PaymentID:D6}";
            receiptNoLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            receiptNoLabel.Size = new Size(200, 25);
            receiptNoLabel.Location = new Point(50, yPos);
            panel.Controls.Add(receiptNoLabel);

            Label dateLabel = new Label();
            dateLabel.Text = $"Date: {payment.PaymentDate:dddd, MMMM dd, yyyy}";
            dateLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            dateLabel.Size = new Size(250, 25);
            dateLabel.Location = new Point(280, yPos);
            panel.Controls.Add(dateLabel);

            yPos += 35;

            // Time
            Label timeLabel = new Label();
            timeLabel.Text = $"Time: {payment.PaymentDate:hh:mm tt}";
            timeLabel.Font = new Font("Arial", 10);
            timeLabel.Size = new Size(200, 20);
            timeLabel.Location = new Point(280, yPos);
            panel.Controls.Add(timeLabel);

            yPos += 40;

            // Student information
            Label studentLabel = new Label();
            studentLabel.Text = "STUDENT INFORMATION";
            studentLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            studentLabel.Size = new Size(200, 25);
            studentLabel.Location = new Point(50, yPos);
            panel.Controls.Add(studentLabel);

            yPos += 30;

            Label studentNameLabel = new Label();
            studentNameLabel.Text = $"Name: {studentName}";
            studentNameLabel.Font = new Font("Arial", 11);
            studentNameLabel.Size = new Size(400, 25);
            studentNameLabel.Location = new Point(50, yPos);
            panel.Controls.Add(studentNameLabel);

            yPos += 25; Label studentIdLabel = new Label();
            studentIdLabel.Text = $"Student ID: {payment.StudentID}";
            studentIdLabel.Font = new Font("Arial", 11);
            studentIdLabel.Size = new Size(400, 25);
            studentIdLabel.Location = new Point(50, yPos);
            panel.Controls.Add(studentIdLabel);

            yPos += 25;

            // Add student contact information
            if (student != null)
            {
                Label emailLabel = new Label();
                emailLabel.Text = $"Email: {student.Email}";
                emailLabel.Font = new Font("Arial", 11);
                emailLabel.Size = new Size(400, 25);
                emailLabel.Location = new Point(50, yPos);
                panel.Controls.Add(emailLabel);

                yPos += 25;

                Label phoneLabel = new Label();
                phoneLabel.Text = $"Phone: {student.PhoneNumber}";
                phoneLabel.Font = new Font("Arial", 11);
                phoneLabel.Size = new Size(400, 25);
                phoneLabel.Location = new Point(50, yPos);
                panel.Controls.Add(phoneLabel);

                yPos += 25;

                Label addressLabel = new Label();
                addressLabel.Text = $"Address: {student.FullAddress}";
                addressLabel.Font = new Font("Arial", 11);
                addressLabel.Size = new Size(400, 25);
                addressLabel.Location = new Point(50, yPos);
                panel.Controls.Add(addressLabel);

                yPos += 35;
            }
            else
            {
                yPos += 35;
            }

            // Package information
            Label packageLabel = new Label();
            packageLabel.Text = "PACKAGE INFORMATION";
            packageLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            packageLabel.Size = new Size(200, 25);
            packageLabel.Location = new Point(50, yPos);
            panel.Controls.Add(packageLabel);

            yPos += 30;

            // Get package details
            string packageDetails = "Package information not available";
            if (student != null && !string.IsNullOrEmpty(student.PackageName))
            {
                try
                {
                    Package packageInfo = packageDAO.GetPackageByName(student.PackageName);
                    if (packageInfo != null)
                    {
                        packageDetails = $"Package: {packageInfo.PackageName}\n" +
                                       $"Number of Lessons: {packageInfo.NoOfLessons}\n" +
                                       $"Package Price: R{packageInfo.Price:F2}";
                    }
                    else
                    {
                        packageDetails = $"Package: {student.PackageName}\nDetails: Not available";
                    }
                }
                catch
                {
                    packageDetails = $"Package: {student.PackageName}\nDetails: Not available";
                }
            }

            Label packageDetailsLabel = new Label();
            packageDetailsLabel.Text = packageDetails;
            packageDetailsLabel.Font = new Font("Arial", 11);
            packageDetailsLabel.Size = new Size(400, 60);
            packageDetailsLabel.Location = new Point(50, yPos);
            panel.Controls.Add(packageDetailsLabel);

            yPos += 70;

            // Payment information
            Label paymentLabel = new Label();
            paymentLabel.Text = "PAYMENT DETAILS";
            paymentLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            paymentLabel.Size = new Size(200, 25);
            paymentLabel.Location = new Point(50, yPos);
            panel.Controls.Add(paymentLabel);

            yPos += 30;            // Payment method
            Label methodLabel = new Label();
            methodLabel.Text = $"Payment Method: {payment.PaymentMethod}";
            methodLabel.Font = new Font("Arial", 11);
            methodLabel.Size = new Size(400, 25);
            methodLabel.Location = new Point(50, yPos);
            panel.Controls.Add(methodLabel);

            yPos += 25;

            // Payment breakdown
            Label amountPaidLabel = new Label();
            amountPaidLabel.Text = $"Amount Paid: R{payment.AmountPaid:F2}";
            amountPaidLabel.Font = new Font("Arial", 11);
            amountPaidLabel.Size = new Size(400, 25);
            amountPaidLabel.Location = new Point(50, yPos);
            panel.Controls.Add(amountPaidLabel);

            yPos += 25;

            Label amountDueLabel = new Label();
            amountDueLabel.Text = $"Outstanding Amount: R{payment.AmountDue:F2}";
            amountDueLabel.Font = new Font("Arial", 11);
            amountDueLabel.ForeColor = payment.AmountDue > 0 ? Color.Red : Color.Green;
            amountDueLabel.Size = new Size(400, 25);
            amountDueLabel.Location = new Point(50, yPos);
            panel.Controls.Add(amountDueLabel);

            yPos += 25;

            Label totalAmountLabel = new Label();
            totalAmountLabel.Text = $"Total Package Amount: R{payment.TotalAmount:F2}";
            totalAmountLabel.Font = new Font("Arial", 11);
            totalAmountLabel.Size = new Size(400, 25);
            totalAmountLabel.Location = new Point(50, yPos);
            panel.Controls.Add(totalAmountLabel);

            yPos += 25;

            Label paymentStatusLabel = new Label();
            paymentStatusLabel.Text = $"Payment Status: {payment.PaymentStatus}";
            paymentStatusLabel.Font = new Font("Arial", 11, FontStyle.Bold);
            paymentStatusLabel.ForeColor = payment.AmountDue > 0 ? Color.Red : Color.Green;
            paymentStatusLabel.Size = new Size(400, 25);
            paymentStatusLabel.Location = new Point(50, yPos);
            panel.Controls.Add(paymentStatusLabel);

            yPos += 35;            // Separator line
            Panel line2 = new Panel();
            line2.BackColor = Color.Black;
            line2.Size = new Size(500, 2);
            line2.Location = new Point(30, yPos);
            panel.Controls.Add(line2);

            yPos += 20;

            // Transaction summary
            Label summaryLabel = new Label();
            summaryLabel.Text = "TRANSACTION SUMMARY";
            summaryLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            summaryLabel.Size = new Size(200, 25);
            summaryLabel.Location = new Point(50, yPos);
            panel.Controls.Add(summaryLabel);

            yPos += 30;

            Label thisPaymentLabel = new Label();
            thisPaymentLabel.Text = $"This Payment: R{payment.AmountPaid:F2}";
            thisPaymentLabel.Font = new Font("Arial", 14, FontStyle.Bold);
            thisPaymentLabel.ForeColor = Color.Green;
            thisPaymentLabel.Size = new Size(400, 30);
            thisPaymentLabel.Location = new Point(50, yPos);
            panel.Controls.Add(thisPaymentLabel);

            yPos += 35;

            if (payment.AmountDue > 0)
            {
                Label nextPaymentLabel = new Label();
                nextPaymentLabel.Text = $"Next Payment Due: R{payment.AmountDue:F2}";
                nextPaymentLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                nextPaymentLabel.ForeColor = Color.OrangeRed;
                nextPaymentLabel.Size = new Size(400, 25);
                nextPaymentLabel.Location = new Point(50, yPos);
                panel.Controls.Add(nextPaymentLabel);

                yPos += 35;
            }
            else
            {
                Label paidInFullLabel = new Label();
                paidInFullLabel.Text = "✓ PAID IN FULL";
                paidInFullLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                paidInFullLabel.ForeColor = Color.Green;
                paidInFullLabel.Size = new Size(400, 25);
                paidInFullLabel.Location = new Point(50, yPos);
                panel.Controls.Add(paidInFullLabel);

                yPos += 35;
            }

            // Another separator line
            Panel line3 = new Panel();
            line3.BackColor = Color.Black;
            line3.Size = new Size(500, 2);
            line3.Location = new Point(30, yPos);
            panel.Controls.Add(line3);

            yPos += 20;

            // Thank you message
            Label thankYouLabel = new Label();
            thankYouLabel.Text = "Thank you for your payment!\nWe appreciate your business.";
            thankYouLabel.Font = new Font("Arial", 11, FontStyle.Italic);
            thankYouLabel.ForeColor = Color.DarkBlue;
            thankYouLabel.Size = new Size(400, 40);
            thankYouLabel.Location = new Point(80, yPos);
            thankYouLabel.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(thankYouLabel);

            yPos += 60;

            // Generation timestamp
            Label timestampLabel = new Label();
            timestampLabel.Text = $"Generated on: {DateTime.Now:dddd, MMMM dd, yyyy 'at' hh:mm tt}";
            timestampLabel.Font = new Font("Arial", 8, FontStyle.Italic);
            timestampLabel.ForeColor = Color.Gray;
            timestampLabel.Size = new Size(400, 20);
            timestampLabel.Location = new Point(80, yPos);
            timestampLabel.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(timestampLabel);
        }

        private void PrintReceipt(Panel receiptPanel, Payment payment)
        {
            try
            {
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += (sender, e) => {
                    // Create a bitmap of the receipt panel
                    Bitmap bitmap = new Bitmap(receiptPanel.Width, receiptPanel.Height);
                    receiptPanel.DrawToBitmap(bitmap, new Rectangle(0, 0, receiptPanel.Width, receiptPanel.Height));

                    // Calculate scaling to fit the page
                    float scale = Math.Min(
                        (float)e.MarginBounds.Width / bitmap.Width,
                        (float)e.MarginBounds.Height / bitmap.Height);

                    int newWidth = (int)(bitmap.Width * scale);
                    int newHeight = (int)(bitmap.Height * scale);

                    // Center the image on the page
                    int x = e.MarginBounds.Left + (e.MarginBounds.Width - newWidth) / 2;
                    int y = e.MarginBounds.Top + (e.MarginBounds.Height - newHeight) / 2;

                    e.Graphics.DrawImage(bitmap, x, y, newWidth, newHeight);
                    bitmap.Dispose();
                };

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDoc;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                    MessageBox.Show("Receipt printed successfully!", "Print Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error printing receipt: {ex.Message}", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveReceiptAsPDF(Panel receiptPanel, Payment payment)
        {
            try
            {
                // Create a bitmap of the receipt panel
                Bitmap bitmap = new Bitmap(receiptPanel.Width, receiptPanel.Height);
                receiptPanel.DrawToBitmap(bitmap, new Rectangle(0, 0, receiptPanel.Width, receiptPanel.Height));

                // Try to use Microsoft Print to PDF
                string fileName = $"Receipt_R{payment.PaymentID:D6}_{DateTime.Now:yyyyMMdd_HHmmss}";

                PrintDocument printDoc = new PrintDocument();
                printDoc.DocumentName = fileName;

                // Look for Microsoft Print to PDF printer
                bool pdfPrinterFound = false;
                foreach (string printerName in PrinterSettings.InstalledPrinters)
                {
                    if (printerName.Contains("Microsoft Print to PDF") || printerName.Contains("PDF"))
                    {
                        printDoc.PrinterSettings.PrinterName = printerName;
                        pdfPrinterFound = true;
                        break;
                    }
                }

                if (pdfPrinterFound)
                {
                    // Set the output file name for PDF printer
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fullPath = Path.Combine(desktopPath, fileName + ".pdf");

                    printDoc.PrinterSettings.PrintToFile = true;
                    printDoc.PrinterSettings.PrintFileName = fullPath;

                    printDoc.PrintPage += (sender, e) => {
                        // Calculate scaling to fit the page  
                        float scale = Math.Min(
                            (float)e.MarginBounds.Width / bitmap.Width,
                            (float)e.MarginBounds.Height / bitmap.Height);

                        int newWidth = (int)(bitmap.Width * scale);
                        int newHeight = (int)(bitmap.Height * scale);

                        // Center the image on the page
                        int x = e.MarginBounds.Left + (e.MarginBounds.Width - newWidth) / 2;
                        int y = e.MarginBounds.Top + (e.MarginBounds.Height - newHeight) / 2;

                        e.Graphics.DrawImage(bitmap, x, y, newWidth, newHeight);
                    };

                    printDoc.Print();
                    MessageBox.Show($"Receipt saved as PDF to Desktop: {fileName}.pdf", "PDF Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Fallback: Save as high-quality image
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
                    saveDialog.FileName = fileName;
                    saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        bitmap.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("Receipt saved as image successfully!", "Image Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                bitmap.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving receipt: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // Don't filter if showing placeholder text
            if (textBoxSearch.Text != "Search payments (student name, amount, method...)" &&
                textBoxSearch.ForeColor != Color.Gray)
            {
                FilterPayments();
            }
        }
        private void FilterPayments()
        {
            try
            {
                string searchText = textBoxSearch.Text.ToLower().Trim();

                // If search is empty or showing placeholder text, show all payments
                if (string.IsNullOrEmpty(searchText) ||
                    searchText == "search payments (student name, amount, method...)" ||
                    textBoxSearch.ForeColor == Color.Gray)
                {
                    PopulatePaymentsTable();
                    return;
                }

                // Get all payments data
                DataTable allPayments = paymentDAO.GetPaymentsForDisplay();
                DataTable filteredPayments = allPayments.Clone(); // Clone structure

                // Filter the payments based on search text
                foreach (DataRow row in allPayments.Rows)
                {
                    bool matches = false;

                    // Check each column for matches
                    foreach (DataColumn column in allPayments.Columns)
                    {
                        if (row[column] != null && row[column] != DBNull.Value)
                        {
                            string cellValue = row[column].ToString().ToLower();
                            if (cellValue.Contains(searchText))
                            {
                                matches = true;
                                break;
                            }
                        }
                    }

                    if (matches)
                    {
                        filteredPayments.ImportRow(row);
                    }
                }

                // Apply the filtered data to the grid
                dataGridView1.DataSource = filteredPayments;

                // Reapply formatting to the filtered grid
                ApplyDataGridViewFormatting();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering payments: {ex.Message}", "Search Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search payments (student name, amount, method...)")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Search payments (student name, amount, method...)";
                textBoxSearch.ForeColor = Color.Gray;
            }
        }
    }
}
