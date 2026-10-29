using System.Collections.Generic;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class ReservationController
    {
        private readonly ReservationRepository _repository;

        public ReservationController()
        {
            _repository = new ReservationRepository();
        }

        public (bool Success, string Message) AddReservation(ReservationModel reservation)
        {
            if (reservation.GuestId <= 0)
                return (false, "Please select a valid guest.");

            if (reservation.RoomId <= 0)
                return (false, "Please select a valid room.");

            if (reservation.CheckOutDate.Date <= reservation.CheckInDate.Date)
                return (false, "Check-out date must be after check-in date.");

            if (reservation.TotalAmount <= 0)
                return (false, "Calculated total must be greater than zero.");

            return _repository.CreateReservation(reservation);
        }

        public List<ReservationModel> GetActiveStays()
        {
            return _repository.GetActiveStays();
        }

        public (bool Success, string Message) CheckOutGuest(int reservationId, int roomId)
        {
            if (reservationId <= 0 || roomId <= 0)
                return (false, "Invalid reservation or room selected.");

            return _repository.ProcessCheckOut(reservationId, roomId);
        }
    }
}