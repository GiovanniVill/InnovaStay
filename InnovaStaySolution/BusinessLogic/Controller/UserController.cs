using System.Collections.Generic;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class UserController
    {
        private readonly UserRepository _userRepo;

        public UserController()
        {
            _userRepo = new UserRepository();
        }

        public List<UserModel> GetAllUsers()
        {
            return _userRepo.GetAllUsersWithProfiles();
        }

        public (bool IsSuccess, string Message) AddUser(string username, string password, string fullName, string role, string status)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return (false, "Kailangan ilagay ang Username at Password.");

            if (string.IsNullOrWhiteSpace(fullName))
                return (false, "Kailangan ilagay ang Full Name.");

            if (string.IsNullOrWhiteSpace(role))
                return (false, "Pumili ng Role para sa account.");

            var user = new UserModel
            {
                Username = username.Trim(),
                FullName = fullName.Trim(),
                Role = role,
                IsLocked = (status == "Locked")
            };

            var (isSuccess, errorMessage) = _userRepo.AddUser(user, password.Trim());
            if (!isSuccess)
            {
                return (false, !string.IsNullOrEmpty(errorMessage) ? errorMessage : "Hindi naidagdag ang user.");
            }

            return (true, "Matagumpay na naidagdag ang user!");
        }

        public (bool IsSuccess, string Message) UpdateUser(int userId, string username, string fullName, string role, string status)
        {
            if (userId <= 0)
                return (false, "Pumili muna ng user sa table.");

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(fullName))
                return (false, "Hindi maaaring blangko ang Username at Full Name.");

            var user = new UserModel
            {
                UserID = userId,
                Username = username.Trim(),
                FullName = fullName.Trim(),
                Role = role,
                IsLocked = (status == "Locked")
            };

            var (isSuccess, errorMessage) = _userRepo.UpdateUser(user);
            if (!isSuccess)
            {
                return (false, !string.IsNullOrEmpty(errorMessage) ? errorMessage : "Hindi na-update ang user.");
            }

            return (true, "Matagumpay na na-update ang user!");
        }

        public (bool IsSuccess, string Message) DeleteUser(int userId)
        {
            if (userId <= 0)
                return (false, "Pumili muna ng user na buburahin.");

            var (isSuccess, errorMessage) = _userRepo.DeleteUser(userId);
            if (!isSuccess)
            {
                return (false, !string.IsNullOrEmpty(errorMessage) ? errorMessage : "Hindi nabura ang user.");
            }

            return (true, "Matagumpay na nabura ang user!");
        }
    }
}