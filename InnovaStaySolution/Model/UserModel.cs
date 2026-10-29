using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty; // Galing sa UserProfiles table
        public string Role { get; set; } = string.Empty;
        public int FailedAttempts { get; set; }
        public bool IsLocked { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}