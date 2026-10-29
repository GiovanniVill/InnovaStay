using System;
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

                    // 1. Ensure the Reservations table exists
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

                    // 2. Insert the reservation record
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

                    // 3. Mark the room as Reserved using sp_Room_CRUD
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
    }
}