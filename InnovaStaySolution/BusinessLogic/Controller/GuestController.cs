using System;
using System.Collections.Generic;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class GuestController
    {
        private readonly GuestRepository _guestRepository;

        public GuestController()
        {
            _guestRepository = new GuestRepository();
        }

        public (bool Success, string Message) AddGuest(GuestModel guest)
        {
            if (guest == null)
                return (false, "Guest details cannot be null.");

            if (string.IsNullOrWhiteSpace(guest.FirstName))
                return (false, "First name is required.");

            if (string.IsNullOrWhiteSpace(guest.LastName))
                return (false, "Last name is required.");

            if (string.IsNullOrWhiteSpace(guest.PhoneNumber))
                return (false, "Phone number is required.");

            bool isSaved = _guestRepository.AddGuest(guest, out string errorMessage);
            if (!isSaved)
                return (false, string.IsNullOrEmpty(errorMessage) ? "Failed to save guest." : errorMessage);

            return (true, "Guest added successfully.");
        }

        public List<GuestModel> GetAllGuests()
        {
            return _guestRepository.GetAllGuests();
        }

        public (bool Success, string Message) UpdateGuest(GuestModel guest)
        {
            if (guest == null || guest.GuestId <= 0)
                return (false, "Invalid guest record.");

            if (string.IsNullOrWhiteSpace(guest.FirstName))
                return (false, "First name is required.");

            if (string.IsNullOrWhiteSpace(guest.LastName))
                return (false, "Last name is required.");

            if (string.IsNullOrWhiteSpace(guest.PhoneNumber))
                return (false, "Phone number is required.");

            bool isUpdated = _guestRepository.UpdateGuest(guest, out string errorMessage);
            if (!isUpdated)
                return (false, string.IsNullOrEmpty(errorMessage) ? "Failed to update guest." : errorMessage);

            return (true, "Guest updated successfully.");
        }

        public (bool Success, string Message) DeleteGuest(int guestId)
        {
            if (guestId <= 0)
                return (false, "Invalid guest ID.");

            bool isDeleted = _guestRepository.DeleteGuest(guestId, out string errorMessage);
            if (!isDeleted)
                return (false, string.IsNullOrEmpty(errorMessage) ? "Failed to delete guest." : errorMessage);

            return (true, "Guest deleted successfully.");
        }
    }
}