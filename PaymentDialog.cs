using System;
using System.Drawing;
using System.Windows.Forms;
using DashboardAS.Data;
using DashboardAS.Models;

namespace DashboardAS
{
    /// <summary>
    /// Reusable modal payment dialog for processing student package payments.
    /// Handles both registration and lesson booking payment scenarios.
    /// </summary>
    public partial class PaymentDialog : Form
    {
        private Student student;
        private Package package;
        private PaymentDAO paymentDAO;
        private PackageDAO packageDAO;
        private decimal totalPaid;
        private decimal amountDue;

        // UI Controls
        private Label lblStudent;
        private Label lblPackage;
        private Label lblLessons;
        private Label lblPrice;
        private Label lblPaid;
        private Label lblDue;
        private Label lblAmount;
        private NumericUpDown nudAmount;
        private Label lblMethod;
        private ComboBox cmbMethod;
        private Button btnPay;
        private Button btnCancel;

        /// <summary>
        /// Gets whether the payment was successfully processed
        /// </summary>
        public bool PaymentProcessed { get; private set; }

        /// <summary>
        /// Gets the payment ID if payment was successful
        /// </summary>
        public int PaymentID { get; private set; }

        /// <summary>
        /// Creates a new payment dialog for the specified student
        /// </summary>
        /// <param name="student">The student to process payment for</param>
        public PaymentDialog(Student student)
        {
            this.student = student ?? throw new ArgumentNullException(nameof(student));
            
            paymentDAO = new PaymentDAO();
            packageDAO = new PackageDAO();
            
            InitializeDialog();
            LoadStudentPackageData();
        }

        private void InitializeDialog()
        {
            // Form properties
            this.Text = "Package Payment";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;

            // Create controls
            CreateControls();
            LayoutControls();
            SetupEventHandlers();
        }

        private void CreateControls()
        {
            // Student info
            lblStudent = new Label 
            { 
                Text = $"Student: {student.FullName}", 
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold),
                ForeColor = Color.DarkBlue
            };

            // Package info
            lblPackage = new Label { Text = "Package: Loading..." };
            lblLessons = new Label { Text = "Lessons: Loading..." };
            
            // Package price
            lblPrice = new Label 
            { 
                Text = "Package Price: Loading...",
                ForeColor = Color.Blue,
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
            };

            // Payment status
            lblPaid = new Label { Text = "Already Paid: Loading..." };
            
            lblDue = new Label 
            { 
                Text = "Amount Due: Loading...",
                ForeColor = Color.Red,
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
            };

            // Payment amount
            lblAmount = new Label { Text = "Payment Amount:" };
            nudAmount = new NumericUpDown
            {
                DecimalPlaces = 2,
                Maximum = 999999m,
                Minimum = 0.01m,
                Value = 0.01m,
                ReadOnly = false // Will be set based on payment policy
            };

            // Payment method
            lblMethod = new Label { Text = "Payment Method:" };
            cmbMethod = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbMethod.Items.AddRange(new string[] { "Cash", "Credit Card", "Debit Card", "Bank Transfer", "EFT" });
            cmbMethod.SelectedIndex = 0;

            // Buttons
            btnPay = new Button
            {
                Text = "Process Payment",
                BackColor = Color.Green,
                ForeColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
            };

            btnCancel = new Button
            {
                Text = "Cancel",
                BackColor = Color.Gray,
                ForeColor = Color.White,
                DialogResult = DialogResult.Cancel
            };

            // Set Cancel button as cancel button for form
            this.CancelButton = btnCancel;
        }

