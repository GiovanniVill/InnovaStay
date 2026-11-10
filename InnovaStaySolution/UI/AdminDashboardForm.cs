using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class AdminDashboardForm : Form
    {
        private readonly RoomController _roomController;
        private readonly UserController _userController;

        private Control? _dashboardMainContent;
        private Panel? _hostPanel;

        public AdminDashboardForm()
        {
            InitializeComponent();
            _roomController = new RoomController();
            _userController = new UserController();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            _hostPanel = this.Controls.Find("pnlContentHost", true).FirstOrDefault() as Panel
                      ?? this.Controls.Find("pnlDashboardHome", true).FirstOrDefault() as Panel
                      ?? this.Controls.Find("panelContainer", true).FirstOrDefault() as Panel
                      ?? this.Controls.Find("pnlDynamicContentHost", true).FirstOrDefault() as Panel
                      ?? this.Controls.OfType<Panel>().FirstOrDefault(p => p.Dock == DockStyle.Fill);

            if (_hostPanel != null && _hostPanel.Controls.Count > 0)
            {
                _dashboardMainContent = _hostPanel.Controls[0];
            }

            ShowDashboardView();
        }

        public void ShowDashboardView()
        {
            if (_hostPanel != null)
            {
                if (_dashboardMainContent != null && !_hostPanel.Controls.Contains(_dashboardMainContent))
                {
                    _hostPanel.Controls.Clear();
                    _hostPanel.Controls.Add(_dashboardMainContent);
                    _dashboardMainContent.BringToFront();
                }
            }

            LoadDashboardMetrics();
        }

        private void LoadDashboardMetrics()
        {
            try
            {
                // 1. Fetch Rooms Data from Database
                var rooms = _roomController.GetAllRooms() ?? new List<RoomModel>();

                int totalRooms = rooms.Count;
                int availableRooms = rooms.Count(r => string.Equals(r.Status, "Available", StringComparison.OrdinalIgnoreCase));
                int reservedRooms = rooms.Count(r => string.Equals(r.Status, "Reserved", StringComparison.OrdinalIgnoreCase)
                                                  || string.Equals(r.Status, "Occupied", StringComparison.OrdinalIgnoreCase));
                decimal totalRevenue = rooms.Sum(r => r.PricePerNight);

                int singleCount = rooms.Count(r => r.RoomType != null && r.RoomType.IndexOf("Single", StringComparison.OrdinalIgnoreCase) >= 0);
                int deluxeCount = rooms.Count(r => r.RoomType != null && r.RoomType.IndexOf("Deluxe", StringComparison.OrdinalIgnoreCase) >= 0);
                int suiteCount = rooms.Count(r => r.RoomType != null && r.RoomType.IndexOf("Suite", StringComparison.OrdinalIgnoreCase) >= 0);

                // 2. Fetch Users Data from Database
                var users = _userController.GetAllUsers() ?? new List<UserModel>();
                int totalUsers = users.Count;
                int activeUsers = users.Count(u => !u.IsLocked);

                var allControls = GetAllControls(this).ToList();
                var allLabels = allControls.OfType<Label>().ToList();

                // 3. Update the 4 Top Metric Cards by Card Headers
                UpdateCardMetrics(allLabels, "Total Rooms", $"{totalRooms} Rooms", $"{availableRooms} Available");
                UpdateCardMetrics(allLabels, "Total Users", $"{totalUsers} Registered", $"{activeUsers} Active Accounts");
                UpdateCardMetrics(allLabels, "Revenue", $"PHP {totalRevenue:N2}", $"{reservedRooms} Booked / Reserved");
                UpdateDatabaseStatusCard(allLabels);

                // 4. Update "Room Quick Breakdown" Card
                UpdateRoomBreakdown(allLabels, singleCount, deluxeCount, suiteCount);

                // 5. Update Active Session status badges
                string currentLoggedIn = string.IsNullOrEmpty(UserSession.CurrentUsername) ? "admin" : UserSession.CurrentUsername;
                foreach (var lbl in allLabels.Where(l => l.Text.Trim() == "---" || l.Text.Contains("Active Session")))
                {
                    if (lbl.Parent != null)
                    {
                        var siblingUser = lbl.Parent.Controls.OfType<Label>().FirstOrDefault(s => s != lbl);
                        if (siblingUser != null)
                        {
                            bool isCurrent = string.Equals(siblingUser.Text.Trim(), currentLoggedIn, StringComparison.OrdinalIgnoreCase);
                            lbl.Text = "Active Session";
                            lbl.ForeColor = Color.FromArgb(46, 125, 50);
                        }
                    }
                }

                // 6. Bind User / Staff Accounts Table
                var userGrid = allControls.OfType<DataGridView>().FirstOrDefault();
                if (userGrid != null)
                {
                    if (userGrid.Columns.Count >= 4)
                    {
                        userGrid.Rows.Clear();
                        foreach (var u in users)
                        {
                            string status = u.IsLocked ? "Locked" : "Active";
                            userGrid.Rows.Add(u.UserID, u.Username, u.Role, status, u.CreatedAt.ToString("g"));
                        }
                    }
                    else
                    {
                        userGrid.AutoGenerateColumns = true;
                        userGrid.DataSource = users.Select(u => new
                        {
                            UserID = u.UserID,
                            Username = u.Username,
                            Role = u.Role,
                            Status = u.IsLocked ? "Locked" : "Active",
                            CreatedAt = u.CreatedAt.ToString("g")
                        }).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[AdminDashboardForm] Error: {ex.Message}");
            }
        }

        private void UpdateCardMetrics(List<Label> allLabels, string headerKeyword, string mainValue, string subValue)
        {
            var headerLbl = allLabels.FirstOrDefault(l => l.Text.IndexOf(headerKeyword, StringComparison.OrdinalIgnoreCase) >= 0);
            if (headerLbl?.Parent != null)
            {
                var cardLabels = headerLbl.Parent.Controls.OfType<Label>()
                    .Where(l => l != headerLbl)
                    .OrderBy(l => l.Top)
                    .ToList();

                if (cardLabels.Count >= 2)
                {
                    // Middle label = large metric value
                    cardLabels[0].Text = mainValue;
                    // Bottom label = sub-caption
                    cardLabels[1].Text = subValue;
                }
                else if (cardLabels.Count == 1)
                {
                    cardLabels[0].Text = mainValue;
                }
            }
        }

        private void UpdateDatabaseStatusCard(List<Label> allLabels)
        {
            var dbHeader = allLabels.FirstOrDefault(l => l.Text.IndexOf("Database Status", StringComparison.OrdinalIgnoreCase) >= 0);
            if (dbHeader?.Parent != null)
            {
                var valLbl = dbHeader.Parent.Controls.OfType<Label>()
                    .FirstOrDefault(l => l != dbHeader && !l.Text.Contains("MSSQL") && !l.Text.Contains("InnovaStayDB"));

                if (valLbl != null)
                {
                    valLbl.Text = "Active Connected";
                    valLbl.ForeColor = Color.FromArgb(46, 125, 50);
                }
            }
        }

        private void UpdateRoomBreakdown(List<Label> allLabels, int singleCount, int deluxeCount, int suiteCount)
        {
            var breakdownHeader = allLabels.FirstOrDefault(l => l.Text.IndexOf("Room Quick Breakdown", StringComparison.OrdinalIgnoreCase) >= 0);
            Control? container = breakdownHeader?.Parent;

            var labelsToInspect = container != null
                ? container.Controls.OfType<Label>().ToList()
                : allLabels;

            foreach (var titleLbl in labelsToInspect)
            {
                string text = titleLbl.Text.Trim();

                if (text.IndexOf("Single", StringComparison.OrdinalIgnoreCase) >= 0 && !text.Contains("rooms"))
                {
                    FindAndSetCountLabel(labelsToInspect, titleLbl, $"{singleCount} rooms");
                }
                else if ((text.IndexOf("Deluxe", StringComparison.OrdinalIgnoreCase) >= 0 || text.IndexOf("Double", StringComparison.OrdinalIgnoreCase) >= 0) && !text.Contains("rooms"))
                {
                    titleLbl.Text = "Deluxe Rooms";
                    FindAndSetCountLabel(labelsToInspect, titleLbl, $"{deluxeCount} rooms");
                }
                else if (text.IndexOf("Suite", StringComparison.OrdinalIgnoreCase) >= 0 && !text.Contains("rooms"))
                {
                    FindAndSetCountLabel(labelsToInspect, titleLbl, $"{suiteCount} rooms");
                }
            }
        }

        private void FindAndSetCountLabel(List<Label> labels, Label titleLbl, string countText)
        {
            // Matches the count label situated horizontally on the same row (within 12px vertical alignment)
            var countLbl = labels.FirstOrDefault(l => l != titleLbl
                && Math.Abs(l.Top - titleLbl.Top) <= 12
                && l.Left > titleLbl.Left);

            if (countLbl != null)
            {
                countLbl.Text = countText;
            }
        }

        private IEnumerable<Control> GetAllControls(Control root)
        {
            foreach (Control c in root.Controls)
            {
                yield return c;
                foreach (Control child in GetAllControls(c))
                {
                    yield return child;
                }
            }
        }

        private void LoadEmbeddedForm(Form form)
        {
            if (_hostPanel == null)
            {
                form.Show();
                return;
            }

            _hostPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            _hostPanel.Controls.Add(form);
            form.Show();
        }

        // --- Sidebar Navigation Handlers ---

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboardView();
        }

        private void btnRoomMaintenance_Click(object sender, EventArgs e)
        {
            LoadEmbeddedForm(new RoomMaintenanceForm());
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            LoadEmbeddedForm(new UserManagementForm());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                UserSession.Clear();
                this.Hide();
                var loginForm = new LoginForm();
                loginForm.FormClosed += (s, args) => this.Close();
                loginForm.Show();
            }
        }
    }
}