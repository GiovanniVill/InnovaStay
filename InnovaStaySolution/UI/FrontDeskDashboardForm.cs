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
        private readonly ReservationController _reservationController;

        // Cached live data from InnovaStayDB
        private List<RoomModel> _liveRooms = new List<RoomModel>();
        private List<ReservationModel> _liveReservations = new List<ReservationModel>();

        // Occupancy & Weekly stats computed from DB
        private int _occupancyPercent = 0;
        private int _checkedInCount = 0;
        private int _checkedOutToday = 0;
        private int _availableCount = 0;
        private int[] _weeklyBookingsCount = new int[6]; // Mo, Tu, We, Th, Fr, Sa

        // InnovaStay Theme Colors
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
            _reservationController = new ReservationController();

            // Connect Paint events for live charts
            pnlTimelineCanvas.Paint += PnlTimelineCanvas_Paint;
            pnlRingCanvas.Paint += PnlRingCanvas_Paint;
            pnlBarCanvas.Paint += PnlBarCanvas_Paint;
        }

        private void FrontDeskDashboardForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            RefreshAllDatabaseData();
        }

        public void RefreshAllDatabaseData()
        {
            try
            {
                // 1. Fetch Rooms from dbo.tbl_Rooms
                _liveRooms = _roomController.GetAllRooms() ?? new List<RoomModel>();
                int totalRooms = Math.Max(1, _liveRooms.Count);

                _availableCount = _liveRooms.Count(r => string.Equals(r.Status, "Available", StringComparison.OrdinalIgnoreCase));
                _checkedInCount = _liveRooms.Count(r => string.Equals(r.Status, "Occupied", StringComparison.OrdinalIgnoreCase));
                int reservedCount = _liveRooms.Count(r => string.Equals(r.Status, "Reserved", StringComparison.OrdinalIgnoreCase));

                _occupancyPercent = (int)Math.Round(((double)(_checkedInCount + reservedCount) / totalRooms) * 100);

                // 2. Fetch Reservations from dbo.Reservations
                _liveReservations = _reservationController.GetActiveStays() ?? new List<ReservationModel>();

                _checkedOutToday = _liveReservations.Count(r =>
                    string.Equals(r.Status, "Checked-Out", StringComparison.OrdinalIgnoreCase) &&
                    r.CheckOutDate.Date == DateTime.Today);

                // 3. Populate Live Check-In / Out Grid
                dgvActivity.Rows.Clear();
                foreach (var res in _liveReservations)
                {
                    dgvActivity.Rows.Add(
                        res.GuestId.ToString(),
                        string.IsNullOrWhiteSpace(res.GuestName) ? $"Guest #{res.GuestId}" : res.GuestName,
                        res.RoomNumber,
                        res.CheckInDate.ToString("MM/dd/yyyy"),
                        res.CheckOutDate.ToString("MM/dd/yyyy"),
                        $"PHP {res.TotalAmount:N2}",
                        res.Status
                    );
                }

                dgvActivity.CellFormatting -= DgvActivity_CellFormatting;
                dgvActivity.CellFormatting += DgvActivity_CellFormatting;

                // 4. Calculate Weekly Bookings
                ComputeWeeklyDistribution();

                // 5. Update Action Queue with real data
                UpdateLiveActionQueue();

                // 6. Request repaint of dynamic graphics
                pnlTimelineCanvas.Invalidate();
                pnlRingCanvas.Invalidate();
                pnlBarCanvas.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to refresh dashboard data: {ex.Message}", "Database Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ComputeWeeklyDistribution()
        {
            Array.Clear(_weeklyBookingsCount, 0, _weeklyBookingsCount.Length);

            DateTime startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);

            foreach (var res in _liveReservations)
            {
                int dayOffset = (res.CheckInDate.Date - startOfWeek.Date).Days;
                if (dayOffset >= 0 && dayOffset < 6)
                {
                    _weeklyBookingsCount[dayOffset]++;
                }
            }
        }

        private void UpdateLiveActionQueue()
        {
            // Card 1: Check rooms under maintenance
            var maintenanceRoom = _liveRooms.FirstOrDefault(r => string.Equals(r.Status, "Maintenance", StringComparison.OrdinalIgnoreCase));
            if (maintenanceRoom != null)
            {
                lblQ1Title.Text = $"Turnover Room {maintenanceRoom.RoomNumber}";
                lblQ1Time.Text = $"Maintenance active • Room #{maintenanceRoom.RoomNumber}";
            }
            else
            {
                lblQ1Title.Text = "All Rooms Inspected";
                lblQ1Time.Text = "No maintenance alerts";
            }

            // Card 2: Upcoming or overdue check-outs
            var pendingCheckout = _liveReservations.FirstOrDefault(r =>
                string.Equals(r.Status, "Checked-In", StringComparison.OrdinalIgnoreCase) &&
                r.CheckOutDate.Date <= DateTime.Today);

            if (pendingCheckout != null)
            {
                lblQ2Title.Text = $"Processing: {pendingCheckout.GuestName}";
                lblQ2Time.Text = $"Rm {pendingCheckout.RoomNumber} • Check-out scheduled today";
            }
            else
            {
                lblQ2Title.Text = "Check-Out Queue Clear";
                lblQ2Time.Text = "No pending departures";
            }

            // Card 3: Today's pending check-ins
            var pendingCheckIn = _liveReservations.FirstOrDefault(r =>
                string.Equals(r.Status, "Confirmed", StringComparison.OrdinalIgnoreCase) &&
                r.CheckInDate.Date == DateTime.Today);

            if (pendingCheckIn != null)
            {
                lblQ3Title.Text = $"Arrival: {pendingCheckIn.GuestName}";
                lblQ3Time.Text = $"Rm {pendingCheckIn.RoomNumber} • Reserved for today";
            }
            else
            {
                lblQ3Title.Text = "No Pending Arrivals";
                lblQ3Time.Text = "Front Desk schedule clear";
            }
        }

        private void DgvActivity_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvActivity.Columns[e.ColumnIndex].Name == "colStatus" && e.Value != null)
            {
                string val = e.Value.ToString()!;
                if (val.Equals("Checked-In", StringComparison.OrdinalIgnoreCase) || val.Equals("CheckedIn", StringComparison.OrdinalIgnoreCase))
                    e.CellStyle.ForeColor = StatusGreen;
                else if (val.Equals("Pending", StringComparison.OrdinalIgnoreCase) || val.Equals("Confirmed", StringComparison.OrdinalIgnoreCase))
                    e.CellStyle.ForeColor = OliveDark;
                else if (val.Equals("Checked-Out", StringComparison.OrdinalIgnoreCase) || val.Equals("CheckedOut", StringComparison.OrdinalIgnoreCase))
                    e.CellStyle.ForeColor = TextMuted;
                else if (val.Equals("Maintenance", StringComparison.OrdinalIgnoreCase) || val.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
                    e.CellStyle.ForeColor = DangerRed;

                e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
        }

        private void PnlTimelineCanvas_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Display top 6 live rooms from DB or default placeholders
            var roomsToDisplay = _liveRooms.Take(6).ToList();
            if (roomsToDisplay.Count == 0) return;

            // Generate next 6 days starting from today
            DateTime today = DateTime.Today;
            string[] dates = new string[6];
            for (int i = 0; i < 6; i++)
            {
                dates[i] = today.AddDays(i).ToString("MMM dd");
            }

            int rowH = Math.Max(26, (pnlTimelineCanvas.Height - 26) / roomsToDisplay.Count);
            int labelW = 90;
            int chartW = pnlTimelineCanvas.Width - labelW - 10;
            int colW = Math.Max(30, chartW / dates.Length);

            using var linePen = new Pen(BorderColor, 1);
            using var textBrush = new SolidBrush(TextMuted);
            using var roomBrush = new SolidBrush(TextDark);
            using var font = new Font("Segoe UI", 8F);

            // Draw Day Grid Lines & Headers
            for (int i = 0; i < dates.Length; i++)
            {
                int x = labelW + (i * colW);
                g.DrawLine(linePen, x, 0, x, pnlTimelineCanvas.Height);
                g.DrawString(dates[i], font, textBrush, x + (colW / 2) - 18, 4);
            }

            // Draw Rooms & Dynamic Status Bars
            for (int i = 0; i < roomsToDisplay.Count; i++)
            {
                var room = roomsToDisplay[i];
                int y = 26 + (i * rowH);

                g.DrawLine(linePen, 0, y, pnlTimelineCanvas.Width, y);
                g.DrawString($"Room {room.RoomNumber}", font, roomBrush, 8, y + (rowH / 2) - 6);

                string status = room.Status?.Trim() ?? "Available";

                if (status.Equals("Occupied", StringComparison.OrdinalIgnoreCase))
                {
                    DrawBar(g, labelW + 8, y + 4, (int)(colW * 2.8), rowH - 8, DeepNavy, "Occupied");
                }
                else if (status.Equals("Reserved", StringComparison.OrdinalIgnoreCase))
                {
                    DrawBar(g, labelW + (int)(colW * 0.8), y + 4, (int)(colW * 2.5), rowH - 8, OliveGold, "Reserved");
                }
                else if (status.Equals("Maintenance", StringComparison.OrdinalIgnoreCase))
                {
                    DrawBar(g, labelW + 8, y + 4, (int)(colW * 3.2), rowH - 8, DangerRed, "Maintenance");
                }
                else
                {
                    DrawBar(g, labelW + 8, y + 4, (int)(colW * 3.5), rowH - 8, StatusGreen, "Available");
                }
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

            using var bgPen = new Pen(BorderColor, 8);
            using var activePen = new Pen(OliveGold, 8);
            activePen.StartCap = LineCap.Round;
            activePen.EndCap = LineCap.Round;

            g.DrawArc(bgPen, rect, 0, 360);
            g.DrawArc(activePen, rect, -90, (int)(360 * (_occupancyPercent / 100.0)));

            using var font = new Font("Segoe UI", 12F, FontStyle.Bold);
            using var navyBrush = new SolidBrush(DeepNavy);
            string text = $"{_occupancyPercent}%";
            SizeF tSize = g.MeasureString(text, font);
            g.DrawString(text, font, navyBrush, rect.X + (size / 2) - (tSize.Width / 2), rect.Y + (size / 2) - (tSize.Height / 2));

            int legX = 100;
            DrawLegendItem(g, $"Occupied: {_checkedInCount}", DeepNavy, legX, 10);
            DrawLegendItem(g, $"Checked Out: {_checkedOutToday}", OliveDark, legX, 34);
            DrawLegendItem(g, $"Available: {_availableCount}", StatusGreen, legX, 58);
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
            int maxVal = Math.Max(1, _weeklyBookingsCount.Max());

            int colW = Math.Max(20, pnlBarCanvas.Width / days.Length);
            int maxH = Math.Max(40, pnlBarCanvas.Height - 24);

            using var barBrush = new SolidBrush(OliveGold);
            using var textBrush = new SolidBrush(TextMuted);
            using var font = new Font("Segoe UI", 8F);

            for (int i = 0; i < days.Length; i++)
            {
                int count = _weeklyBookingsCount[i];
                int barH = count > 0 ? (int)(maxH * ((double)count / maxVal)) : 4; // minimum 4px height indicator
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
            RefreshAllDatabaseData();
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
        public void ShowDashboardWorkspace()
        {
            if (activeForm != null)
            {
                var temp = activeForm;
                activeForm = null;
                temp.Close();
            }

            pnlDashboardWorkspace.Visible = true;
            pnlDashboardWorkspace.BringToFront();
            RefreshAllDatabaseData();
        }
    }
}