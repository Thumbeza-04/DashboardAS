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
    /// <summary>
    /// Login form that authenticates users against the UserLoginMJ database table.
    /// Available test credentials from database:
    /// - Username: admin, Password: admin123 (Manager role)
    /// - Username: reception, Password: reception123 (Reception role)
    /// - Username: david.instructor, Password: instructor123 (Instructor role)
    /// - Username: jessica.instructor, Password: instructor123 (Instructor role)
    /// </summary>
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get username and password from textboxes
                string username = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();

                // Validate input
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return;
                }

                // Authenticate user against UserLoginMJ database
                UserLogin authenticatedUser = UserLoginDAO.AuthenticateUser(username, password);

                if (authenticatedUser != null)
                {
                    // Authentication successful
                    MessageBox.Show($"Welcome, {authenticatedUser.Username}!\nRole: {authenticatedUser.Role}", 
                                  "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Open the main form (home page)
                    Form1 homePage = new Form1();
                    homePage.Show();
                    this.Hide();
                }
                else
                {
                    // Authentication failed
                    MessageBox.Show("Invalid username or password. Please try again.", 
                                  "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    // Clear password field for security
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                // Handle any database or other errors with detailed information
                string errorMessage = $"An error occurred during login:\n\n";
                errorMessage += $"Error Type: {ex.GetType().Name}\n";
                errorMessage += $"Message: {ex.Message}\n";
                
                if (ex.InnerException != null)
                {
                    errorMessage += $"Inner Exception: {ex.InnerException.Message}\n";
                }
                
                // Log to debug output for development
                System.Diagnostics.Debug.WriteLine($"Login Error: {ex}");
                
                MessageBox.Show(errorMessage, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Clear sensitive information
                textBox2.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }

