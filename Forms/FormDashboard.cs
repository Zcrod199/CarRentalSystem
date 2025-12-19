using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.Classes;

namespace CarRentalSystem.Forms
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {UserSession.FullName}!";
            LoadStatistics();
            LoadRecentTransactions();
        }

        private void LoadStatistics()
        {
            try
            {
                // Total Vehicles
                string queryVehicles = "SELECT COUNT(*) FROM Vehicles";
                object totalVehicles = DatabaseConnection.ExecuteScalar(queryVehicles);
                lblTotalVehicles.Text = totalVehicles.ToString();

                // Available Vehicles
                string queryAvailable = "SELECT COUNT(*) FROM Vehicles WHERE Status = 'Available'";
                object availableVehicles = DatabaseConnection.ExecuteScalar(queryAvailable);
                lblAvailableVehicles.Text = availableVehicles.ToString();

                // Rented Vehicles
                string queryRented = "SELECT COUNT(*) FROM Vehicles WHERE Status = 'Rented'";
                object rentedVehicles = DatabaseConnection.ExecuteScalar(queryRented);
                lblRentedVehicles.Text = rentedVehicles.ToString();

                // Total Customers
                string queryCustomers = "SELECT COUNT(*) FROM Customers";
                object totalCustomers = DatabaseConnection.ExecuteScalar(queryCustomers);
                lblTotalCustomers.Text = totalCustomers.ToString();

                // Today's Rentals
                string queryToday = "SELECT COUNT(*) FROM Rentals WHERE CAST(RentalDate AS DATE) = CAST(GETDATE() AS DATE)";
                object todayRentals = DatabaseConnection.ExecuteScalar(queryToday);
                lblTodayRentals.Text = todayRentals.ToString();

                // Monthly Revenue
                string queryRevenue = @"SELECT ISNULL(SUM(TotalAmount), 0) 
                                       FROM Rentals 
                                       WHERE MONTH(RentalDate) = MONTH(GETDATE()) 
                                       AND YEAR(RentalDate) = YEAR(GETDATE())";
                object monthlyRevenue = DatabaseConnection.ExecuteScalar(queryRevenue);
                lblMonthlyRevenue.Text = "$" + Convert.ToDecimal(monthlyRevenue).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRecentTransactions()
        {
            try
            {
                string query = @"SELECT TOP 10 
                                r.RentalID, 
                                c.FullName AS Customer,
                                v.Brand + ' ' + v.Model AS Vehicle,
                                v.PlateNumber,
                                r.StartDate,
                                r.EndDate,
                                r.TotalAmount,
                                r.Status
                                FROM Rentals r
                                INNER JOIN Customers c ON r.CustomerID = c.CustomerID
                                INNER JOIN Vehicles v ON r.VehicleID = v.VehicleID
                                ORDER BY r.RentalDate DESC";

                DataTable dt = DatabaseConnection.ExecuteReader(query);
                dgvRecentTransactions.DataSource = dt;

                if (dgvRecentTransactions.Columns.Count > 0)
                {
                    dgvRecentTransactions.Columns["RentalID"].HeaderText = "ID";
                    dgvRecentTransactions.Columns["Customer"].HeaderText = "Customer";
                    dgvRecentTransactions.Columns["Vehicle"].HeaderText = "Vehicle";
                    dgvRecentTransactions.Columns["PlateNumber"].HeaderText = "Plate";
                    dgvRecentTransactions.Columns["StartDate"].HeaderText = "Start";
                    dgvRecentTransactions.Columns["EndDate"].HeaderText = "End";
                    dgvRecentTransactions.Columns["TotalAmount"].HeaderText = "Amount";
                    dgvRecentTransactions.Columns["Status"].HeaderText = "Status";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            FormManageVehicles form = new FormManageVehicles();
            form.ShowDialog();
            LoadStatistics();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FormManageCustomers form = new FormManageCustomers();
            form.ShowDialog();
            LoadStatistics();
        }

        private void btnNewRental_Click(object sender, EventArgs e)
        {
            FormNewRental form = new FormNewRental();
            form.ShowDialog();
            LoadStatistics();
            LoadRecentTransactions();
        }

        private void btnReturnVehicle_Click(object sender, EventArgs e)
        {
            FormReturnVehicle form = new FormReturnVehicle();
            form.ShowDialog();
            LoadStatistics();
            LoadRecentTransactions();
        }

        private void btnRentalHistory_Click(object sender, EventArgs e)
        {
            FormRentalHistory form = new FormRentalHistory();
            form.ShowDialog();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            FormManageMaintenance form = new FormManageMaintenance();
            form.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSettings form = new FormSettings();
            form.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStatistics();
            LoadRecentTransactions();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UserSession.ClearSession();
                FormLogin login = new FormLogin();
                login.Show();
                this.Close();
            }
        }

        private void FormDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UserSession.IsLoggedIn())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", 
                    "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
