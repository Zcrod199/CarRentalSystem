namespace CarRentalSystem.Forms
{
    partial class FormDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnNewRental;
        private System.Windows.Forms.Button btnReturnVehicle;
        private System.Windows.Forms.Button btnRentalHistory;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.GroupBox grpVehicles;
        private System.Windows.Forms.Label lblTotalVehicles;
        private System.Windows.Forms.Label lblAvailableVehicles;
        private System.Windows.Forms.Label lblRentedVehicles;
        private System.Windows.Forms.GroupBox grpCustomers;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.GroupBox grpRentals;
        private System.Windows.Forms.Label lblTodayRentals;
        private System.Windows.Forms.GroupBox grpRevenue;
        private System.Windows.Forms.Label lblMonthlyRevenue;
        private System.Windows.Forms.DataGridView dgvRecentTransactions;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblRecentTransactions;

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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnRentalHistory = new System.Windows.Forms.Button();
            this.btnReturnVehicle = new System.Windows.Forms.Button();
            this.btnNewRental = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.panelStats = new System.Windows.Forms.Panel();
            this.grpRevenue = new System.Windows.Forms.GroupBox();
            this.lblMonthlyRevenue = new System.Windows.Forms.Label();
            this.grpRentals = new System.Windows.Forms.GroupBox();
            this.lblTodayRentals = new System.Windows.Forms.Label();
            this.grpCustomers = new System.Windows.Forms.GroupBox();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.grpVehicles = new System.Windows.Forms.GroupBox();
            this.lblRentedVehicles = new System.Windows.Forms.Label();
            this.lblAvailableVehicles = new System.Windows.Forms.Label();
            this.lblTotalVehicles = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblRecentTransactions = new System.Windows.Forms.Label();
            this.dgvRecentTransactions = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.grpRevenue.SuspendLayout();
            this.grpRentals.SuspendLayout();
            this.grpCustomers.SuspendLayout();
            this.grpVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 60);
            this.panelTop.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1070, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(250, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome!";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnMaintenance);
            this.panelMenu.Controls.Add(this.btnRentalHistory);
            this.panelMenu.Controls.Add(this.btnReturnVehicle);
            this.panelMenu.Controls.Add(this.btnNewRental);
            this.panelMenu.Controls.Add(this.btnCustomers);
            this.panelMenu.Controls.Add(this.btnVehicles);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 60);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 640);
            this.panelMenu.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 360);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 50);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.Location = new System.Drawing.Point(0, 300);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(200, 50);
            this.btnMaintenance.TabIndex = 5;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnRentalHistory
            // 
            this.btnRentalHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnRentalHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRentalHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentalHistory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRentalHistory.ForeColor = System.Drawing.Color.White;
            this.btnRentalHistory.Location = new System.Drawing.Point(0, 240);
            this.btnRentalHistory.Name = "btnRentalHistory";
            this.btnRentalHistory.Size = new System.Drawing.Size(200, 50);
            this.btnRentalHistory.TabIndex = 4;
            this.btnRentalHistory.Text = "Rental History";
            this.btnRentalHistory.UseVisualStyleBackColor = false;
            this.btnRentalHistory.Click += new System.EventHandler(this.btnRentalHistory_Click);
            // 
            // btnReturnVehicle
            // 
            this.btnReturnVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnReturnVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnVehicle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnReturnVehicle.ForeColor = System.Drawing.Color.White;
            this.btnReturnVehicle.Location = new System.Drawing.Point(0, 180);
            this.btnReturnVehicle.Name = "btnReturnVehicle";
            this.btnReturnVehicle.Size = new System.Drawing.Size(200, 50);
            this.btnReturnVehicle.TabIndex = 3;
            this.btnReturnVehicle.Text = "Return Vehicle";
            this.btnReturnVehicle.UseVisualStyleBackColor = false;
            this.btnReturnVehicle.Click += new System.EventHandler(this.btnReturnVehicle_Click);
            // 
            // btnNewRental
            // 
            this.btnNewRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnNewRental.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRental.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNewRental.ForeColor = System.Drawing.Color.White;
            this.btnNewRental.Location = new System.Drawing.Point(0, 120);
            this.btnNewRental.Name = "btnNewRental";
            this.btnNewRental.Size = new System.Drawing.Size(200, 50);
            this.btnNewRental.TabIndex = 2;
            this.btnNewRental.Text = "New Rental";
            this.btnNewRental.UseVisualStyleBackColor = false;
            this.btnNewRental.Click += new System.EventHandler(this.btnNewRental_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(0, 60);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(200, 50);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnVehicles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicles.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnVehicles.ForeColor = System.Drawing.Color.White;
            this.btnVehicles.Location = new System.Drawing.Point(0, 0);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(200, 50);
            this.btnVehicles.TabIndex = 0;
            this.btnVehicles.Text = "Vehicles";
            this.btnVehicles.UseVisualStyleBackColor = false;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.grpRevenue);
            this.panelStats.Controls.Add(this.grpRentals);
            this.panelStats.Controls.Add(this.grpCustomers);
            this.panelStats.Controls.Add(this.grpVehicles);
            this.panelStats.Location = new System.Drawing.Point(220, 80);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(960, 150);
            this.panelStats.TabIndex = 2;
            // 
            // grpRevenue
            // 
            this.grpRevenue.Controls.Add(this.lblMonthlyRevenue);
            this.grpRevenue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpRevenue.Location = new System.Drawing.Point(720, 10);
            this.grpRevenue.Name = "grpRevenue";
            this.grpRevenue.Size = new System.Drawing.Size(220, 130);
            this.grpRevenue.TabIndex = 3;
            this.grpRevenue.TabStop = false;
            this.grpRevenue.Text = "Monthly Revenue";
            // 
            // lblMonthlyRevenue
            // 
            this.lblMonthlyRevenue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblMonthlyRevenue.Location = new System.Drawing.Point(10, 40);
            this.lblMonthlyRevenue.Name = "lblMonthlyRevenue";
            this.lblMonthlyRevenue.Size = new System.Drawing.Size(200, 60);
            this.lblMonthlyRevenue.TabIndex = 0;
            this.lblMonthlyRevenue.Text = "$0.00";
            this.lblMonthlyRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpRentals
            // 
            this.grpRentals.Controls.Add(this.lblTodayRentals);
            this.grpRentals.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpRentals.Location = new System.Drawing.Point(480, 10);
            this.grpRentals.Name = "grpRentals";
            this.grpRentals.Size = new System.Drawing.Size(220, 130);
            this.grpRentals.TabIndex = 2;
            this.grpRentals.TabStop = false;
            this.grpRentals.Text = "Today\'s Rentals";
            // 
            // lblTodayRentals
            // 
            this.lblTodayRentals.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTodayRentals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblTodayRentals.Location = new System.Drawing.Point(10, 40);
            this.lblTodayRentals.Name = "lblTodayRentals";
            this.lblTodayRentals.Size = new System.Drawing.Size(200, 60);
            this.lblTodayRentals.TabIndex = 0;
            this.lblTodayRentals.Text = "0";
            this.lblTodayRentals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCustomers
            // 
            this.grpCustomers.Controls.Add(this.lblTotalCustomers);
            this.grpCustomers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCustomers.Location = new System.Drawing.Point(240, 10);
            this.grpCustomers.Name = "grpCustomers";
            this.grpCustomers.Size = new System.Drawing.Size(220, 130);
            this.grpCustomers.TabIndex = 1;
            this.grpCustomers.TabStop = false;
            this.grpCustomers.Text = "Total Customers";
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.lblTotalCustomers.Location = new System.Drawing.Point(10, 40);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(200, 60);
            this.lblTotalCustomers.TabIndex = 0;
            this.lblTotalCustomers.Text = "0";
            this.lblTotalCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpVehicles
            // 
            this.grpVehicles.Controls.Add(this.lblRentedVehicles);
            this.grpVehicles.Controls.Add(this.lblAvailableVehicles);
            this.grpVehicles.Controls.Add(this.lblTotalVehicles);
            this.grpVehicles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpVehicles.Location = new System.Drawing.Point(0, 10);
            this.grpVehicles.Name = "grpVehicles";
            this.grpVehicles.Size = new System.Drawing.Size(220, 130);
            this.grpVehicles.TabIndex = 0;
            this.grpVehicles.TabStop = false;
            this.grpVehicles.Text = "Vehicles";
            // 
            // lblRentedVehicles
            // 
            this.lblRentedVehicles.AutoSize = true;
            this.lblRentedVehicles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRentedVehicles.Location = new System.Drawing.Point(10, 95);
            this.lblRentedVehicles.Name = "lblRentedVehicles";
            this.lblRentedVehicles.Size = new System.Drawing.Size(66, 19);
            this.lblRentedVehicles.TabIndex = 2;
            this.lblRentedVehicles.Text = "Rented: 0";
            // 
            // lblAvailableVehicles
            // 
            this.lblAvailableVehicles.AutoSize = true;
            this.lblAvailableVehicles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAvailableVehicles.Location = new System.Drawing.Point(10, 65);
            this.lblAvailableVehicles.Name = "lblAvailableVehicles";
            this.lblAvailableVehicles.Size = new System.Drawing.Size(83, 19);
            this.lblAvailableVehicles.TabIndex = 1;
            this.lblAvailableVehicles.Text = "Available: 0";
            // 
            // lblTotalVehicles
            // 
            this.lblTotalVehicles.AutoSize = true;
            this.lblTotalVehicles.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalVehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTotalVehicles.Location = new System.Drawing.Point(10, 30);
            this.lblTotalVehicles.Name = "lblTotalVehicles";
            this.lblTotalVehicles.Size = new System.Drawing.Size(72, 25);
            this.lblTotalVehicles.TabIndex = 0;
            this.lblTotalVehicles.Text = "Total: 0";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1070, 250);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblRecentTransactions
            // 
            this.lblRecentTransactions.AutoSize = true;
            this.lblRecentTransactions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentTransactions.Location = new System.Drawing.Point(220, 255);
            this.lblRecentTransactions.Name = "lblRecentTransactions";
            this.lblRecentTransactions.Size = new System.Drawing.Size(169, 21);
            this.lblRecentTransactions.TabIndex = 4;
            this.lblRecentTransactions.Text = "Recent Transactions";
            // 
            // dgvRecentTransactions
            // 
            this.dgvRecentTransactions.AllowUserToAddRows = false;
            this.dgvRecentTransactions.AllowUserToDeleteRows = false;
            this.dgvRecentTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentTransactions.Location = new System.Drawing.Point(220, 290);
            this.dgvRecentTransactions.Name = "dgvRecentTransactions";
            this.dgvRecentTransactions.ReadOnly = true;
            this.dgvRecentTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentTransactions.Size = new System.Drawing.Size(960, 390);
            this.dgvRecentTransactions.TabIndex = 5;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.dgvRecentTransactions);
            this.Controls.Add(this.lblRecentTransactions);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - Car Rental System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDashboard_FormClosing);
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.grpRevenue.ResumeLayout(false);
            this.grpRentals.ResumeLayout(false);
            this.grpCustomers.ResumeLayout(false);
            this.grpVehicles.ResumeLayout(false);
            this.grpVehicles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
