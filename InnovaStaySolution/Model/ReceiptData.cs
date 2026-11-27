using System;
using System.Collections.Generic;

namespace Model
{
    public class ChargeItem
    {
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }

    public class ReceiptData
    {
        public string ReceiptNumber { get; set; } = string.Empty;
        public DateTime IssuedDate { get; set; } = DateTime.Now;

        public string GuestName { get; set; } = string.Empty;
        public string BillingAddress { get; set; } = string.Empty;
        public string HotelName { get; set; } = "Grand Horizon Hotel";
        public string RoomType { get; set; } = string.Empty;
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public int Nights { get; set; } = 1;
        public int NumberOfRooms { get; set; } = 1;
        public decimal RoomRatePerNight { get; set; }
        public int NumberOfExtraBeds { get; set; }
        public decimal ExtraBedRatePerNight { get; set; }

        public List<ChargeItem> ExtraCharges { get; set; } = new List<ChargeItem>();
        public string PaymentMethod { get; set; } = "Cash";
        public decimal AmountTendered { get; set; }
        public decimal TotalPaid { get; set; }

        public decimal RoomSubtotal { get; set; }
        public decimal ExtraChargesTotal { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal ChangeDue { get; set; }
        public decimal BalanceRemaining { get; set; }
    }
}