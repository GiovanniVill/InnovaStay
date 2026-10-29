using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class UserManagementForm : Form
    {
        private readonly UserController _userController;

        public UserManagementForm()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            SetupDropdowns();
            LoadUsers();
            ClearInputs();
        }

        private void SetupDropdowns()
        {
            if (cmbRole.Items.Count == 0)
            {
                cmbRole.Items.AddRange(new object[] { "Admin", "Front Desk" });
            }

            if (cmbStatus.Items.Count == 0)
            {
                cmbStatus.Items.AddRange(new object[] { "Active", "Locked" });
            }
        }

        private void LoadUsers()
        {
            try
            {
                var users = _userController.GetAllUsers();
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = users;

                if (dgvUsers.Columns["PasswordHash"] != null)
                {
                    dgvUsers.Columns["PasswordHash"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nagka-error sa pag-load ng users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUsers.Rows[e.RowIndex].DataBoundItem is UserModel user)
            {
                txtUserId.Text = user.UserID.ToString();
                txtUsername.Text = user.Username;
                txtPassword.Text = string.Empty;
                txtFullName.Text = user.FullName;
                cmbRole.SelectedItem = user.Role;
                cmbStatus.SelectedItem = user.IsLocked ? "Locked" : "Active";
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Pagtatanong bago magdagdag
            DialogResult confirm = MessageBox.Show(
                "Sigurado ka bang nais mong idagdag ang user na ito?",
                "Kumpirmasyon sa Pagdagdag",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes)
                return;

            string role = cmbRole.SelectedItem?.ToString() ?? string.Empty;
            string status = cmbStatus.SelectedItem?.ToString() ?? "Active";

            var (isSuccess, message) = _userController.AddUser(
                txtUsername.Text,
                txtPassword.Text,
                txtFullName.Text,
                role,
                status
            );

            MessageBox.Show(
                message,
                isSuccess ? "Tagumpay" : "Paunawa",
                MessageBoxButtons.OK,
                isSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning
            );

            if (isSuccess)
            {
                LoadUsers();
                ClearInputs();
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out int userId))
            {
                MessageBox.Show("Pumili muna ng user sa table na nais mong i-update.", "Paunawa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pagtatanong bago mag-update
            DialogResult confirm = MessageBox.Show(
                $"Sigurado ka bang nais mong i-update ang account para kay '{txtUsername.Text}'?",
                "Kumpirmasyon sa Pag-update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes)
                return;

            string role = cmbRole.SelectedItem?.ToString() ?? string.Empty;
            string status = cmbStatus.SelectedItem?.ToString() ?? "Active";

            var (isSuccess, message) = _userController.UpdateUser(
                userId,
                txtUsername.Text,
                txtFullName.Text,
                role,
                status
            );

            MessageBox.Show(
                message,
                isSuccess ? "Tagumpay" : "Paunawa",
                MessageBoxButtons.OK,
                isSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning
            );

            if (isSuccess)
            {
                LoadUsers();
                ClearInputs();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out int userId))
            {
                MessageBox.Show("Pumili muna ng user na nais burahin mula sa table.", "Paunawa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pagtatanong bago magbura
            DialogResult confirm = MessageBox.Show(
                $"Sigurado ka bang nais mong tuluyang burahin ang user na may ID {userId} ({txtUsername.Text})?",
                "Kumpirmasyon sa Pagbura",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            var (isSuccess, message) = _userController.DeleteUser(userId);
            MessageBox.Show(message, isSuccess ? "Tagumpay" : "Paunawa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (isSuccess)
            {
                LoadUsers();
                ClearInputs();
            }
        }

        private void btnClearUser_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Nais mo bang linisin ang lahat ng nakasulat sa input fields?",
                "Kumpirmasyon",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                ClearInputs();
                MessageBox.Show("Nalinis na ang mga input field.", "Tagumpay", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearInputs()
        {
            txtUserId.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtFullName.Text = string.Empty;
            cmbRole.SelectedIndex = -1;
            cmbStatus.SelectedIndex = 0;
        }
    }
}