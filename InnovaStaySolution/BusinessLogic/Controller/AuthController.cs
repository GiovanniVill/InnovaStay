using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class AuthController
    {
        private readonly UserRepository _userRepository;

        public AuthController()
        {
            _userRepository = new UserRepository();
        }

        public AuthResult Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return new AuthResult
                {
                    Status = "INVALID",
                    Role = string.Empty,
                    AttemptsLeft = 3
                };
            }

            return _userRepository.Authenticate(username.Trim(), password.Trim());
        }
    }
}