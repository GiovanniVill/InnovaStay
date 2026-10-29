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

        public (bool Success, string Message) CreateReservation(ReservationModel reservation)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string ensureTableQuery = @"
                        IF OBJECT_ID('dbo.Reservations', 'U') IS NULL
                        BEGIN
                            CREATE TABLE dbo.Reservations (
                                ReservationId INT IDENTITY(1,1) PRIMARY KEY,
                                GuestId INT NOT NULL,
                                RoomId INT NOT NULL,
                                CheckInDate DATETIME NOT NULL,
                                CheckOutDate DATETIME NOT NULL,
                                TotalAmount DECIMAL(18, 2) NOT NULL,
                                Status NVARCHAR(50) NOT NULL DEFAULT 'Confirmed',
                                CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
                            );
                        END";

                    using (var initCmd = new SqlCommand(ensureTableQuery, conn))
                    {
                        initCmd.ExecuteNonQuery();
                    }

                    string insertQuery = @"
                        INSERT INTO dbo.Reservations (GuestId, RoomId, CheckInDate, CheckOutDate, TotalAmount, Status, CreatedAt)
                        VALUES (@GuestId, @RoomId, @CheckInDate, @CheckOutDate, @TotalAmount, @Status, @CreatedAt);";

                    using (var cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@GuestId", reservation.GuestId);
                        cmd.Parameters.AddWithValue("@RoomId", reservation.RoomId);
                        cmd.Parameters.AddWithValue("@CheckInDate", reservation.CheckInDate);
                        cmd.Parameters.AddWithValue("@CheckOutDate", reservation.CheckOutDate);
                        cmd.Parameters.AddWithValue("@TotalAmount", reservation.TotalAmount);
                        cmd.Parameters.AddWithValue("@Status", reservation.Status ?? "Confirmed");
                        cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }

                    using (var roomCmd = new SqlCommand("sp_Room_CRUD", conn))
                    {
                        roomCmd.CommandType = CommandType.StoredProcedure;
                        roomCmd.Parameters.AddWithValue("@Action", "UPDATE");
                        roomCmd.Parameters.AddWithValue("@RoomId", reservation.RoomId);
                        roomCmd.Parameters.AddWithValue("@RoomNumber", DBNull.Value);
                        roomCmd.Parameters.AddWithValue("@RoomType", DBNull.Value);
                        roomCmd.Parameters.AddWithValue("@PricePerNight", 0);
                        roomCmd.Parameters.AddWithValue("@Status", "Reserved");
                        roomCmd.Parameters.AddWithValue("@Floor", 0);

                        roomCmd.ExecuteNonQuery();
                    }

                    return (true, "Reservation created successfully!");
                }
            }
            catch (Exception ex)
            {
                return (false, "Database error: " + ex.Message);
            }
        }

        public List<ReservationModel> GetActiveStays()
        {
            var list = new List<ReservationModel>();

            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT r.ReservationId, r.GuestId, r.RoomId, r.CheckInDate, r.CheckOutDate, 
                           r.TotalAmount, r.Status, r.CreatedAt
                    FROM dbo.Reservations r
                    WHERE r.Status IN ('Confirmed', 'CheckedIn')
                    ORDER BY r.ReservationId DESC;";

                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ReservationModel
                        {
                            ReservationId = Convert.ToInt32(reader["ReservationId"]),
                            GuestId = Convert.ToInt32(reader["GuestId"]),
                            RoomId = Convert.ToInt32(reader["RoomId"]),
                            CheckInDate = Convert.ToDateTime(reader["CheckInDate"]),
                            CheckOutDate = Convert.ToDateTime(reader["CheckOutDate"]),
                            TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                            Status = reader["Status"].ToString() ?? string.Empty,
                            CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                        });
                    }
                }
            }

            return list;
        }

        public (bool Success, string Message) ProcessCheckOut(int reservationId, int roomId)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    // 1. Update reservation status to CheckedOut
                    string updateResQuery = "UPDATE dbo.Reservations SET Status = 'CheckedOut' WHERE ReservationId = @ReservationId;";
                    using (var resCmd = new SqlCommand(updateResQuery, conn))
                    {
                        resCmd.Parameters.AddWithValue("@ReservationId", reservationId);
                        resCmd.ExecuteNonQuery();
                    }

                    // 2. Set the room status back to Available for turnover
                    using (var roomCmd = new SqlCommand("sp_Room_CRUD", conn))
                    {
                        roomCmd.CommandType = CommandType.StoredProcedure;
                        roomCmd.Parameters.AddWithValue("@Action", "UPDATE");
                        roomCmd.Parameters.AddWithValue("@RoomId", roomId);
                        roomCmd.Parameters.AddWithValue("@RoomNumber", DBNull.Value);
                        roomCmd.Parameters.AddWithValue("@RoomType", DBNull.Value);
                        roomCmd.Parameters.AddWithValue("@PricePerNight", 0);
                        roomCmd.Parameters.AddWithValue("@Status", "Available");
                        roomCmd.Parameters.AddWithValue("@Floor", 0);

                        roomCmd.ExecuteNonQuery();
                    }

                    return (true, "Guest departure confirmed. Room is now available for turnover!");
                }
            }
            catch (Exception ex)
            {
                return (false, "Database error: " + ex.Message);
            }
        }
    }
}