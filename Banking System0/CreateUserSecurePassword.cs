using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System0
{
    public static class CreateUserSecurePassword
    {
        // Define the minimum password requirements
        private const int MinimumPasswordLength = 5;
        private const int NumberOfNonAlphanumericCharacters = 1;

        // Validate if the user's password meets complexity requirements
        public static bool ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < MinimumPasswordLength)
                return false;

            int nonAlphanumericCount = password.Count(c => !char.IsLetterOrDigit(c));
            if (nonAlphanumericCount < NumberOfNonAlphanumericCharacters)
                return false;

            return true;
        }


        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