        private void LayoutControls()
        {
            int margin = 20;
            int currentY = margin;
            int controlHeight = 25;
            int spacing = 10;

            // Student info
            lblStudent.Location = new Point(margin, currentY);
            lblStudent.Size = new Size(this.Width - 2 * margin, controlHeight);
            currentY += controlHeight + spacing;

            // Package info
            lblPackage.Location = new Point(margin, currentY);
            lblPackage.Size = new Size(this.Width - 2 * margin, controlHeight);
            currentY += controlHeight + spacing / 2;

            lblLessons.Location = new Point(margin, currentY);
            lblLessons.Size = new Size(200, controlHeight);
            currentY += controlHeight + spacing / 2;

            lblPrice.Location = new Point(margin, currentY);
            lblPrice.Size = new Size(200, controlHeight);
            currentY += controlHeight + spacing;

            // Payment status
            lblPaid.Location = new Point(margin, currentY);
            lblPaid.Size = new Size(200, controlHeight);
            currentY += controlHeight + spacing / 2;

            lblDue.Location = new Point(margin, currentY);
            lblDue.Size = new Size(200, controlHeight);
            currentY += controlHeight + spacing;

            // Payment amount
            lblAmount.Location = new Point(margin, currentY);
            lblAmount.Size = new Size(120, controlHeight);
            nudAmount.Location = new Point(margin + 130, currentY);
            nudAmount.Size = new Size(100, controlHeight);
            currentY += controlHeight + spacing;

            // Payment method
            lblMethod.Location = new Point(margin, currentY);
            lblMethod.Size = new Size(120, controlHeight);
            cmbMethod.Location = new Point(margin + 130, currentY);
            cmbMethod.Size = new Size(120, controlHeight);
            currentY += controlHeight + spacing * 2;

            // Buttons
            int buttonWidth = 120;
            int buttonHeight = 35;
            int buttonSpacing = 20;
            int totalButtonWidth = buttonWidth * 2 + buttonSpacing;
            int buttonStartX = (this.Width - totalButtonWidth) / 2;

            btnPay.Location = new Point(buttonStartX, currentY);
            btnPay.Size = new Size(buttonWidth, buttonHeight);

            btnCancel.Location = new Point(buttonStartX + buttonWidth + buttonSpacing, currentY);
            btnCancel.Size = new Size(buttonWidth, buttonHeight);

            // Add all controls to form
            this.Controls.AddRange(new Control[]
            {
                lblStudent, lblPackage, lblLessons, lblPrice, lblPaid, lblDue,
                lblAmount, nudAmount, lblMethod, cmbMethod, btnPay, btnCancel
            });
        }

        private void SetupEventHandlers()
        {
            btnPay.Click += BtnPay_Click;
        }

        private void LoadStudentPackageData()
        {
            try
            {
                // Validate student has a package
                if (string.IsNullOrEmpty(student.PackageName))
                {
                    throw new InvalidOperationException("Student does not have a package assigned.");
                }

                // Load package data
                package = packageDAO.GetPackageByName(student.PackageName);
                if (package == null)
                {
                    throw new InvalidOperationException($"Package '{student.PackageName}' not found in database.");
                }

                // Validate package data
                if (package.Price <= 0)
                {
                    throw new InvalidOperationException($"Package '{package.PackageName}' has invalid price: R{package.Price:F2}");
                }

                // Get payment information
                totalPaid = paymentDAO.GetTotalPaymentsByStudent(student.StudentID);
                amountDue = Math.Max(0, package.Price - totalPaid);

                // Update UI with loaded data
                UpdateUI();
            }
            catch (Exception ex)
            {
                ShowError($"Error loading package data: {ex.Message}");
                btnPay.Enabled = false;
            }
        }

