using System;
using System.Data;
using System.IO;
using System.Text;

namespace CarRentalSystem.Classes
{
    /// <summary>
    /// Provides report generation utilities
    /// </summary>
    public class ReportHelper
    {
        /// <summary>
        /// Exports DataTable to CSV format
        /// </summary>
        /// <param name="dt">DataTable to export</param>
        /// <param name="filePath">File path to save CSV</param>
        /// <returns>True if export successful</returns>
        public static bool ExportToCSV(DataTable dt, string filePath)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                // Add column headers
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sb.Append(dt.Columns[i].ColumnName);
                    if (i < dt.Columns.Count - 1)
                        sb.Append(",");
                }
                sb.AppendLine();

                // Add rows
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        sb.Append(row[i].ToString().Replace(",", ";"));
                        if (i < dt.Columns.Count - 1)
                            sb.Append(",");
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(filePath, sb.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Generates rental receipt text
        /// </summary>
        /// <param name="rentalData">DataRow with rental information</param>
        /// <returns>Receipt text</returns>
        public static string GenerateRentalReceipt(DataRow rentalData)
        {
            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine("========================================");
            receipt.AppendLine("     CAR RENTAL MANAGEMENT SYSTEM");
            receipt.AppendLine("            RENTAL RECEIPT");
            receipt.AppendLine("========================================");
            receipt.AppendLine();
            receipt.AppendLine($"Rental ID: {rentalData["RentalID"]}");
            receipt.AppendLine($"Date: {DateTime.Now:yyyy-MM-dd HH:mm}");
            receipt.AppendLine();
            receipt.AppendLine("CUSTOMER INFORMATION:");
            receipt.AppendLine($"Name: {rentalData["CustomerName"]}");
            receipt.AppendLine($"Phone: {rentalData["Phone"]}");
            receipt.AppendLine();
            receipt.AppendLine("VEHICLE INFORMATION:");
            receipt.AppendLine($"Vehicle: {rentalData["VehicleInfo"]}");
            receipt.AppendLine($"Plate Number: {rentalData["PlateNumber"]}");
            receipt.AppendLine();
            receipt.AppendLine("RENTAL DETAILS:");
            receipt.AppendLine($"Start Date: {rentalData["StartDate"]}");
            receipt.AppendLine($"End Date: {rentalData["EndDate"]}");
            receipt.AppendLine($"Total Days: {rentalData["TotalDays"]}");
            receipt.AppendLine($"Daily Rate: ${rentalData["DailyRate"]}");
            receipt.AppendLine();
            receipt.AppendLine("PAYMENT SUMMARY:");
            receipt.AppendLine($"Subtotal: ${rentalData["SubTotal"]}");
            receipt.AppendLine($"Total Amount: ${rentalData["TotalAmount"]}");
            receipt.AppendLine($"Payment Method: {rentalData["PaymentMethod"]}");
            receipt.AppendLine();
            receipt.AppendLine("========================================");
            receipt.AppendLine("     Thank you for your business!");
            receipt.AppendLine("========================================");

            return receipt.ToString();
        }

        /// <summary>
        /// Calculates late fee based on days late
        /// </summary>
        /// <param name="expectedReturnDate">Expected return date</param>
        /// <param name="actualReturnDate">Actual return date</param>
        /// <param name="dailyRate">Daily rental rate</param>
        /// <returns>Late fee amount</returns>
        public static decimal CalculateLateFee(DateTime expectedReturnDate, DateTime actualReturnDate, decimal dailyRate)
        {
            if (actualReturnDate.Date <= expectedReturnDate.Date)
                return 0;

            int daysLate = (actualReturnDate.Date - expectedReturnDate.Date).Days;
            // Late fee is 1.5x the daily rate per day
            return daysLate * dailyRate * 1.5m;
        }

        /// <summary>
        /// Calculates total days between two dates
        /// </summary>
        /// <param name="startDate">Start date</param>
        /// <param name="endDate">End date</param>
        /// <returns>Number of days</returns>
        public static int CalculateTotalDays(DateTime startDate, DateTime endDate)
        {
            int days = (endDate.Date - startDate.Date).Days;
            return days < 1 ? 1 : days; // Minimum 1 day
        }
    }
}
