using System.Collections.Generic;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class ReservationController
    {
        private readonly ReservationRepository _reservationRepository;

        public ReservationController()
        {
            _reservationRepository = new ReservationRepository();
        }

        public List<ReservationModel> GetRecentReservations(int limit = 10)
        {
            return _reservationRepository.GetRecentReservations(limit);
        }

        public List<ReservationModel> GetActiveStays()
        {
            return _reservationRepository.GetActiveStays();
        }

        public List<ReservationModel> GetPendingCheckIns()
        {
            return _reservationRepository.GetPendingCheckIns();
        }

        // Handles CreateReservationForm.cs
        public (bool Success, string Message) AddReservation(ReservationModel model)
        {
            return _reservationRepository.CreateReservation(model);
        }

        // Alias for CreateReservation
        public (bool Success, string Message) CreateReservation(ReservationModel model)
        {
            return _reservationRepository.CreateReservation(model);
        }

        public (bool Success, string Message) CheckInGuest(int reservationId, int roomId)
        {
            return _reservationRepository.ProcessCheckIn(reservationId, roomId);
        }

        public (bool Success, string Message) CheckOutGuest(int reservationId, int roomId)
        {
            return _reservationRepository.ProcessCheckOut(reservationId, roomId);
        }
    }
}