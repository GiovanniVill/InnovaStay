using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class AuthResult
    {
        public string Status { get; set; } = string.Empty; // "SUCCESS", "INVALID", "LOCKED"
        public string Role { get; set; } = string.Empty;   // "Admin", "Front Desk"
        public int AttemptsLeft { get; set; }
    }
}