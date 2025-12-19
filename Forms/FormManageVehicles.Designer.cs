namespace CarRentalSystem.Forms
{
    partial class FormManageVehicles
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.GroupBox grpVehicleInfo;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblDailyRate;
        private System.Windows.Forms.TextBox txtDailyRate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.ComboBox cmbFuelType;
        private System.Windows.Forms.Label lblTransmissionType;
        private System.Windows.Forms.ComboBox cmbTransmissionType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.grpVehicleInfo = new System.Windows.Forms.GroupBox();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblDailyRate = new System.Windows.Forms.Label();
            this.txtDailyRate = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblMileage = new System.Windows.Forms.Label();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.lblTransmissionType = new System.Windows.Forms.Label();
            this.cmbTransmissionType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.grpVehicleInfo.SuspendLayout();
            this.SuspendLayout();
            
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Location = new System.Drawing.Point(12, 50);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(760, 250);
            this.dgvVehicles.TabIndex = 0;
            this.dgvVehicles.SelectionChanged += new System.EventHandler(this.dgvVehicles_SelectionChanged);
            
            this.txtSearch.Location = new System.Drawing.Point(12, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 20);
            this.txtSearch.TabIndex = 1;
            
            this.btnSearch.Location = new System.Drawing.Point(320, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            
            this.grpVehicleInfo.Controls.Add(this.lblPlateNumber);
            this.grpVehicleInfo.Controls.Add(this.txtPlateNumber);
            this.grpVehicleInfo.Controls.Add(this.lblBrand);
            this.grpVehicleInfo.Controls.Add(this.txtBrand);
            this.grpVehicleInfo.Controls.Add(this.lblModel);
            this.grpVehicleInfo.Controls.Add(this.txtModel);
            this.grpVehicleInfo.Controls.Add(this.lblYear);
            this.grpVehicleInfo.Controls.Add(this.txtYear);
            this.grpVehicleInfo.Controls.Add(this.lblColor);
            this.grpVehicleInfo.Controls.Add(this.txtColor);
            this.grpVehicleInfo.Controls.Add(this.lblType);
            this.grpVehicleInfo.Controls.Add(this.cmbType);
            this.grpVehicleInfo.Controls.Add(this.lblDailyRate);
            this.grpVehicleInfo.Controls.Add(this.txtDailyRate);
            this.grpVehicleInfo.Controls.Add(this.lblStatus);
            this.grpVehicleInfo.Controls.Add(this.cmbStatus);
            this.grpVehicleInfo.Controls.Add(this.lblMileage);
            this.grpVehicleInfo.Controls.Add(this.txtMileage);
            this.grpVehicleInfo.Controls.Add(this.lblFuelType);
            this.grpVehicleInfo.Controls.Add(this.cmbFuelType);
            this.grpVehicleInfo.Controls.Add(this.lblTransmissionType);
            this.grpVehicleInfo.Controls.Add(this.cmbTransmissionType);
            this.grpVehicleInfo.Location = new System.Drawing.Point(12, 310);
            this.grpVehicleInfo.Name = "grpVehicleInfo";
            this.grpVehicleInfo.Size = new System.Drawing.Size(760, 200);
            this.grpVehicleInfo.TabIndex = 3;
            this.grpVehicleInfo.TabStop = false;
            this.grpVehicleInfo.Text = "Vehicle Information";
            
            int yPos = 25;
            int col1X = 20, col2X = 140, col3X = 400, col4X = 520;
            
            this.lblPlateNumber.Location = new System.Drawing.Point(col1X, yPos);
            this.lblPlateNumber.Size = new System.Drawing.Size(100, 20);
            this.lblPlateNumber.Text = "Plate Number:";
            this.txtPlateNumber.Location = new System.Drawing.Point(col2X, yPos);
            this.txtPlateNumber.Size = new System.Drawing.Size(200, 20);
            
            this.lblBrand.Location = new System.Drawing.Point(col3X, yPos);
            this.lblBrand.Size = new System.Drawing.Size(100, 20);
            this.lblBrand.Text = "Brand:";
            this.txtBrand.Location = new System.Drawing.Point(col4X, yPos);
            this.txtBrand.Size = new System.Drawing.Size(200, 20);
            
            yPos += 30;
            this.lblModel.Location = new System.Drawing.Point(col1X, yPos);
            this.lblModel.Size = new System.Drawing.Size(100, 20);
            this.lblModel.Text = "Model:";
            this.txtModel.Location = new System.Drawing.Point(col2X, yPos);
            this.txtModel.Size = new System.Drawing.Size(200, 20);
            
            this.lblYear.Location = new System.Drawing.Point(col3X, yPos);
            this.lblYear.Size = new System.Drawing.Size(100, 20);
            this.lblYear.Text = "Year:";
            this.txtYear.Location = new System.Drawing.Point(col4X, yPos);
            this.txtYear.Size = new System.Drawing.Size(200, 20);
            
            yPos += 30;
            this.lblColor.Location = new System.Drawing.Point(col1X, yPos);
            this.lblColor.Size = new System.Drawing.Size(100, 20);
            this.lblColor.Text = "Color:";
            this.txtColor.Location = new System.Drawing.Point(col2X, yPos);
            this.txtColor.Size = new System.Drawing.Size(200, 20);
            
            this.lblType.Location = new System.Drawing.Point(col3X, yPos);
            this.lblType.Size = new System.Drawing.Size(100, 20);
            this.lblType.Text = "Type:";
            this.cmbType.Location = new System.Drawing.Point(col4X, yPos);
            this.cmbType.Size = new System.Drawing.Size(200, 21);
            
            yPos += 30;
            this.lblDailyRate.Location = new System.Drawing.Point(col1X, yPos);
            this.lblDailyRate.Size = new System.Drawing.Size(100, 20);
            this.lblDailyRate.Text = "Daily Rate:";
            this.txtDailyRate.Location = new System.Drawing.Point(col2X, yPos);
            this.txtDailyRate.Size = new System.Drawing.Size(200, 20);
            
            this.lblStatus.Location = new System.Drawing.Point(col3X, yPos);
            this.lblStatus.Size = new System.Drawing.Size(100, 20);
            this.lblStatus.Text = "Status:";
            this.cmbStatus.Location = new System.Drawing.Point(col4X, yPos);
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            
            yPos += 30;
            this.lblMileage.Location = new System.Drawing.Point(col1X, yPos);
            this.lblMileage.Size = new System.Drawing.Size(100, 20);
            this.lblMileage.Text = "Mileage:";
            this.txtMileage.Location = new System.Drawing.Point(col2X, yPos);
            this.txtMileage.Size = new System.Drawing.Size(200, 20);
            
            this.lblFuelType.Location = new System.Drawing.Point(col3X, yPos);
            this.lblFuelType.Size = new System.Drawing.Size(100, 20);
            this.lblFuelType.Text = "Fuel Type:";
            this.cmbFuelType.Location = new System.Drawing.Point(col4X, yPos);
            this.cmbFuelType.Size = new System.Drawing.Size(200, 21);
            
            yPos += 30;
            this.lblTransmissionType.Location = new System.Drawing.Point(col1X, yPos);
            this.lblTransmissionType.Size = new System.Drawing.Size(100, 20);
            this.lblTransmissionType.Text = "Transmission:";
            this.cmbTransmissionType.Location = new System.Drawing.Point(col2X, yPos);
            this.cmbTransmissionType.Size = new System.Drawing.Size(200, 21);
            
            this.btnAdd.Location = new System.Drawing.Point(12, 520);
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.Text = "Add New";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            
            this.btnEdit.Location = new System.Drawing.Point(110, 520);
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            
            this.btnDelete.Location = new System.Drawing.Point(208, 520);
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            
            this.btnSave.Location = new System.Drawing.Point(486, 520);
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            
            this.btnCancel.Location = new System.Drawing.Point(584, 520);
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            
            this.btnClose.Location = new System.Drawing.Point(682, 520);
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpVehicleInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvVehicles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormManageVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Vehicles";
            this.Load += new System.EventHandler(this.FormManageVehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.grpVehicleInfo.ResumeLayout(false);
            this.grpVehicleInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
