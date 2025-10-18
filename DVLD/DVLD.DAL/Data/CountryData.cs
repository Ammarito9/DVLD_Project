using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using DVLD.DAL.DTO;

namespace DVLD.DAL.Data
{
    public class CountryData
    {
        private static object HandleNull(string? value)
        {
            return string.IsNullOrEmpty(value) ? DBNull.Value : value;
        }

        public static DataTable GetByID(int iD)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"SELECT * FROM Countries
                            WHERE ID = @ID";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", iD);

            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                using var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }
        }
        public static DataTable GetByCountryName(string CountryName)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"SELECT * FROM Countries
                            WHERE CountryName = @CountryName";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CountryName", CountryName);

            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                using var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }
        }

        public static int Add(CountryDTO country)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"INSERT INTO Countries (CountryName)
                            VALUES 
							(@CountryName)

							SELECT SCOPE_IDENTITY();";

            using var cmd = new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@CountryName", country.CountryName);

            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(),out int iD))
                    return iD;

                return 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }
        }
        public static int Update(CountryDTO country)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"UPDATE Countries 
                            SET
                            CountryName = @CountryName
                            WHERE ID = @ID;";

            using var cmd = new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@CountryName", country.CountryName);
            cmd.Parameters.AddWithValue("@ID", country.ID);

            try
            {
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                return rows;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }
        }
        public static int Delete(int iD)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"DELETE FROM Countries
                            WHERE ID = @ID;";

            using var cmd = new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@ID",iD);

            try
            {
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                return rows;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }

        }
        public static DataTable GetAll()
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"SELECT * FROM Countries;";

            using var cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();

                DataTable dt = new DataTable();

                using var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }
        }

        public static List<string> GetAllCountryNames()
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"SELECT CountryName FROM Countries;";

            using var cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();

                List<string> CountryNames = new List<string>();

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                    CountryNames.Add(reader.GetString(0));

                return CountryNames;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }
        }
        public static bool IsExist(int iD)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"SELECT 1 FROM Countries
                            WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", iD);
            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();

                return result != null;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }
        }
    }
}
