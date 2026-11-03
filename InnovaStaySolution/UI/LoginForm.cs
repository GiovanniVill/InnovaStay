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

        // Static property accessed by Program.cs
        public static string LoggedInRole { get; set; } = "FrontDesk";

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

                // Normalize role string so "Front Desk" matches "FrontDesk"
                string role = (result.Role ?? "").Replace(" ", "");

                if (string.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(role, "FrontDesk", StringComparison.OrdinalIgnoreCase))
                {
                    LoggedInRole = role;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblEmptyF.Text = $"Unrecognized role: {result.Role}";
                    lblEmptyF.Visible = true;
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