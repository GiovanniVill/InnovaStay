using System;
using System.Drawing;
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

        // InnovaStay Theme Colors
        private readonly Color OliveGold = Color.FromArgb(184, 172, 102);
        private readonly Color OliveHover = Color.FromArgb(160, 150, 85);
        private readonly Color DarkNavy = Color.FromArgb(20, 26, 40);
        private readonly Color BorderGray = Color.FromArgb(220, 224, 230);
        private readonly Color CardBg = Color.White;
        private readonly Color FormBg = Color.FromArgb(248, 249, 250);

        public CreateReservationForm()
        {
            InitializeComponent();
            _guestController = new GuestController();
            _roomController = new RoomController();
            _reservationController = new ReservationController();

            ApplyModernTheme();
        }

        private void ApplyModernTheme()
        {
            this.BackColor = FormBg;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // Container card centered within the panel
            var cardPanel = new Panel
            {
                Name = "pnlCard",
                BackColor = CardBg,
                Size = new Size(620, 480),
                Location = new Point((this.ClientSize.Width - 620) / 2, Math.Max(20, (this.ClientSize.Height - 480) / 2)),
                Anchor = AnchorStyles.None
            };

            // Subtle border
            cardPanel.Paint += (s, e) =>
            {
                using (var pen = new Pen(BorderGray, 1))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, cardPanel.Width - 1, cardPanel.Height - 1);
                }
            };

            // Card Header Title
            var lblTitle = new Label
            {
                Text = "NEW RESERVATION",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = OliveGold,
                Location = new Point(35, 25),
                AutoSize = true
            };

            var lblSubtitle = new Label
            {
                Text = "Select guest and dates to verify and assign available rooms.",
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = Color.FromArgb(120, 125, 135),
                Location = new Point(36, 55),
                AutoSize = true
            };

            int labelX = 35;
            int inputX = 180;
            int inputWidth = 380;

            // 1. Guest Selection
            label3.Text = "Guest Selection:";
            label3.Location = new Point(labelX, 105);
            label3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label3.ForeColor = DarkNavy;
            label3.AutoSize = true;

            cmbGuest.Location = new Point(inputX, 102);
            cmbGuest.Width = inputWidth;
            cmbGuest.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGuest.FlatStyle = FlatStyle.Flat;

            // 2. Room Selection
            label4.Text = "Room Selection:";
            label4.Location = new Point(labelX, 155);
            label4.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label4.ForeColor = DarkNavy;
            label4.AutoSize = true;

            cmbRoom.Location = new Point(inputX, 152);
            cmbRoom.Width = inputWidth;
            cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoom.FlatStyle = FlatStyle.Flat;

            // 3. Check-In Date
            label5.Text = "Check-In Date:";
            label5.Location = new Point(labelX, 205);
            label5.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label5.ForeColor = DarkNavy;
            label5.AutoSize = true;

            dtpCheckIn.Location = new Point(inputX, 202);
            dtpCheckIn.Width = inputWidth;
            dtpCheckIn.Font = new Font("Segoe UI", 9.5F);

            // 4. Check-Out Date
            label6.Text = "Check-Out Date:";
            label6.Location = new Point(labelX, 255);
            label6.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label6.ForeColor = DarkNavy;
            label6.AutoSize = true;

            dtpCheckOut.Location = new Point(inputX, 252);
            dtpCheckOut.Width = inputWidth;
            dtpCheckOut.Font = new Font("Segoe UI", 9.5F);

            // 5. Total Calculation
            label1.Text = "Calculated Total:";
            label1.Location = new Point(labelX, 305);
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label1.ForeColor = DarkNavy;
            label1.AutoSize = true;

            lblTotalAmount.Text = "PHP 0.00";
            lblTotalAmount.Location = new Point(inputX, 303);
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalAmount.ForeColor = OliveGold;
            lblTotalAmount.AutoSize = true;

            // 6. Action Buttons
            btnConfirmReservation.Text = "Reserve Room";
            btnConfirmReservation.Location = new Point(inputX + inputWidth - 160, 375);
            btnConfirmReservation.Size = new Size(160, 42);
            btnConfirmReservation.FlatStyle = FlatStyle.Flat;
            btnConfirmReservation.FlatAppearance.BorderSize = 0;
            btnConfirmReservation.BackColor = OliveGold;
            btnConfirmReservation.ForeColor = Color.White;
            btnConfirmReservation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirmReservation.Cursor = Cursors.Hand;
            btnConfirmReservation.MouseEnter += (s, e) => btnConfirmReservation.BackColor = OliveHover;
            btnConfirmReservation.MouseLeave += (s, e) => btnConfirmReservation.BackColor = OliveGold;

            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(inputX + inputWidth - 280, 375);
            btnCancel.Size = new Size(110, 42);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderColor = BorderGray;
            btnCancel.FlatAppearance.BorderSize = 1;
            btnCancel.BackColor = Color.White;
            btnCancel.ForeColor = Color.FromArgb(100, 105, 115);
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.MouseEnter += (s, e) => btnCancel.BackColor = Color.FromArgb(245, 245, 245);
            btnCancel.MouseLeave += (s, e) => btnCancel.BackColor = Color.White;

            // Assemble controls into the card
            cardPanel.Controls.Add(lblTitle);
            cardPanel.Controls.Add(lblSubtitle);
            cardPanel.Controls.Add(label3);
            cardPanel.Controls.Add(cmbGuest);
            cardPanel.Controls.Add(label4);
            cardPanel.Controls.Add(cmbRoom);
            cardPanel.Controls.Add(label5);
            cardPanel.Controls.Add(dtpCheckIn);
            cardPanel.Controls.Add(label6);
            cardPanel.Controls.Add(dtpCheckOut);
            cardPanel.Controls.Add(label1);
            cardPanel.Controls.Add(lblTotalAmount);
            cardPanel.Controls.Add(btnCancel);
            cardPanel.Controls.Add(btnConfirmReservation);

            this.Controls.Clear();
            this.Controls.Add(cardPanel);

            // Re-center card dynamically when embedded or resized
            this.Resize += (s, e) =>
            {
                cardPanel.Location = new Point(
                    Math.Max(20, (this.ClientSize.Width - cardPanel.Width) / 2),
                    Math.Max(20, (this.ClientSize.Height - cardPanel.Height) / 2)
                );
            };
        }

        private void CreateReservationForm_Load_1(object sender, EventArgs e)
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
                var availableRooms = _roomController.GetAvailableRoomsByDates(dtpCheckIn.Value.Date, dtpCheckOut.Value.Date);

                cmbRoom.DataSource = null;
                cmbRoom.DataSource = availableRooms;
                cmbRoom.DisplayMember = "RoomNumber";
                cmbRoom.ValueMember = "RoomId";
                cmbRoom.SelectedIndex = -1;
                _selectedRoomRate = 0m;
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
            LoadAvailableRooms();
            CalculateTotal();
        }

        private void dtpCheckOut_ValueChanged(object? sender, EventArgs e)
        {
            LoadAvailableRooms();
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            int nights = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days;
            if (nights <= 0) nights = 1;

            decimal total = nights * _selectedRoomRate;
            lblTotalAmount.Text = $"PHP {total:N2}  ({nights} {(nights == 1 ? "night" : "nights")})";
        }

        private void btnConfirmReservation_Click(object sender, EventArgs e)
        {
            if (cmbGuest.SelectedValue == null)
            {
                MessageBox.Show("Please select a guest.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRoom.SelectedValue == null)
            {
                MessageBox.Show("Please select an available room.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}