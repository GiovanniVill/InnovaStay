using System;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class DashboardRepository
    {
        private readonly string connectionString = "Server=localhost;Database=InnovaStayDB;Trusted_Connection=True;";

        public DashboardSummary GetFrontDeskSummary()
        {
            var summary = new DashboardSummary();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // 1. Fetch KPI Counts
                string kpiQuery = @"
                    SELECT 
                        (SELECT COUNT(*) FROM tbl_Rooms WHERE RoomStatus = 'Available') AS AvailableRooms,
                        (SELECT COUNT(*) FROM tbl_Rooms WHERE RoomStatus = 'Occupied') AS OccupiedRooms,
                        (SELECT COUNT(*) FROM tbl_Reservations WHERE CAST(CheckInDate AS DATE) = CAST(GETDATE() AS DATE) AND ReservationStatus IN ('Confirmed', 'Pending')) AS ExpectedArrivals,
                        (SELECT COUNT(*) FROM tbl_Reservations WHERE CAST(CheckOutDate AS DATE) = CAST(GETDATE() AS DATE) AND ReservationStatus = 'Checked-In') AS ExpectedDepartures;";

                using (SqlCommand cmd = new SqlCommand(kpiQuery, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        summary.AvailableRooms = Convert.ToInt32(reader["AvailableRooms"]);
                        summary.OccupiedRooms = Convert.ToInt32(reader["OccupiedRooms"]);
                        summary.ExpectedArrivals = Convert.ToInt32(reader["ExpectedArrivals"]);
                        summary.ExpectedDepartures = Convert.ToInt32(reader["ExpectedDepartures"]);
                    }
                }

                // 2. Fetch Active Schedule & In-House Guests
                string listQuery = @"
                    SELECT 
                        r.ReservationID AS [Res #],
                        CONCAT(g.FirstName, ' ', g.LastName) AS [Guest Name],
                        rm.RoomNumber AS [Room],
                        rm.RoomType AS [Room Type],
                        r.ReservationStatus AS [Status],
                        CONVERT(VARCHAR(10), r.CheckInDate, 120) AS [Check-In],
                        CONVERT(VARCHAR(10), r.CheckOutDate, 120) AS [Check-Out]
                    FROM tbl_Reservations r
                    INNER JOIN tbl_Guests g ON r.GuestID = g.GuestID
                    LEFT JOIN tbl_Rooms rm ON r.RoomID = rm.RoomID
                    WHERE r.ReservationStatus IN ('Checked-In', 'Confirmed')
                    ORDER BY r.CheckInDate ASC;";

                using (SqlDataAdapter da = new SqlDataAdapter(listQuery, con))
                {
                    da.Fill(summary.ScheduleTable);
                }
            }

            return summary;
        }
    }
}