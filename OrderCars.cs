using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Project_AD
{
    public partial class OrderCars : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["CarManagementDB"].ConnectionString;
        private DataTable carsTable = new DataTable(); // For storing car data to filter

        public OrderCars()
        {
            InitializeComponent();
            LoadCars();
        }

        private void OrderCars_Load(object sender, EventArgs e)
        {
            LoadCars(); // Load available cars into the dropdown and table
        }

        private void LoadCars()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, Make, Model, Price, Year FROM Cars";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    carsTable.Clear();
                    adapter.Fill(carsTable);

                    // Populate ComboBox
                    cbSelectCar.DisplayMember = "Model";
                    cbSelectCar.ValueMember = "Id";
                    cbSelectCar.DataSource = carsTable;

                    // Populate DataGridView
                    dgvOrderSummaryCars.DataSource = carsTable;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrderCars_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSelectCar.SelectedIndex == -1 || nudCarsQuantity.Value <= 0)
                {
                    MessageBox.Show("Please select a car and enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int quantity = (int)nudCarsQuantity.Value;
                decimal pricePerUnit = Convert.ToDecimal(txtCarsPrice.Text) / quantity;
                string customerName = txtCustomerName.Text.Trim();
                string carModel = cbSelectCar.Text;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO CarOrders (CustomerName, CarModel, Quantity, TotalPrice, OrderDate) VALUES (@CustomerName, @CarModel, @Quantity, @TotalPrice, @OrderDate)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerName", customerName);
                        cmd.Parameters.AddWithValue("@CarModel", carModel);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@TotalPrice", pricePerUnit * quantity);
                        cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show($"Format error: {formatEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSelectCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSelectCar.SelectedIndex != -1)
                {
                    int carId = Convert.ToInt32(cbSelectCar.SelectedValue);
                    DataRow[] selectedCar = carsTable.Select("Id = " + carId);

                    if (selectedCar.Length > 0)
                    {
                        txtCarsPrice.Text = selectedCar[0]["Price"].ToString();
                        nudCarsQuantity.Value = 1; // Reset quantity to 1
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while selecting a car: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nudCarsQuantity_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSelectCar.SelectedIndex != -1 && decimal.TryParse(carsTable.Select("Id = " + cbSelectCar.SelectedValue)[0]["Price"].ToString(), out decimal pricePerUnit))
                {
                    int quantity = (int)nudCarsQuantity.Value;
                    txtCarsPrice.Text = (pricePerUnit * quantity).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating quantity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txrtSearchCars_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Apply filter on the DataGridView based on the search text
                string filterText = txrtSearchCars.Text.Trim();
                if (!string.IsNullOrWhiteSpace(filterText))
                {
                    DataView dv = carsTable.DefaultView;
                    dv.RowFilter = $"Model LIKE '%{filterText}%' OR Make LIKE '%{filterText}%'"; // Searches by Model or Make
                    dgvOrderSummaryCars.DataSource = dv;
                }
                else
                {
                    dgvOrderSummaryCars.DataSource = carsTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching cars: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrderSummaryCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events if needed (e.g., view details of an order or car)
        }

        private void txtCarsPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Reset total price if the car price changes
                nudCarsQuantity_ValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating price: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
