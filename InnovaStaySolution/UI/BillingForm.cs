using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class BillingForm : Form
    {
        private readonly CultureInfo _phpCulture = new CultureInfo("en-PH");
        private readonly Random _random = new Random();
        private readonly List<ReceiptData> _activeStays = new List<ReceiptData>();
        private readonly ReservationController _reservationController = new ReservationController();
        private readonly RoomController _roomController = new RoomController();
        private ReceiptData? _currentStay;

        public BillingForm()
        {
            InitializeComponent();
            InitializeFormEvents();
            LoadLiveActiveStays();
            PopulatePaymentMethods();
            RefreshBillingUI();
        }

        private void InitializeFormEvents()
        {
            if (Controls.Find("btnAcceptPayment", true).FirstOrDefault() is Button acceptBtn)
            {
                acceptBtn.Click -= BtnPay_Click;
                acceptBtn.Click += BtnPay_Click;
            }

            if (Controls.Find("btnPay", true).FirstOrDefault() is Button payBtn)
            {
                payBtn.Click -= BtnPay_Click;
                payBtn.Click += BtnPay_Click;
            }

            if (Controls.Find("btnAddCharge", true).FirstOrDefault() is Button addChargeBtn)
            {
                addChargeBtn.Click -= BtnAddCharge_Click;
                addChargeBtn.Click += BtnAddCharge_Click;
            }

            if (Controls.Find("btnClose", true).FirstOrDefault() is Button closeBtn)
            {
                closeBtn.Click -= CloseForm_Click;
                closeBtn.Click += CloseForm_Click;
            }
        }

        private void CloseForm_Click(object? sender, EventArgs e) => Close();

        private void PopulatePaymentMethods()
        {
            cmbPaymentMethod.Items.Clear();
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "GCash", "Bank Transfer" });
            cmbPaymentMethod.SelectedIndex = 0;
        }

        private string GenerateReceiptNumber()
        {
            string stamp = DateTime.Now.ToString("yyyyMMdd-HHmmss");
            int code;
            lock (_random)
            {
                code = _random.Next(1000, 9999);
            }
            return $"RCP-{stamp}-{code}";
        }

        private void CalculateTotals(ReceiptData stay)
        {
            int nights = Math.Max(1, stay.Nights);
            int rooms = Math.Max(1, stay.NumberOfRooms);
            int extraBeds = Math.Max(0, stay.NumberOfExtraBeds);
            decimal roomRate = Math.Max(0m, stay.RoomRatePerNight);
            decimal bedRate = Math.Max(0m, stay.ExtraBedRatePerNight);

            stay.RoomSubtotal = Math.Round(roomRate * nights * rooms, 2);

            decimal itemsSum = stay.ExtraCharges?.Sum(c => Math.Max(0m, c.Amount)) ?? 0m;
            decimal bedsSum = extraBeds * bedRate * nights;
            stay.ExtraChargesTotal = Math.Round(bedsSum + itemsSum, 2);

            stay.GrandTotal = Math.Round(stay.RoomSubtotal + stay.ExtraChargesTotal, 2);

            decimal tenderedRef = stay.AmountTendered > 0m ? stay.AmountTendered : stay.TotalPaid;
            stay.ChangeDue = tenderedRef > stay.GrandTotal
                ? Math.Round(tenderedRef - stay.GrandTotal, 2)
                : 0m;

            stay.BalanceRemaining = Math.Round(Math.Max(0m, stay.GrandTotal - stay.TotalPaid), 2);
        }

        private void LoadLiveActiveStays()
        {
            _activeStays.Clear();

            try
            {
                var rooms = _roomController.GetAllRooms() ?? new List<RoomModel>();
                var reservations = _reservationController.GetActiveStays() ?? new List<ReservationModel>();

                var validStays = reservations
                    .Where(r => string.Equals(r.Status, "Checked-In", StringComparison.OrdinalIgnoreCase)
                             || string.Equals(r.Status, "CheckedIn", StringComparison.OrdinalIgnoreCase)
                             || string.Equals(r.Status, "Confirmed", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                foreach (var res in validStays)
                {
                    int nights = Math.Max(1, (res.CheckOutDate.Date - res.CheckInDate.Date).Days);
                    var matchedRoom = rooms.FirstOrDefault(rm =>
                        string.Equals(rm.RoomNumber, res.RoomNumber, StringComparison.OrdinalIgnoreCase));

                    decimal ratePerNight = matchedRoom != null && matchedRoom.PricePerNight > 0m
                        ? matchedRoom.PricePerNight
                        : Math.Round(res.TotalAmount / nights, 2);

                    string roomLabel = matchedRoom != null && !string.IsNullOrWhiteSpace(matchedRoom.RoomType)
                        ? $"{matchedRoom.RoomType} - Room {res.RoomNumber}"
                        : $"Room {res.RoomNumber}";

                    var stay = new ReceiptData
                    {
                        GuestName = string.IsNullOrWhiteSpace(res.GuestName) ? $"Guest #{res.GuestId}" : res.GuestName,
                        BillingAddress = "Nasugbu, Batangas",
                        HotelName = "InnovaStay Hotel",
                        RoomType = roomLabel,
                        CheckInDate = res.CheckInDate,
                        CheckOutDate = res.CheckOutDate,
                        Nights = nights,
                        NumberOfRooms = 1,
                        RoomRatePerNight = ratePerNight,
                        NumberOfExtraBeds = 0,
                        ExtraBedRatePerNight = 0m,
                        ExtraCharges = new List<ChargeItem>(),
                        PaymentMethod = "Cash"
                    };

                    CalculateTotals(stay);
                    _activeStays.Add(stay);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load active stays from database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cmbActiveStays.SelectedIndexChanged -= cmbActiveStays_SelectedIndexChanged;
            cmbActiveStays.DataSource = null;
            cmbActiveStays.Items.Clear();

            if (_activeStays.Count > 0)
            {
                cmbActiveStays.DisplayMember = nameof(ReceiptData.GuestName);
                cmbActiveStays.DataSource = _activeStays;
                cmbActiveStays.SelectedIndex = 0;
                _currentStay = _activeStays[0];
            }
            else
            {
                _currentStay = null;
            }

            cmbActiveStays.SelectedIndexChanged += cmbActiveStays_SelectedIndexChanged;
        }

        private void cmbActiveStays_SelectedIndexChanged(object? sender, EventArgs e)
        {
            _currentStay = cmbActiveStays.SelectedItem as ReceiptData;
            RefreshBillingUI();
        }

        private void BtnAddCharge_Click(object? sender, EventArgs e)
        {
            if (_currentStay == null) return;

            string desc = txtChargeDesc.Text.Trim();
            if (string.IsNullOrWhiteSpace(desc))
            {
                MessageBox.Show("Please enter a charge description.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChargeDesc.Focus();
                return;
            }

            if ((!decimal.TryParse(txtChargeAmount.Text.Trim(), NumberStyles.Currency, _phpCulture, out decimal amount)
                && !decimal.TryParse(txtChargeAmount.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out amount))
                || amount <= 0m)
            {
                MessageBox.Show("Please enter a valid positive charge amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChargeAmount.Focus();
                return;
            }

            _currentStay.ExtraCharges.Add(new ChargeItem
            {
                Description = desc,
                Amount = Math.Round(amount, 2),
                Date = DateTime.Now
            });

            CalculateTotals(_currentStay);
            txtChargeDesc.Clear();
            txtChargeAmount.Clear();
            RefreshBillingUI();
        }

        private void BtnPay_Click(object? sender, EventArgs e)
        {
            if (_currentStay == null)
            {
                MessageBox.Show("Please select an active stay first.", "No Stay Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((!decimal.TryParse(txtPaymentAmount.Text.Trim(), NumberStyles.Currency, _phpCulture, out decimal tendered)
                && !decimal.TryParse(txtPaymentAmount.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out tendered))
                || tendered <= 0m)
            {
                MessageBox.Show("Please enter a valid payment amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPaymentAmount.Focus();
                return;
            }

            _currentStay.PaymentMethod = cmbPaymentMethod.SelectedItem?.ToString() ?? "Cash";
            _currentStay.AmountTendered = Math.Round(tendered, 2);
            _currentStay.TotalPaid = Math.Round(_currentStay.TotalPaid + tendered, 2);
            _currentStay.IssuedDate = DateTime.Now;

            if (string.IsNullOrWhiteSpace(_currentStay.ReceiptNumber))
            {
                _currentStay.ReceiptNumber = GenerateReceiptNumber();
            }

            CalculateTotals(_currentStay);
            RefreshBillingUI();

            using (var receiptForm = new Reciept(_currentStay))
            {
                receiptForm.ShowDialog(this);
            }
        }

        private void RefreshBillingUI()
        {
            dgvCharges.Rows.Clear();

            if (_currentStay == null)
            {
                lblGuestInfo.Text = "Guest: No active stays";
                lblRoomRate.Text = $"Room Charges: {0m.ToString("C2", _phpCulture)}";
                lblTotalCharges.Text = $"Extra Charges: {0m.ToString("C2", _phpCulture)}";
                lblTotalPaid.Text = $"Paid: {0m.ToString("C2", _phpCulture)}";
                lblBalanceDue.Text = $"Balance Due: {0m.ToString("C2", _phpCulture)}";
                txtPaymentAmount.Clear();
                return;
            }

            CalculateTotals(_currentStay);

            lblGuestInfo.Text = $"Guest: {_currentStay.GuestName} ({_currentStay.RoomType}, {_currentStay.Nights}n)";
            lblRoomRate.Text = $"Room Charges: {_currentStay.RoomSubtotal.ToString("C2", _phpCulture)}";
            lblTotalCharges.Text = $"Extra Charges: {_currentStay.ExtraChargesTotal.ToString("C2", _phpCulture)}";
            lblTotalPaid.Text = $"Paid: {_currentStay.TotalPaid.ToString("C2", _phpCulture)}";
            txtPaymentAmount.Text = _currentStay.BalanceRemaining.ToString("N2");

            string changeText = _currentStay.ChangeDue > 0m
                ? $" | Change: {_currentStay.ChangeDue.ToString("C2", _phpCulture)}"
                : string.Empty;

            lblBalanceDue.Text = $"Balance Due: {_currentStay.BalanceRemaining.ToString("C2", _phpCulture)}{changeText}";

            foreach (var item in _currentStay.ExtraCharges)
            {
                dgvCharges.Rows.Add(
                    item.Description,
                    item.Amount.ToString("C2", _phpCulture),
                    item.Date.ToString("yyyy-MM-dd HH:mm"));
            }
        }
    }
}