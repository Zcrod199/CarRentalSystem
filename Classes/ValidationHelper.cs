using System;
using System.Text.RegularExpressions;

namespace CarRentalSystem.Classes
{
    /// <summary>
    /// Provides input validation helper methods
    /// </summary>
    public class ValidationHelper
    {
        /// <summary>
        /// Validates email format
        /// </summary>
        /// <param name="email">Email address to validate</param>
        /// <returns>True if email is valid</returns>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Validates phone number format
        /// </summary>
        /// <param name="phone">Phone number to validate</param>
        /// <returns>True if phone is valid</returns>
        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            // Remove common formatting characters
            string cleanPhone = phone.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            
            // Check if it contains only digits and is reasonable length
            return Regex.IsMatch(cleanPhone, @"^\d{7,15}$");
        }

        /// <summary>
        /// Validates if string is not empty
        /// </summary>
        /// <param name="value">String to validate</param>
        /// <returns>True if not empty</returns>
        public static bool IsNotEmpty(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Validates numeric input
        /// </summary>
        /// <param name="value">Value to validate</param>
        /// <returns>True if numeric</returns>
        public static bool IsNumeric(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            return double.TryParse(value, out _);
        }

        /// <summary>
        /// Validates decimal input
        /// </summary>
        /// <param name="value">Value to validate</param>
        /// <param name="result">Parsed decimal result</param>
        /// <returns>True if valid decimal</returns>
        public static bool IsValidDecimal(string value, out decimal result)
        {
            return decimal.TryParse(value, out result);
        }

        /// <summary>
        /// Validates integer input
        /// </summary>
        /// <param name="value">Value to validate</param>
        /// <param name="result">Parsed integer result</param>
        /// <returns>True if valid integer</returns>
        public static bool IsValidInteger(string value, out int result)
        {
            return int.TryParse(value, out result);
        }

        /// <summary>
        /// Validates date input
        /// </summary>
        /// <param name="value">Value to validate</param>
        /// <param name="result">Parsed date result</param>
        /// <returns>True if valid date</returns>
        public static bool IsValidDate(string value, out DateTime result)
        {
            return DateTime.TryParse(value, out result);
        }

        /// <summary>
        /// Validates if date is not in the past
        /// </summary>
        /// <param name="date">Date to validate</param>
        /// <returns>True if date is today or in future</returns>
        public static bool IsNotPastDate(DateTime date)
        {
            return date.Date >= DateTime.Now.Date;
        }

        /// <summary>
        /// Validates if end date is after start date
        /// </summary>
        /// <param name="startDate">Start date</param>
        /// <param name="endDate">End date</param>
        /// <returns>True if end date is after start date</returns>
        public static bool IsValidDateRange(DateTime startDate, DateTime endDate)
        {
            return endDate.Date >= startDate.Date;
        }
    }
}
