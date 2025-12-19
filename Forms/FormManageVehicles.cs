using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarRentalSystem.Classes;

namespace CarRentalSystem.Forms
{
    public partial class FormManageVehicles : Form
    {
        private int selectedVehicleID = 0;
        private bool isEditMode = false;

        public FormManageVehicles()
        {
            InitializeComponent();
        }

        private void FormManageVehicles_Load(object sender, EventArgs e)
        {
            LoadVehicles();
            PopulateComboBoxes();
            SetReadOnlyMode();
        }

        private void LoadVehicles()
        {
            try
            {
                string query = @"SELECT VehicleID, PlateNumber, Brand, Model, Year, Color, Type, 
                                DailyRate, Status, Mileage, FuelType, TransmissionType 
                                FROM Vehicles ORDER BY VehicleID DESC";
                
                DataTable dt = DatabaseConnection.ExecuteReader(query);
                dgvVehicles.DataSource = dt;

                if (dgvVehicles.Columns.Count > 0)
                {
                    dgvVehicles.Columns["VehicleID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateComboBoxes()
        {
            cmbStatus.Items.AddRange(new string[] { "Available", "Rented", "Maintenance" });
            cmbFuelType.Items.AddRange(new string[] { "Gasoline", "Diesel", "Electric", "Hybrid" });
            cmbTransmissionType.Items.AddRange(new string[] { "Automatic", "Manual" });
            cmbType.Items.AddRange(new string[] { "Sedan", "SUV", "Sports", "Van", "Truck" });
        }

        private void SetReadOnlyMode()
        {
            txtPlateNumber.ReadOnly = true;
            txtBrand.ReadOnly = true;
            txtModel.ReadOnly = true;
            txtYear.ReadOnly = true;
            txtColor.ReadOnly = true;
            cmbType.Enabled = false;
            txtDailyRate.ReadOnly = true;
            cmbStatus.Enabled = false;
            txtMileage.ReadOnly = true;
            cmbFuelType.Enabled = false;
            cmbTransmissionType.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void SetEditMode()
        {
            txtPlateNumber.ReadOnly = isEditMode;
            txtBrand.ReadOnly = false;
            txtModel.ReadOnly = false;
            txtYear.ReadOnly = false;
            txtColor.ReadOnly = false;
            cmbType.Enabled = true;
            txtDailyRate.ReadOnly = false;
            cmbStatus.Enabled = true;
            txtMileage.ReadOnly = false;
            cmbFuelType.Enabled = true;
            cmbTransmissionType.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void ClearFields()
        {
            selectedVehicleID = 0;
            txtPlateNumber.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtColor.Clear();
            cmbType.SelectedIndex = -1;
            txtDailyRate.Clear();
            cmbStatus.SelectedIndex = -1;
            txtMileage.Clear();
            cmbFuelType.SelectedIndex = -1;
            cmbTransmissionType.SelectedIndex = -1;
        }

        private void dgvVehicles_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVehicles.CurrentRow != null && !btnSave.Enabled)
            {
                DataGridViewRow row = dgvVehicles.CurrentRow;
                selectedVehicleID = Convert.ToInt32(row.Cells["VehicleID"].Value);
                txtPlateNumber.Text = row.Cells["PlateNumber"].Value.ToString();
                txtBrand.Text = row.Cells["Brand"].Value.ToString();
                txtModel.Text = row.Cells["Model"].Value.ToString();
                txtYear.Text = row.Cells["Year"].Value.ToString();
                txtColor.Text = row.Cells["Color"].Value.ToString();
                cmbType.Text = row.Cells["Type"].Value.ToString();
                txtDailyRate.Text = row.Cells["DailyRate"].Value.ToString();
                cmbStatus.Text = row.Cells["Status"].Value.ToString();
                txtMileage.Text = row.Cells["Mileage"].Value.ToString();
                cmbFuelType.Text = row.Cells["FuelType"].Value.ToString();
                cmbTransmissionType.Text = row.Cells["TransmissionType"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isEditMode = false;
            ClearFields();
            SetEditMode();
            cmbStatus.SelectedIndex = 0; // Default to Available
            txtPlateNumber.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedVehicleID == 0)
            {
                MessageBox.Show("Please select a vehicle to edit.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEditMode = true;
            SetEditMode();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedVehicleID == 0)
            {
                MessageBox.Show("Please select a vehicle to delete.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this vehicle?", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Vehicles WHERE VehicleID = @VehicleID";
                    SqlParameter[] parameters = {
                        new SqlParameter("@VehicleID", selectedVehicleID)
                    };

                    DatabaseConnection.ExecuteQuery(query, parameters);
                    MessageBox.Show("Vehicle deleted successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVehicles();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting vehicle: " + ex.Message, "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                if (isEditMode)
                {
                    // Update existing vehicle
                    string query = @"UPDATE Vehicles SET Brand = @Brand, Model = @Model, Year = @Year, 
                                    Color = @Color, Type = @Type, DailyRate = @DailyRate, Status = @Status, 
                                    Mileage = @Mileage, FuelType = @FuelType, TransmissionType = @TransmissionType 
                                    WHERE VehicleID = @VehicleID";

                    SqlParameter[] parameters = {
                        new SqlParameter("@VehicleID", selectedVehicleID),
                        new SqlParameter("@Brand", txtBrand.Text.Trim()),
                        new SqlParameter("@Model", txtModel.Text.Trim()),
                        new SqlParameter("@Year", int.Parse(txtYear.Text)),
                        new SqlParameter("@Color", txtColor.Text.Trim()),
                        new SqlParameter("@Type", cmbType.Text),
                        new SqlParameter("@DailyRate", decimal.Parse(txtDailyRate.Text)),
                        new SqlParameter("@Status", cmbStatus.Text),
                        new SqlParameter("@Mileage", int.Parse(txtMileage.Text)),
                        new SqlParameter("@FuelType", cmbFuelType.Text),
                        new SqlParameter("@TransmissionType", cmbTransmissionType.Text)
                    };

                    DatabaseConnection.ExecuteQuery(query, parameters);
                    MessageBox.Show("Vehicle updated successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Insert new vehicle
                    string query = @"INSERT INTO Vehicles (PlateNumber, Brand, Model, Year, Color, Type, DailyRate, 
                                    Status, Mileage, FuelType, TransmissionType) 
                                    VALUES (@PlateNumber, @Brand, @Model, @Year, @Color, @Type, @DailyRate, 
                                    @Status, @Mileage, @FuelType, @TransmissionType)";

                    SqlParameter[] parameters = {
                        new SqlParameter("@PlateNumber", txtPlateNumber.Text.Trim()),
                        new SqlParameter("@Brand", txtBrand.Text.Trim()),
                        new SqlParameter("@Model", txtModel.Text.Trim()),
                        new SqlParameter("@Year", int.Parse(txtYear.Text)),
                        new SqlParameter("@Color", txtColor.Text.Trim()),
                        new SqlParameter("@Type", cmbType.Text),
                        new SqlParameter("@DailyRate", decimal.Parse(txtDailyRate.Text)),
                        new SqlParameter("@Status", cmbStatus.Text),
                        new SqlParameter("@Mileage", int.Parse(txtMileage.Text)),
                        new SqlParameter("@FuelType", cmbFuelType.Text),
                        new SqlParameter("@TransmissionType", cmbTransmissionType.Text)
                    };

                    DatabaseConnection.ExecuteQuery(query, parameters);
                    MessageBox.Show("Vehicle added successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadVehicles();
                SetReadOnlyMode();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving vehicle: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (!ValidationHelper.IsNotEmpty(txtPlateNumber.Text))
            {
                MessageBox.Show("Please enter plate number.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidationHelper.IsNotEmpty(txtBrand.Text))
            {
                MessageBox.Show("Please enter brand.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidationHelper.IsValidInteger(txtYear.Text, out int year) || year < 1900 || year > DateTime.Now.Year + 1)
            {
                MessageBox.Show("Please enter a valid year.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidationHelper.IsValidDecimal(txtDailyRate.Text, out decimal rate) || rate <= 0)
            {
                MessageBox.Show("Please enter a valid daily rate.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidationHelper.IsValidInteger(txtMileage.Text, out int mileage) || mileage < 0)
            {
                MessageBox.Show("Please enter a valid mileage.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetReadOnlyMode();
            ClearFields();
            if (dgvVehicles.Rows.Count > 0)
            {
                dgvVehicles.Rows[0].Selected = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadVehicles();
                return;
            }

            try
            {
                string query = @"SELECT VehicleID, PlateNumber, Brand, Model, Year, Color, Type, 
                                DailyRate, Status, Mileage, FuelType, TransmissionType 
                                FROM Vehicles 
                                WHERE PlateNumber LIKE @Search OR Brand LIKE @Search OR Model LIKE @Search 
                                ORDER BY VehicleID DESC";

                SqlParameter[] parameters = {
                    new SqlParameter("@Search", "%" + txtSearch.Text.Trim() + "%")
                };

                DataTable dt = DatabaseConnection.ExecuteReader(query, parameters);
                dgvVehicles.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
