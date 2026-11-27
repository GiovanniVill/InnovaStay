using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class Reciept : Form
    {
        private readonly CultureInfo _phpCulture = new CultureInfo("en-PH");
        private readonly PrintDocument _printDocument = new PrintDocument();
        private readonly Button _btnPrintReceipt = new Button();
        private readonly Label _lblReceiptNumber = new Label();

        private ReceiptData _receiptData = new ReceiptData();

        public Reciept()
        {
            InitializeComponent();
            InitializeRuntimeControls();
            ConfigurePrinting();
        }

        public Reciept(ReceiptData data) : this()
        {
            LoadReceipt(data);
        }

        private void InitializeRuntimeControls()
        {
            _lblReceiptNumber.AutoSize = true;
            _lblReceiptNumber.Font = new Font("Sitka Heading", 10.5F, FontStyle.Bold);
            _lblReceiptNumber.Location = new Point(26, 63);
            _lblReceiptNumber.Name = "lblReceiptNumber";
            _lblReceiptNumber.Text = "Receipt #: -";
            Controls.Add(_lblReceiptNumber);

            _btnPrintReceipt.Text = "Print Receipt";
            _btnPrintReceipt.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            _btnPrintReceipt.Size = new Size(135, 34);
            _btnPrintReceipt.Location = new Point(360, 560);
            _btnPrintReceipt.Click += BtnPrintReceipt_Click;
            Controls.Add(_btnPrintReceipt);
        }

        private void ConfigurePrinting()
        {
            _printDocument.DocumentName = "Hotel Receipt";
            _printDocument.PrintPage += PrintDocument_PrintPage;
        }

        public void LoadReceipt(ReceiptData data)
        {
            _receiptData = data ?? new ReceiptData();

            _lblReceiptNumber.Text = $"Receipt #: {_receiptData.ReceiptNumber}";
            lblIssuedTo.Text = string.IsNullOrWhiteSpace(_receiptData.GuestName) ? "-" : _receiptData.GuestName;
            lblBillingAddress.Text = string.IsNullOrWhiteSpace(_receiptData.BillingAddress) ? "-" : _receiptData.BillingAddress;
            lblIssuedDate.Text = _receiptData.IssuedDate.ToString("yyyy-MM-dd HH:mm");

            lblHotelName.Text = string.IsNullOrWhiteSpace(_receiptData.HotelName) ? "-" : _receiptData.HotelName;
            lblPeriod.Text = $"{_receiptData.CheckInDate:MMM dd, yyyy} - {_receiptData.CheckOutDate:MMM dd, yyyy} ({_receiptData.Nights}n)";
            lblRoomType.Text = string.IsNullOrWhiteSpace(_receiptData.RoomType) ? "-" : _receiptData.RoomType;
            lblNumberOfRooms.Text = _receiptData.NumberOfRooms.ToString();
            lblNumberOfExtraBeds.Text = _receiptData.NumberOfExtraBeds.ToString();

            lblTotalRoomCharges.Text = FormatMoney(_receiptData.RoomSubtotal);
            lblTotalExtraBedCharges.Text = FormatMoney(_receiptData.ExtraChargesTotal);
            lblGrandTotal.Text = FormatMoney(_receiptData.GrandTotal);

            bool isCard = string.Equals(_receiptData.PaymentMethod, "Credit Card", StringComparison.OrdinalIgnoreCase)
                         || string.Equals(_receiptData.PaymentMethod, "Card", StringComparison.OrdinalIgnoreCase);

            lblTotalChargeToCreditCard.Text = isCard
                ? FormatMoney(_receiptData.GrandTotal)
                : FormatMoney(0m);
        }

        private void BtnPrintReceipt_Click(object? sender, EventArgs e)
        {
            try
            {
                using (var previewDialog = new PrintPreviewDialog())
                {
                    previewDialog.Document = _printDocument;
                    previewDialog.Width = 850;
                    previewDialog.Height = 650;
                    previewDialog.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to open print preview: {ex.Message}",
                    "Print Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object? sender, PrintPageEventArgs e)
        {
            Graphics? g = e.Graphics;
            if (g == null)
            {
                e.HasMorePages = false;
                return;
            }

            float left = e.MarginBounds.Left;
            float top = e.MarginBounds.Top;
            float y = top;

            using var titleFont = new Font("Segoe UI", 18F, FontStyle.Bold);
            using var headerFont = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            using var bodyFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            using var pen = new Pen(Color.Black, 1f);

            g.DrawString("HOTEL OFFICIAL RECEIPT", titleFont, Brushes.Black, left, y);
            y += 38;

            g.DrawString($"Receipt No.: {_receiptData.ReceiptNumber}", headerFont, Brushes.Black, left, y);
            g.DrawString($"Issued: {_receiptData.IssuedDate:yyyy-MM-dd HH:mm}", bodyFont, Brushes.Black, left + 320, y);
            y += 24;

            g.DrawLine(pen, left, y, left + 560, y);
            y += 14;

            g.DrawString($"Issued To: {_receiptData.GuestName}", bodyFont, Brushes.Black, left, y);
            y += 20;
            g.DrawString($"Billing Address: {_receiptData.BillingAddress}", bodyFont, Brushes.Black, left, y);
            y += 20;
            g.DrawString($"Hotel: {_receiptData.HotelName}", bodyFont, Brushes.Black, left, y);
            y += 20;
            g.DrawString($"Stay Period: {_receiptData.CheckInDate:MMM dd, yyyy} - {_receiptData.CheckOutDate:MMM dd, yyyy} ({_receiptData.Nights} night(s))", bodyFont, Brushes.Black, left, y);
            y += 20;
            g.DrawString($"Room Type: {_receiptData.RoomType}  |  Rooms: {_receiptData.NumberOfRooms}  |  Extra Beds: {_receiptData.NumberOfExtraBeds}", bodyFont, Brushes.Black, left, y);
            y += 28;

            g.DrawLine(pen, left, y, left + 560, y);
            y += 12;

            g.DrawString("Description", headerFont, Brushes.Black, left, y);
            g.DrawString("Amount", headerFont, Brushes.Black, left + 430, y);
            y += 24;

            g.DrawString($"Room Subtotal ({FormatMoney(_receiptData.RoomRatePerNight)} x {_receiptData.Nights}n x {_receiptData.NumberOfRooms}rm)", bodyFont, Brushes.Black, left, y);
            g.DrawString(FormatMoney(_receiptData.RoomSubtotal), bodyFont, Brushes.Black, left + 430, y);
            y += 22;

            g.DrawString("Extra Charges (Beds & Folio)", bodyFont, Brushes.Black, left, y);
            g.DrawString(FormatMoney(_receiptData.ExtraChargesTotal), bodyFont, Brushes.Black, left + 430, y);
            y += 22;

            if (_receiptData.ExtraCharges != null)
            {
                foreach (var item in _receiptData.ExtraCharges)
                {
                    g.DrawString($"  • {item.Description} ({item.Date:MM/dd})", bodyFont, Brushes.DarkGray, left + 10, y);
                    g.DrawString(FormatMoney(item.Amount), bodyFont, Brushes.DarkGray, left + 430, y);
                    y += 20;
                }
            }

            y += 6;
            g.DrawLine(pen, left, y, left + 560, y);
            y += 12;

            g.DrawString("GRAND TOTAL", headerFont, Brushes.Black, left, y);
            g.DrawString(FormatMoney(_receiptData.GrandTotal), headerFont, Brushes.Black, left + 430, y);
            y += 24;

            g.DrawString($"Payment Method: {_receiptData.PaymentMethod}", bodyFont, Brushes.Black, left, y);
            y += 20;

            g.DrawString("Amount Tendered / Paid:", bodyFont, Brushes.Black, left, y);
            g.DrawString(FormatMoney(_receiptData.AmountTendered > 0 ? _receiptData.AmountTendered : _receiptData.TotalPaid), bodyFont, Brushes.Black, left + 430, y);
            y += 22;

            g.DrawString("Change Due:", headerFont, Brushes.Black, left, y);
            g.DrawString(FormatMoney(_receiptData.ChangeDue), headerFont, Brushes.Black, left + 430, y);
            y += 34;

            g.DrawString("Thank you for staying with us!", bodyFont, Brushes.Black, left, y);

            e.HasMorePages = false;
        }

        private string FormatMoney(decimal amount) => amount.ToString("C2", _phpCulture);

        private void panel1_Paint(object? sender, PaintEventArgs e) { }
        private void label5_Click(object? sender, EventArgs e) { }
        private void tableLayoutPanel1_Paint(object? sender, PaintEventArgs e) { }
    }
}