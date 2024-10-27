using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class CustomerOrderDetails : Form
    {
        // Get the connection string from the configuration file
        string connectionString = ConfigurationManager.ConnectionStrings["CarManagementDB"].ConnectionString;

        public CustomerOrderDetails()
        {
            InitializeComponent();
        }

        // This method is called when the form loads
        private void CustomerOrderDetails_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        // Load all orders into the DataGridView when the form is loaded
        private void LoadOrders()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT o.Id, c.CustomerName, o.OrderDate
                    FROM Orders o
                    INNER JOIN Customers c ON o.CustomerId = c.Id";
                
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                
                dgvOrderDetails.DataSource = dt;
                // Optional: Auto-size columns for better readability
                dgvOrderDetails.AutoResizeColumns();
            }
        }

        // This method is triggered when the user clicks the 'View Details' button
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetails.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to view details.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected Order ID
            int orderId = Convert.ToInt32(dgvOrderDetails.SelectedRows[0].Cells["Id"].Value);

            // Load the selected order's details
            LoadOrderDetails(orderId);
        }

        // Load the details of the selected order
        private void LoadOrderDetails(int orderId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT p.PartName, od.Quantity, od.UnitPrice, (od.Quantity * od.UnitPrice) AS TotalPrice
                    FROM OrderDetails od
                    JOIN Parts p ON od.PartId = p.Id
                    WHERE od.OrderId = @OrderId";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderId", orderId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Assuming you have a DataGridView named dgvPartDetails to show the order's part details
                dgvPartDetails.DataSource = dt;
                // Optional: Auto-size columns for better readability
                dgvPartDetails.AutoResizeColumns();
            }
        }

        // Optional: Handle cell click events if needed
        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can implement additional logic here if needed
        }

        private void dgvPartDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can implement additional logic here if needed
        }
    }
}
