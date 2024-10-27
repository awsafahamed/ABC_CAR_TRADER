using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class ManageCarPartsForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["CarManagementDB"].ConnectionString;

        public ManageCarPartsForm()
        {
            InitializeComponent();
        }

        private void ManageCarPartsForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCars();
                LoadCarParts(); // Initial load
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load Cars to display in ComboBox with Make and Model
        private void LoadCars()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, Make + ' ' + Model AS CarName FROM Cars";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cbCar.DisplayMember = "CarName";   // Display the concatenated name
                    cbCar.ValueMember = "Id";          // Use the Car ID as the value
                    cbCar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load cars: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load Car Parts into DataGridView
        private void LoadCarParts(string searchFilter = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, Name, CarId, Price FROM CarParts";
                    if (!string.IsNullOrEmpty(searchFilter))
                    {
                        query += " WHERE Name LIKE @SearchFilter";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchFilter))
                        {
                            cmd.Parameters.AddWithValue("@SearchFilter", "%" + searchFilter + "%");
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvCarParts.DataSource = dt;

                        // Adjust column headers
                        dgvCarParts.Columns["Id"].HeaderText = "ID";
                        dgvCarParts.Columns["Name"].HeaderText = "Part Name";
                        dgvCarParts.Columns["CarId"].HeaderText = "Car ID";
                        dgvCarParts.Columns["Price"].HeaderText = "Price";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load car parts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add a new car part
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    int carId = Convert.ToInt32(cbCar.SelectedValue);
                    string partName = txtPartName.Text;
                    decimal partPrice = decimal.Parse(txtPartPrice.Text);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "INSERT INTO CarParts (Name, CarId, Price) VALUES (@Name, @CarId, @Price)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", partName);
                            cmd.Parameters.AddWithValue("@CarId", carId);
                            cmd.Parameters.AddWithValue("@Price", partPrice);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadCarParts();  // Reload the car parts after adding
                    ClearFields();
                    MessageBox.Show("Part added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding part: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Edit an existing car part
        private void btnEditPart_Click(object sender, EventArgs e)
        {
            if (dgvCarParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateInput())
            {
                try
                {
                    int partId = Convert.ToInt32(dgvCarParts.SelectedRows[0].Cells["Id"].Value);
                    int carId = Convert.ToInt32(cbCar.SelectedValue);
                    string partName = txtPartName.Text;
                    decimal partPrice = decimal.Parse(txtPartPrice.Text);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE CarParts SET Name = @Name, CarId = @CarId, Price = @Price WHERE Id = @Id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", partName);
                            cmd.Parameters.AddWithValue("@CarId", carId);
                            cmd.Parameters.AddWithValue("@Price", partPrice);
                            cmd.Parameters.AddWithValue("@Id", partId);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadCarParts();  // Reload the car parts after editing
                    ClearFields();
                    MessageBox.Show("Part updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating part: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Delete a selected car part
        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgvCarParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int partId = Convert.ToInt32(dgvCarParts.SelectedRows[0].Cells["Id"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM CarParts WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", partId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadCarParts();  // Reload the car parts after deleting
                MessageBox.Show("Part deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting part: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // When a row in the DataGridView is selected, load the part details
        private void dgvCarParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvCarParts.Rows.Count)
                {
                    DataGridViewRow row = dgvCarParts.Rows[e.RowIndex];
                    cbCar.SelectedValue = row.Cells["CarId"].Value;           // Set the car in the ComboBox
                    txtPartName.Text = row.Cells["Name"].Value.ToString();     // Set part name
                    txtPartPrice.Text = row.Cells["Price"].Value.ToString();   // Set part price
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting part details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper to clear input fields after adding/editing
        private void ClearFields()
        {
            txtPartName.Clear();
            txtPartPrice.Clear();
            cbCar.SelectedIndex = -1;   // Reset the ComboBox
        }

        // Simple input validation before adding/editing a part
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtPartName.Text))
            {
                MessageBox.Show("Please enter a valid part name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPartPrice.Text) || !decimal.TryParse(txtPartPrice.Text, out _))
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbCar.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a car.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void txtSearchCarParts_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadCarParts(txtSearchCarParts.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching car parts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
