using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class GuestRepository
    {
        private readonly string _connectionString = "Server=localhost;Database=InnovaStayDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public bool AddGuest(GuestModel guest, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("sp_Guest_CRUD", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "CREATE");
                    cmd.Parameters.AddWithValue("@FirstName", guest.FirstName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@LastName", guest.LastName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", guest.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PhoneNumber", guest.PhoneNumber ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", guest.Address ?? (object)DBNull.Value);

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

        public List<GuestModel> GetAllGuests()
        {
            var list = new List<GuestModel>();

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand("sp_Guest_CRUD", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "READ_ALL");

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new GuestModel
                        {
                            GuestId = Convert.ToInt32(reader["GuestId"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty,
                            PhoneNumber = reader["PhoneNumber"] != DBNull.Value ? reader["PhoneNumber"].ToString() : string.Empty,
                            Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : string.Empty,
                            CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                            UpdatedAt = Convert.ToDateTime(reader["UpdatedAt"])
                        });
                    }
                }
            }

            return list;
        }

        public bool UpdateGuest(GuestModel guest, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("sp_Guest_CRUD", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "UPDATE");
                    cmd.Parameters.AddWithValue("@GuestId", guest.GuestId);
                    cmd.Parameters.AddWithValue("@FirstName", guest.FirstName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@LastName", guest.LastName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", guest.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PhoneNumber", guest.PhoneNumber ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", guest.Address ?? (object)DBNull.Value);

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

        public bool DeleteGuest(int guestId, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("sp_Guest_CRUD", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "DELETE");
                    cmd.Parameters.AddWithValue("@GuestId", guestId);

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
    }
}