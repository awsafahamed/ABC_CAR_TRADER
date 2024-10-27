using System;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        // Event handler to order car parts
        private void btnOrderCarsParts_Click(object sender, EventArgs e)
        {
            try
            {
                Order_Car_Parts orderCarPartsForm = new Order_Car_Parts();
                orderCarPartsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Order Car Parts form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler to track orders
        private void btnTrackOrders_Click(object sender, EventArgs e)
        {
            try
            {
                Track_Orders trackOrdersForm = new Track_Orders();
                trackOrdersForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Track Orders form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler to order cars
        private void btnOrderCars_Click(object sender, EventArgs e)
        {
            try
            {
                OrderCars orderCarsForm = new OrderCars();
                orderCarsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Order Cars form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for logout
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

        // Event handler for Customer Dashboard form load
        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                // Initialization code if required
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the Customer Dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
