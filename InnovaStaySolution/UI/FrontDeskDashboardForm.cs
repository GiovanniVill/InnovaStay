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
    public partial class FrontDeskDashboardForm : Form
    {
        private Form? activeForm = null;
        private readonly RoomController _roomController;

        // InnovaStay Unified Palette
        private readonly Color DeepNavy = Color.FromArgb(20, 26, 40);
        private readonly Color OliveGold = Color.FromArgb(184, 172, 102);
        private readonly Color OliveDark = Color.FromArgb(145, 134, 75);
        private readonly Color BorderColor = Color.FromArgb(228, 231, 236);
        private readonly Color TextDark = Color.FromArgb(28, 34, 46);
        private readonly Color TextMuted = Color.FromArgb(115, 122, 134);
        private readonly Color StatusGreen = Color.FromArgb(46, 125, 50);
        private readonly Color DangerRed = Color.FromArgb(220, 53, 69);

        public FrontDeskDashboardForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            _roomController = new RoomController();

            pnlTimelineCanvas.Paint += PnlTimelineCanvas_Paint;
            pnlRingCanvas.Paint += PnlRingCanvas_Paint;
            pnlBarCanvas.Paint += PnlBarCanvas_Paint;
        }

        private void FrontDeskDashboardForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadMockData();
            pnlTimelineCanvas.Invalidate();
            pnlRingCanvas.Invalidate();
            pnlBarCanvas.Invalidate();
        }

        private void LoadMockData()
        {
            if (dgvActivity.Rows.Count == 0)
            {
                dgvActivity.Rows.Add("1002", "Kyle David", "105", "10/29/2026", "10/30/2026", "PHP 1,500.00", "Checked-In");
                dgvActivity.Rows.Add("4", "John Doe", "104", "10/29/2026", "10/30/2026", "PHP 5,000.00", "Pending");
                dgvActivity.Rows.Add("3", "Kyle David", "104", "10/29/2026", "10/30/2026", "PHP 5,000.00", "Checked-Out");
                dgvActivity.Rows.Add("2", "Gio Cacacx", "106", "10/29/2026", "10/30/2026", "PHP 5,000.00", "Maintenance");
            }

            dgvActivity.CellFormatting -= DgvActivity_CellFormatting;
            dgvActivity.CellFormatting += DgvActivity_CellFormatting;
        }

        private void DgvActivity_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvActivity.Columns[e.ColumnIndex].Name == "colStatus" && e.Value != null)
            {
                string val = e.Value.ToString()!;
                if (val == "Checked-In") e.CellStyle.ForeColor = StatusGreen;
                else if (val == "Pending") e.CellStyle.ForeColor = OliveDark;
                else if (val == "Checked-Out") e.CellStyle.ForeColor = TextMuted;
                else if (val == "Maintenance") e.CellStyle.ForeColor = DangerRed;
                e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
        }

        private void PnlTimelineCanvas_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var rooms = _roomController.GetAllRooms() ?? new List<RoomModel>();
            string[] displayRooms = rooms.Count > 0
                ? rooms.Take(6).Select(r => $"Room {r.RoomNumber}").ToArray()
                : new[] { "Room 101", "Room 102", "Room 103", "Room 104", "Room 105", "Room 106" };

            string[] dates = { "Oct 29", "Oct 30", "Oct 31", "Nov 1", "Nov 3", "Nov 5" };

            int rowH = Math.Max(26, (pnlTimelineCanvas.Height - 26) / displayRooms.Length);
            int labelW = 85;
            int chartW = pnlTimelineCanvas.Width - labelW - 10;
            int colW = Math.Max(30, chartW / dates.Length);

            using var linePen = new Pen(BorderColor, 1);
            using var textBrush = new SolidBrush(TextMuted);
            using var roomBrush = new SolidBrush(TextDark);
            using var font = new Font("Segoe UI", 8F);

            for (int i = 0; i < dates.Length; i++)
            {
                int x = labelW + (i * colW);
                g.DrawLine(linePen, x, 0, x, pnlTimelineCanvas.Height);
                g.DrawString(dates[i], font, textBrush, x + (colW / 2) - 18, 4);
            }

            for (int i = 0; i < displayRooms.Length; i++)
            {
                int y = 26 + (i * rowH);
                g.DrawLine(linePen, 0, y, pnlTimelineCanvas.Width, y);
                g.DrawString(displayRooms[i], font, roomBrush, 8, y + (rowH / 2) - 6);

                if (i == 0) DrawBar(g, labelW + (int)(colW * 1.8), y + 4, (int)(colW * 2.8), rowH - 8, DeepNavy, "Occupied");
                else if (i == 1) DrawBar(g, labelW + (int)(colW * 0.8), y + 4, (int)(colW * 2.6), rowH - 8, StatusGreen, "Available");
                else if (i == 3) DrawBar(g, labelW + (int)(colW * 0.8), y + 4, (int)(colW * 3.4), rowH - 8, OliveGold, "Reserved");
                else if (i == 4) DrawBar(g, labelW + 10, y + 4, (int)(colW * 3.2), rowH - 8, DeepNavy, "Occupied");
                else if (i == 5) DrawBar(g, labelW + (int)(colW * 1.5), y + 4, (int)(colW * 3.6), rowH - 8, DangerRed, "Maintenance");
            }
        }

        private void DrawBar(Graphics g, int x, int y, int w, int h, Color color, string text)
        {
            using var brush = new SolidBrush(color);
            using var path = GetRoundedRect(new Rectangle(x, y, w, h), 4);
            g.FillPath(brush, path);
            using var font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            g.DrawString(text, font, Brushes.White, x + (w / 2) - (text.Length * 3), y + (h / 2) - 6);
        }

        private void PnlRingCanvas_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int size = 76;
            Rectangle rect = new Rectangle(6, 6, size, size);
            int percent = 78;

            using var bgPen = new Pen(BorderColor, 8);
            using var activePen = new Pen(OliveGold, 8);
            activePen.StartCap = LineCap.Round;
            activePen.EndCap = LineCap.Round;

            g.DrawArc(bgPen, rect, 0, 360);
            g.DrawArc(activePen, rect, -90, (int)(360 * (percent / 100.0)));

            using var font = new Font("Segoe UI", 12F, FontStyle.Bold);
            using var navyBrush = new SolidBrush(DeepNavy);
            string text = $"{percent}%";
            SizeF tSize = g.MeasureString(text, font);
            g.DrawString(text, font, navyBrush, rect.X + (size / 2) - (tSize.Width / 2), rect.Y + (size / 2) - (tSize.Height / 2));

            int legX = 100;
            DrawLegendItem(g, "Checked In: 12", DeepNavy, legX, 10);
            DrawLegendItem(g, "Checked Out: 3", OliveDark, legX, 34);
            DrawLegendItem(g, "Available: 8", StatusGreen, legX, 58);
        }

        private void DrawLegendItem(Graphics g, string text, Color color, int x, int y)
        {
            using var b = new SolidBrush(color);
            g.FillRectangle(b, x, y + 3, 8, 8);
            using var textBrush = new SolidBrush(TextDark);
            using var font = new Font("Segoe UI", 8.5F);
            g.DrawString(text, font, textBrush, x + 14, y);
        }

        private void PnlBarCanvas_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            string[] days = { "Mo", "Tu", "We", "Th", "Fr", "Sa" };
            int[] vals = { 45, 30, 65, 80, 55, 40 };

            int colW = Math.Max(20, pnlBarCanvas.Width / days.Length);
            int maxH = Math.Max(40, pnlBarCanvas.Height - 24);

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

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                var temp = activeForm;
                activeForm = null;
                temp.Close();
            }

            pnlDashboardWorkspace.Visible = false;

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMainContent.Controls.Add(childForm);
            panelMainContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // --- Sidebar Button Handlers ---

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                var temp = activeForm;
                activeForm = null;
                temp.Close();
            }

            pnlDashboardWorkspace.Visible = true;
            pnlDashboardWorkspace.BringToFront();
            pnlTimelineCanvas.Invalidate();
            pnlRingCanvas.Invalidate();
            pnlBarCanvas.Invalidate();
        }

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

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GuestInfo());
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
                UserSession.Clear();
                this.Hide();
                var loginForm = new LoginForm();
                loginForm.FormClosed += (s, args) => this.Close();
                loginForm.Show();
            }
        }
    }
}