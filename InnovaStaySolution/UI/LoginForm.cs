using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class LoginForm : Form
    {
        private readonly AuthController _authController;

        public LoginForm()
        {
            InitializeComponent();
            _authController = new AuthController();

            if (cmbRole.SelectedIndex == -1 && cmbRole.Items.Count > 0)
            {
                cmbRole.SelectedIndex = 0;
            }
        }



        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string selectedRole = cmbRole.SelectedItem?.ToString() ?? string.Empty;

            // Uses label6 (or change to your status label name)
            Label statusLabel = this.Controls.ContainsKey("lblStatus") ? (Label)this.Controls["lblStatus"] : label6;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Empty fields are not allowed.";
                return;
            }

            if (string.IsNullOrEmpty(selectedRole))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Please select a role.";
                return;
            }

            AuthResult result = _authController.Login(username, password);

            if (result.Status == "SUCCESS")
            {
                if (!result.Role.Equals(selectedRole, StringComparison.OrdinalIgnoreCase))
                {
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = $"Unauthorized: Role is '{result.Role}', not '{selectedRole}'.";
                    return;
                }

                statusLabel.Text = string.Empty;
                txtPassword.Clear();
                this.Hide();

                if (selectedRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    var adminDash = new AdminDashboardForm();
                    adminDash.Tag = this;
                    adminDash.FormClosed += (s, args) => this.Close();
                    adminDash.Show();
                }
                else
                {
                    var frontDeskDash = new FrontDeskDashboardForm();
                    frontDeskDash.Tag = this;
                    frontDeskDash.FormClosed += (s, args) => this.Close();
                    frontDeskDash.Show();
                }
            }
            else if (result.Status == "LOCKED")
            {
                statusLabel.ForeColor = Color.DarkRed;
                statusLabel.Text = "Account locked: Maximum failed attempts exceeded.";
            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = $"Invalid credentials. Attempts left: {result.AttemptsLeft}";
            }
        }
    }
}