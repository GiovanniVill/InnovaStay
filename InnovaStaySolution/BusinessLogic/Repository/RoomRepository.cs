using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class RoomRepository
    {
        private readonly string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=InnovaStayDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public bool AddRoom(RoomModel room, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("sp_Room_CRUD", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "CREATE");
                    cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@RoomType", room.RoomType ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PricePerNight", room.PricePerNight);
                    cmd.Parameters.AddWithValue("@Status", room.Status ?? "Available");
                    cmd.Parameters.AddWithValue("@Floor", room.Floor);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public List<RoomModel> GetAllRooms()
        {
            var list = new List<RoomModel>();

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand("sp_Room_CRUD", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "READ_ALL");

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new RoomModel
                        {
                            RoomId = Convert.ToInt32(reader["RoomId"]),
                            RoomNumber = reader["RoomNumber"].ToString(),
                            RoomType = reader["RoomType"].ToString(),
                            PricePerNight = Convert.ToDecimal(reader["PricePerNight"]),
                            Status = reader["Status"].ToString(),
                            Floor = Convert.ToInt32(reader["Floor"]),
                            CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                            UpdatedAt = Convert.ToDateTime(reader["UpdatedAt"])
                        });
                    }
                }
            }

            return list;
        }

        public bool UpdateRoom(RoomModel room, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("sp_Room_CRUD", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "UPDATE");
                    cmd.Parameters.AddWithValue("@RoomId", room.RoomId);
                    cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@RoomType", room.RoomType ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PricePerNight", room.PricePerNight);
                    cmd.Parameters.AddWithValue("@Status", room.Status ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Floor", room.Floor);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public bool DeleteRoom(int roomId, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("sp_Room_CRUD", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "DELETE");
                    cmd.Parameters.AddWithValue("@RoomId", roomId);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        // US-05: Check room availability based on selected check-in and check-out dates
        public List<RoomModel> GetAvailableRoomsByDates(DateTime checkIn, DateTime checkOut)
        {
            var list = new List<RoomModel>();

            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // 1. Get all rooms from the system
                var allRooms = GetAllRooms();

                // 2. Fetch room IDs that have active booking overlaps during the selected date window
                var bookedRoomIds = new HashSet<int>();
                string conflictQuery = @"
                    IF OBJECT_ID('dbo.Reservations', 'U') IS NOT NULL
                    BEGIN
                        SELECT RoomId
                        FROM dbo.Reservations
                        WHERE Status IN ('Confirmed', 'CheckedIn')
                          AND @CheckIn < CheckOutDate
                          AND @CheckOut > CheckInDate;
                    END";

                using (var cmd = new SqlCommand(conflictQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@CheckIn", checkIn.Date);
                    cmd.Parameters.AddWithValue("@CheckOut", checkOut.Date);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bookedRoomIds.Add(Convert.ToInt32(reader["RoomId"]));
                        }
                    }
                }

                // 3. Keep rooms not under Maintenance and not booked during the chosen window
                foreach (var room in allRooms)
                {
                    bool isMaintenance = string.Equals(room.Status, "Maintenance", StringComparison.OrdinalIgnoreCase);
                    if (!isMaintenance && !bookedRoomIds.Contains(room.RoomId))
                    {
                        list.Add(room);
                    }
                }
            }

            return list;
        }
    }
}