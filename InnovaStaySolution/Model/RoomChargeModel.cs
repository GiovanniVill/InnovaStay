using System;

namespace Model
{
    public class RoomChargeModel
    {
        public int ChargeId { get; set; }
        public int ReservationId { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime ChargedAt { get; set; } = DateTime.Now;
    }
}