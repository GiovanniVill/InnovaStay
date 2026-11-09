using System;

namespace Model
{
    public class PaymentModel
    {
        public int PaymentId { get; set; }
        public int ReservationId { get; set; }
        public string PaymentMethod { get; set; } = "Cash";
        public decimal AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public string PaymentStatus { get; set; } = "Paid";
    }
}