using System;
using System.Windows.Forms;
using CarRentalSystem.Classes;

namespace CarRentalSystem.Forms
{
    public partial class FormManageCustomers : Form
    {
        public FormManageCustomers()
        {
            InitializeComponent();
        }

        private void FormManageCustomers_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Manage Customers";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}