using System;
using System.Windows.Forms;
using CarRentalSystem.Forms;

namespace CarRentalSystem
{
    /// <summary>
    /// Main entry point for the Car Rental Management System application
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
