using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class CheckOutForm : Form
    {
        private readonly ReservationController _reservationController;
        private List<ReservationModel> _activeStays = new List<ReservationModel>();

        public CheckOutForm()
        {
            InitializeComponent();
            _reservationController = new ReservationController();

            WireUpButtons();
            SetupGridAppearance();
            LoadActiveStays();
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            LoadActiveStays();
        }

        private void WireUpButtons()
        {
            // Recursively search controls to ensure click events are hooked 
            // regardless of whether the designer named them btnProcessDeparture, button1, etc.
            foreach (Control c in this.Controls)
            {
                AttachButtonEvents(c);
            }
        }

        private void AttachButtonEvents(Control parent)
        {
            if (parent is Button btn)
            {
                string text = btn.Text.Trim();
                if (text.Equals("Process Departure", StringComparison.OrdinalIgnoreCase))
                {
                    btn.Click -= HandleProcessDeparture;
                    btn.Click += HandleProcessDeparture;
                }
                else if (text.Equals("Close", StringComparison.OrdinalIgnoreCase))
                {
                    btn.Click -= HandleClose;
                    btn.Click += HandleClose;
                }
            }

            foreach (Control child in parent.Controls)
            {
                AttachButtonEvents(child);
            }
        }

        private void SetupGridAppearance()
        {
            dgvStays.Columns.Clear();
            dgvStays.AutoGenerateColumns = false;
            dgvStays.AllowUserToAddRows = false;
            dgvStays.ReadOnly = true;
            dgvStays.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStays.MultiSelect = false;
            dgvStays.BackgroundColor = Color.White;
            dgvStays.BorderStyle = BorderStyle.FixedSingle;
            dgvStays.RowHeadersVisible = false;
            dgvStays.EnableHeadersVisualStyles = false;
            dgvStays.ColumnHeadersVisible = true;
            dgvStays.ColumnHeadersHeight = 36;

            // InnovaStay Navy Header Styling
            dgvStays.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 26, 40);
            dgvStays.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStays.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvStays.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvStays.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvStays.DefaultCellStyle.SelectionBackColor = Color.FromArgb(184, 172, 102);
            dgvStays.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvStays.RowTemplate.Height = 32;

            // Define Columns
            dgvStays.Columns.Add(new DataGridViewTextBoxColumn { Name = "colResId", HeaderText = "Res #", FillWeight = 50 });
            dgvStays.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGuest", HeaderText = "Guest Name", FillWeight = 130 });
            dgvStays.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRoom", HeaderText = "Room #", FillWeight = 60 });
            dgvStays.Columns.Add(new DataGridViewTextBoxColumn { Name = "colType", HeaderText = "Room Type", FillWeight = 80 });
            dgvStays.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCheckIn", HeaderText = "Check-In", FillWeight = 85 });
            dgvStays.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCheckOut", HeaderText = "Check-Out", FillWeight = 85 });
            dgvStays.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTotal", HeaderText = "Total Amount", FillWeight = 90 });
            dgvStays.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Status", FillWeight = 75 });
            dgvStays.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRoomId", HeaderText = "RoomId", Visible = false });

            dgvStays.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadActiveStays()
        {
            try
            {
                _activeStays = _reservationController.GetActiveStays() ?? new List<ReservationModel>();

                dgvStays.Rows.Clear();

                foreach (var r in _activeStays)
                {
                    dgvStays.Rows.Add(
                        r.ReservationId,
                        string.IsNullOrWhiteSpace(r.GuestName) ? $"Guest #{r.GuestId}" : r.GuestName,
                        r.RoomNumber,
                        r.RoomType,
                        r.CheckInDate.ToString("MM/dd/yyyy"),
                        r.CheckOutDate.ToString("MM/dd/yyyy"),
                        $"PHP {r.TotalAmount:N2}",
                        r.Status,
                        r.RoomId
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading checkouts: {ex.Message}", "Database Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleProcessDeparture(object? sender, EventArgs e)
        {
            if (dgvStays.CurrentRow == null || dgvStays.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select an active guest from the list.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int resId = Convert.ToInt32(dgvStays.CurrentRow.Cells["colResId"].Value);
            int roomId = Convert.ToInt32(dgvStays.CurrentRow.Cells["colRoomId"].Value);
            string guestName = dgvStays.CurrentRow.Cells["colGuest"].Value?.ToString() ?? "Guest";
            string roomNum = dgvStays.CurrentRow.Cells["colRoom"].Value?.ToString() ?? "N/A";
            string total = dgvStays.CurrentRow.Cells["colTotal"].Value?.ToString() ?? "PHP 0.00";

            var confirm = MessageBox.Show(
                $"Confirm check-out for:\n\nGuest: {guestName}\nRoom: {roomNum}\nTotal Bill: {total}\n\nThis will mark the reservation as 'CheckedOut' and return the room to 'Available'.",
                "Confirm Departure",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var result = _reservationController.CheckOutGuest(resId, roomId);
                if (result.Success)
                {
                    MessageBox.Show("Check-out completed successfully! Room is now Available.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadActiveStays();
                }
                else
                {
                    MessageBox.Show($"Check-out failed: {result.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HandleClose(object? sender, EventArgs e)
        {
            // Restore dashboard visibility on the parent form before closing
            if (this.ParentForm is FrontDeskDashboardForm dashboard)
            {
                dashboard.ShowDashboardWorkspace();
            }

            this.Close();
        }
    }
}