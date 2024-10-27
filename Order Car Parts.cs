using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Project_AD
{
    public partial class Order_Car_Parts : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["CarManagementDB"].ConnectionString;
        private DataTable carPartsTable = new DataTable();
        private DataTable carsTable = new DataTable();
        private decimal unitPrice = 0; // Store the unit price of the selected car part

        public Order_Car_Parts()
        {
            InitializeComponent();
        }

        private void Order_Car_Parts_Load(object sender, EventArgs e)
        {
            LoadCarModels(); // Load available car models into the ComboBox
            LoadCarParts();  // Load available car parts into the ComboBox and DataGridView
        }

        // Load car models from the Cars table
        private void LoadCarModels()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, Model FROM Cars";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    carsTable.Clear();
                    adapter.Fill(carsTable);

                    // Populate ComboBox for car models
                    cbSelectCar.DisplayMember = "Model";
                    cbSelectCar.ValueMember = "Id";
                    cbSelectCar.DataSource = carsTable;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error loading car models: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load car parts from the CarParts table
        private void LoadCarParts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, Name, Price FROM CarParts";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    carPartsTable.Clear();
                    adapter.Fill(carPartsTable);

                    // Populate ComboBox for car parts
                    cbSelectCarParts.DisplayMember = "Name";
                    cbSelectCarParts.ValueMember = "Id";
                    cbSelectCarParts.DataSource = carPartsTable;

                    // Load data into DataGridView
                    dgvOrderSummary.DataSource = carPartsTable.Copy(); // Load all parts into the DataGridView
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error loading car parts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // When a car part is selected, display its price
        private void cbSelectCarParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSelectCarParts.SelectedIndex != -1)
                {
                    int partId = Convert.ToInt32(cbSelectCarParts.SelectedValue);
                    DataRow[] selectedPart = carPartsTable.Select("Id = " + partId);

                    if (selectedPart.Length > 0)
                    {
                        // Get the unit price from the selected part
                        unitPrice = Convert.ToDecimal(selectedPart[0]["Price"]);
                        txtPrice.Text = unitPrice.ToString("0.00");
                        UpdateTotalPrice(); // Update the total price based on the selected part and quantity
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting car part: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // When the quantity is changed, update the total price
        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        // Update the total price based on quantity and unit price
        private void UpdateTotalPrice()
        {
            try
            {
                int quantity = (int)nudQuantity.Value;
                decimal totalPrice = unitPrice * quantity; // Calculate total price
                txtPrice.Text = totalPrice.ToString("0.00"); // Display the updated total price
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total price: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handle placing an order
        private void btnOrderPart_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSelectCar.SelectedIndex == -1 || cbSelectCarParts.SelectedIndex == -1 || nudQuantity.Value <= 0)
                {
                    MessageBox.Show("Please select a car model, a part, and enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int carId = Convert.ToInt32(cbSelectCar.SelectedValue);
                string carModel = cbSelectCar.Text;
                int partId = Convert.ToInt32(cbSelectCarParts.SelectedValue);
                string partName = cbSelectCarParts.Text;
                int quantity = (int)nudQuantity.Value;
                decimal totalPrice = Convert.ToDecimal(txtPrice.Text);
                string customerName = txtCustomerName.Text.Trim(); // Retrieve customer name from input

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO CarPartsOrder (CarId, CustomerName, CarModel, Quantity, OrderedDate, TotalPrice) " +
                                   "VALUES (@CarId, @CustomerName, @CarModel, @Quantity, @OrderedDate, @TotalPrice)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CarId", carId);
                    cmd.Parameters.AddWithValue("@CustomerName", customerName);
                    cmd.Parameters.AddWithValue("@CarModel", carModel);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@OrderedDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Refresh the DataGridView to show updated parts
                LoadCarParts();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error placing order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Apply search filter on car parts
        private void txtSearchCarParts_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtSearchCarParts.Text.Trim();
                if (!string.IsNullOrWhiteSpace(filterText))
                {
                    DataView dv = carPartsTable.DefaultView;
                    dv.RowFilter = $"Name LIKE '%{filterText}%'";
                    dgvOrderSummary.DataSource = dv;
                }
                else
                {
                    dgvOrderSummary.DataSource = carPartsTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering car parts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrderSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events if needed
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            // Handle customer name input if needed
        }
    }
}
