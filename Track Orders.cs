using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class Track_Orders : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["CarManagementDB"].ConnectionString;

        public Track_Orders()
        {
            InitializeComponent();
        }

        private void Track_Orders_Load(object sender, EventArgs e)
        {
            // Optional: Load any initial data or setup
        }

        private void btnTrackOrder_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderId.Text.Trim();
            if (string.IsNullOrEmpty(orderId))
            {
                MessageBox.Show("Please enter an Order ID.");
                return;
            }

            LoadCarOrder(orderId);
        }

        private void LoadCarOrder(string orderId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM CarOrders WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", orderId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgvOrderTracking.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No order found with the given Order ID.");
                        dgvOrderTracking.DataSource = null; // Clear the DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading order data: " + ex.Message);
                }
            }
        }

        private void btcTrackCarParts_Click(object sender, EventArgs e)
        {
            string carPartsOrderId = txtTrackCarParts.Text.Trim();
            if (string.IsNullOrEmpty(carPartsOrderId))
            {
                MessageBox.Show("Please enter a Car Parts Order ID.");
                return;
            }

            LoadCarPartsOrder(carPartsOrderId);
        }

        private void LoadCarPartsOrder(string carPartsOrderId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM CarPartsOrder WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", carPartsOrderId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgvTrackingCarParts.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No parts order found with the given ID.");
                        dgvTrackingCarParts.DataSource = null; // Clear the DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading car parts order data: " + ex.Message);
                }
            }
        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {
            // Optional: Trigger dynamic filtering on text change if needed
            if (!string.IsNullOrEmpty(txtOrderId.Text.Trim()))
            {
                LoadCarOrder(txtOrderId.Text.Trim());
            }
        }

        private void dgvOrderTracking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle any actions for clicking on the order tracking DataGridView
        }

        private void txtTrackCarParts_TextChanged(object sender, EventArgs e)
        {
            // Optional: Trigger dynamic filtering on text change if needed
            if (!string.IsNullOrEmpty(txtTrackCarParts.Text.Trim()))
            {
                LoadCarPartsOrder(txtTrackCarParts.Text.Trim());
            }
        }

        private void dgvTrackingCarParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle any actions for clicking on the car parts tracking DataGridView
        }
    }
}
