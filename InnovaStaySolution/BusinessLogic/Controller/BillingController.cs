using System.Collections.Generic;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class BillingController
    {
        private readonly BillingRepository _billingRepo;

        public BillingController()
        {
            _billingRepo = new BillingRepository();
        }

        public List<RoomChargeModel> GetCharges(int reservationId)
        {
            return _billingRepo.GetChargesByReservation(reservationId);
        }

        public (bool Success, string Message) AddCharge(int reservationId, string description, decimal amount)
        {
            return _billingRepo.AddRoomCharge(reservationId, description, amount);
        }

        public decimal GetTotalPayments(int reservationId)
        {
            return _billingRepo.GetTotalPaymentsByReservation(reservationId);
        }

        public (bool Success, string Message) ProcessPayment(PaymentModel payment)
        {
            return _billingRepo.RecordPayment(payment);
        }
    }
}