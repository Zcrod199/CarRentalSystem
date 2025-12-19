using System;
using System.Security.Cryptography;
using System.Text;

namespace CarRentalSystem.Classes
{
    /// <summary>
    /// Provides security-related helper methods
    /// </summary>
    public class SecurityHelper
    {
        /// <summary>
        /// Encrypts password using MD5 hash
        /// </summary>
        /// <param name="password">Plain text password</param>
        /// <returns>MD5 hashed password</returns>
        public static string EncryptPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return string.Empty;

            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// Validates password strength
        /// </summary>
        /// <param name="password">Password to validate</param>
        /// <returns>True if password meets requirements</returns>
        public static bool ValidatePasswordStrength(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            // At least 6 characters
            if (password.Length < 6)
                return false;

            return true;
        }

        /// <summary>
        /// Verifies if entered password matches stored hash
        /// </summary>
        /// <param name="enteredPassword">Plain text password entered by user</param>
        /// <param name="storedHash">Stored password hash</param>
        /// <returns>True if passwords match</returns>
        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            string enteredHash = EncryptPassword(enteredPassword);
            return enteredHash.Equals(storedHash, StringComparison.OrdinalIgnoreCase);
        }
    }
}
