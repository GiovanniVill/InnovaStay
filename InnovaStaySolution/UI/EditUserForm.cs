using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;

namespace UI
{
    public partial class EditUserForm : Form
    {
        private readonly UserController _userController;
        private readonly int _userId;

        private readonly Color OliveGold = Color.FromArgb(184, 172, 102);
        private readonly Color OliveHover = Color.FromArgb(160, 150, 85);
        private readonly Color NeutralGray = Color.FromArgb(160, 165, 170);
        private readonly Color NeutralHover = Color.FromArgb(135, 140, 145);

        public EditUserForm(int userId, string username, string role)
        {
            InitializeComponent();
            _userController = new UserController();
            _userId = userId;

            txtUserId.Text = userId.ToString();
            txtUsername.Text = username;

            string normalizedRole = role.Replace(" ", "");
            cmbRole.SelectedItem = cmbRole.Items.Contains(normalizedRole) ? normalizedRole : "FrontDesk";

            btnSave.MouseEnter += (s, e) => btnSave.BackColor = OliveHover;
            btnSave.MouseLeave += (s, e) => btnSave.BackColor = OliveGold;
            btnCancel.MouseEnter += (s, e) => btnCancel.BackColor = NeutralHover;
            btnCancel.MouseLeave += (s, e) => btnCancel.BackColor = NeutralGray;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        {
            string username = txtUsername.Text.Trim();
            string newPassword = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString() ?? "Front Desk";

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Must pass newPassword as the 6th parameter
            var (success, errorMsg) = _userController.UpdateUser(_userId, username, username, role, "Active", newPassword);

            if (success)
            {
                MessageBox.Show("User account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(errorMsg, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}