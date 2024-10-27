using System;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        // Event handler to manage cars
        private void btnManageCars_Click(object sender, EventArgs e)
        {
            try
            {
                ManageCarsForm manageCarsForm = new ManageCarsForm();
                manageCarsForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Manage Cars form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler to manage car parts
        private void btnManageCarParts_Click(object sender, EventArgs e)
        {
            try
            {
                ManageCarPartsForm manageCarPartsForm = new ManageCarPartsForm();
                manageCarPartsForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Manage Car Parts form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler to view customer order details
        private void btnCustomerOrderDetails_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerOrderDetails customerOrderDetails = new CustomerOrderDetails();
                customerOrderDetails.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Customer Order Details form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

/*        // Event handler to generate reports
        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            try
            {
                // Code to generate and display reports can be added here
                MessageBox.Show("Reports feature coming soon!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate reports: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        // Event handler for Admin Dashboard form load
        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Initialization code if required
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the Admin Dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler to log out
        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to log out: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler to manage customers
        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                ManageCustomersForm manageCustomersForm = new ManageCustomersForm();
                manageCustomersForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Manage Customers form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
