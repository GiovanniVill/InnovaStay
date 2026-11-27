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

        // Occupancy stats computed from DB
        private int _occupancyPercent = 0;
        private int _checkedInCount = 0;
        private int _checkedOutToday = 0;
        private int _availableCount = 0;

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

            // Connect Paint event for occupancy ring chart
            pnlRingCanvas.Paint += PnlRingCanvas_Paint;
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

                // 4. Request repaint of occupancy ring
                pnlRingCanvas.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to refresh dashboard data: {ex.Message}", "Database Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            OpenChildForm(new CheckInForm());
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CheckOutForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
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

        private void btnBilling_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BillingForm());
        }
    }
}