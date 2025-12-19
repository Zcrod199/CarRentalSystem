using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.Classes;

namespace CarRentalSystem.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Set focus to username textbox
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter username.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                // Encrypt the entered password
                string encryptedPassword = SecurityHelper.EncryptPassword(txtPassword.Text);

                // Query to check user credentials
                string query = @"SELECT UserID, FullName, Role, IsActive 
                                FROM Users 
                                WHERE Username = @Username AND Password = @Password";

                SqlParameter[] parameters = {
                    new SqlParameter("@Username", txtUsername.Text.Trim()),
                    new SqlParameter("@Password", encryptedPassword)
                };

                DataTable dt = DatabaseConnection.ExecuteReader(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    
                    // Check if user is active
                    if (!Convert.ToBoolean(row["IsActive"]))
                    {
                        MessageBox.Show("Your account has been deactivated. Please contact administrator.", 
                            "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Set session data
                    UserSession.UserID = Convert.ToInt32(row["UserID"]);
                    UserSession.FullName = row["FullName"].ToString();
                    UserSession.Role = row["Role"].ToString();

                    // Show success message
                    MessageBox.Show($"Welcome, {UserSession.FullName}!", "Login Successful", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open Dashboard
                    FormDashboard dashboard = new FormDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow Enter key to trigger login
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
