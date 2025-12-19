using System;
using System.Windows.Forms;
using CarRentalSystem.Classes;

namespace CarRentalSystem.Forms
{
    public partial class FormManageMaintenance : Form
    {
        public FormManageMaintenance()
        {
            InitializeComponent();
        }

        private void FormManageMaintenance_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Manage Maintenance";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}