using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class UserManagementForm : Form
    {
        private readonly UserController _userController;
        private int _selectedUserId = 0;
        private List<UserModel> _allUsers = new List<UserModel>();

        // InnovaStay Theme Colors
        private readonly Color OliveGold = Color.FromArgb(184, 172, 102);
        private readonly Color OliveHover = Color.FromArgb(160, 150, 85);
        private readonly Color SidebarCream = Color.FromArgb(238, 236, 203);
        private readonly Color TableHeaderNavy = Color.FromArgb(20, 26, 40);
        private readonly Color SelectionTan = Color.FromArgb(226, 222, 190);
        private readonly Color DangerRed = Color.FromArgb(220, 53, 69);
        private readonly Color DangerHover = Color.FromArgb(200, 35, 51);
        private readonly Color HeaderGray = Color.FromArgb(195, 198, 202);

        // Header and Search Controls
        private Panel? _headerPanel;
        private Label? _lblHeaderTitle;
        private Label? _lblSearch;
        private TextBox? _txtSearch;
        private Button? _btnClearSearch;

        public UserManagementForm()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            InitializeDropdowns();
            ApplyInnovaStayStyling();
            BuildTopHeaderAndSearchBar();
            HookGridEvents();
            RefreshGridAndInputs();
        }

        private void InitializeDropdowns()
        {
            if (cmbRole != null && cmbRole.Items.Count == 0)
            {
                cmbRole.Items.AddRange(new object[] { "Admin", "FrontDesk" });
            }

            if (cmbStatus != null && cmbStatus.Items.Count == 0)
            {
                cmbStatus.Items.AddRange(new object[] { "Active", "Inactive", "Locked" });
            }
        }

        private void ApplyInnovaStayStyling()
        {
            this.BackColor = SidebarCream;
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);

            // 1. Flush Left Panel Setup
            if (this.Controls.Find("panel1", true).FirstOrDefault() is Panel leftPanel)
            {
                leftPanel.BorderStyle = BorderStyle.None;
                leftPanel.Dock = DockStyle.Left;
                leftPanel.BackColor = SidebarCream;
            }

            // 2. Input Fields
            TextBoxBase[] textboxes = { txtUserId, txtUsername, txtPassword, txtFullName };
            foreach (var tb in textboxes.Where(t => t != null))
            {
                tb.Font = new Font("Segoe UI", 10F);
                tb.BorderStyle = BorderStyle.FixedSingle;
            }

            if (txtUserId != null)
            {
                txtUserId.ReadOnly = true;
                txtUserId.BackColor = Color.FromArgb(245, 245, 240);
            }

            if (txtPassword != null)
            {
                txtPassword.UseSystemPasswordChar = true;
            }

            // Dropdowns
            ComboBox[] combos = { cmbRole, cmbStatus };
            foreach (var cb in combos.Where(c => c != null))
            {
                cb.Font = new Font("Segoe UI", 10F);
                cb.FlatStyle = FlatStyle.Flat;
            }

            // Primary Olive Buttons
            Button[] primaryBtns = { btnAddUser, btnUpdateUser, btnClearUser };
            foreach (var btn in primaryBtns.Where(b => b != null))
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = OliveGold;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
                btn.MouseEnter += (s, e) => btn.BackColor = OliveHover;
                btn.MouseLeave += (s, e) => btn.BackColor = OliveGold;
            }

            // Danger Delete Button
            if (btnDeleteUser != null)
            {
                btnDeleteUser.FlatStyle = FlatStyle.Flat;
                btnDeleteUser.FlatAppearance.BorderSize = 0;
                btnDeleteUser.BackColor = DangerRed;
                btnDeleteUser.ForeColor = Color.White;
                btnDeleteUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                btnDeleteUser.Cursor = Cursors.Hand;
                btnDeleteUser.MouseEnter += (s, e) => btnDeleteUser.BackColor = DangerHover;
                btnDeleteUser.MouseLeave += (s, e) => btnDeleteUser.BackColor = DangerRed;
            }

            // 3. DataGridView Flush Right Setup
            if (dgvUsers != null)
            {
                dgvUsers.Dock = DockStyle.Fill;
                dgvUsers.BackgroundColor = Color.White;
                dgvUsers.BorderStyle = BorderStyle.None;
                dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgvUsers.GridColor = Color.FromArgb(230, 233, 236);
                dgvUsers.RowHeadersVisible = false;
                dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvUsers.MultiSelect = false;
                dgvUsers.AllowUserToResizeRows = false;
                dgvUsers.RowTemplate.Height = 36;
                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvUsers.EnableHeadersVisualStyles = false;
                dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvUsers.ColumnHeadersHeight = 38;
                dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = TableHeaderNavy;
                dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor = TableHeaderNavy;
                dgvUsers.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
                dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

                dgvUsers.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
                dgvUsers.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
                dgvUsers.DefaultCellStyle.SelectionBackColor = SelectionTan;
                dgvUsers.DefaultCellStyle.SelectionForeColor = TableHeaderNavy;
                dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 246);
                dgvUsers.AlternatingRowsDefaultCellStyle.SelectionBackColor = SelectionTan;
                dgvUsers.AlternatingRowsDefaultCellStyle.SelectionForeColor = TableHeaderNavy;
            }
        }

        private void BuildTopHeaderAndSearchBar()
        {
            if (dgvUsers == null) return;

            // Gray sub-header bar identical to Room Maintenance
            _headerPanel = new Panel
            {
                Name = "pnlUserHeader",
                Dock = DockStyle.Top,
                Height = 44,
                BackColor = HeaderGray
            };

            _lblHeaderTitle = new Label
            {
                Text = "User Accounts List",
                Font = new Font("Segoe UI", 11.5F, FontStyle.Bold),
                ForeColor = TableHeaderNavy,
                AutoSize = true,
                Location = new Point(14, 11)
            };

            _lblSearch = new Label
            {
                Text = "Search:",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = TableHeaderNavy,
                AutoSize = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };

            _txtSearch = new TextBox
            {
                Name = "txtSearchUsersDynamic",
                PlaceholderText = "Username, name, role...",
                Font = new Font("Segoe UI", 9.5F, FontStyle.Regular),
                Size = new Size(230, 26),
                BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };

            _btnClearSearch = new Button
            {
                Name = "btnClearSearchUsersDynamic",
                Text = "Clear",
                Size = new Size(65, 26),
                FlatStyle = FlatStyle.Flat,
                BackColor = OliveGold,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            _btnClearSearch.FlatAppearance.BorderSize = 0;
            _btnClearSearch.MouseEnter += (s, e) => _btnClearSearch.BackColor = OliveHover;
            _btnClearSearch.MouseLeave += (s, e) => _btnClearSearch.BackColor = OliveGold;

            // Layout positioning inside the header
            int headerW = _headerPanel.Width > 0 ? _headerPanel.Width : 800;
            _btnClearSearch.Location = new Point(headerW - 80, 9);
            _txtSearch.Location = new Point(_btnClearSearch.Left - 238, 9);
            _lblSearch.Location = new Point(_txtSearch.Left - 58, 13);

            _txtSearch.TextChanged += (s, e) => ApplySearchFilter();
            _btnClearSearch.Click += (s, e) =>
            {
                if (_txtSearch != null) _txtSearch.Text = string.Empty;
                ApplySearchFilter();
            };

            _headerPanel.Controls.Add(_lblHeaderTitle);
            _headerPanel.Controls.Add(_lblSearch);
            _headerPanel.Controls.Add(_txtSearch);
            _headerPanel.Controls.Add(_btnClearSearch);

            // Container ordering: LeftPanel docked Left, HeaderPanel docked Top, Grid docked Fill
            this.Controls.Add(_headerPanel);
            _headerPanel.BringToFront();
            dgvUsers.BringToFront();
        }

        private void ApplySearchFilter()
        {
            if (dgvUsers == null) return;

            string query = _txtSearch?.Text.Trim().ToLower() ?? "";

            if (string.IsNullOrEmpty(query))
            {
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = _allUsers;
            }
            else
            {
                var filtered = _allUsers.Where(u =>
                    (!string.IsNullOrEmpty(u.Username) && u.Username.ToLower().Contains(query)) ||
                    (!string.IsNullOrEmpty(u.FullName) && u.FullName.ToLower().Contains(query)) ||
                    (!string.IsNullOrEmpty(u.Role) && u.Role.ToLower().Contains(query))
                ).ToList();

                dgvUsers.DataSource = null;
                dgvUsers.DataSource = filtered;
            }

            FormatColumns();
        }

        private void FormatColumns()
        {
            if (dgvUsers == null || dgvUsers.Columns.Count == 0) return;

            if (dgvUsers.Columns.Contains("CreatedAt"))
                dgvUsers.Columns["CreatedAt"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";

            if (dgvUsers.Columns.Contains("PasswordHash"))
                dgvUsers.Columns["PasswordHash"].Visible = false;
        }

        private void HookGridEvents()
        {
            if (dgvUsers != null)
            {
                dgvUsers.MouseDown += (s, e) =>
                {
                    var hit = dgvUsers.HitTest(e.X, e.Y);
                    if (hit.Type == DataGridViewHitTestType.None)
                    {
                        ResetForm();
                    }
                };
            }
        }

        private void ResetForm()
        {
            _selectedUserId = 0;
            if (txtUserId != null) txtUserId.Text = "(Auto)";
            if (txtUsername != null) txtUsername.Clear();
            if (txtPassword != null) txtPassword.Clear();
            if (txtFullName != null) txtFullName.Clear();
            if (cmbRole != null && cmbRole.Items.Count > 1) cmbRole.SelectedIndex = 1;
            if (cmbStatus != null && cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;

            if (btnAddUser != null) btnAddUser.Enabled = true;
            if (btnUpdateUser != null) btnUpdateUser.Enabled = false;
            if (btnDeleteUser != null) btnDeleteUser.Enabled = false;

            if (dgvUsers != null) dgvUsers.ClearSelection();
        }

        private void RefreshGridAndInputs()
        {
            _allUsers = _userController.GetAllUsers() ?? new List<UserModel>();
            ApplySearchFilter();
            ResetForm();
        }

        // --- Visual Designer Wired Events ---

        public void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvUsers == null) return;

            var row = dgvUsers.Rows[e.RowIndex];
            _selectedUserId = Convert.ToInt32(row.Cells["UserID"].Value);

            if (txtUserId != null) txtUserId.Text = _selectedUserId.ToString();
            if (txtUsername != null) txtUsername.Text = row.Cells["Username"]?.Value?.ToString() ?? "";
            if (txtFullName != null) txtFullName.Text = row.Cells["FullName"]?.Value?.ToString() ?? "";
            if (txtPassword != null) txtPassword.Text = "";

            if (cmbRole != null)
            {
                string r = row.Cells["Role"]?.Value?.ToString() ?? "";
                cmbRole.SelectedItem = r.Replace(" ", "");
            }

            if (cmbStatus != null)
            {
                bool isLocked = Convert.ToBoolean(row.Cells["IsLocked"]?.Value ?? false);
                cmbStatus.SelectedItem = isLocked ? "Locked" : "Active";
            }

            if (btnAddUser != null) btnAddUser.Enabled = false;
            if (btnUpdateUser != null) btnUpdateUser.Enabled = true;
            if (btnDeleteUser != null) btnDeleteUser.Enabled = true;
        }

        public void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername?.Text.Trim() ?? "";
            string password = txtPassword?.Text.Trim() ?? "";
            string fullName = txtFullName?.Text.Trim() ?? "";
            string role = cmbRole?.SelectedItem?.ToString() ?? "FrontDesk";
            string status = cmbStatus?.SelectedItem?.ToString() ?? "Active";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password are required to create a new user account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(fullName))
            {
                fullName = username;
            }

            var (success, errorMsg) = _userController.AddUser(username, password, fullName, role, status);

            if (success)
            {
                MessageBox.Show("User account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGridAndInputs();
            }
            else
            {
                MessageBox.Show(errorMsg, "Error Creating User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (_selectedUserId <= 0)
            {
                MessageBox.Show("Please select a user from the table to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = txtUsername?.Text.Trim() ?? "";
            string fullName = txtFullName?.Text.Trim() ?? "";
            string role = cmbRole?.SelectedItem?.ToString() ?? "FrontDesk";
            string status = cmbStatus?.SelectedItem?.ToString() ?? "Active";

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(fullName))
            {
                fullName = username;
            }

            var (success, errorMsg) = _userController.UpdateUser(_selectedUserId, username, fullName, role, status);

            if (success)
            {
                MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGridAndInputs();
            }
            else
            {
                MessageBox.Show(errorMsg, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (_selectedUserId <= 0)
            {
                MessageBox.Show("Please select a user from the table to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string user = txtUsername?.Text ?? "this user";
            var confirm = MessageBox.Show($"Are you sure you want to delete user account '{user}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var (success, errorMsg) = _userController.DeleteUser(_selectedUserId);

                if (success)
                {
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGridAndInputs();
                }
                else
                {
                    MessageBox.Show(errorMsg, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void btnClearUser_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}