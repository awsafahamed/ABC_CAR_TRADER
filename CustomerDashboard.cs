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

       

     
        private void btnOrderCarsParts_Click(object sender, EventArgs e)
        {
            // Open the Order Car Parts form
            Order_Car_Parts orderCarPartsForm = new Order_Car_Parts();
            orderCarPartsForm.ShowDialog();
        }

        private void btnTrackOrders_Click(object sender, EventArgs e)
        {
            // Open the Track Orders form
            Track_Orders trackOrdersForm = new Track_Orders();
            trackOrdersForm.ShowDialog();
        }

        private void btnOrderCars_Click(object sender, EventArgs e)
        {
            OrderCars trackOrdersForm = new OrderCars();
            trackOrdersForm.ShowDialog();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();

            // Close the current AdminDashboardForm
            this.Close();
        }
    }
}
