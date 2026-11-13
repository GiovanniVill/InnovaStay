using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class UserRepository
    {
        private readonly string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=InnovaStayDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public AuthResult Authenticate(string username, string password)
        {
            var result = new AuthResult
            {
                Status = "INVALID",
                Role = string.Empty,
                AttemptsLeft = 0
            };

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spAuthenticateUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", password);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result.Status = reader["AuthStatus"] != DBNull.Value ? reader["AuthStatus"].ToString()! : "INVALID";
                            result.Role = reader["Role"] != DBNull.Value ? reader["Role"].ToString()! : string.Empty;
                            result.AttemptsLeft = reader["AttemptsLeft"] != DBNull.Value ? Convert.ToInt32(reader["AttemptsLeft"]) : 0;
                        }
                    }
                }
            }

            return result;
        }

        public List<UserModel> GetAllUsersWithProfiles()
        {
            var list = new List<UserModel>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spGetAllUsersWithProfiles", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        var cols = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            cols.Add(reader.GetName(i));
                        }

                        while (reader.Read())
                        {
                            string username = cols.Contains("Username") && reader["Username"] != DBNull.Value
                                ? reader["Username"].ToString()! : "";

                            string fullName = cols.Contains("FullName") && reader["FullName"] != DBNull.Value
                                ? reader["FullName"].ToString()! : username;

                            int userId = cols.Contains("UserID") && reader["UserID"] != DBNull.Value
                                ? Convert.ToInt32(reader["UserID"]) : 0;

                            string role = cols.Contains("Role") && reader["Role"] != DBNull.Value
                                ? reader["Role"].ToString()! : "FrontDesk";

                            int failedAttempts = cols.Contains("FailedAttempts") && reader["FailedAttempts"] != DBNull.Value
                                ? Convert.ToInt32(reader["FailedAttempts"]) : 0;

                            bool isLocked = cols.Contains("IsLocked") && reader["IsLocked"] != DBNull.Value
                                && Convert.ToBoolean(reader["IsLocked"]);

                            DateTime createdAt = cols.Contains("CreatedAt") && reader["CreatedAt"] != DBNull.Value
                                ? Convert.ToDateTime(reader["CreatedAt"]) : DateTime.Now;

                            list.Add(new UserModel
                            {
                                UserID = userId,
                                Username = username,
                                FullName = fullName,
                                Role = role,
                                FailedAttempts = failedAttempts,
                                IsLocked = isLocked,
                                CreatedAt = createdAt
                            });
                        }
                    }
                }
            }

            return list;
        }

        public (bool IsSuccess, string ErrorMessage) AddUser(UserModel user, string plainPassword)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("spAddUserWithProfile", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", user.Username);
                        cmd.Parameters.AddWithValue("@PasswordHash", plainPassword);
                        cmd.Parameters.AddWithValue("@FullName", user.FullName);
                        cmd.Parameters.AddWithValue("@Role", user.Role);
                        cmd.Parameters.AddWithValue("@IsLocked", user.IsLocked);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        bool ok = (rows >= 1 || rows == -1);
                        return (ok, string.Empty);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    return (false, $"Mayroon nang account na may username na '{user.Username}'. Pumili ng ibang username.");
                }
                return (false, $"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"System error: {ex.Message}");
            }
        }

        public (bool IsSuccess, string ErrorMessage) UpdateUser(UserModel user, string? plainPassword = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("spUpdateUserWithProfile", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserID", user.UserID);
                        cmd.Parameters.AddWithValue("@Username", user.Username);
                        cmd.Parameters.AddWithValue("@FullName", user.FullName);
                        cmd.Parameters.AddWithValue("@Role", user.Role);
                        cmd.Parameters.AddWithValue("@IsLocked", user.IsLocked);
                        cmd.Parameters.AddWithValue("@PasswordHash", string.IsNullOrWhiteSpace(plainPassword) ? DBNull.Value : plainPassword);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        bool ok = (rows >= 1 || rows == -1);
                        return (ok, string.Empty);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    return (false, $"Mayroon nang ibang account na gumagamit ng username na '{user.Username}'.");
                }
                return (false, $"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"System error: {ex.Message}");
            }
        }

        public (bool IsSuccess, string ErrorMessage) DeleteUser(int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("spDeleteUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        bool ok = (rows >= 1 || rows == -1);
                        return (ok, string.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, $"Database error: {ex.Message}");
            }
        }
    }
}