using System;

namespace Model
{
    public class RoomModel
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; } 
        public decimal PricePerNight { get; set; }
        public string Status { get; set; } 
        public int Floor { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}   