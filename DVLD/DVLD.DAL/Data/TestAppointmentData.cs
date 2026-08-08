using DVLD.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.Data
{
    public static class TestAppointmentData
    {
        public static DataRow GetByID(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT * FROM TestAppointments
                            WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                conn.Open();
    
                DataTable dt = new DataTable();
                using var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                return dt.Rows[0];
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

            string query = @"SELECT * FROM TestAppointments;";

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
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
        }
        public static DataTable GetAllFiltered(int testTypeID, int localDrivingLicenseApplicationID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT * FROM TestAppointments
WHERE TestTypeID = @ID AND LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", testTypeID);
            cmd.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);

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
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
        }
        public static int Add(TestAppointmentDTO testAppointmentDTO)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"INSERT INTO TestAppointments(TestTypeID, LocalDrivingLicenseApplicationID, CreatedByUserID, ScheduledDate, PaidFee, IsLocked, RetakeTestApplicationID)
                            VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @CreatedByUserID, @ScheduledDate, @PaidFee, @IsLocked, @RetakeTestApplicationID);

                            SELECT SCOPE_IDENTITY();";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TestTypeID", testAppointmentDTO.TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", testAppointmentDTO.LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", testAppointmentDTO.CreatedByUserID);
            cmd.Parameters.AddWithValue("@ScheduledDate", testAppointmentDTO.ScheduledDate);
            cmd.Parameters.AddWithValue("@PaidFee", testAppointmentDTO.PaidFee);
            cmd.Parameters.AddWithValue("@IsLocked", testAppointmentDTO.IsLocked);
            cmd.Parameters.AddWithValue("@RetakeTestApplicationID", testAppointmentDTO.RetakeTestApplicationID is null ? Convert.DBNull : testAppointmentDTO.RetakeTestApplicationID);
          
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
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
        }
        public static int Update(TestAppointmentDTO testAppointmentDTO)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"UPDATE TestAppointments 
                            SET
                                TestTypeID = @TestTypeID,
                                LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                                CreatedByUserID = @CreatedByUserID,
                                ScheduledDate = @ScheduledDate,
                                PaidFee = @PaidFee,
                                IsLocked = @IsLocked,
                                RetakeTestApplicationID = @RetakeTestApplicationID
                            WHERE ID = @ID";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", testAppointmentDTO.ID);
            cmd.Parameters.AddWithValue("@TestTypeID", testAppointmentDTO.TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", testAppointmentDTO.LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", testAppointmentDTO.CreatedByUserID);
            cmd.Parameters.AddWithValue("@ScheduledDate", testAppointmentDTO.ScheduledDate);
            cmd.Parameters.AddWithValue("@PaidFee", testAppointmentDTO.PaidFee);
            cmd.Parameters.AddWithValue("@IsLocked", testAppointmentDTO.IsLocked);
            cmd.Parameters.AddWithValue("@RetakeTestApplicationID", testAppointmentDTO.RetakeTestApplicationID is null ? Convert.DBNull : testAppointmentDTO.RetakeTestApplicationID);

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
        public static int Delete(int iD)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"DELETE FROM TestAppointments
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
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
        }
        public static bool IsExist(int iD)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT 1 FROM TestAppointments
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
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogEntryType.Error);
            }
        }
        // It counts the number of the privous test appointments witch are the number of trials
        public static int GetNumberOfTestTrials(int localDrivingLicenseID, int testTypeID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT Count(t.ID) AS Trials FROM TestAppointments t
                            WHERE t.LocalDrivingLicenseApplicationID = @ID AND t.TestTypeID = @testType;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", localDrivingLicenseID);
            cmd.Parameters.AddWithValue("@testType", testTypeID);

            try
            {
                conn.Open();

                DataTable dt = new DataTable();

                object result = cmd.ExecuteScalar();

                if (result is not null && int.TryParse(result.ToString(), out int trials))
                    return trials;

                return -1;
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
        public static bool IsThereActiveAppointment(int localDrivingLicenseID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT 1 FROM TestAppointments t
                            WHERE t.LocalDrivingLicenseApplicationID = @ID AND t.IsLocked = 0;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", localDrivingLicenseID);
            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();

                if(result is not null && int.TryParse(result.ToString(), out int res))
                    return res == 1 ? true : false;

                return false;
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
