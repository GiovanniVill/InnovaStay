using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class CheckOutForm : Form
    {
        private readonly ReservationController _reservationController;
        private readonly RoomController _roomController;
        private readonly GuestController _guestController;

        private List<ReservationModel> _activeReservations = new();

        public CheckOutForm()
        {
            InitializeComponent();
            _reservationController = new ReservationController();
            _roomController = new RoomController();
            _guestController = new GuestController();

            this.Load += (s, e) => LoadCheckOutList();
            btnConfirmCheckOut.Click += (s, e) => ProcessCheckOutAction();
            btnClose.Click += (s, e) => this.Close();
        }

        private void LoadCheckOutList()
        {
            try
            {
                _activeReservations = _reservationController.GetActiveStays();
                var allRooms = _roomController.GetAllRooms();
                var allGuests = _guestController.GetAllGuests();

                // Enrich with Room and Guest details for display
                foreach (var res in _activeReservations)
                {
                    var room = allRooms.Find(r => r.RoomId == res.RoomId);
                    if (room != null)
                    {
                        res.RoomNumber = room.RoomNumber ?? string.Empty;
                        res.RoomType = room.RoomType ?? string.Empty;
                    }

                    var guest = allGuests.Find(g => g.GuestId == res.GuestId);
                    if (guest != null)
                    {
                        var prop = guest.GetType().GetProperty("FullName")
                                   ?? guest.GetType().GetProperty("FirstName")
                                   ?? guest.GetType().GetProperty("Name");
                        res.GuestName = prop?.GetValue(guest)?.ToString() ?? $"Guest #{res.GuestId}";
                    }
                }

                dgvStays.DataSource = null;
                dgvStays.DataSource = _activeReservations;

                if (dgvStays.Columns["ReservationId"] != null) dgvStays.Columns["ReservationId"].HeaderText = "Res #";
                if (dgvStays.Columns["GuestName"] != null) dgvStays.Columns["GuestName"].HeaderText = "Guest";
                if (dgvStays.Columns["RoomNumber"] != null) dgvStays.Columns["RoomNumber"].HeaderText = "Room #";
                if (dgvStays.Columns["RoomType"] != null) dgvStays.Columns["RoomType"].HeaderText = "Type";
                if (dgvStays.Columns["CheckInDate"] != null) dgvStays.Columns["CheckInDate"].HeaderText = "Check-In";
                if (dgvStays.Columns["CheckOutDate"] != null) dgvStays.Columns["CheckOutDate"].HeaderText = "Check-Out";
                if (dgvStays.Columns["TotalAmount"] != null)
                {
                    dgvStays.Columns["TotalAmount"].HeaderText = "Total";
                    dgvStays.Columns["TotalAmount"].DefaultCellStyle.Format = "N2";
                }
                if (dgvStays.Columns["Status"] != null) dgvStays.Columns["Status"].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading active stays: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessCheckOutAction()
        {
            if (dgvStays.CurrentRow == null || !(dgvStays.CurrentRow.DataBoundItem is ReservationModel selectedStay))
            {
                MessageBox.Show("Please select an active stay from the list to check out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show(
                $"Are you sure you want to process check-out for Room {selectedStay.RoomNumber} ({selectedStay.GuestName})?",
                "Confirm Check-Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                var (success, message) = _reservationController.CheckOutGuest(selectedStay.ReservationId, selectedStay.RoomId);
                MessageBox.Show(message, success ? "Success" : "Error", MessageBoxButtons.OK,
                    success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (success)
                {
                    this.DialogResult = DialogResult.OK;
                    LoadCheckOutList();
                }
            }
        }
    }
}