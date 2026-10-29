using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class CreateReservationForm : Form
    {
        private readonly GuestController _guestController;
        private readonly RoomController _roomController;
        private readonly ReservationController _reservationController;

        private decimal _selectedRoomRate = 0m;

        public CreateReservationForm()
        {
            InitializeComponent();
            _guestController = new GuestController();
            _roomController = new RoomController();
            _reservationController = new ReservationController();

            this.Load += (s, e) => InitializeReservationForm();

            btnCancel.Click += (s, e) => this.Close();
            btnConfirmReservation.Click += (s, e) => ExecuteReservation();

            cmbRoom.SelectedIndexChanged += cmbRoom_SelectedIndexChanged;
            dtpCheckIn.ValueChanged += dtpCheckIn_ValueChanged;
            dtpCheckOut.ValueChanged += dtpCheckOut_ValueChanged;
        }

        private void InitializeReservationForm()
        {
            dtpCheckIn.Value = DateTime.Today;
            dtpCheckOut.Value = DateTime.Today.AddDays(1);

            LoadGuests();
            LoadAvailableRooms();
            CalculateTotal();
        }

        private void LoadGuests()
        {
            try
            {
                var guests = _guestController.GetAllGuests();
                cmbGuest.DataSource = null;
                cmbGuest.DataSource = guests;

                if (typeof(GuestModel).GetProperty("FullName") != null)
                {
                    cmbGuest.DisplayMember = "FullName";
                }
                else if (typeof(GuestModel).GetProperty("Name") != null)
                {
                    cmbGuest.DisplayMember = "Name";
                }
                else if (typeof(GuestModel).GetProperty("FirstName") != null)
                {
                    cmbGuest.DisplayMember = "FirstName";
                }

                cmbGuest.ValueMember = "GuestId";
                cmbGuest.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading guests: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAvailableRooms()
        {
            try
            {
                var rooms = _roomController.GetAllRooms();
                var availableRooms = rooms != null
                    ? rooms.FindAll(r => string.Equals(r.Status, "Available", StringComparison.OrdinalIgnoreCase))
                    : new List<RoomModel>();

                cmbRoom.DataSource = null;
                cmbRoom.DataSource = availableRooms;
                cmbRoom.DisplayMember = "RoomNumber";
                cmbRoom.ValueMember = "RoomId";
                cmbRoom.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbRoom_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbRoom.SelectedItem is RoomModel room)
            {
                _selectedRoomRate = room.PricePerNight;
            }
            else
            {
                _selectedRoomRate = 0m;
            }

            CalculateTotal();
        }

        private void dtpCheckIn_ValueChanged(object? sender, EventArgs e)
        {
            if (dtpCheckOut.Value <= dtpCheckIn.Value)
            {
                dtpCheckOut.Value = dtpCheckIn.Value.AddDays(1);
            }
            CalculateTotal();
        }

        private void dtpCheckOut_ValueChanged(object? sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            int nights = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days;
            if (nights <= 0) nights = 1;

            decimal total = nights * _selectedRoomRate;
            lblTotalAmount.Text = $"PHP {total:N2} ({nights} {(nights == 1 ? "night" : "nights")})";
        }

        private void ExecuteReservation()
        {
            if (cmbGuest.SelectedValue == null)
            {
                MessageBox.Show("Please select a guest.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRoom.SelectedValue == null)
            {
                MessageBox.Show("Please select a room.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nights = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days;
            if (nights <= 0)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var reservation = new ReservationModel
            {
                GuestId = Convert.ToInt32(cmbGuest.SelectedValue),
                RoomId = Convert.ToInt32(cmbRoom.SelectedValue),
                CheckInDate = dtpCheckIn.Value.Date,
                CheckOutDate = dtpCheckOut.Value.Date,
                TotalAmount = nights * _selectedRoomRate,
                Status = "Confirmed"
            };

            var (success, message) = _reservationController.AddReservation(reservation);
            MessageBox.Show(message, success ? "Success" : "Error", MessageBoxButtons.OK,
                success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (success)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CreateReservationForm_Load(object sender, EventArgs e) => InitializeReservationForm();
        private void CreateReservationForm_Load_1(object sender, EventArgs e) => InitializeReservationForm();
        private void btnConfirmReservation_Click(object sender, EventArgs e) => ExecuteReservation();
        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
        private void btnCancel_Click_1(object sender, EventArgs e) => this.Close();
    }
}