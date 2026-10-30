using System;
using System.Data;

namespace Model
{
    public class DashboardSummary
    {
        public int TotalRooms { get; set; }
        public int AvailableRooms { get; set; }
        public int OccupiedRooms { get; set; }
        public int ExpectedArrivals { get; set; }
        public int ExpectedDepartures { get; set; }
        public DataTable ScheduleTable { get; set; } = new DataTable();
    }
}