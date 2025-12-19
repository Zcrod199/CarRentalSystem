using System;
using System.Windows.Forms;
using CarRentalSystem.Classes;

namespace CarRentalSystem.Forms
{
    public partial class FormReturnVehicle : Form
    {
        public FormReturnVehicle()
        {
            InitializeComponent();
        }

        private void FormReturnVehicle_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Return Vehicle";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}