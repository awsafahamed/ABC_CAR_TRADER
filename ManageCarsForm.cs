using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class ManageCarsForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["CarManagementDB"].ConnectionString;

        public ManageCarsForm()
        {
            InitializeComponent();
        }

        private void ManageCarsForm_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void LoadCars(string searchTerm = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Make, Model, Year, Price FROM Cars";
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    query += " WHERE Make LIKE @SearchTerm OR Model LIKE @SearchTerm";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                }

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCars.DataSource = dt;

                // Adjust column headers
                dgvCars.Columns["Id"].HeaderText = "ID";
                dgvCars.Columns["Make"].HeaderText = "Make";
                dgvCars.Columns["Model"].HeaderText = "Model";
                dgvCars.Columns["Year"].HeaderText = "Year";
                dgvCars.Columns["Price"].HeaderText = "Price";
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            string make = txtMake.Text.Trim();
            string model = txtModel.Text.Trim();
            int year;
            decimal price;

            // Validate input
            if (string.IsNullOrWhiteSpace(make) || string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show("Make and Model cannot be empty.");
                return;
            }

            if (!int.TryParse(txtYear.Text.Trim(), out year) || year < 1886 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Cars (Make, Model, Year, Price) VALUES (@Make, @Model, @Year, @Price)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Make", make);
                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Price", price);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadCars();
            ClearFields();
            MessageBox.Show("Car added successfully!");
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a car to edit.");
                return;
            }

            int carId = Convert.ToInt32(dgvCars.SelectedRows[0].Cells["Id"].Value);
            string make = txtMake.Text.Trim();
            string model = txtModel.Text.Trim();
            int year;
            decimal price;

            // Validate input
            if (string.IsNullOrWhiteSpace(make) || string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show("Make and Model cannot be empty.");
                return;
            }

            if (!int.TryParse(txtYear.Text.Trim(), out year) || year < 1886 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Cars SET Make = @Make, Model = @Model, Year = @Year, Price = @Price WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Make", make);
                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Id", carId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadCars();
            ClearFields();
            MessageBox.Show("Car updated successfully!");
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a car to delete.");
                return;
            }

            int carId = Convert.ToInt32(dgvCars.SelectedRows[0].Cells["Id"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Cars WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", carId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadCars();
            MessageBox.Show("Car deleted successfully!");
        }

        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCars.Rows[e.RowIndex];
                txtMake.Text = row.Cells["Make"].Value.ToString();
                txtModel.Text = row.Cells["Model"].Value.ToString();
                txtYear.Text = row.Cells["Year"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();
        }

        // Handle the Year text change event
        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            int year;
            // Validate the year input
            if (int.TryParse(txtYear.Text.Trim(), out year) && year >= 1886 && year <= DateTime.Now.Year)
            {
                if (dgvCars.SelectedRows.Count > 0) // Ensure a row is selected
                {
                    int carId = Convert.ToInt32(dgvCars.SelectedRows[0].Cells["Id"].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Cars SET Year = @Year WHERE Id = @Id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Year", year);
                        cmd.Parameters.AddWithValue("@Id", carId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    LoadCars(); // Refresh the DataGridView to show the updated year
                    MessageBox.Show("Car year updated successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid year between 1886 and the current year.");
            }
        }

      
        private void txtSearchCars_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchCars.Text.Trim();
            LoadCars(searchTerm);
        }
    }
}
