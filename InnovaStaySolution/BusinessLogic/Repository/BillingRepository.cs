using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class BillingRepository
    {
        private readonly string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=InnovaStayDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public List<RoomChargeModel> GetChargesByReservation(int reservationId)
        {
            var list = new List<RoomChargeModel>();
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = "SELECT ChargeId, ReservationId, Description, Amount, ChargedAt FROM dbo.tbl_RoomCharges WHERE ReservationId = @ReservationId ORDER BY ChargedAt ASC;";
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@ReservationId", SqlDbType.Int).Value = reservationId;

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new RoomChargeModel
                    {
                        ChargeId = Convert.ToInt32(reader["ChargeId"]),
                        ReservationId = Convert.ToInt32(reader["ReservationId"]),
                        Description = reader["Description"].ToString() ?? string.Empty,
                        Amount = Convert.ToDecimal(reader["Amount"]),
                        ChargedAt = Convert.ToDateTime(reader["ChargedAt"])
                    });
                }
            }
            catch { }
            return list;
        }

        public (bool Success, string Message) AddRoomCharge(int reservationId, string description, decimal amount)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = "INSERT INTO dbo.tbl_RoomCharges (ReservationId, Description, Amount) VALUES (@ReservationId, @Description, @Amount);";
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@ReservationId", SqlDbType.Int).Value = reservationId;
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 150).Value = description;
                cmd.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;

                int rows = cmd.ExecuteNonQuery();
                return (rows > 0, rows > 0 ? "Charge posted successfully." : "Failed to post charge.");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public decimal GetTotalPaymentsByReservation(int reservationId)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = "SELECT ISNULL(SUM(AmountPaid), 0) FROM dbo.tbl_Payments WHERE ReservationId = @ReservationId;";
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@ReservationId", SqlDbType.Int).Value = reservationId;

                return Convert.ToDecimal(cmd.ExecuteScalar() ?? 0);
            }
            catch
            {
                return 0m;
            }
        }

        public (bool Success, string Message) RecordPayment(PaymentModel payment)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                    INSERT INTO dbo.tbl_Payments (ReservationId, PaymentMethod, AmountPaid, PaymentDate, PaymentStatus)
                    VALUES (@ReservationId, @PaymentMethod, @AmountPaid, @PaymentDate, @PaymentStatus);";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@ReservationId", SqlDbType.Int).Value = payment.ReservationId;
                cmd.Parameters.Add("@PaymentMethod", SqlDbType.NVarChar, 50).Value = payment.PaymentMethod;
                cmd.Parameters.Add("@AmountPaid", SqlDbType.Decimal).Value = payment.AmountPaid;
                cmd.Parameters.Add("@PaymentDate", SqlDbType.DateTime).Value = payment.PaymentDate;
                cmd.Parameters.Add("@PaymentStatus", SqlDbType.NVarChar, 50).Value = payment.PaymentStatus;

                int rows = cmd.ExecuteNonQuery();
                return (rows > 0, rows > 0 ? "Payment recorded successfully." : "Failed to record payment.");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}