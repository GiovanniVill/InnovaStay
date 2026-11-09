using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class BillingForm : Form
    {
        private readonly ReservationController _reservationController;
        private readonly BillingController _billingController;
        private List<ReservationModel> _activeStays = new List<ReservationModel>();

        public BillingForm()
        {
            InitializeComponent();
            _reservationController = new ReservationController();
            _billingController = new BillingController();
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            if (cmbPaymentMethod.Items.Count > 0)
            {
                cmbPaymentMethod.SelectedIndex = 0;
            }

            LoadActiveStays();
        }

        private void LoadActiveStays()
        {
            try
            {
                _activeStays = _reservationController.GetActiveStays() ?? new List<ReservationModel>();
                cmbActiveStays.Items.Clear();

                foreach (var r in _activeStays)
                {
                    cmbActiveStays.Items.Add($"Res #{r.ReservationId} - {r.GuestName} (Rm {r.RoomNumber})");
                }

                if (cmbActiveStays.Items.Count > 0)
                {
                    cmbActiveStays.SelectedIndex = 0;
                }
                else
                {
                    ResetSummary();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load active stays: {ex.Message}", "Database Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ReservationModel? GetSelectedReservation()
        {
            if (cmbActiveStays.SelectedIndex < 0 || cmbActiveStays.SelectedIndex >= _activeStays.Count)
                return null;
            return _activeStays[cmbActiveStays.SelectedIndex];
        }

        private void RefreshBillingSummary()
        {
            var res = GetSelectedReservation();
            if (res == null)
            {
                ResetSummary();
                return;
            }

            var charges = _billingController.GetCharges(res.ReservationId);
            decimal extraTotal = 0;
            dgvCharges.Rows.Clear();

            foreach (var c in charges)
            {
                extraTotal += c.Amount;
                dgvCharges.Rows.Add(c.Description, $"PHP {c.Amount:N2}", c.ChargedAt.ToString("MM/dd/yyyy hh:mm tt"));
            }

            decimal totalPaid = _billingController.GetTotalPayments(res.ReservationId);
            decimal balanceDue = (res.TotalAmount + extraTotal) - totalPaid;

            lblGuestInfo.Text = $"Guest: {res.GuestName} | Room: {res.RoomNumber} ({res.RoomType})";
            lblRoomRate.Text = $"Room Charges: PHP {res.TotalAmount:N2}";
            lblTotalCharges.Text = $"Extra Charges: PHP {extraTotal:N2}";
            lblTotalPaid.Text = $"Paid: PHP {totalPaid:N2}";
            lblBalanceDue.Text = $"Balance Due: PHP {Math.Max(0, balanceDue):N2}";

            txtPaymentAmount.Text = Math.Max(0, balanceDue).ToString("F2");
        }

        private void ResetSummary()
        {
            lblGuestInfo.Text = "Guest: -";
            lblRoomRate.Text = "Room Charges: PHP 0.00";
            lblTotalCharges.Text = "Extra Charges: PHP 0.00";
            lblTotalPaid.Text = "Paid: PHP 0.00";
            lblBalanceDue.Text = "Balance Due: PHP 0.00";
            dgvCharges.Rows.Clear();
            txtPaymentAmount.Clear();
        }

        private void cmbActiveStays_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshBillingSummary();
        }

        private void btnAddCharge_Click(object sender, EventArgs e)
        {
            var res = GetSelectedReservation();
            if (res == null)
            {
                MessageBox.Show("Please select an active stay first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtChargeDesc.Text) || !decimal.TryParse(txtChargeAmount.Text, out decimal amt) || amt <= 0)
            {
                MessageBox.Show("Please enter a valid description and a positive amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = _billingController.AddCharge(res.ReservationId, txtChargeDesc.Text.Trim(), amt);
            if (result.Success)
            {
                txtChargeDesc.Clear();
                txtChargeAmount.Clear();
                RefreshBillingSummary();
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var res = GetSelectedReservation();
            if (res == null)
            {
                MessageBox.Show("Please select an active stay first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPaymentAmount.Text, out decimal amt) || amt <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var payment = new PaymentModel
            {
                ReservationId = res.ReservationId,
                PaymentMethod = cmbPaymentMethod.SelectedItem?.ToString() ?? "Cash",
                AmountPaid = amt,
                PaymentDate = DateTime.Now,
                PaymentStatus = "Paid"
            };

            var result = _billingController.ProcessPayment(payment);
            if (result.Success)
            {
                MessageBox.Show($"Payment of PHP {amt:N2} accepted via {payment.PaymentMethod}.", "Payment Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshBillingSummary();
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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