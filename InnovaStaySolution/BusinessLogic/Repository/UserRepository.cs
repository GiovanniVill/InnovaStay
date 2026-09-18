using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class UserRepository
    {
        private readonly string _connectionString = "Server=localhost;Database=InnovaStayDB;Trusted_Connection=True;TrustServerCertificate=True;";

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
    }
}
