using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CarRentalSystem.Classes
{
    /// <summary>
    /// Handles all database connection and query execution operations
    /// </summary>
    public class DatabaseConnection
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["CarRentalDB"].ConnectionString;

        /// <summary>
        /// Returns a new SQL connection
        /// </summary>
        /// <returns>SqlConnection object</returns>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        /// <summary>
        /// Executes INSERT, UPDATE, DELETE queries
        /// </summary>
        /// <param name="query">SQL query string</param>
        /// <param name="parameters">SQL parameters array</param>
        /// <returns>Number of rows affected</returns>
        public static int ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database error: " + ex.Message);
            }
        }

        /// <summary>
        /// Executes SELECT queries and returns DataTable
        /// </summary>
        /// <param name="query">SQL query string</param>
        /// <param name="parameters">SQL parameters array</param>
        /// <returns>DataTable with query results</returns>
        public static DataTable ExecuteReader(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database error: " + ex.Message);
            }
        }

        /// <summary>
        /// Executes queries that return a single value (COUNT, SUM, etc.)
        /// </summary>
        /// <param name="query">SQL query string</param>
        /// <param name="parameters">SQL parameters array</param>
        /// <returns>Single value result</returns>
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database error: " + ex.Message);
            }
        }

        /// <summary>
        /// Test database connection
        /// </summary>
        /// <returns>True if connection successful</returns>
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
