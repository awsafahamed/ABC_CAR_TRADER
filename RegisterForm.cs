using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class RegisterForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["CarManagementDB"].ConnectionString;

        public RegisterForm()
        {
            InitializeComponent();
        }

        // Event handler for the Register button click
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Get user details from the form
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = "Customer"; // Default role for new users

            // Validate inputs
            if (!AreInputsValid(firstName, lastName, email, username, password))
            {
                MessageBox.Show("Please fill in all fields.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Check if the username already exists
                if (IsUsernameExists(username))
                {
                    MessageBox.Show("Username already exists. Please choose another one.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Register the new user
                RegisterNewUser(firstName, lastName, email, username, password, role);
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, close the registration form after successful registration
                this.Close();
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                MessageBox.Show("An error occurred during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to validate form inputs
        private bool AreInputsValid(string firstName, string lastName, string email, string username, string password)
        {
            return !string.IsNullOrEmpty(firstName) &&
                   !string.IsNullOrEmpty(lastName) &&
                   !string.IsNullOrEmpty(email) &&
                   !string.IsNullOrEmpty(username) &&
                   !string.IsNullOrEmpty(password);
        }

        // Method to check if a username already exists
        private bool IsUsernameExists(string username)
        {
            bool userExists = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Failed to connect to the database: " + sqlEx.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true; // Assume user exists if connection fails
                    }

                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);

                        try
                        {
                            int count = (int)checkCmd.ExecuteScalar();
                            userExists = count > 0;
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show("Error checking username availability: " + sqlEx.Message, "Database Query Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return userExists;
        }

        // Method to register a new user
        private void RegisterNewUser(string firstName, string lastName, string email, string username, string password, string role)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Failed to connect to the database: " + sqlEx.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string insertQuery = @"
                        INSERT INTO Users (FirstName, LastName, Email, Username, Password, Role) 
                        VALUES (@FirstName, @LastName, @Email, @Username, @Password, @Role)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@FirstName", firstName);
                        insertCmd.Parameters.AddWithValue("@LastName", lastName);
                        insertCmd.Parameters.AddWithValue("@Email", email);
                        insertCmd.Parameters.AddWithValue("@Username", username);
                        insertCmd.Parameters.AddWithValue("@Password", password);
                        insertCmd.Parameters.AddWithValue("@Role", role);

                        try
                        {
                            insertCmd.ExecuteNonQuery();
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show("Error inserting user data: " + sqlEx.Message, "Database Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error during user registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for switching to the login form
        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            try
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Login form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Any logic needed during form load can be added here
        }
    }
}
