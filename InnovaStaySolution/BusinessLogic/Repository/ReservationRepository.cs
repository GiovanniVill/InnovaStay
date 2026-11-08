using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class ReservationRepository
    {
        private readonly string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=InnovaStayDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public List<ReservationModel> GetRecentReservations(int limit = 10)
        {
            var list = new List<ReservationModel>();

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                    SELECT TOP (@Limit)
                        r.ReservationId,
                        r.GuestId,
                        r.RoomId,
                        ISNULL(NULLIF(LTRIM(RTRIM(CONCAT(g.first_name, ' ', g.last_name))), ''), 'Guest #' + CAST(r.GuestId AS NVARCHAR)) AS GuestName,
                        ISNULL(rm.room_number, CAST(r.RoomId AS NVARCHAR)) AS RoomNumber,
                        ISNULL(rm.room_type, 'Standard') AS RoomType,
                        r.CheckInDate,
                        r.CheckOutDate,
                        ISNULL(r.TotalAmount, 0) AS TotalAmount,
                        ISNULL(r.Status, 'Confirmed') AS Status,
                        ISNULL(r.CreatedAt, GETDATE()) AS CreatedAt
                    FROM dbo.Reservations r
                    LEFT JOIN dbo.tbl_Guests g ON r.GuestId = g.guest_id
                    LEFT JOIN dbo.tbl_Rooms rm ON r.RoomId = rm.room_id
                    ORDER BY r.ReservationId DESC";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@Limit", SqlDbType.Int).Value = limit;

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ReservationModel
                    {
                        ReservationId = Convert.ToInt32(reader["ReservationId"]),
                        GuestId = Convert.ToInt32(reader["GuestId"]),
                        RoomId = reader["RoomId"] != DBNull.Value ? Convert.ToInt32(reader["RoomId"]) : 0,
                        GuestName = reader["GuestName"].ToString() ?? "",
                        RoomNumber = reader["RoomNumber"].ToString() ?? "",
                        RoomType = reader["RoomType"].ToString() ?? "",
                        CheckInDate = Convert.ToDateTime(reader["CheckInDate"]),
                        CheckOutDate = Convert.ToDateTime(reader["CheckOutDate"]),
                        TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                        Status = reader["Status"].ToString() ?? "Confirmed",
                        CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[GetRecentReservations Error]: {ex.Message}");
            }

            return list;
        }

        public List<ReservationModel> GetActiveStays()
        {
            var list = new List<ReservationModel>();

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                    SELECT 
                        r.ReservationId,
                        r.GuestId,
                        r.RoomId,
                        ISNULL(NULLIF(LTRIM(RTRIM(CONCAT(g.first_name, ' ', g.last_name))), ''), 'Guest #' + CAST(r.GuestId AS NVARCHAR)) AS GuestName,
                        ISNULL(rm.room_number, CAST(r.RoomId AS NVARCHAR)) AS RoomNumber,
                        ISNULL(rm.room_type, 'Standard') AS RoomType,
                        r.CheckInDate,
                        r.CheckOutDate,
                        ISNULL(r.TotalAmount, 0) AS TotalAmount,
                        ISNULL(r.Status, 'Confirmed') AS Status,
                        ISNULL(r.CreatedAt, GETDATE()) AS CreatedAt
                    FROM dbo.Reservations r
                    LEFT JOIN dbo.tbl_Guests g ON r.GuestId = g.guest_id
                    LEFT JOIN dbo.tbl_Rooms rm ON r.RoomId = rm.room_id
                    WHERE r.Status = 'Checked-In' OR r.Status = 'Confirmed' OR r.Status = 'CheckedIn'
                    ORDER BY r.ReservationId DESC";

                using var cmd = new SqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new ReservationModel
                    {
                        ReservationId = Convert.ToInt32(reader["ReservationId"]),
                        GuestId = Convert.ToInt32(reader["GuestId"]),
                        RoomId = reader["RoomId"] != DBNull.Value ? Convert.ToInt32(reader["RoomId"]) : 0,
                        GuestName = reader["GuestName"].ToString() ?? "",
                        RoomNumber = reader["RoomNumber"].ToString() ?? "",
                        RoomType = reader["RoomType"].ToString() ?? "",
                        CheckInDate = Convert.ToDateTime(reader["CheckInDate"]),
                        CheckOutDate = Convert.ToDateTime(reader["CheckOutDate"]),
                        TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                        Status = reader["Status"].ToString() ?? "Confirmed",
                        CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[GetActiveStays Error]: {ex.Message}");
            }

            return list;
        }

        public (bool Success, string Message) CreateReservation(ReservationModel model)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                // If reservation status is explicitly Checked-In, set room to Occupied.
                // Otherwise (Confirmed/Pending), set room to Reserved.
                string targetRoomStatus = string.Equals(model.Status, "Checked-In", StringComparison.OrdinalIgnoreCase) ||
                                          string.Equals(model.Status, "CheckedIn", StringComparison.OrdinalIgnoreCase)
                    ? "Occupied"
                    : "Reserved";

                string sql = @"
                    INSERT INTO dbo.Reservations (GuestId, RoomId, CheckInDate, CheckOutDate, TotalAmount, Status, CreatedAt)
                    VALUES (@GuestId, @RoomId, @CheckInDate, @CheckOutDate, @TotalAmount, @Status, @CreatedAt);

                    UPDATE dbo.tbl_Rooms 
                    SET status = @RoomStatus 
                    WHERE room_id = @RoomId;";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@GuestId", SqlDbType.Int).Value = model.GuestId;
                cmd.Parameters.Add("@RoomId", SqlDbType.Int).Value = model.RoomId;
                cmd.Parameters.Add("@CheckInDate", SqlDbType.DateTime).Value = model.CheckInDate;
                cmd.Parameters.Add("@CheckOutDate", SqlDbType.DateTime).Value = model.CheckOutDate;
                cmd.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = model.TotalAmount;
                cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 50).Value = model.Status;
                cmd.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = model.CreatedAt;
                cmd.Parameters.Add("@RoomStatus", SqlDbType.NVarChar, 50).Value = targetRoomStatus;

                int rows = cmd.ExecuteNonQuery();
                return (rows > 0, rows > 0 ? "Reservation saved successfully." : "No records inserted.");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool Success, string Message) ProcessCheckOut(int reservationId, int roomId)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                    UPDATE dbo.Reservations 
                    SET Status = 'CheckedOut' 
                    WHERE ReservationId = @ReservationId;

                    UPDATE dbo.tbl_Rooms 
                    SET status = 'Available' 
                    WHERE room_id = @RoomId;";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@ReservationId", SqlDbType.Int).Value = reservationId;
                cmd.Parameters.Add("@RoomId", SqlDbType.Int).Value = roomId;

                int rows = cmd.ExecuteNonQuery();
                return (rows > 0, rows > 0 ? "Check-out completed." : "Failed to update record.");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}