using System;
using System.Windows.Forms;
using CarRentalSystem.Classes;

namespace CarRentalSystem.Forms
{
    public partial class FormNewRental : Form
    {
        public FormNewRental()
        {
            InitializeComponent();
        }

        private void FormNewRental_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "New Rental";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}