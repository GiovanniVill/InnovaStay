using System;
using System.Collections.Generic;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class RoomController
    {
        private readonly RoomRepository _roomRepository;

        public RoomController()
        {
            _roomRepository = new RoomRepository();
        }

        private bool IsAdmin(string userRole)
        {
            return string.Equals(userRole, "Admin", StringComparison.OrdinalIgnoreCase);
        }

        public (bool Success, string Message) AddRoom(RoomModel room, string userRole)
        {
            if (!IsAdmin(userRole))
                return (false, "Access denied. Only Admins can add rooms.");

            if (room == null)
                return (false, "Room details cannot be null.");

            if (string.IsNullOrWhiteSpace(room.RoomNumber))
                return (false, "Room number is required.");

            if (string.IsNullOrWhiteSpace(room.RoomType))
                return (false, "Room type is required.");

            if (room.PricePerNight <= 0)
                return (false, "Price per night must be greater than zero.");

            if (room.Floor <= 0)
                return (false, "Floor must be a positive number.");

            bool isSaved = _roomRepository.AddRoom(room, out string errorMessage);
            if (!isSaved)
                return (false, string.IsNullOrEmpty(errorMessage) ? "Failed to add room." : errorMessage);

            return (true, "Room added successfully.");
        }

        public List<RoomModel> GetAllRooms()
        {
            return _roomRepository.GetAllRooms();
        }

        public (bool Success, string Message) UpdateRoom(RoomModel room, string userRole)
        {
            if (!IsAdmin(userRole))
                return (false, "Access denied. Only Admins can modify rooms.");

            if (room == null || room.RoomId <= 0)
                return (false, "Invalid room record.");

            if (string.IsNullOrWhiteSpace(room.RoomNumber))
                return (false, "Room number is required.");

            if (string.IsNullOrWhiteSpace(room.RoomType))
                return (false, "Room type is required.");

            if (room.PricePerNight <= 0)
                return (false, "Price per night must be greater than zero.");

            bool isUpdated = _roomRepository.UpdateRoom(room, out string errorMessage);
            if (!isUpdated)
                return (false, string.IsNullOrEmpty(errorMessage) ? "Failed to update room." : errorMessage);

            return (true, "Room updated successfully.");
        }

        public (bool Success, string Message) DeleteRoom(int roomId, string userRole)
        {
            if (!IsAdmin(userRole))
                return (false, "Access denied. Only Admins can delete rooms.");

            if (roomId <= 0)
                return (false, "Invalid room ID.");

            bool isDeleted = _roomRepository.DeleteRoom(roomId, out string errorMessage);
            if (!isDeleted)
                return (false, string.IsNullOrEmpty(errorMessage) ? "Failed to delete room." : errorMessage);

            return (true, "Room deleted successfully.");
        }
    }
}