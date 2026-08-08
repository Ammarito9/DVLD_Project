using DVLD.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.Data
{
    public static class LicenseData
    {
        public static DataTable GetByID(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            DataTable dt = new DataTable();

            string query = @"SELECT l.*, lc.ClassName, lt.TypeName, u.username FROM Licenses l
                            JOIN LicenseClasses lc on l.LicenseClassID = lc.ID
                            JOIN LicenseTypes lt on l.LicenseTypeID = lt.ID
                            JOIN Drivers d on l.DriverID = d.ID
                            JOIN Users u on l.CreatedByUserID = u.ID
                            JOIN Applications a on l.ApplicationID = a.ID
                            WHERE l.ID = @ID;";

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
        public static DataTable GetLicense(string nationalNumber, int licenseClassID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            DataTable dt = new DataTable();

            string query = @"
SELECT 
    l.*,
    lc.ClassName,
    lt.TypeName,
    u.username
FROM Licenses l
    JOIN LicenseClasses lc on l.LicenseClassID = lc.ID
    JOIN LicenseTypes lt on l.LicenseTypeID = lt.ID
    JOIN Drivers d on l.DriverID = d.ID
    JOIN Users u on l.CreatedByUserID = u.ID
    JOIN Applications a on l.ApplicationID = a.ID
    JOIN Persons p ON d.PersonID = p.ID 
WHERE p.NationalNumber = @NationalNumber AND lc.ID = @LicenseClassID AND l.IsActive = 1;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@NationalNumber", nationalNumber);
            cmd.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

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

        public static DataRow? GetLicenseInfoDetailed(int licenseID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            DataTable dt = new DataTable();

            string query = @"
SELECT
	lc.ClassName,
    lc.ID AS ClassID,
	CONCAT_WS(' ',p.FirstName, p.SecondName, p.ThirdName, p.LastName) AS Fullname,
	l.ID AS LicenseID,
	p.NationalNumber,
	CASE 
		WHEN p.Gender = 'M' THEN 'Male'
		ELSE 'Female'
	END AS Gender,
	l.IssueDate,
	lt.TypeName AS IssueReason,
	l.LicenseNote,
	l.IsActive,
	p.DateOfBirth,
	d.ID AS DriverID,
	l.ExpiryDate,
	CASE
		WHEN (SELECT 1 FROM LicenseDetentions ld WHERE ld.LicenseID = l.ID AND ld.IsReleased = 0) = 1 THEN 'Yes'
		ELSE 'No'
	END AS IsDetained,
    p.PersonalPhotoPath
FROM Licenses l
JOIN LicenseClasses lc ON l.LicenseClassID = lc.ID
JOIN LicenseTypes lt ON l.LicenseTypeID = lt.ID
JOIN Applications a ON l.ApplicationID = a.ID
JOIN Persons p ON a.PersonID = p.ID
JOIN Drivers d ON d.PersonID = p.ID
WHERE l.ID = @ID;"; // I have deleted this ( AND l.IsActive = 1) from this line.

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", licenseID);

            try
            {
                conn.Open();

                using var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                if (dt.Rows.Count <= 0)
                    return null;

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

            DataTable dt = new DataTable();

            string query = @"SELECT l.*, lc.ClassName, lt.TypeName, u.username FROM Licenses l
                            JOIN LicenseClasses lc on l.LicenseClassID = lc.ID
                            JOIN LicenseTypes lt on l.LicenseTypeID = lt.ID
                            JOIN Drivers d on l.DriverID = d.ID
                            JOIN Users u on l.CreatedByUserID = u.ID
                            JOIN Applications a on l.ApplicationID = a.ID;";

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
        public static int Add(LicenseDTO license)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"INSERT INTO Licenses
                            (DriverID, LicenseClassID, LicenseTypeID, CreatedByUserID, ApplicationID, IssueDate, ExpiryDate, IsActive, LicenseNumber, LicenseNote, PaidFee)
                            VALUES
                            (@DriverID, @LicenseClassID, @LicenseTypeID, @CreatedByUserID, @ApplicationID, @IssueDate, @ExpiryDate, @IsActive, @LicenseNumber, @LicenseNote, @PaidFee);

                            SELECT SCOPE_IDENTITY();";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@DriverID",license.DriverId);
            cmd.Parameters.AddWithValue("@LicenseClassID",license.LicenseClassId);
            cmd.Parameters.AddWithValue("@LicenseTypeID",license.LicenseTypeId);
            cmd.Parameters.AddWithValue("@CreatedByUserID",license.CreatedByUserId);
            cmd.Parameters.AddWithValue("@ApplicationID",license.ApplicationId);
            cmd.Parameters.AddWithValue("@IssueDate",license.IssueDate);
            cmd.Parameters.AddWithValue("@ExpiryDate",license.ExpiryDate);
            cmd.Parameters.AddWithValue("@IsActive",license.IsActive);
            cmd.Parameters.AddWithValue("@LicenseNumber",license.LicenseNumber);
            if(license.LicenseNote is null)
                cmd.Parameters.AddWithValue("@LicenseNote",Convert.DBNull);
            else
                cmd.Parameters.AddWithValue("@LicenseNote", license.LicenseNote);
            cmd.Parameters.AddWithValue("@PaidFee",license.PaidFee);

            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result is not null && int.TryParse(result.ToString(), out int ID))
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
        public static int Update(LicenseDTO license)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"UPDATE Licenses 
                            SET
                                DriverID = @DriverID,
                                LicenseClassID = @LicenseClassID,
                                LicenseTypeID = @LicenseTypeID,
                                CreatedByUserID = @CreatedByUserID,
                                ApplicationID = @ApplicationID,
                                IssueDate = @IssueDate,
                                ExpiryDate = @ExpiryDate,
                                IsActive = @IsActive,
                                LicenseNumber = @LicenseNumber,
                                LicenseNote = @LicenseNote,
                                PaidFee = @PaidFee
                            WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", license.ID);
            cmd.Parameters.AddWithValue("@DriverID", license.DriverId);
            cmd.Parameters.AddWithValue("@LicenseClassID", license.LicenseClassId);
            cmd.Parameters.AddWithValue("@LicenseTypeID", license.LicenseTypeId);
            cmd.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserId);
            cmd.Parameters.AddWithValue("@ApplicationID", license.ApplicationId);
            cmd.Parameters.AddWithValue("@IssueDate", license.IssueDate);
            cmd.Parameters.AddWithValue("@ExpiryDate", license.ExpiryDate);
            cmd.Parameters.AddWithValue("@IsActive", license.IsActive);
            cmd.Parameters.AddWithValue("@LicenseNumber", license.LicenseNumber);
            if (license.LicenseNote is null)
                cmd.Parameters.AddWithValue("@LicenseNote", Convert.DBNull);
            else
                cmd.Parameters.AddWithValue("@LicenseNote", license.LicenseNote);
            cmd.Parameters.AddWithValue("@PaidFee", license.PaidFee);

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

            string query = @"DELETE FROM Licenses
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

            string query = @"SELECT 1 FROM Licenses
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
    }
}
