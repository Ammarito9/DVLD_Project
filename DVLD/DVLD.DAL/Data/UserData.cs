using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD.DAL;
using DVLD.DAL.DTO;

namespace DVLD.DAL.Data
{
    public class UserData
    {
        private static object HandleNull(string? value)
        {
            return string.IsNullOrEmpty(value) ? DBNull.Value : value;
        }

        public static DataTable GetByID(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT * FROM Users WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                conn.Open();

                var dt = new DataTable();

                using var reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.HasRows)
                    dt.Load(reader);

                return dt;
            }
            catch (SqlException ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
        }
        public static DataTable GetByUsername(string Username)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT * FROM Users WHERE Username = @Username;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", Username);

            try
            {
                conn.Open();

                var dt = new DataTable();

                using var reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.HasRows)
                    dt.Load(reader);

                return dt;
            }
            catch (SqlException ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
        }

        public static int Add(UserDTO user)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"INSERT INTO Users (UserName, Password, PersonID, Permissions, IsActive)
                            VALUES
                            (@UserName, @Password, @PersonID, @Permissions, @IsActive)
                            SELECT SCOPE_IDENTITY();";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@PersonID", user.PersonID);
            cmd.Parameters.AddWithValue("@Permissions", user.Permissions);
            cmd.Parameters.AddWithValue("@IsActive", user.IsActive);

            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(), out int ID))
                    return ID;
            
                return 0;
            }
            catch (SqlException ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
        }
        public static int Update(UserDTO user)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"UPDATE Users
                            SET
                                UserName = @UserName,
                                Password = @Password,
                                PersonID = @PersonID,
                                Permissions = @Permissions,
                                IsActive = @IsActive 
                            WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", user.ID);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@PersonID", user.PersonID);
            cmd.Parameters.AddWithValue("@Permissions", user.Permissions);
            cmd.Parameters.AddWithValue("@IsActive", user.IsActive);

            try
            {
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                return rows;
            }
            catch (SqlException ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
        }
        public static int Delete(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"DELETE FROM Users
                            WHERE ID = @ID";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                return rows;
            }
            catch (SqlException ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
        }
        public static DataTable GetAll()
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT u.ID, u.PersonID, p.FirstName + ' ' + p.LastName as FullName, u.Username, u.IsActive FROM Users u
                            JOIN Persons p on u.PersonID = p.ID";

            using var cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();

                using var reader = cmd.ExecuteReader();

                var dt = new DataTable();

                if(reader.HasRows)
                    dt.Load(reader);

                return dt;
            }
            catch (SqlException ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
        }

        public static DataTable GetAllFiltered(String filter, String filterValue)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = "", WhereClause = "";

            switch (filter)
            {
                case "Username":
                    WhereClause = "u.Username LIKE @FilterValue";
                    filterValue = $"%{filterValue}%";
                    break;
                case "FullName":
                    WhereClause = "p.FirstName + ' ' + p.LastName LIKE @FilterValue";
                    filterValue = $"%{filterValue}%";
                    break;
                case "UserId":
                    WhereClause = "u.ID = @FilterValue";
                    break;
                case "PersonId":
                    WhereClause = "u.PersonId = @FilterValue";
                    break;
                case "IsActive":
                    WhereClause = "u.IsActive = @FilterValue";
                    break;
                default:
                    break;
            }

            query = @$"SELECT u.ID, u.PersonID, p.FirstName + ' ' + p.LastName as FullName, u.Username, u.IsActive 
                    FROM Users u
                    JOIN Persons p on u.PersonID = p.ID WHERE {WhereClause};";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FilterValue", filterValue);

            try
            {
                conn.Open();

                using var reader = cmd.ExecuteReader();

                DataTable FilteredUsers = new DataTable();

                if (reader.HasRows)
                    FilteredUsers.Load(reader);

                return FilteredUsers;
            }
            catch (SqlException ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
        }
        public static bool IsExist(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT 1 FROM Users 
                            WHERE ID = @ID";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();
                return result != null;
            }
            catch (SqlException ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
        }

        public static bool IsExist(String Username)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT 1 FROM Users 
                            WHERE Username = @Username";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", Username);

            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();
                return result != null;
            }
            catch (SqlException ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
        }

        public static bool DoesPersonIdConnectedToUser(int id)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"
                                SELECT 1 FROM Users u
                                JOIN Persons p ON p.ID = u.PersonID
                                WHERE p.ID = @id;
                            ";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();
                return (result != null);
            }
            catch (SqlException ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
        }
    }
}
