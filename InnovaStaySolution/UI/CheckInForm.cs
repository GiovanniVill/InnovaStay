using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class CheckInForm : Form
    {
        private readonly ReservationController _reservationController;
        private List<ReservationModel> _pendingReservations = new List<ReservationModel>();

        public CheckInForm()
        {
            InitializeComponent();
            _reservationController = new ReservationController();
        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {
            LoadPendingCheckIns();
        }

        private void LoadPendingCheckIns()
        {
            try
            {
                _pendingReservations = _reservationController.GetPendingCheckIns() ?? new List<ReservationModel>();
                dgvCheckIn.Rows.Clear();

                foreach (var r in _pendingReservations)
                {
                    dgvCheckIn.Rows.Add(
                        r.ReservationId,
                        r.GuestName,
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
                MessageBox.Show($"Unable to load pending check-ins: {ex.Message}", "Database Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmCheckIn_Click(object sender, EventArgs e)
        {
            if (dgvCheckIn.CurrentRow == null || dgvCheckIn.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a reservation to check in.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int resId = Convert.ToInt32(dgvCheckIn.CurrentRow.Cells["colResId"].Value);
            int roomId = Convert.ToInt32(dgvCheckIn.CurrentRow.Cells["colRoomId"].Value);
            string guestName = dgvCheckIn.CurrentRow.Cells["colGuest"].Value?.ToString() ?? "Guest";
            string roomNum = dgvCheckIn.CurrentRow.Cells["colRoom"].Value?.ToString() ?? "N/A";

            var confirm = MessageBox.Show(
                $"Confirm check-in for:\n\nGuest: {guestName}\nRoom: {roomNum}\n\nThis will mark the reservation as 'Checked-In' and set the room to 'Occupied'.",
                "Confirm Check-In",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var result = _reservationController.CheckInGuest(resId, roomId);
                if (result.Success)
                {
                    MessageBox.Show("Guest successfully checked in! Room is now marked as Occupied.", "Check-In Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPendingCheckIns();
                }
                else
                {
                    MessageBox.Show($"Check-in failed: {result.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is FrontDeskDashboardForm dashboard)
            {
                dashboard.ShowDashboardWorkspace();
            }

            this.Close();
        }
    }
}