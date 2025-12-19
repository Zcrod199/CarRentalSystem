using System;
using System.Windows.Forms;
using CarRentalSystem.Classes;

namespace CarRentalSystem.Forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Settings";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}