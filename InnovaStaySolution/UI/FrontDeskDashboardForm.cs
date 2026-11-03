using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class FrontDeskDashboardForm : Form
    {
        private Form? activeForm = null;
        private readonly RoomController _roomController;

        // InnovaStay Unified Theme Palette (Admin Dashboard match)
        private readonly Color CanvasBg = Color.FromArgb(244, 245, 247);
        private readonly Color CardBg = Color.White;
        private readonly Color BorderColor = Color.FromArgb(228, 231, 236);
        private readonly Color DeepNavy = Color.FromArgb(20, 26, 40);
        private readonly Color OliveGold = Color.FromArgb(184, 172, 102);
        private readonly Color OliveDark = Color.FromArgb(145, 134, 75);
        private readonly Color SidebarCream = Color.FromArgb(238, 236, 203);
        private readonly Color SelectionTan = Color.FromArgb(226, 222, 190);
        private readonly Color TextDark = Color.FromArgb(28, 34, 46);
        private readonly Color TextMuted = Color.FromArgb(115, 122, 134);
        private readonly Color StatusGreen = Color.FromArgb(46, 125, 50);
        private readonly Color DangerRed = Color.FromArgb(220, 53, 69);
        private readonly Color DangerHover = Color.FromArgb(195, 30, 45);

        public FrontDeskDashboardForm()
        {
            InitializeComponent();
            _roomController = new RoomController();
            this.Resize += FrontDeskDashboardForm_Resize;
        }

        private void FrontDeskDashboardForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = CanvasBg;
            StyleSidebar();
            LoadDashboardOverview();
        }

        private void FrontDeskDashboardForm_Resize(object? sender, EventArgs e)
        {
            if (activeForm == null && this.WindowState != FormWindowState.Minimized)
            {
                LoadDashboardOverview();
            }
        }

        private void StyleSidebar()
        {
            Panel? sidebar = null;
            foreach (Control c in this.Controls)
            {
                if (c is Panel p && p != panelMainContent && (p.Dock == DockStyle.Left || p.Left == 0))
                {
                    sidebar = p;
                    break;
                }
            }

            if (sidebar != null)
            {
                sidebar.BackColor = SidebarCream;
                foreach (Control child in sidebar.Controls)
                {
                    if (child is Label lbl)
                    {
                        lbl.ForeColor = DeepNavy;
                    }
                    else if (child is Button btn)
                    {
                        string txt = btn.Text.ToLower();
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                        btn.Cursor = Cursors.Hand;

                        if (txt.Contains("log"))
                        {
                            btn.BackColor = DangerRed;
                            btn.ForeColor = Color.White;
                            btn.MouseEnter += (s, ev) => btn.BackColor = DangerHover;
                            btn.MouseLeave += (s, ev) => btn.BackColor = DangerRed;
                        }
                        else
                        {
                            btn.BackColor = OliveGold;
                            btn.ForeColor = Color.White;
                            btn.MouseEnter += (s, ev) => btn.BackColor = OliveDark;
                            btn.MouseLeave += (s, ev) => btn.BackColor = OliveGold;
                        }
                    }
                }
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                var temp = activeForm;
                activeForm = null;
                temp.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMainContent.Controls.Clear();
            panelMainContent.Controls.Add(childForm);
            panelMainContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void LoadDashboardOverview()
        {
            if (activeForm != null)
            {
                var temp = activeForm;
                activeForm = null;
                temp.Close();
            }

            panelMainContent.SuspendLayout();
            panelMainContent.Controls.Clear();
            panelMainContent.BackColor = CanvasBg;

            int pad = 24;
            int gap = 16;
            int availW = Math.Max(780, panelMainContent.ClientSize.Width - (pad * 2));
            int availH = Math.Max(600, panelMainContent.ClientSize.Height - (pad * 2));

            // Header Section
            Label lblTitle = new Label
            {
                Text = "Front Desk Workspace",
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = DeepNavy,
                Location = new Point(pad, pad - 6),
                AutoSize = true
            };
            panelMainContent.Controls.Add(lblTitle);

            Label lblSubtitle = new Label
            {
                Text = "Live Room Activity & Front Office Tasks",
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                ForeColor = OliveDark,
                Location = new Point(pad, pad + 32),
                AutoSize = true
            };
            panelMainContent.Controls.Add(lblSubtitle);

            // Fetch live room records
            var rooms = _roomController.GetAllRooms() ?? new List<RoomModel>();
            int totalRooms = Math.Max(1, rooms.Count);
            int occupiedCount = rooms.Count(r => string.Equals(r.Status, "Occupied", StringComparison.OrdinalIgnoreCase) || string.Equals(r.Status, "Reserved", StringComparison.OrdinalIgnoreCase));
            int availableCount = rooms.Count(r => string.Equals(r.Status, "Available", StringComparison.OrdinalIgnoreCase));
            int occupancyPercent = (int)Math.Round(((double)occupiedCount / totalRooms) * 100);

            // Layout split
            int rightColW = Math.Max(280, (int)(availW * 0.28));
            int leftColW = availW - rightColW - gap;
            int topRowH = Math.Max(260, (int)(availH * 0.44));
            int botRowH = Math.Max(280, availH - topRowH - gap);

            int startY = pad + 60;
            int rightX = pad + leftColW + gap;
            int botY = startY + topRowH + gap;

            // 1. TOP-LEFT: Rooms & Availability Timeline
            Panel timelineCard = CreateCard(pad, startY, leftColW, topRowH);
            BuildTimelineView(timelineCard, rooms);
            panelMainContent.Controls.Add(timelineCard);

            // 2. TOP-RIGHT: Today's Occupancy & Bookings
            Panel occupancyCard = CreateCard(rightX, startY, rightColW, topRowH);
            BuildOccupancyView(occupancyCard, occupancyPercent, occupiedCount, 3, availableCount);
            panelMainContent.Controls.Add(occupancyCard);

            // 3. BOTTOM-LEFT: Live Activity Table
            Panel activityCard = CreateCard(pad, botY, leftColW, botRowH);
            BuildActivityGrid(activityCard);
            panelMainContent.Controls.Add(activityCard);

            // 4. BOTTOM-RIGHT: Action Queue
            Panel queueCard = CreateCard(rightX, botY, rightColW, botRowH);
            BuildQueueView(queueCard);
            panelMainContent.Controls.Add(queueCard);

            panelMainContent.ResumeLayout(true);
        }

        private Panel CreateCard(int x, int y, int w, int h)
        {
            Panel p = new Panel
            {
                Location = new Point(x, y),
                Size = new Size(w, h),
                BackColor = CardBg
            };
            p.Paint += (s, e) =>
            {
                using var pen = new Pen(BorderColor, 1);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawRectangle(pen, 0, 0, p.Width - 1, p.Height - 1);
            };
            return p;
        }

        private void BuildTimelineView(Panel parent, List<RoomModel> rooms)
        {
            Label lblTitle = new Label
            {
                Text = "Rooms & Reservations",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = DeepNavy,
                Location = new Point(16, 12),
                AutoSize = true
            };
            parent.Controls.Add(lblTitle);

            Label lblSub = new Label
            {
                Text = "Interactive Rooms Availability Timeline",
                Font = new Font("Segoe UI", 9F),
                ForeColor = TextMuted,
                Location = new Point(16, 36),
                AutoSize = true
            };
            parent.Controls.Add(lblSub);

            int legendX = parent.Width - 320;
            AddLegend(parent, "Occupied", DeepNavy, legendX, 16);
            AddLegend(parent, "Reserved", OliveGold, legendX + 90, 16);
            AddLegend(parent, "Maintenance", DangerRed, legendX + 185, 16);

            Panel canvas = new Panel
            {
                Location = new Point(16, 62),
                Size = new Size(parent.Width - 32, parent.Height - 78),
                BackColor = Color.FromArgb(250, 251, 253),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            string[] dates = { "Oct 29", "Oct 30", "Oct 31", "Nov 1", "Nov 3", "Nov 5" };
            string[] displayRooms = rooms.Count > 0
                ? rooms.Take(6).Select(r => $"Room {r.RoomNumber}").ToArray()
                : new[] { "Room 101", "Room 102", "Room 103", "Room 104", "Room 105", "Room 106" };

            canvas.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                int rowH = Math.Max(26, (canvas.Height - 28) / displayRooms.Length);
                int labelW = 85;
                int chartW = canvas.Width - labelW - 10;
                int colW = chartW / dates.Length;

                using var linePen = new Pen(BorderColor, 1);
                using var textBrush = new SolidBrush(TextMuted);
                using var roomBrush = new SolidBrush(TextDark);
                using var font = new Font("Segoe UI", 8F);

                for (int i = 0; i < dates.Length; i++)
                {
                    int x = labelW + (i * colW);
                    g.DrawLine(linePen, x, 0, x, canvas.Height);
                    g.DrawString(dates[i], font, textBrush, x + (colW / 2) - 18, 6);
                }

                for (int i = 0; i < displayRooms.Length; i++)
                {
                    int y = 28 + (i * rowH);
                    g.DrawLine(linePen, 0, y, canvas.Width, y);
                    g.DrawString(displayRooms[i], font, roomBrush, 8, y + (rowH / 2) - 6);

                    if (i == 0) DrawBar(g, labelW + (int)(colW * 1.8), y + 4, (int)(colW * 2.8), rowH - 8, DeepNavy, "Occupied");
                    else if (i == 1) DrawBar(g, labelW + (int)(colW * 0.8), y + 4, (int)(colW * 2.6), rowH - 8, StatusGreen, "Available");
                    else if (i == 3) DrawBar(g, labelW + (int)(colW * 0.8), y + 4, (int)(colW * 3.4), rowH - 8, OliveGold, "Reserved");
                    else if (i == 4) DrawBar(g, labelW + 10, y + 4, (int)(colW * 3.2), rowH - 8, DeepNavy, "Occupied");
                    else if (i == 5) DrawBar(g, labelW + (int)(colW * 1.5), y + 4, (int)(colW * 3.6), rowH - 8, DangerRed, "Maintenance");
                }
            };

            parent.Controls.Add(canvas);
        }

        private void DrawBar(Graphics g, int x, int y, int w, int h, Color color, string text)
        {
            using var brush = new SolidBrush(color);
            using var path = GetRoundedRect(new Rectangle(x, y, w, h), 4);
            g.FillPath(brush, path);
            using var font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            g.DrawString(text, font, Brushes.White, x + (w / 2) - (text.Length * 3), y + (h / 2) - 6);
        }

        private void AddLegend(Panel parent, string text, Color color, int x, int y)
        {
            Panel dot = new Panel
            {
                Size = new Size(10, 10),
                Location = new Point(x, y + 4),
                BackColor = color,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            Label lbl = new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 8F),
                ForeColor = TextMuted,
                Location = new Point(x + 14, y + 1),
                AutoSize = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            parent.Controls.Add(dot);
            parent.Controls.Add(lbl);
        }

        private void BuildOccupancyView(Panel parent, int percent, int inCount, int outCount, int availCount)
        {
            Label lblTitle = new Label
            {
                Text = "Today's Occupancy",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = DeepNavy,
                Location = new Point(16, 12),
                AutoSize = true
            };
            parent.Controls.Add(lblTitle);

            Panel ringCanvas = new Panel
            {
                Location = new Point(14, 42),
                Size = new Size(parent.Width - 28, 96),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            ringCanvas.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                int size = 80;
                Rectangle rect = new Rectangle(6, 6, size, size);

                using var bgPen = new Pen(BorderColor, 10);
                using var activePen = new Pen(OliveGold, 10);
                activePen.StartCap = LineCap.Round;
                activePen.EndCap = LineCap.Round;

                g.DrawArc(bgPen, rect, 0, 360);
                g.DrawArc(activePen, rect, -90, (int)(360 * (percent / 100.0)));

                using var font = new Font("Segoe UI", 13F, FontStyle.Bold);
                using var navyBrush = new SolidBrush(DeepNavy);
                string text = $"{percent}%";
                SizeF tSize = g.MeasureString(text, font);
                g.DrawString(text, font, navyBrush, rect.X + (size / 2) - (tSize.Width / 2), rect.Y + (size / 2) - (tSize.Height / 2));

                int legX = 105;
                DrawLegendItem(g, "Checked In: " + inCount, DeepNavy, legX, 16);
                DrawLegendItem(g, "Checked Out: " + outCount, OliveDark, legX, 38);
                DrawLegendItem(g, "Available: " + availCount, StatusGreen, legX, 60);
            };
            parent.Controls.Add(ringCanvas);

            Label lblWeek = new Label
            {
                Text = "Bookings this week",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = TextMuted,
                Location = new Point(16, 146),
                AutoSize = true
            };
            parent.Controls.Add(lblWeek);

            Panel barCanvas = new Panel
            {
                Location = new Point(16, 170),
                Size = new Size(parent.Width - 32, parent.Height - 178),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            barCanvas.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                string[] days = { "Mo", "Tu", "We", "Th", "Fr", "Sa" };
                int[] vals = { 45, 30, 65, 80, 55, 40 };

                int colW = barCanvas.Width / days.Length;
                int maxH = barCanvas.Height - 26;

                using var barBrush = new SolidBrush(OliveGold);
                using var textBrush = new SolidBrush(TextMuted);
                using var font = new Font("Segoe UI", 8F);

                for (int i = 0; i < days.Length; i++)
                {
                    int barH = (int)(maxH * (vals[i] / 100.0));
                    int x = (i * colW) + (colW / 2) - 8;
                    int y = maxH - barH;

                    using var path = GetRoundedRect(new Rectangle(x, y, 16, barH), 3);
                    g.FillPath(barBrush, path);
                    g.DrawString(days[i], font, textBrush, x - 2, maxH + 4);
                }
            };
            parent.Controls.Add(barCanvas);
        }

        private void DrawLegendItem(Graphics g, string text, Color color, int x, int y)
        {
            using var b = new SolidBrush(color);
            g.FillRectangle(b, x, y + 3, 8, 8);
            using var textBrush = new SolidBrush(TextDark);
            using var font = new Font("Segoe UI", 8.5F);
            g.DrawString(text, font, textBrush, x + 14, y);
        }

        private void BuildActivityGrid(Panel parent)
        {
            Label lblTitle = new Label
            {
                Text = "Live Check-In / Out Activity",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = DeepNavy,
                Location = new Point(16, 14),
                AutoSize = true
            };
            parent.Controls.Add(lblTitle);

            DataGridView dgv = new DataGridView
            {
                Location = new Point(16, 44),
                Size = new Size(parent.Width - 32, parent.Height - 56),
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

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeight = 36;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = DeepNavy;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            dgv.DefaultCellStyle.BackColor = CardBg;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.ForeColor = TextDark;
            dgv.DefaultCellStyle.SelectionBackColor = SelectionTan;
            dgv.DefaultCellStyle.SelectionForeColor = DeepNavy;

            dgv.Columns.Add("GuestId", "Guest ID");
            dgv.Columns.Add("GuestName", "Guest Name");
            dgv.Columns.Add("Room", "Room #");
            dgv.Columns.Add("CheckIn", "Check-in Date");
            dgv.Columns.Add("CheckOut", "Check-out Date");
            dgv.Columns.Add("Total", "Total Amount");
            dgv.Columns.Add("Status", "Status");

            dgv.Rows.Add("1002", "Kyle David", "105", "10/29/2026", "10/30/2026", "PHP 1,500.00", "Checked-In");
            dgv.Rows.Add("4", "John Doe", "104", "10/29/2026", "10/30/2026", "PHP 5,000.00", "Pending");
            dgv.Rows.Add("3", "Kyle David", "104", "10/29/2026", "10/30/2026", "PHP 5,000.00", "Checked-Out");
            dgv.Rows.Add("2", "Gio Cacacx", "106", "10/29/2026", "10/30/2026", "PHP 5,000.00", "Maintenance");

            dgv.CellFormatting += (s, e) =>
            {
                if (dgv.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
                {
                    string val = e.Value.ToString()!;
                    if (val == "Checked-In") e.CellStyle.ForeColor = StatusGreen;
                    else if (val == "Pending") e.CellStyle.ForeColor = OliveDark;
                    else if (val == "Checked-Out") e.CellStyle.ForeColor = TextMuted;
                    else if (val == "Maintenance") e.CellStyle.ForeColor = DangerRed;
                    e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
            };

            parent.Controls.Add(dgv);
        }

        private void BuildQueueView(Panel parent)
        {
            Label lblTitle = new Label
            {
                Text = "Action Queue",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = DeepNavy,
                Location = new Point(16, 14),
                AutoSize = true
            };
            parent.Controls.Add(lblTitle);

            int itemW = parent.Width - 32;
            parent.Controls.Add(CreateQueueCard("Turnover room 103", "Cleaning required • 2 hours ago", 16, 46, itemW));
            parent.Controls.Add(CreateQueueCard("Processing Kyle David", "Check-Out pending • 5 hours ago", 16, 122, itemW));
            parent.Controls.Add(CreateQueueCard("Keycard Reset: Rm 105", "Front Desk Request • 7 hours ago", 16, 198, itemW));
        }

        private Panel CreateQueueCard(string title, string time, int x, int y, int width)
        {
            Panel p = new Panel
            {
                Location = new Point(x, y),
                Size = new Size(width, 64),
                BackColor = Color.FromArgb(248, 249, 251),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            p.Paint += (s, e) =>
            {
                using var pen = new Pen(BorderColor, 1);
                e.Graphics.DrawRectangle(pen, 0, 0, p.Width - 1, p.Height - 1);
            };

            Label lblT = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = DeepNavy,
                Location = new Point(12, 12),
                AutoSize = true
            };

            Label lblTime = new Label
            {
                Text = time,
                Font = new Font("Segoe UI", 8F),
                ForeColor = TextMuted,
                Location = new Point(12, 34),
                AutoSize = true
            };

            p.Controls.Add(lblT);
            p.Controls.Add(lblTime);
            return p;
        }

        private GraphicsPath GetRoundedRect(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle arc = new Rectangle(bounds.Location, new Size(diameter, diameter));

            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }

        // --- Button Click Handlers ---


        private void btnCreateRes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateReservationForm());
        }

        private void btnGuestManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GuestManagementForm());
        }

        private void btnBP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CheckOutForm());
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CheckOutForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Sigurado ka bang nais mong mag-logout?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Hide();
                var loginForm = new LoginForm();
                loginForm.FormClosed += (s, args) => this.Close();
                loginForm.Show();
            }
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            LoadDashboardOverview();
        }
    }
}