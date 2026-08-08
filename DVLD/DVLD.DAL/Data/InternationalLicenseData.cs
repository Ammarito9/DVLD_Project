using DVLD.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.DAL.Data
{
    public static class InternationalLicenseData
    {
        public static DataTable GetByID(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            DataTable dt = new DataTable();

            string query = @"
SELECT 
    * 
FROM InternationalLicenses
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
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }

        }
        public static DataTable GetByPersonID(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            DataTable dt = new DataTable();

            string query = @"
SELECT 
    * 
FROM InternationalLicenses il
    JOIN Drivers d ON il.DriverID = d.ID
    JOIN Persons p ON d.PersonID = p.ID
WHERE p.ID = @ID;";

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
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }

        }
        public static DataTable GetFiltered(string filter, string search)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);
            string WhereClause = "";

            switch (filter)
            {
                case "INTERNATIONAL_LICENSE_ID":
                    {
                        WhereClause = "ID = @Search";
                        break;
                    }
                case "APPLICATIONID":
                    {
                        WhereClause = "ApplicationID = @Search";
                        break;
                    }
                case "DRIVERID":
                    {
                        WhereClause = "DriverID = @Search";
                        break;
                    }
                case "LOCAL_LICENSEID":
                    {
                        WhereClause = "IssuedUsingLocalLicenseID = @Search";
                        break;
                    }
                default:
                    WhereClause = "1 = 1";
                    break;
            }

            string query = $@"
SELECT * FROM InternationalLicenses
WHERE {WhereClause};";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Search", search);

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
        public static DataTable GetDriverInternationalLicenseInfo(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            DataTable dt = new DataTable();

            string query = @"
SELECT 
	CONCAT_WS(' ',p.FirstName, p.SecondName, p.ThirdName, p.LastName) AS Fullname,
	il.ID AS InternationalLicenseID,
	il.IssuedUsingLocalLicenseID AS LocalLicenseID,
	il.DriverID,
	il.ApplicationID,
	p.NationalNumber,
	CASE
		WHEN p.Gender = 'M' THEN 'Male'
		ELSE 'Female'
	END AS Gender,
	il.IssueDate,
	il.ExpiryDate,
	p.DateOfBirth,
	il.IsActive,
    p.PersonalPhotoPath
FROM InternationalLicenses il
JOIN Drivers d ON il.DriverID = d.ID
JOIN Persons p ON d.PersonID = p.ID
WHERE il.ID = @ID;";

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
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }

        }


        public static DataTable GetAll()
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            DataTable dt = new DataTable();

            string query = @"
SELECT 
    * 
FROM InternationalLicenses;";

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
        public static int Add(int driverID, int applicationID, int issuedUsingLocalLicenseID, int createdByUserID, DateTime issueDate, DateTime expiryDate, bool isActive)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"
INSERT INTO InternationalLicenses
(DriverID, ApplicationID, IssuedUsingLocalLicenseID, CreatedByUserID, IssueDate, ExpiryDate, IsActive)
VALUES
(@DriverID, @ApplicationID, @IssuedUsingLocalLicenseID, @CreatedByUserID, @IssueDate, @ExpiryDate, @IsActive);

SELECT SCOPE_IDENTITY();";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@DriverID", driverID);
            cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", issuedUsingLocalLicenseID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            cmd.Parameters.AddWithValue("@IssueDate", issueDate);
            cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate);
            cmd.Parameters.AddWithValue("@IsActive", isActive);

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
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }
        }
        public static bool IsExist(int iD)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT 1 FROM InternationalLicenses
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
        public static bool DoesPersonHasInternationalLicense(int personID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"
SELECT 
    1 
FROM InternationalLicenses il
    JOIN Drivers d ON il.DriverID = d.ID
    JOIN Persons p ON d.PersonID = p.ID
WHERE p.ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", personID);

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
