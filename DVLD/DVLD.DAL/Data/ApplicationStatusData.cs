using DVLD.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.Data
{
    public static class ApplicationStatusData
    {
        public static DataTable GetByID(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            DataTable dt = new DataTable();

            string query = @"SELECT * FROM ApplicationStatuses
                        WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);

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

            DataTable dt = new DataTable();

            string query = @"SELECT * FROM ApplicationStatuses;";

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
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
        }
    }
}
