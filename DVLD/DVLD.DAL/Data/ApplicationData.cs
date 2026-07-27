using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD.DAL.DTO;

namespace DVLD.DAL.Data
{
    public static class ApplicationData
    {
        public static DataTable GetByID(int iD)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            DataTable dt = new DataTable();

            string query = @"Select * From Applications
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
        public static DataRow GetByIDDetailed(int ID)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            DataTable dt = new DataTable();

            string query = @"SELECT 
	a.ID,
    p.ID AS PersonID,
	CONCAT_WS(' ',p.FirstName, p.SecondName, p.ThirdName, p.LastName) AS Fullname,
	s.ServiceName,
	ast.StatusName,
	u.Username,
	a.ApplicationDate,
	a.LastStatusDate,
	a.ApplicationPaidFee
FROM Applications a
	JOIN Persons p ON a.PersonID = p.ID
	JOIN Services s ON a.ServiceID = s.ID
	JOIN ApplicationStatuses ast ON a.ApplicationStatusID = ast.ID
	JOIN Users u ON a.CreatedByUserID = u.ID
WHERE a.ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                conn.Open();

                using var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                return dt.Rows[0];
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

            string query = @"Select * From Applications;";

            using var cmd = new SqlCommand(query, conn);

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
        public static int Add(ApplicationDTO applicationDTO)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"INSERT INTO Applications (PersonID, ServiceID, ApplicationStatusID, LastStatusDate, ApplicationDate, CreatedByUserID, ApplicationPaidFee)
                            VALUES
                            (@PersonID, @ServiceID, @ApplicationStatusID, @LastStatusDate, @ApplicationDate, @CreatedByUserID, @ApplicationPaidFee);

                            SELECT SCOPE_IDENTITY();";
            
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@PersonID", applicationDTO.PersonID);
            cmd.Parameters.AddWithValue("@ServiceID", applicationDTO.ServiceID);
            cmd.Parameters.AddWithValue("@ApplicationStatusID", applicationDTO.ApplicationStatusID);
            cmd.Parameters.AddWithValue("@LastStatusDate", applicationDTO.LastStatusDate);
            cmd.Parameters.AddWithValue("@ApplicationDate", applicationDTO.ApplicationDate);
            cmd.Parameters.AddWithValue("@CreatedByUserID", applicationDTO.CreatedByUserID);
            cmd.Parameters.AddWithValue("@ApplicationPaidFee", applicationDTO.ApplicationPaidFee);

            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                    return id;

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
        public static int Update(ApplicationDTO applicationDTO)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"UPDATE Applications 
                            SET
                                PersonID = @PersonID,
                                ServiceID = @ServiceID, 
                                ApplicationStatusID = @ApplicationStatusID, 
                                LastStatusDate = @LastStatusDate, 
                                ApplicationPaidFee = @ApplicationPaidFee
                            WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", applicationDTO.ID);
            cmd.Parameters.AddWithValue("@PersonID", applicationDTO.PersonID);
            cmd.Parameters.AddWithValue("@ServiceID", applicationDTO.ServiceID);
            cmd.Parameters.AddWithValue("@ApplicationStatusID", applicationDTO.ApplicationStatusID);
            cmd.Parameters.AddWithValue("@LastStatusDate", applicationDTO.LastStatusDate);
            cmd.Parameters.AddWithValue("@ApplicationPaidFee", applicationDTO.ApplicationPaidFee);

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

            string query = @"DELETE FROM Applications
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
        public static bool IsExist(int iD)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"SELECT 1 FROM Applications
                            WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", iD);
            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();

                return result is not null;
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
