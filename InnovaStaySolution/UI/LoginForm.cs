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
        }



        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblEmptyF.Text = "Please enter both username and password.";
                lblEmptyF.Visible = true;
                return;
            }

            var result = _authController.Login(username, password);

            if (result != null && string.Equals(result.Status, "SUCCESS", StringComparison.OrdinalIgnoreCase))
            {
                lblEmptyF.Visible = false;
                this.Hide();

                if (string.Equals(result.Role, "Admin", StringComparison.OrdinalIgnoreCase))
                {
                    var adminDash = new AdminDashboardForm();
                    adminDash.FormClosed += (s, args) => this.Close();
                    adminDash.Show();
                }
                else if (string.Equals(result.Role, "Front Desk", StringComparison.OrdinalIgnoreCase))
                {
                    var frontDeskDash = new FrontDeskDashboardForm();
                    frontDeskDash.FormClosed += (s, args) => this.Close();
                    frontDeskDash.Show();
                }
                else
                {
                    lblEmptyF.Text = $"Unrecognized role: {result.Role}";
                    lblEmptyF.Visible = true;
                    this.Show();
                }
            }
            else if (result != null && string.Equals(result.Status, "LOCKED", StringComparison.OrdinalIgnoreCase))
            {
                lblEmptyF.Text = "Account is locked due to too many failed attempts.";
                lblEmptyF.Visible = true;
            }
            else
            {
                int attempts = result?.AttemptsLeft ?? 0;
                lblEmptyF.Text = $"Invalid credentials. Attempts left: {attempts}";
                lblEmptyF.Visible = true;
            }

        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblEmptyF.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblEmptyF.Visible = false;
        }
    }
}