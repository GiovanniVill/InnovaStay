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
                return (false, "Username and Password are required.");

            if (string.IsNullOrWhiteSpace(role))
                return (false, "Please select a Role for the account.");

            string resolvedFullName = string.IsNullOrWhiteSpace(fullName) ? username.Trim() : fullName.Trim();

            var user = new UserModel
            {
                Username = username.Trim(),
                FullName = resolvedFullName,
                Role = role,
                IsLocked = (status == "Locked")
            };

            var (isSuccess, errorMessage) = _userRepo.AddUser(user, password.Trim());
            if (!isSuccess)
            {
                return (false, !string.IsNullOrEmpty(errorMessage) ? errorMessage : "Failed to add user account.");
            }

            return (true, "User account added successfully!");
        }

        public (bool IsSuccess, string Message) UpdateUser(int userId, string username, string fullName, string role, string status, string? newPassword = null)
        {
            if (userId <= 0)
                return (false, "Please select a user from the table first.");

            if (string.IsNullOrWhiteSpace(username))
                return (false, "Username cannot be empty.");

            string resolvedFullName = string.IsNullOrWhiteSpace(fullName) ? username.Trim() : fullName.Trim();

            var user = new UserModel
            {
                UserID = userId,
                Username = username.Trim(),
                FullName = resolvedFullName,
                Role = role,
                IsLocked = (status == "Locked")
            };

            string? trimmedPassword = string.IsNullOrWhiteSpace(newPassword) ? null : newPassword.Trim();

            var (isSuccess, errorMessage) = _userRepo.UpdateUser(user, trimmedPassword);
            if (!isSuccess)
            {
                return (false, !string.IsNullOrEmpty(errorMessage) ? errorMessage : "Failed to update user account.");
            }

            return (true, "User account updated successfully!");
        }

        public (bool IsSuccess, string Message) DeleteUser(int userId)
        {
            if (userId <= 0)
                return (false, "Please select a user to delete.");

            var (isSuccess, errorMessage) = _userRepo.DeleteUser(userId);
            if (!isSuccess)
            {
                return (false, !string.IsNullOrEmpty(errorMessage) ? errorMessage : "Failed to delete user account.");
            }

            return (true, "User account deleted successfully!");
        }
    }
}