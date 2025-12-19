namespace CarRentalSystem.Classes
{
    /// <summary>
    /// Static class to store current logged-in user session data
    /// </summary>
    public static class UserSession
    {
        /// <summary>
        /// Gets or sets the user ID of the logged-in user
        /// </summary>
        public static int UserID { get; set; }

        /// <summary>
        /// Gets or sets the full name of the logged-in user
        /// </summary>
        public static string FullName { get; set; }

        /// <summary>
        /// Gets or sets the role of the logged-in user (Admin or Staff)
        /// </summary>
        public static string Role { get; set; }

        /// <summary>
        /// Clears the session data (used on logout)
        /// </summary>
        public static void ClearSession()
        {
            UserID = 0;
            FullName = string.Empty;
            Role = string.Empty;
        }

        /// <summary>
        /// Checks if user is logged in
        /// </summary>
        /// <returns>True if user is logged in</returns>
        public static bool IsLoggedIn()
        {
            return UserID > 0;
        }

        /// <summary>
        /// Checks if logged-in user is an admin
        /// </summary>
        /// <returns>True if user role is Admin</returns>
        public static bool IsAdmin()
        {
            return Role == "Admin";
        }
    }
}
