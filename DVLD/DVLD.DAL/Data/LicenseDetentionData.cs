using DVLD.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.Data
{
    public static class LicenseDetentionData
    {
        public static DataTable GetByID(int ID)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            DataTable dt = new DataTable();

            string query = @"
SELECT * FROM LicenseDetentions ld
WHERE ld.ID = @ID;";

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
        public static DataTable GetByLicenseID(int licenseID)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            DataTable dt = new DataTable();

            string query = @"
SELECT * FROM LicenseDetentions ld
WHERE ld.LicenseID = @licenseID AND ld.IsReleased = 0;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@licenseID", licenseID);

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
            using var conn = new SqlConnection(Connection.ConnectionString);

            DataTable dt = new DataTable();

            string query = @"
SELECT * FROM LicenseDetentions ld;";

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
        public static DataTable GetDetailed(string? filter = null, string? search = null)
        {
            string whereClause;

            if (search is null)
                search = "1";

            switch (filter)
            {
                case "DETAIN_ID":
                    whereClause = "ld.ID = @search";
                    break;
                case "DATE_OF_DETAIN":
                    whereClause = "ld.DateOfDetain = @search";
                    break;
                case "IS_RELEASED":
                    whereClause = "ld.IsReleased = @search";
                    break;
                case "DETAIN_FEES":
                    whereClause = "ld.DetainFees = @search";
                    break;
                case "RELEASE_DATE":
                    whereClause = "ld.ReleaseDate = @search";
                    break;
                case "NATIONAL_NUMBER":
                    whereClause = "p.NationalNumber = @search";
                    break;
                case "FULL_NAME":
                    whereClause = "CONCAT(p.FirstName,p.SecondName,p.ThirdName,p.LastName) LIKE '%' + @Search + '%'";
                    search = search.Replace(" ", null);
                    break;
                case "RELEASE_APPLICATION_ID":
                    whereClause = "ld.ReleaseApplicationID = @search";
                    break;
                default:
                    whereClause = "1 = @search";
                    break;
            }
            using var conn = new SqlConnection(Connection.ConnectionString);

            DataTable dt = new DataTable();

            string query = @$"
SELECT 
	ld.ID AS DetainID,
	ld.DateOfDetain,
	ld.IsReleased,
	ld.DetainFees,
	ld.ReleaseDate,
	p.NationalNumber,
	CONCAT_WS(' ', p.FirstName, p.SecondName, p.ThirdName, p.LastName) AS Fullname,
	ld.ReleaseApplicationID
FROM LicenseDetentions ld
JOIN Licenses l ON ld.LicenseID = l.ID
JOIN Drivers d ON l.DriverID = d.ID
JOIN Persons p ON d.PersonID = p.ID
WHERE {whereClause};";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@search", search);
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

        public static int Add(int LicenseID,int? ReleaseApplicationID, int? ReleasedByUserID, int CreatedByUserID,Decimal DetainFee,DateTime DateOfDetain,DateTime? ReleaseDate,bool IsReleased)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"
INSERT INTO LicenseDetentions
(LicenseID,
ReleaseApplicationID,
CreatedByUserID,
ReleasedByUserID,
DetainFees,
DateOfDetain,
ReleaseDate,
IsReleased
)
VALUES
(@LicenseID,
@ReleaseApplicationID,
@CreatedByUserID,
@ReleasedByUserID,
@DetainFee,
@DateOfDetain,
@ReleaseDate,
@IsReleased
);

SELECT SCOPE_IDENTITY();";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            if (ReleaseApplicationID is null)
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", Convert.DBNull);
            else
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            if (ReleasedByUserID is null)
                cmd.Parameters.AddWithValue("@ReleasedByUserID", Convert.DBNull);
            else
                cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);

            cmd.Parameters.AddWithValue("@DetainFee", DetainFee);
            cmd.Parameters.AddWithValue("@DateOfDetain", DateOfDetain);

            if(ReleaseDate is null)
                cmd.Parameters.AddWithValue("@ReleaseDate", Convert.DBNull);
            else
                cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);

            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);

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
        public static int Update(int ID, int LicenseID, int? ReleaseApplicationID, int? ReleasedByUserID, int CreatedByUserID, Decimal DetainFee, DateTime DateOfDetain, DateTime? ReleaseDate, bool IsReleased)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"
UPDATE LicenseDetentions
SET
    LicenseID = @LicenseID,
    ReleaseApplicationID = @ReleaseApplicationID,
    CreatedByUserID = @CreatedByUserID,
    ReleasedByUserID = @ReleasedByUserID,
    DetainFees = @DetainFee,
    DateOfDetain = @DateOfDetain,
    ReleaseDate = @ReleaseDate,
    IsReleased = @IsReleased
WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            if (ReleaseApplicationID is null)
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", Convert.DBNull);
            else
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            if (ReleasedByUserID is null)
                cmd.Parameters.AddWithValue("@ReleasedByUserID", Convert.DBNull);
            else
                cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);

            cmd.Parameters.AddWithValue("@DetainFee", DetainFee);
            cmd.Parameters.AddWithValue("@DateOfDetain", DateOfDetain);

            if (ReleaseDate is null)
                cmd.Parameters.AddWithValue("@ReleaseDate", Convert.DBNull);
            else
                cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);

            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);

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

            string query = @"DELETE FROM LicenseDetentions
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

            string query = @"SELECT 1 FROM LicenseDetentions
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
