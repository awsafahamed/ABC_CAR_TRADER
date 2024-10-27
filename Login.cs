using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Event handler for Login button click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get the entered username and password from the form fields
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Verify that both username and password are entered
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Attempt to validate the user credentials
                string role = ValidateUserCredentials(username, password);

                if (role == "Admin")
                {
                    // If the role is 'Admin', show the Admin Dashboard
                    ShowAdminDashboard();
                }
                else if (role == "Customer")
                {
                    // If the role is 'Customer', show the Customer Dashboard
                    ShowCustomerDashboard();
                }
                else
                {
                    // If no role is returned, the login failed
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to validate user credentials
        private string ValidateUserCredentials(string username, string password)
        {
            string role = null;

            try
            {
                // Get the connection string from App.config
                string connectionString = ConfigurationManager.ConnectionStrings["CarManagementDB"].ConnectionString;

                // Create a SQL connection using the connection string
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        // Open the connection
                        conn.Open();
                    }
                    catch (SqlException sqlEx)
                    {
                        // Handle SQL connection errors
                        MessageBox.Show("Failed to connect to the database: " + sqlEx.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return role; // Return null if connection fails
                    }

                    try
                    {
                        // Prepare the SQL query to check the user's credentials
                        string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password";

                        // Create the SQL command
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Add parameters to the query to prevent SQL injection
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.Parameters.AddWithValue("@Password", password);

                            // Execute the query and retrieve the role (Admin or Customer)
                            var result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                role = result.ToString();
                            }
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        // Handle SQL command execution errors
                        MessageBox.Show("Failed to execute query: " + sqlEx.Message, "Database Query Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (ConfigurationErrorsException configEx)
            {
                // Handle configuration errors
                MessageBox.Show("A configuration error occurred: " + configEx.Message, "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return role;
        }

        // Method to show the Admin Dashboard
        private void ShowAdminDashboard()
        {
            try
            {
                AdminDashboardForm adminDashboard = new AdminDashboardForm();
                adminDashboard.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Admin Dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to show the Customer Dashboard
        private void ShowCustomerDashboard()
        {
            try
            {
                CustomerDashboard customerDashboard = new CustomerDashboard();
                customerDashboard.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Customer Dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for Register button click
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                RegisterForm registerForm = new RegisterForm();
                registerForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Register form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Show(); // Show the login form if the register form is closed
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Any logic needed during form load can be added here
        }
    }
}
