using System;
using System.Collections.Generic;
using System.Data;
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
                        r.ReservationID,
                        r.GuestID,
                        r.RoomID,
                        ISNULL(g.FullName, 'Guest #' + CAST(r.GuestID AS NVARCHAR)) AS GuestName,
                        ISNULL(rm.RoomNumber, 'N/A') AS RoomNumber,
                        ISNULL(rm.RoomType, 'Standard') AS RoomType,
                        r.CheckInDate,
                        r.CheckOutDate,
                        ISNULL(r.TotalAmount, 0) AS TotalAmount,
                        ISNULL(r.Status, 'Confirmed') AS Status,
                        ISNULL(r.CreatedAt, GETDATE()) AS CreatedAt
                    FROM dbo.Reservations r
                    LEFT JOIN dbo.tbl_Guests g ON r.GuestID = g.GuestID
                    LEFT JOIN dbo.tbl_Rooms rm ON r.RoomID = rm.RoomID
                    ORDER BY r.ReservationID DESC";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@Limit", SqlDbType.Int).Value = limit;

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ReservationModel
                    {
                        ReservationId = Convert.ToInt32(reader["ReservationID"]),
                        GuestId = Convert.ToInt32(reader["GuestID"]),
                        RoomId = reader["RoomID"] != DBNull.Value ? Convert.ToInt32(reader["RoomID"]) : 0,
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
            catch
            {
                // Return empty list if table is empty or connection fails
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
                        r.ReservationID,
                        r.GuestID,
                        r.RoomID,
                        ISNULL(g.FullName, 'Guest #' + CAST(r.GuestID AS NVARCHAR)) AS GuestName,
                        ISNULL(rm.RoomNumber, 'N/A') AS RoomNumber,
                        ISNULL(rm.RoomType, 'Standard') AS RoomType,
                        r.CheckInDate,
                        r.CheckOutDate,
                        ISNULL(r.TotalAmount, 0) AS TotalAmount,
                        ISNULL(r.Status, 'Checked-In') AS Status,
                        ISNULL(r.CreatedAt, GETDATE()) AS CreatedAt
                    FROM dbo.Reservations r
                    LEFT JOIN dbo.tbl_Guests g ON r.GuestID = g.GuestID
                    LEFT JOIN dbo.tbl_Rooms rm ON r.RoomID = rm.RoomID
                    WHERE r.Status = 'Checked-In' OR r.Status = 'Confirmed'
                    ORDER BY r.CheckOutDate ASC";

                using var cmd = new SqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new ReservationModel
                    {
                        ReservationId = Convert.ToInt32(reader["ReservationID"]),
                        GuestId = Convert.ToInt32(reader["GuestID"]),
                        RoomId = reader["RoomID"] != DBNull.Value ? Convert.ToInt32(reader["RoomID"]) : 0,
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
            catch
            {
                // Fallback to empty list
            }

            return list;
        }

        public (bool Success, string Message) CreateReservation(ReservationModel model)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                    INSERT INTO dbo.Reservations (GuestID, RoomID, CheckInDate, CheckOutDate, TotalAmount, Status, CreatedAt)
                    VALUES (@GuestID, @RoomID, @CheckInDate, @CheckOutDate, @TotalAmount, @Status, @CreatedAt);

                    UPDATE dbo.tbl_Rooms SET Status = 'Occupied' WHERE RoomID = @RoomID;";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@GuestID", SqlDbType.Int).Value = model.GuestId;
                cmd.Parameters.Add("@RoomID", SqlDbType.Int).Value = model.RoomId;
                cmd.Parameters.Add("@CheckInDate", SqlDbType.DateTime).Value = model.CheckInDate;
                cmd.Parameters.Add("@CheckOutDate", SqlDbType.DateTime).Value = model.CheckOutDate;
                cmd.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = model.TotalAmount;
                cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 50).Value = model.Status;
                cmd.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = model.CreatedAt;

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
                    SET Status = 'Checked-Out' 
                    WHERE ReservationID = @ReservationID;

                    UPDATE dbo.tbl_Rooms 
                    SET Status = 'Available' 
                    WHERE RoomID = @RoomID;";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@ReservationID", SqlDbType.Int).Value = reservationId;
                cmd.Parameters.Add("@RoomID", SqlDbType.Int).Value = roomId;

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