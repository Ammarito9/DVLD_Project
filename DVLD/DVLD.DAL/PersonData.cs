using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DVLD.DAL
{
    public class PersonData
    {
        private static object HandleNull(string? value)
        {
            return string.IsNullOrEmpty(value) ? DBNull.Value : value;
        }
        public static bool GetByID(int iD, ref int nationalityCountryID, ref string nationalNumber, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref string gender, ref DateTime dateOfBirth, ref string email, ref string address, ref string phoneNumber, ref string personalPhotoPath)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"SELECT * FROM Persons
                            WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", iD);

            try
            {
                conn.Open();

                using var reader = cmd.ExecuteReader();

                if (!reader.Read())
                    return false;

                nationalityCountryID = (int)reader["NationalityCountryID"];
                nationalNumber = (string)reader["NationalNumber"];
                firstName = (string)reader["FirstName"];
                secondName = reader["SecondName"] == DBNull.Value ? null : (string)reader["SecondName"];
                thirdName = reader["ThirdName"] == DBNull.Value ? null : (string)reader["ThirdName"];
                lastName = (string)reader["LastName"];
                gender = (string)reader["Gender"];
                dateOfBirth = (DateTime)reader["DateOfBirth"];
                email = reader["Email"] == DBNull.Value ? null : (string)reader["Email"];
                address = (string)reader["Address"];
                phoneNumber = (string)reader["PhoneNumber"];
                personalPhotoPath = reader["PersonalPhotoPath"] == DBNull.Value ? null : (string)reader["PersonalPhotoPath"];

                return true;
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

        public static bool GetByNationalNumber(ref int iD, ref int nationalityCountryID, string nationalNumber, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref string gender, ref DateTime dateOfBirth, ref string email, ref string address, ref string phoneNumber, ref string personalPhotoPath)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"SELECT * FROM Persons
                            WHERE NationalNumber = @NationalNumber;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@NationalNumber", nationalNumber);

            try
            {
                conn.Open();

                using var reader = cmd.ExecuteReader();

                if (!reader.Read())
                    return false;
                
                iD = (int)reader["ID"];
                nationalityCountryID = (int)reader["NationalityCountryID"];
                firstName = (string)reader["FirstName"];
                secondName = reader["SecondName"] == DBNull.Value ? null : (string)reader["SecondName"];
                thirdName = reader["ThirdName"] == DBNull.Value ? null : (string)reader["ThirdName"];
                lastName = (string)reader["LastName"];
                gender = (string)reader["Gender"];
                dateOfBirth = (DateTime)reader["DateOfBirth"];
                email = reader["Email"] == DBNull.Value ? null : (string)reader["Email"];
                address = (string)reader["Address"];
                phoneNumber = (string)reader["PhoneNumber"];
                personalPhotoPath = reader["PersonalPhotoPath"] == DBNull.Value ? null : (string)reader["PersonalPhotoPath"];

                return true;
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

        //Returns the newly created ID
        public static int Add(int nationalityCountryID, string nationalNumber, string firstName, string secondName, string thirdName, string lastName, string gender, DateTime dateOfBirth, string email, string address, string phoneNumber, string personalPhotoPath)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"INSERT INTO Persons(NationalityCountryID, NationalNumber, FirstName, SecondName, ThirdName, LastName, Address, DateOfBirth, Email, Gender, PhoneNumber, PersonalPhotoPath)
                            VALUES
                            (@NationalityCountryID, @NationalNumber, @FirstName, @SecondName, @ThirdName, @LastName, @Address, @DateOfBirth, @Email, @Gender, @PhoneNumber, @PersonalPhotoPath);

                            SELECT SCOPE_IDENTITY();";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);
            cmd.Parameters.AddWithValue("@NationalNumber", nationalNumber);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@SecondName", HandleNull(secondName));
            cmd.Parameters.AddWithValue("@ThirdName", HandleNull(thirdName));
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@Email", HandleNull(email));
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            cmd.Parameters.AddWithValue("@PersonalPhotoPath", HandleNull(personalPhotoPath));

            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                    return ID;

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
        //Returns the number of rows effected!
        public static int Update(int iD, int nationalityCountryID, string nationalNumber, string firstName, string secondName, string thirdName, string lastName, string gender, DateTime dateOfBirth, string email, string address, string phoneNumber, string personalPhotoPath)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"UPDATE Persons
                            SET 
                                NationalityCountryID = @nationalityCountryID,
                                NationalNumber = @nationalNumber,
                                FirstName = @firstName,
                                SecondName = @secondName,
                                ThirdName = @thirdName,
                                LastName = @lastName,
                                Address = @address,
                                DateOfBirth = @dateOfBirth,
                                Email = @email,
                                Gender = @gender,
                                PhoneNumber = @phoneNumber,
                                PersonalPhotoPath = @personalPhotoPath
                            WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", iD);
            cmd.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);
            cmd.Parameters.AddWithValue("@NationalNumber", nationalNumber);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@SecondName", HandleNull(secondName));
            cmd.Parameters.AddWithValue("@ThirdName", HandleNull(thirdName));
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@Email", HandleNull(email));
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            cmd.Parameters.AddWithValue("@PersonalPhotoPath", HandleNull(personalPhotoPath));

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

            string query = @"DELETE FROM Persons
                            WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", iD);

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

            DataTable dt = new DataTable();

            string query = @"SELECT * FROM Persons;";

            using var cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();

                using var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

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

        public static bool IsExist(int iD)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"SELECT 1 FROM Persons
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
