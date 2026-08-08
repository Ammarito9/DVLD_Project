using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD.DAL.DTO;

namespace DVLD.DAL.Data
{
    public class ServiceData
    {
        public static DataTable GetByID(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT * FROM Services WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                conn.Open();
                using var reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();

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
        public static int Update(ServiceDTO service)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"UPDATE Services
                            SET
                                ServiceName = @ServiceName,
                                ServiceFee = @ServiceFee
                            WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", service.ID);
            cmd.Parameters.AddWithValue("@ServiceName", service.ServiceName);
            cmd.Parameters.AddWithValue("@ServiceFee", service.ServiceFee);

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

            string query = @"SELECT * FROM Services;";

            using var cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                using var reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();

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
        public static bool IsExist(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT 1 FROM Services
                            WHERE ID = @ID;";

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
    }
}
