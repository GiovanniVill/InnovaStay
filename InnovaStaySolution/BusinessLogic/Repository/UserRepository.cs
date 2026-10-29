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
                        while (reader.Read())
                        {
                            list.Add(new UserModel
                            {
                                UserID = Convert.ToInt32(reader["UserID"]),
                                Username = reader["Username"].ToString()!,
                                FullName = reader["FullName"].ToString()!,
                                Role = reader["Role"].ToString()!,
                                FailedAttempts = Convert.ToInt32(reader["FailedAttempts"]),
                                IsLocked = Convert.ToBoolean(reader["IsLocked"]),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
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

                        // Dahil may SET NOCOUNT ON sa procedure, -1 o anumang bilang >= 1 ay tagumpay
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

        public (bool IsSuccess, string ErrorMessage) UpdateUser(UserModel user)
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