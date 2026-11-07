using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        // InnovaStay Theme Colors
        private readonly Color OliveGold = Color.FromArgb(184, 172, 102);
        private readonly Color OliveDark = Color.FromArgb(145, 134, 75);
        private readonly Color DeepNavy = Color.FromArgb(20, 26, 40);
        private readonly Color CanvasBg = Color.FromArgb(244, 245, 247);
        private readonly Color CardBg = Color.White;
        private readonly Color BorderColor = Color.FromArgb(228, 231, 236);
        private readonly Color TextDark = Color.FromArgb(28, 34, 46);
        private readonly Color TextMuted = Color.FromArgb(115, 122, 134);
        private readonly Color StatusGreen = Color.FromArgb(46, 125, 50);
        private readonly Color StatusGreenBg = Color.FromArgb(232, 245, 233);
        private readonly Color DangerRed = Color.FromArgb(220, 53, 69);
        private readonly Color DangerHover = Color.FromArgb(195, 30, 45);

        private bool _isDashboardActive = true;

        public AdminDashboardForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            _roomController = new RoomController();
            _userController = new UserController();
            this.Resize += AdminDashboardForm_Resize;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            StyleExistingSidebar();
            ShowDashboardView();
        }

        private void AdminDashboardForm_Resize(object? sender, EventArgs e)
        {
            if (_isDashboardActive && this.WindowState != FormWindowState.Minimized)
            {
                ShowDashboardView();
            }
        }

        private Panel? GetSidebarPanel()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel p && (p.Dock == DockStyle.Left || p.Name.ToLower().Contains("side") || (p.Left == 0 && p.Width < 260)))
                {
                    return p;
                }
            }
            return null;
        }

        private void StyleExistingSidebar()
        {
            Panel? sidebar = GetSidebarPanel();
            if (sidebar == null) return;

            sidebar.BackColor = Color.FromArgb(238, 236, 203);
            foreach (Control child in sidebar.Controls)
            {
                if (child is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;

                    if (btn.Text.ToLower().Contains("log"))
                    {
                        btn.BackColor = DangerRed;
                        btn.ForeColor = Color.White;
                        btn.MouseEnter += (s, e) => btn.BackColor = DangerHover;
                        btn.MouseLeave += (s, e) => btn.BackColor = DangerRed;
                    }
                    else
                    {
                        btn.BackColor = OliveGold;
                        btn.ForeColor = Color.White;
                        btn.MouseEnter += (s, e) => btn.BackColor = OliveDark;
                        btn.MouseLeave += (s, e) => btn.BackColor = OliveGold;
                    }
                }
            }
        }

        private Control GetContentContainer()
        {
            Control? host = this.Controls.Find("pnlContentHost", true).FirstOrDefault();
            if (host != null) return host;

            Control? home = this.Controls.Find("pnlDashboardHome", true).FirstOrDefault();
            if (home != null) return home;

            Panel? sidebar = GetSidebarPanel();
            foreach (Control c in this.Controls)
            {
                if (c != sidebar && c is Panel p && p.Dock == DockStyle.Fill)
                    return p;
            }

            Panel dynamicHost = new Panel
            {
                Name = "pnlDynamicContentHost",
                Dock = DockStyle.Fill,
                BackColor = CanvasBg
            };
            this.Controls.Add(dynamicHost);
            dynamicHost.BringToFront();
            return dynamicHost;
        }

        private void ShowDashboardView()
        {
            _isDashboardActive = true;
            Control container = GetContentContainer();
            container.SuspendLayout();
            container.Controls.Clear();
            container.BringToFront();
            container.BackColor = CanvasBg;

            int paddingX = 28;
            int paddingY = 20;
            int availableWidth = Math.Max(700, container.ClientSize.Width - (paddingX * 2));
            int availableHeight = Math.Max(500, container.ClientSize.Height - paddingY);

            // Header Section
            Label lblHeader = new Label
            {
                Text = "Admin Workspace",
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = DeepNavy,
                Location = new Point(paddingX, paddingY),
                AutoSize = true
            };
            container.Controls.Add(lblHeader);

            Label lblSubtitle = new Label
            {
                Text = "System Overview & Performance",
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                ForeColor = OliveDark,
                Location = new Point(paddingX, paddingY + 38),
                AutoSize = true
            };
            container.Controls.Add(lblSubtitle);

            // Fetch live database records
            var rooms = _roomController.GetAllRooms() ?? new List<RoomModel>();
            int totalRooms = rooms.Count;
            int availableRooms = rooms.Count(r => string.Equals(r.Status, "Available", StringComparison.OrdinalIgnoreCase));
            int reservedRooms = rooms.Count(r => string.Equals(r.Status, "Reserved", StringComparison.OrdinalIgnoreCase) || string.Equals(r.Status, "Occupied", StringComparison.OrdinalIgnoreCase));
            decimal totalRevenue = rooms.Sum(r => r.PricePerNight);

            var users = _userController.GetAllUsers() ?? new List<UserModel>();
            int totalUsers = users.Count;
            int activeUsers = users.Count(u => !u.IsLocked);

            // 4 Top Metric Cards
            int cardGap = 16;
            int cardW = (availableWidth - (cardGap * 3)) / 4;
            int cardH = 115;
            int startY = paddingY + 70;

            container.Controls.Add(CreateStatCard("Total Rooms", $"{totalRooms} Rooms", $"{availableRooms} Available", paddingX, startY, cardW, cardH, true));
            container.Controls.Add(CreateStatCard("Total Users / Staff", $"{totalUsers} Registered", $"{activeUsers} Active Accounts", paddingX + (cardW + cardGap), startY, cardW, cardH, false));
            container.Controls.Add(CreateStatCard("System Revenue Potential", $"PHP {totalRevenue:N2}", $"{reservedRooms} Booked / Reserved", paddingX + (cardW + cardGap) * 2, startY, cardW, cardH, true));
            container.Controls.Add(CreateDatabaseStatusCard(paddingX + (cardW + cardGap) * 3, startY, cardW, cardH));

            // Main Lower Section
            int gridY = startY + cardH + 20;
            int mainSectionH = Math.Max(420, availableHeight - gridY - 24);

            int rightPanelW = Math.Max(320, (int)(availableWidth * 0.28));
            int leftGridW = availableWidth - rightPanelW - cardGap;

            // Users Table Card
            Panel gridPanel = new Panel
            {
                Location = new Point(paddingX, gridY),
                Size = new Size(leftGridW, mainSectionH),
                BackColor = CardBg,
                Padding = new Padding(16)
            };
            gridPanel.Paint += (s, e) => DrawCardBorder(e.Graphics, gridPanel.ClientRectangle);

            Label lblGridTitle = new Label
            {
                Text = "User & Staff Accounts (InnovaStayDB.dbo.Users)",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = DeepNavy,
                Location = new Point(16, 14),
                AutoSize = true
            };
            gridPanel.Controls.Add(lblGridTitle);

            DataGridView userGrid = new DataGridView
            {
                Location = new Point(16, 50),
                Size = new Size(gridPanel.Width - 32, gridPanel.Height - 64),
                BackgroundColor = CardBg,
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                GridColor = Color.FromArgb(240, 242, 245),
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AllowUserToAddRows = false,
                ReadOnly = true,
                RowTemplate = { Height = 42 },
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                EnableHeadersVisualStyles = false,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            userGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            userGrid.ColumnHeadersHeight = 38;
            userGrid.ColumnHeadersDefaultCellStyle.BackColor = DeepNavy;
            userGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            userGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            userGrid.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            userGrid.DefaultCellStyle.ForeColor = TextDark;
            userGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(238, 235, 215);
            userGrid.DefaultCellStyle.SelectionForeColor = DeepNavy;

            userGrid.Columns.Add("UserId", "User ID");
            userGrid.Columns.Add("Username", "Username");
            userGrid.Columns.Add("Role", "Role");
            userGrid.Columns.Add("Status", "Status");
            userGrid.Columns.Add("CreatedAt", "Created At");

            foreach (var u in users)
            {
                string statusText = u.IsLocked ? "Locked" : "Active";
                userGrid.Rows.Add(u.UserID, u.Username, u.Role, statusText, u.CreatedAt.ToString("g"));
            }

            gridPanel.Controls.Add(userGrid);
            container.Controls.Add(gridPanel);

            // Right-Side Widgets Container
            int rightX = gridPanel.Right + cardGap;
            Panel rightContainer = new Panel
            {
                Location = new Point(rightX, gridY),
                Size = new Size(rightPanelW, mainSectionH),
                BackColor = Color.Transparent
            };

            int gapRight = 14;
            int totalRightAvailH = mainSectionH - (gapRight * 2);
            int card1H = 135;
            int card3H = 150;
            int card2H = Math.Max(150, totalRightAvailH - card1H - card3H);

            // 1. Session & Active Status
            Panel sessionCard = CreateSidebarCard("Active Session & User Accounts", 0, 0, rightPanelW, card1H);
            string currentLoggedIn = string.IsNullOrEmpty(UserSession.CurrentUsername) ? "admin" : UserSession.CurrentUsername;

            int sessionY = 38;
            foreach (var u in users.Take(2))
            {
                bool isCurrentActive = string.Equals(u.Username, currentLoggedIn, StringComparison.OrdinalIgnoreCase);
                string badge = isCurrentActive ? $"{u.Role} (Active Session)" : $"{u.Role} (Offline)";
                Color badgeColor = isCurrentActive ? StatusGreen : TextMuted;

                sessionCard.Controls.Add(CreateSessionItem(u.Username, badge, badgeColor, 14, sessionY, rightPanelW - 28));
                sessionY += 34;
            }
            rightContainer.Controls.Add(sessionCard);

            // 2. System Audit Logs
            Panel auditCard = CreateSidebarCard("Database Activity Logs", 0, card1H + gapRight, rightPanelW, card2H);
            auditCard.Controls.Add(CreateLogEntry("sp_Room_CRUD executed", "Recently", 14, 38, rightPanelW - 28));
            auditCard.Controls.Add(CreateLogEntry("spGetAllUsersWithProfiles queried", "Just now", 14, 92, rightPanelW - 28));
            auditCard.Controls.Add(CreateLogEntry("dbo.tbl_Rooms state synchronized", "Live", 14, 146, rightPanelW - 28));
            rightContainer.Controls.Add(auditCard);

            // 3. Room Categories Breakdown
            Panel roomStatsCard = CreateSidebarCard("Room Quick Breakdown", 0, card1H + gapRight + card2H + gapRight, rightPanelW, card3H);
            roomStatsCard.Controls.Add(CreateMiniStat("Single Rooms", rooms.Count(r => r.RoomType != null && r.RoomType.IndexOf("Single", StringComparison.OrdinalIgnoreCase) >= 0).ToString(), 14, 36, rightPanelW - 28));
            roomStatsCard.Controls.Add(CreateMiniStat("Double Rooms", rooms.Count(r => r.RoomType != null && r.RoomType.IndexOf("Double", StringComparison.OrdinalIgnoreCase) >= 0).ToString(), 14, 72, rightPanelW - 28));
            roomStatsCard.Controls.Add(CreateMiniStat("Suites", rooms.Count(r => r.RoomType != null && r.RoomType.IndexOf("Suite", StringComparison.OrdinalIgnoreCase) >= 0).ToString(), 14, 108, rightPanelW - 28));
            rightContainer.Controls.Add(roomStatsCard);

            container.Controls.Add(rightContainer);
            container.ResumeLayout(true);
        }

        private void LoadEmbeddedForm(Form form)
        {
            _isDashboardActive = false;
            Control container = GetContentContainer();
            container.Controls.Clear();
            container.BringToFront();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            container.Controls.Add(form);
            form.Show();
        }

        private Panel CreateStatCard(string title, string value, string subtitle, int x, int y, int w, int h, bool drawGraph)
        {
            Panel card = new Panel
            {
                Location = new Point(x, y),
                Size = new Size(w, h),
                BackColor = CardBg
            };

            card.Paint += (s, e) =>
            {
                DrawCardBorder(e.Graphics, card.ClientRectangle);
                if (drawGraph)
                {
                    using var pen = new Pen(OliveGold, 2.2f);
                    Point[] pts = new Point[]
                    {
                        new Point(card.Width - 75, card.Height - 25),
                        new Point(card.Width - 58, card.Height - 38),
                        new Point(card.Width - 40, card.Height - 22),
                        new Point(card.Width - 24, card.Height - 44),
                        new Point(card.Width - 10, card.Height - 32)
                    };
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawLines(pen, pts);
                }
            };

            Label lblT = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = TextMuted,
                Location = new Point(14, 12),
                AutoSize = true
            };

            Label lblV = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = DeepNavy,
                Location = new Point(12, 38),
                AutoSize = true
            };

            Label lblS = new Label
            {
                Text = subtitle,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = OliveDark,
                Location = new Point(14, 80),
                AutoSize = true
            };

            card.Controls.Add(lblT);
            card.Controls.Add(lblV);
            card.Controls.Add(lblS);
            return card;
        }

        private Panel CreateDatabaseStatusCard(int x, int y, int w, int h)
        {
            Panel card = new Panel
            {
                Location = new Point(x, y),
                Size = new Size(w, h),
                BackColor = CardBg
            };

            card.Paint += (s, e) => DrawCardBorder(e.Graphics, card.ClientRectangle);

            Label lblT = new Label
            {
                Text = "Database Status",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = TextMuted,
                Location = new Point(14, 12),
                AutoSize = true
            };

            bool isDbOnline = TestDatabaseConnection();

            Label lblStatus = new Label
            {
                Text = isDbOnline ? "Active Connected" : "Connection Issue",
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = isDbOnline ? StatusGreen : DangerRed,
                BackColor = isDbOnline ? StatusGreenBg : Color.FromArgb(253, 237, 237),
                Padding = new Padding(6, 4, 6, 4),
                Location = new Point(14, 42),
                AutoSize = true
            };

            Label lblSub = new Label
            {
                Text = "MSSQLLocalDB InnovaStayDB",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Regular),
                ForeColor = TextMuted,
                Location = new Point(14, 80),
                AutoSize = true
            };

            card.Controls.Add(lblT);
            card.Controls.Add(lblStatus);
            card.Controls.Add(lblSub);
            return card;
        }

        private bool TestDatabaseConnection()
        {
            try
            {
                return _roomController.GetAllRooms() != null;
            }
            catch
            {
                return false;
            }
        }

        private Panel CreateSidebarCard(string title, int x, int y, int w, int h)
        {
            Panel card = new Panel
            {
                Location = new Point(x, y),
                Size = new Size(w, h),
                BackColor = CardBg,
                Padding = new Padding(12)
            };
            card.Paint += (s, e) => DrawCardBorder(e.Graphics, card.ClientRectangle);

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                ForeColor = DeepNavy,
                Location = new Point(14, 10),
                AutoSize = true
            };
            card.Controls.Add(lblTitle);
            return card;
        }

        private Control CreateSessionItem(string username, string badgeText, Color badgeColor, int x, int y, int width)
        {
            Panel item = new Panel
            {
                Location = new Point(x, y),
                Size = new Size(width, 28)
            };

            Label lblUser = new Label
            {
                Text = username,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = DeepNavy,
                Location = new Point(0, 4),
                AutoSize = true
            };

            Label lblBadge = new Label
            {
                Text = badgeText,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Regular),
                ForeColor = badgeColor,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(Math.Max(110, width - 150), 4),
                AutoSize = true
            };

            item.Controls.Add(lblUser);
            item.Controls.Add(lblBadge);
            return item;
        }

        private Control CreateLogEntry(string action, string time, int x, int y, int width)
        {
            Panel p = new Panel
            {
                Location = new Point(x, y),
                Size = new Size(width, 48)
            };

            Label dot = new Label
            {
                Text = "•",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = OliveGold,
                Location = new Point(0, -2),
                AutoSize = true
            };

            Label lblAction = new Label
            {
                Text = action,
                Font = new Font("Segoe UI", 8.8F, FontStyle.Regular),
                ForeColor = TextDark,
                Location = new Point(14, 2),
                Size = new Size(width - 20, 24)
            };

            Label lblTime = new Label
            {
                Text = time,
                Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                ForeColor = TextMuted,
                Location = new Point(14, 26),
                AutoSize = true
            };

            p.Controls.Add(dot);
            p.Controls.Add(lblAction);
            p.Controls.Add(lblTime);
            return p;
        }

        private Control CreateMiniStat(string roomType, string count, int x, int y, int width)
        {
            Panel p = new Panel
            {
                Location = new Point(x, y),
                Size = new Size(width, 32)
            };

            Label lblName = new Label
            {
                Text = roomType,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = TextDark,
                Location = new Point(0, 6),
                AutoSize = true
            };

            Label lblCount = new Label
            {
                Text = $"{count} rooms",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = OliveDark,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(Math.Max(100, width - 85), 6),
                AutoSize = true
            };

            p.Controls.Add(lblName);
            p.Controls.Add(lblCount);
            return p;
        }

        private void DrawCardBorder(Graphics g, Rectangle bounds)
        {
            using var pen = new Pen(BorderColor, 1);
            g.DrawRectangle(pen, 0, 0, bounds.Width - 1, bounds.Height - 1);
        }

        // --- Sidebar Button Handlers ---

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboardView();
        }

        private void btnRM_Click(object sender, EventArgs e)
        {
            LoadEmbeddedForm(new RoomMaintenanceForm());
        }

        private void btnRoomMaintenance_Click(object sender, EventArgs e)
        {
            LoadEmbeddedForm(new RoomMaintenanceForm());
        }

        private void btnUM_Click(object sender, EventArgs e)
        {
            LoadEmbeddedForm(new UserManagementForm());
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