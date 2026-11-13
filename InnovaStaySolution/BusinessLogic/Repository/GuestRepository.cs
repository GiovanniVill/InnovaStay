using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class GuestRepository
    {
        private readonly string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=InnovaStayDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public bool AddGuest(GuestModel guest, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("sp_Guest_CRUD", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "INSERT");
                    cmd.Parameters.AddWithValue("@first_name", guest.FirstName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@middle_name", string.IsNullOrWhiteSpace(guest.MiddleName) ? (object)DBNull.Value : guest.MiddleName);
                    cmd.Parameters.AddWithValue("@last_name", guest.LastName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@email", guest.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@phone_number", guest.PhoneNumber ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@address", guest.Address ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@age", guest.Age > 0 ? guest.Age : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@date_of_birth", guest.DateOfBirth.HasValue ? guest.DateOfBirth.Value.Date : (object)DBNull.Value);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && decimal.TryParse(result.ToString(), out decimal newId) && newId > 0)
                    {
                        guest.GuestId = Convert.ToInt32(newId);
                        return true;
                    }

                    errorMessage = "Failed to retrieve new guest ID.";
                    return false;
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
                cmd.Parameters.AddWithValue("@Action", "SELECT_ALL");

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    var cols = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                    for (int i = 0; i < reader.FieldCount; i++)
                        cols.Add(reader.GetName(i));

                    while (reader.Read())
                    {
                        list.Add(new GuestModel
                        {
                            GuestId = Convert.ToInt32(reader["guest_id"]),
                            FirstName = reader["first_name"].ToString() ?? string.Empty,
                            MiddleName = cols.Contains("middle_name") && reader["middle_name"] != DBNull.Value ? reader["middle_name"].ToString() ?? string.Empty : string.Empty,
                            LastName = reader["last_name"].ToString() ?? string.Empty,
                            Email = reader["email"] != DBNull.Value ? reader["email"].ToString() ?? string.Empty : string.Empty,
                            PhoneNumber = reader["phone_number"] != DBNull.Value ? reader["phone_number"].ToString() ?? string.Empty : string.Empty,
                            Address = reader["address"] != DBNull.Value ? reader["address"].ToString() ?? string.Empty : string.Empty,
                            Age = cols.Contains("age") && reader["age"] != DBNull.Value ? Convert.ToInt32(reader["age"]) : 0,
                            DateOfBirth = cols.Contains("date_of_birth") && reader["date_of_birth"] != DBNull.Value ? Convert.ToDateTime(reader["date_of_birth"]) : (DateTime?)null,
                            CreatedAt = reader["created_at"] != DBNull.Value ? Convert.ToDateTime(reader["created_at"]) : DateTime.MinValue,
                            UpdatedAt = reader["updated_at"] != DBNull.Value ? Convert.ToDateTime(reader["updated_at"]) : DateTime.MinValue
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
                    cmd.Parameters.AddWithValue("@guest_id", guest.GuestId);
                    cmd.Parameters.AddWithValue("@first_name", guest.FirstName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@middle_name", string.IsNullOrWhiteSpace(guest.MiddleName) ? (object)DBNull.Value : guest.MiddleName);
                    cmd.Parameters.AddWithValue("@last_name", guest.LastName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@email", guest.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@phone_number", guest.PhoneNumber ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@address", guest.Address ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@age", guest.Age > 0 ? guest.Age : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@date_of_birth", guest.DateOfBirth.HasValue ? guest.DateOfBirth.Value.Date : (object)DBNull.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
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
                    cmd.Parameters.AddWithValue("@guest_id", guestId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
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