        private void UpdateUI()
        {
            try
            {
                // Update package information
                lblPackage.Text = $"Package: {package.PackageName}";
                lblLessons.Text = $"Lessons: {package.NoOfLessons}";
                lblPrice.Text = $"Package Price: R{package.Price:F2}";

                // Update payment status
                lblPaid.Text = $"Already Paid: R{totalPaid:F2}";
                lblDue.Text = $"Amount Due: R{amountDue:F2}";

                // Configure payment amount
                if (amountDue <= 0)
                {
                    // Already fully paid
                    lblDue.ForeColor = Color.Green;
                    lblDue.Text = "Status: Fully Paid";
                    nudAmount.Enabled = false;
                    btnPay.Enabled = false;
                    btnPay.Text = "Already Paid";
                    
                    MessageBox.Show($"Student {student.FullName} has already paid for their package in full.\n\n" +
                                  $"Package: {package.PackageName}\n" +
                                  $"Total Paid: R{totalPaid:F2}",
                                  "Already Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Full payment required (no partial payments)
                    SetNumericUpDownValueSafely(nudAmount, amountDue);
                    nudAmount.Minimum = amountDue;
                    nudAmount.Maximum = amountDue;
                    nudAmount.ReadOnly = true; // Full payment only
                    
                    btnPay.Enabled = true;
                    btnPay.Text = $"Pay R{amountDue:F2}";
                }
            }
            catch (Exception ex)
            {
                ShowError($"Error updating payment dialog: {ex.Message}");
                btnPay.Enabled = false;
            }
        }

        private void SetNumericUpDownValueSafely(NumericUpDown control, decimal value)
        {
            try
            {
                // Ensure value is within bounds
                if (value < control.Minimum)
                    value = control.Minimum;
                if (value > control.Maximum)
                    value = control.Maximum;

                control.Value = value;
            }
            catch (Exception ex)
            {
                // Fallback to minimum value if there's any issue
                control.Value = control.Minimum;
                System.Diagnostics.Debug.WriteLine($"Warning: Could not set NumericUpDown value to {value}. Error: {ex.Message}");
            }
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate payment amount
                if (nudAmount.Value <= 0)
                {
                    MessageBox.Show("Payment amount must be greater than zero.", "Invalid Amount", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nudAmount.Value != amountDue)
                {
                    MessageBox.Show($"Full payment of R{amountDue:F2} is required. Partial payments are not allowed.", 
                        "Full Payment Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate payment method
                if (cmbMethod.SelectedItem == null)
                {
                    MessageBox.Show("Please select a payment method.", "Payment Method Required", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbMethod.Focus();
                    return;
                }

                // Confirm payment
                DialogResult confirmResult = MessageBox.Show(
                    $"Process payment of R{nudAmount.Value:F2} for {student.FullName}?\n\n" +
                    $"Package: {package.PackageName}\n" +
                    $"Payment Method: {cmbMethod.Text}\n\n" +
                    "This action cannot be undone.",
                    "Confirm Payment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult != DialogResult.Yes)
                    return;

                // Process payment
                Payment payment = new Payment
                {
                    StudentID = student.StudentID,
                    PaymentDate = DateTime.Now,
                    AmountPaid = nudAmount.Value,
                    AmountDue = 0, // Full payment, no amount due
                    PaymentMethod = cmbMethod.Text
                };

                PaymentID = paymentDAO.AddPayment(payment);
                
                if (PaymentID > 0)
                {
                    PaymentProcessed = true;
                    
                    MessageBox.Show(
                        $"Payment processed successfully!\n\n" +
                        $"Payment ID: {PaymentID}\n" +
                        $"Amount: R{nudAmount.Value:F2}\n" +
                        $"Method: {cmbMethod.Text}\n\n" +
                        "The student can now book lessons.",
                        "Payment Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to process payment. Please try again or contact support.", 
                        "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ShowError($"Error processing payment: {ex.Message}");
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Shows the payment dialog for the specified student
        /// </summary>
        /// <param name="parent">Parent form</param>
        /// <param name="student">Student to process payment for</param>
        /// <returns>Payment result information</returns>
        public static PaymentResult ShowPaymentDialog(IWin32Window parent, Student student)
        {
            try
            {
                using (PaymentDialog dialog = new PaymentDialog(student))
                {
                    DialogResult result = dialog.ShowDialog(parent);
                    
                    return new PaymentResult
                    {
                        Success = dialog.PaymentProcessed,
                        PaymentID = dialog.PaymentID,
                        Cancelled = result == DialogResult.Cancel
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening payment dialog: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return new PaymentResult
                {
                    Success = false,
                    Error = ex.Message
                };
            }
        }
    }

    /// <summary>
    /// Result of a payment dialog operation
    /// </summary>
    public class PaymentResult
    {
        public bool Success { get; set; }
        public int PaymentID { get; set; }
        public bool Cancelled { get; set; }
        public string Error { get; set; }
    }
}
