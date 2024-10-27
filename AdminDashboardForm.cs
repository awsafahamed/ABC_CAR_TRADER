using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void btnManageCars_Click(object sender, EventArgs e)
        {
            // Create an instance of the ManageCarsForm and show it
            ManageCarsForm manageCarsForm = new ManageCarsForm();
            manageCarsForm.Show();
        }

        private void btnManageCarParts_Click(object sender, EventArgs e)
        {
            // Create an instance of the ManageCarPartsForm and show it
            ManageCarPartsForm manageCarPartsForm = new ManageCarPartsForm();
            manageCarPartsForm.Show();
        }

        private void btnCustomerOrderDetails_Click(object sender, EventArgs e)
        {
            // Create an instance of the CustomerOrderDetailsForm and show it
            CustomerOrderDetails customerOrderDetails = new CustomerOrderDetails();
            customerOrderDetails.Show();
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
          
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();

            // Close the current AdminDashboardForm
            this.Close();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            ManageCustomersForm manageCustomersForm = new ManageCustomersForm();
            manageCustomersForm.Show();

        }
    }
    }

