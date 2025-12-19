using System;
using System.Windows.Forms;
using CarRentalSystem.Classes;

namespace CarRentalSystem.Forms
{
    public partial class FormRentalHistory : Form
    {
        public FormRentalHistory()
        {
            InitializeComponent();
        }

        private void FormRentalHistory_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Rental History";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}