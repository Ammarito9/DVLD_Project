using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLD.DAL.DTO;

namespace DVLD.DAL.Data
{
    public class PersonData
    {
        private static object HandleNull(string? value)
        {
            return string.IsNullOrEmpty(value) ? DBNull.Value : value;
        }
        public static DataTable GetByID(int iD)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            DataTable dt = new DataTable();

            string query = @"SELECT * FROM Persons
                            WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", iD);

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

        public static DataTable GetByNationalNumber(string nationalNumber)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            DataTable dt = new DataTable();

            string query = @"SELECT * FROM Persons
                            WHERE NationalNumber = @NationalNumber;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@NationalNumber", nationalNumber);

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

        //Returns the newly created ID
        public static int Add(PersonDTO person)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"INSERT INTO Persons(NationalityCountryID, NationalNumber, FirstName, SecondName, ThirdName, LastName, Address, DateOfBirth, Email, Gender, PhoneNumber, PersonalPhotoPath)
                            VALUES
                            (@NationalityCountryID, @NationalNumber, @FirstName, @SecondName, @ThirdName, @LastName, @Address, @DateOfBirth, @Email, @Gender, @PhoneNumber, @PersonalPhotoPath);

                            SELECT SCOPE_IDENTITY();";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@NationalityCountryID", person.NationalityCountryID);
            cmd.Parameters.AddWithValue("@NationalNumber", person.NationalNumber);
            cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
            cmd.Parameters.AddWithValue("@SecondName", HandleNull(person.SecondName));
            cmd.Parameters.AddWithValue("@ThirdName", HandleNull(person.ThirdName));
            cmd.Parameters.AddWithValue("@LastName", person.LastName);
            cmd.Parameters.AddWithValue("@Address", person.Address);
            cmd.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
            cmd.Parameters.AddWithValue("@Email", HandleNull(person.Email));
            cmd.Parameters.AddWithValue("@Gender", person.Gender);
            cmd.Parameters.AddWithValue("@PhoneNumber", person.PhoneNumber);
            cmd.Parameters.AddWithValue("@PersonalPhotoPath", HandleNull(person.PersonalPhotoPath));

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
        public static int Update(PersonDTO person)
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
            cmd.Parameters.AddWithValue("@ID", person.ID);
            cmd.Parameters.AddWithValue("@NationalityCountryID", person.NationalityCountryID);
            cmd.Parameters.AddWithValue("@NationalNumber", person.NationalNumber);
            cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
            cmd.Parameters.AddWithValue("@SecondName", HandleNull(person.SecondName));
            cmd.Parameters.AddWithValue("@ThirdName", HandleNull(person.ThirdName));
            cmd.Parameters.AddWithValue("@LastName", person.LastName);
            cmd.Parameters.AddWithValue("@Address", person.Address);
            cmd.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
            cmd.Parameters.AddWithValue("@Email", HandleNull(person.Email));
            cmd.Parameters.AddWithValue("@Gender", person.Gender);
            cmd.Parameters.AddWithValue("@PhoneNumber", person.PhoneNumber);
            cmd.Parameters.AddWithValue("@PersonalPhotoPath", HandleNull(person.PersonalPhotoPath));

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

        public enum FilterBy 
        { 
            None = 0,
            ID,
            NationalNumber,
            Country,
            FirstName,
            SecondName,
            ThirdName,
            LastName,
            Gender,
            Email,
            Address,
            PhoneNumber,
        }
        public static DataTable GetAllFilterBy(FilterBy filter,string filterBy)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            DataTable dt = new DataTable();

            string query = @$"SELECT * FROM Persons
                            WHERE {filter.ToString()} = @filterBy;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@filterBy", filterBy);
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

        public static bool IsExist(string NationalNumber)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"SELECT 1 FROM Persons
                            WHERE NationalNumber = @NationalNumber;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@NationalNumber", NationalNumber);

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
