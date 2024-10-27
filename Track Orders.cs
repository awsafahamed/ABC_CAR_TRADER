using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class Track_Orders : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["CarManagementDB"].ConnectionString;

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
            try
            {
                string orderId = txtOrderId.Text.Trim();
                if (string.IsNullOrEmpty(orderId))
                {
                    MessageBox.Show("Please enter an Order ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LoadCarOrder(orderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCarOrder(string orderId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM CarOrders WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
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
                            MessageBox.Show("No order found with the given Order ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvOrderTracking.DataSource = null; // Clear the DataGridView
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btcTrackCarParts_Click(object sender, EventArgs e)
        {
            try
            {
                string carPartsOrderId = txtTrackCarParts.Text.Trim();
                if (string.IsNullOrEmpty(carPartsOrderId))
                {
                    MessageBox.Show("Please enter a Car Parts Order ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LoadCarPartsOrder(carPartsOrderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCarPartsOrder(string carPartsOrderId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM CarPartsOrder WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
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
                            MessageBox.Show("No parts order found with the given ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvTrackingCarParts.DataSource = null; // Clear the DataGridView
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading car parts order data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {
            // Optional: Trigger dynamic filtering on text change if needed
            try
            {
                if (!string.IsNullOrEmpty(txtOrderId.Text.Trim()))
                {
                    LoadCarOrder(txtOrderId.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during order ID change: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrderTracking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle any actions for clicking on the order tracking DataGridView
        }

        private void txtTrackCarParts_TextChanged(object sender, EventArgs e)
        {
            // Optional: Trigger dynamic filtering on text change if needed
            try
            {
                if (!string.IsNullOrEmpty(txtTrackCarParts.Text.Trim()))
                {
                    LoadCarPartsOrder(txtTrackCarParts.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during parts order ID change: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTrackingCarParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle any actions for clicking on the car parts tracking DataGridView
        }
    }
}
