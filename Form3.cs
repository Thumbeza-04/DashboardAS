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
{    public partial class Form3 : Form
    {
        private PackageDAO packageDAO;
        private StudentDAO studentDAO;
        private List<Package> packages;
        private Student currentStudent; // For edit mode
        private bool isEditMode = false;

        public Form3()
        {
            InitializeComponent();
            packageDAO = new PackageDAO();
            studentDAO = new StudentDAO();
            LoadPackages();
            SetupForm();
        }

        // Constructor for edit mode
        public Form3(Student student) : this()
        {
            currentStudent = student;
            isEditMode = true;
            PopulateFormWithStudentData();
            SetupForm();
        }        private void SetupForm()
        {
            // Update button text based on mode
            button1.Text = isEditMode ? "Update Student" : "Register Student";
            
            // Update form title
            this.Text = isEditMode ? "Edit Student" : "Register Student";
            
            // Setup validation event handlers
            SetupValidationEvents();
        }        private void SetupValidationEvents()
        {
            // Email validation
            textBox3.TextChanged += ValidateEmail;
            textBox3.Leave += ValidateEmail;
            
            // Phone number validation
            textBox4.TextChanged += ValidatePhoneNumber;
            textBox4.Leave += ValidatePhoneNumber;
            textBox4.KeyPress += PhoneNumber_KeyPress;
            textBox4.MaxLength = 15; // Allow for formatting characters
            
            // ID Number validation
            textBox5.TextChanged += ValidateIDNumber;
            textBox5.Leave += ValidateIDNumber;
            textBox5.KeyPress += IDNumber_KeyPress;
            textBox5.MaxLength = 13; // Exactly 13 digits for SA ID
            
            // Postal code validation
            textBox9.TextChanged += ValidatePostalCode;
            textBox9.Leave += ValidatePostalCode;
            textBox9.KeyPress += PostalCode_KeyPress;
            textBox9.MaxLength = 4; // Exactly 4 digits for SA postal codes
        }private void LoadPackages()
        {
            try
            {
                packages = packageDAO.GetAllPackages();
                comboBox1.DataSource = packages;
                comboBox1.DisplayMember = "DisplayText";
                comboBox1.ValueMember = "PackageName";
                comboBox1.SelectedIndex = -1; // No selection initially
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading packages: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFormWithStudentData()
        {
            if (currentStudent == null) return;

            textBox1.Text = currentStudent.Name;
            textBox2.Text = currentStudent.Surname;
            textBox3.Text = currentStudent.Email;
            textBox4.Text = currentStudent.PhoneNumber;
            textBox5.Text = currentStudent.IDNo;
            textBox6.Text = currentStudent.StreetNumber;
            textBox7.Text = currentStudent.StreetName;
            textBox8.Text = currentStudent.City;
            textBox9.Text = currentStudent.PostalCode;

            // Set gender
            if (!string.IsNullOrEmpty(currentStudent.Gender))
            {
                comboBox2.SelectedItem = currentStudent.Gender;
            }

            // Set status
            if (!string.IsNullOrEmpty(currentStudent.Status))
            {
                comboBox3.SelectedItem = currentStudent.Status;
            }

            // Set package
            if (!string.IsNullOrEmpty(currentStudent.PackageName))
            {
                comboBox1.SelectedValue = currentStudent.PackageName;
            }        }

        #region Validation Methods

        // Email validation using South African standards
        private void ValidateEmail(object sender, EventArgs e)
        {
            TextBox emailTextBox = sender as TextBox;
            string email = emailTextBox.Text.Trim();
            
            if (string.IsNullOrEmpty(email))
            {
                emailTextBox.BackColor = Color.White;
                return;
            }
            
            // Basic email regex pattern
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (System.Text.RegularExpressions.Regex.IsMatch(email, pattern))
            {
                emailTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                emailTextBox.BackColor = Color.LightCoral;
            }
        }        // Phone number validation for South African format
        private void ValidatePhoneNumber(object sender, EventArgs e)
        {
            TextBox phoneTextBox = sender as TextBox;
            string phone = phoneTextBox.Text.Trim().Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");
            
            if (string.IsNullOrEmpty(phone))
            {
                phoneTextBox.BackColor = Color.White;
                return;
            }
            
            // South African phone number patterns
            // Mobile: 06X, 07X, 08X (081-084), 09X
            // Landline: 01X, 02X, 03X, 04X, 05X
            bool isValid = false;
            
            if (phone.Length == 10 && phone.StartsWith("0"))
            {
                string prefix = phone.Substring(0, 3);
                
                // Common SA mobile prefixes
                string[] mobilePrefixes = { "060", "061", "062", "063", "064", "065", "066", "067", "068", "069",
                                          "070", "071", "072", "073", "074", "076", "078", "079",
                                          "081", "082", "083", "084", "087" };
                
                // Common SA landline prefixes (area codes)
                string[] landlinePrefixes = { "010", "011", "012", "013", "014", "015", "016", "017", "018", "019",
                                            "021", "022", "023", "027", "028",
                                            "031", "032", "033", "034", "035", "036", "037", "038", "039",
                                            "040", "041", "042", "043", "044", "045", "046", "047", "048", "049",
                                            "051", "053", "054", "056", "057", "058" };
                
                isValid = mobilePrefixes.Contains(prefix) || landlinePrefixes.Contains(prefix);
            }
            
            if (isValid)
            {
                phoneTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                phoneTextBox.BackColor = Color.LightCoral;
            }
        }

        // Only allow digits for phone number
        private void PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        // South African ID number validation using Luhn algorithm
        private void ValidateIDNumber(object sender, EventArgs e)
        {
            TextBox idTextBox = sender as TextBox;
            string idNumber = idTextBox.Text.Trim();
            
            if (string.IsNullOrEmpty(idNumber))
            {
                idTextBox.BackColor = Color.White;
                return;
            }
            
            if (IsValidSouthAfricanID(idNumber))
            {
                idTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                idTextBox.BackColor = Color.LightCoral;
            }
        }

        // Only allow digits for ID number
        private void IDNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }        // South African ID validation with proper checksum algorithm
        private bool IsValidSouthAfricanID(string idNumber)
        {
            // South African ID format: YYMMDDSSSSCZG
            // YY = Year, MM = Month, DD = Day, SSSS = Sequence, C = Citizenship, Z = Usually 8/9, G = Gender
            
            if (string.IsNullOrEmpty(idNumber) || idNumber.Length != 13)
                return false;
            
            if (!idNumber.All(char.IsDigit))
                return false;
              // Validate date portion first
            if (!IsValidDateInID(idNumber))
                return false;
            
            // Apply checksum algorithm
            return ValidateLuhnAlgorithm(idNumber);
        }private bool IsValidDateInID(string idNumber)
        {
            try
            {
                int year = int.Parse(idNumber.Substring(0, 2));
                int month = int.Parse(idNumber.Substring(2, 2));
                int day = int.Parse(idNumber.Substring(4, 2));
                
                // Determine century based on current year
                int currentYear = DateTime.Now.Year;
                int currentYearTwoDigit = currentYear % 100;
                
                // If the year is greater than current year (e.g., 30 when current is 25), assume 1900s
                // Otherwise assume 2000s
                int fullYear;
                if (year > currentYearTwoDigit + 10) // Allow some future buffer
                {
                    fullYear = 1900 + year;
                }
                else
                {
                    fullYear = 2000 + year;
                }
                
                // Validate month and day ranges
                if (month < 1 || month > 12) return false;
                if (day < 1 || day > 31) return false;
                
                // Try to create a valid date
                DateTime testDate = new DateTime(fullYear, month, day);
                
                // Check if date is not in the future and person is reasonable age (not over 150)
                DateTime minDate = DateTime.Now.AddYears(-150);
                return testDate >= minDate && testDate <= DateTime.Now;
            }
            catch
            {
                return false;
            }
        }private bool ValidateLuhnAlgorithm(string idNumber)
        {
            // South African ID checksum algorithm (modified Luhn)
            int sum = 0;
            
            // Take every second digit from right to left (excluding check digit)
            // and multiply by 2, then sum all digits
            for (int i = 0; i < 12; i += 2)
            {
                int digit = int.Parse(idNumber[i].ToString());
                sum += digit;
            }
            
            // Take remaining digits, multiply by 2, and add digit sum
            string evenPositions = "";
            for (int i = 1; i < 12; i += 2)
            {
                evenPositions += idNumber[i];
            }
            
            int evenSum = int.Parse(evenPositions) * 2;
            while (evenSum > 0)
            {
                sum += evenSum % 10;
                evenSum /= 10;
            }
            
            // Calculate check digit
            int checkDigit = (10 - (sum % 10)) % 10;
            if (checkDigit == 10) checkDigit = 0;
            
            int actualCheckDigit = int.Parse(idNumber[12].ToString());
            
            return checkDigit == actualCheckDigit;
        }

        // Postal code validation for South Africa
        private void ValidatePostalCode(object sender, EventArgs e)
        {
            TextBox postalTextBox = sender as TextBox;
            string postalCode = postalTextBox.Text.Trim();
            
            if (string.IsNullOrEmpty(postalCode))
            {
                postalTextBox.BackColor = Color.White;
                return;
            }
            
            // South African postal codes are 4 digits
            if (postalCode.Length == 4 && postalCode.All(char.IsDigit))
            {
                postalTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                postalTextBox.BackColor = Color.LightCoral;
            }
        }

        // Only allow digits for postal code
        private void PostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

            private void ClearForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            
            // Reset background colors
            textBox3.BackColor = Color.White; // Email
            textBox4.BackColor = Color.White; // Phone
            textBox5.BackColor = Color.White; // ID
            textBox9.BackColor = Color.White; // Postal code
        }private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Please enter a name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Please enter a surname.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return;
                }                if (string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Please enter an email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Focus();
                    return;
                }

                // Validate email format
                if (textBox3.BackColor == Color.LightCoral)
                {
                    MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Please enter a phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Focus();
                    return;
                }

                // Validate phone number format
                if (textBox4.BackColor == Color.LightCoral)
                {
                    MessageBox.Show("Please enter a valid South African phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    MessageBox.Show("Please enter an ID number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox5.Focus();
                    return;
                }

                // Validate ID number format
                if (textBox5.BackColor == Color.LightCoral)
                {
                    MessageBox.Show("Please enter a valid South African ID number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox5.Focus();
                    return;
                }

                // Validate postal code if provided
                if (!string.IsNullOrWhiteSpace(textBox9.Text) && textBox9.BackColor == Color.LightCoral)
                {
                    MessageBox.Show("Please enter a valid South African postal code (4 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox9.Focus();
                    return;
                }

                if (comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox2.Focus();
                    return;
                }

                // Create student object with form data
                Student student = new Student
                {
                    Name = textBox1.Text.Trim(),
                    Surname = textBox2.Text.Trim(),
                    Email = textBox3.Text.Trim(),
                    PhoneNumber = textBox4.Text.Trim(),
                    IDNo = textBox5.Text.Trim(),
                    Gender = comboBox2.SelectedItem?.ToString(),
                    StreetNumber = textBox6.Text.Trim(),
                    StreetName = textBox7.Text.Trim(),
                    City = textBox8.Text.Trim(),
                    PostalCode = textBox9.Text.Trim(),
                    Status = comboBox3.SelectedItem?.ToString() ?? "New",
                    PackageName = comboBox1.SelectedValue?.ToString()
                };

                if (isEditMode)
                {
                    // Update existing student
                    student.StudentID = currentStudent.StudentID;
                    bool success = studentDAO.UpdateStudent(student);

                    if (success)
                    {
                        MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update student. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Add new student
                    int studentId = studentDAO.AddStudent(student);

                    if (studentId > 0)
                    {
                        MessageBox.Show($"Student registered successfully! Student ID: {studentId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to register student. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                string action = isEditMode ? "updating" : "registering";
                MessageBox.Show($"Error {action} student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
