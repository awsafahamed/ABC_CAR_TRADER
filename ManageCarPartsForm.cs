using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class ManageCarPartsForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CarManagementDB"].ConnectionString;

        public ManageCarPartsForm()
        {
            InitializeComponent();
        }

        private void ManageCarPartsForm_Load(object sender, EventArgs e)
        {
            LoadCars();
            LoadCarParts(); // Initial load
        }

        // Load Cars to display in ComboBox with Make and Model
        private void LoadCars()
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

        // Load Car Parts into DataGridView
        private void LoadCarParts(string searchFilter = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Name, CarId, Price FROM CarParts";
                if (!string.IsNullOrEmpty(searchFilter))
                {
                    query += " WHERE Name LIKE @SearchFilter";
                }
                SqlCommand cmd = new SqlCommand(query, conn);
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
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", partName);
                        cmd.Parameters.AddWithValue("@CarId", carId);
                        cmd.Parameters.AddWithValue("@Price", partPrice);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    LoadCarParts();  // Reload the car parts after adding
                    ClearFields();
                    MessageBox.Show("Part added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding part: " + ex.Message);
                }
            }
        }

        // Edit an existing car part
        private void btnEditPart_Click(object sender, EventArgs e)
        {
            if (dgvCarParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to edit.");
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
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", partName);
                        cmd.Parameters.AddWithValue("@CarId", carId);
                        cmd.Parameters.AddWithValue("@Price", partPrice);
                        cmd.Parameters.AddWithValue("@Id", partId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    LoadCarParts();  // Reload the car parts after editing
                    ClearFields();
                    MessageBox.Show("Part updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating part: " + ex.Message);
                }
            }
        }

        // Delete a selected car part
        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgvCarParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }

            try
            {
                int partId = Convert.ToInt32(dgvCarParts.SelectedRows[0].Cells["Id"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM CarParts WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", partId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                LoadCarParts();  // Reload the car parts after deleting
                MessageBox.Show("Part deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting part: " + ex.Message);
            }
        }

        // When a row in the DataGridView is selected, load the part details
        private void dgvCarParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCarParts.Rows.Count)
            {
                DataGridViewRow row = dgvCarParts.Rows[e.RowIndex];
                cbCar.SelectedValue = row.Cells["CarId"].Value;           // Set the car in the ComboBox
                txtPartName.Text = row.Cells["Name"].Value.ToString();     // Set part name
                txtPartPrice.Text = row.Cells["Price"].Value.ToString();   // Set part price
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
                MessageBox.Show("Please enter a valid part name.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPartPrice.Text) || !decimal.TryParse(txtPartPrice.Text, out _))
            {
                MessageBox.Show("Please enter a valid price.");
                return false;
            }

            if (cbCar.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a car.");
                return false;
            }

            return true;
        }

        private void txtSearchCarParts_TextChanged(object sender, EventArgs e)
        {
            // Call LoadCarParts with the search filter whenever the text changes
            LoadCarParts(txtSearchCarParts.Text);
        }
    }
}
