using DVLD.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.Data
{
    public static class LocalDrivingLicenseApplicationData
    {
        public static int Add(LocalDrivingLicenseApplicationDTO localDrivingLicenseApplication)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications
                            (LicenseClassID, ApplicationID)
                            VALUES
                            (@LicenseClassID, @ApplicationID);

                            SELECT SCOPE_IDENTITY();";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseClassID", localDrivingLicenseApplication.LicenseClassID);
            cmd.Parameters.AddWithValue("@ApplicationID", localDrivingLicenseApplication.ApplicationID);

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
        public static bool CheckIfPersonHasApplicationForLicenseClassExist(int personID, int licenseClassID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT 1 FROM LocalDrivingLicenseApplications l
                            JOIN Applications a ON l.ApplicationID = a.ID
                            JOIN LicenseClasses lc ON l.LicenseClassID = lc.ID
                            WHERE a.PersonID = @personID AND lc.ID = @licenseClassID AND a.ServiceID = 1 AND a.ApplicationStatusID != 2;";

            using var cmd = new SqlCommand(@query, conn);
            cmd.Parameters.AddWithValue("@personID", personID);
            cmd.Parameters.AddWithValue("@licenseClassID", licenseClassID);
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
        // The query here is not working correctly probably check it later.
        public static bool CheckIfPersonHasLicenseForLicenseClass(int personID, int licenseClassID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT 1 FROM LocalDrivingLicenseApplications l
                            JOIN Applications a ON l.ApplicationID = a.ID
                            JOIN LicenseClasses lc ON l.LicenseClassID = lc.ID
                            WHERE a.PersonID = @personID AND lc.ID = @licenseClassID AND a.ServiceID = 1 AND a.ApplicationStatusID = 3;";

            using var cmd = new SqlCommand(@query, conn);
            cmd.Parameters.AddWithValue("@personID", personID);
            cmd.Parameters.AddWithValue("@licenseClassID", licenseClassID);
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

        public static DataTable GetAll()
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"
SELECT 
    l.ID,
    lc.ClassName,
    p.NationalNumber,
    CONCAT_WS(' ',p.FirstName, p.SecondName, p.ThirdName, p.LastName) AS Fullname,
    a.ApplicationDate,
    SUM(
	    Case
		    WHEN t.TestResult = 'P' THEN 1
		    ELSE 0
	    END
    ) AS PassedTests, 
    ast.StatusName
FROM LocalDrivingLicenseApplications l
LEFT JOIN Applications a ON l.ApplicationID = a.ID
LEFT JOIN Persons p ON a.PersonID = p.ID
LEFT JOIN LicenseClasses lc ON l.LicenseClassID = lc.ID
LEFT JOIN ApplicationStatuses ast ON a.ApplicationStatusID = ast.ID
LEFT JOIN TestAppointments ta ON ta.LocalDrivingLicenseApplicationID = l.ID
LEFT JOIN Tests t ON t.TestAppointmentID = ta.ID
GROUP BY 
    l.ID,
    lc.ClassName,
    p.NationalNumber,
    a.ApplicationDate,
    CONCAT_WS(' ',p.FirstName, p.SecondName, p.ThirdName, p.LastName),
    ast.StatusName;";

            using var cmd = new SqlCommand(query, conn);

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
        public static DataTable GetByID(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT * FROM LocalDrivingLicenseApplications
                            WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);

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
        public static DataTable GetByIDDetailed(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT l.ID, a.PersonID, CONCAT_WS(' ',p.FirstName, p.SecondName, p.ThirdName, p.LastName) AS Fullname, lc.ClassName,l.ApplicationID, l.LicenseClassID 
                            FROM LocalDrivingLicenseApplications l
	                            JOIN Applications a ON l.ApplicationID = a.ID
	                            JOIN LicenseClasses lc ON l.LicenseClassID = lc.ID
	                            JOIN Persons p ON a.PersonID = p.ID
                            WHERE l.ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);

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

        public static DataTable GetAllFilterByStatus(int StatusID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"
SELECT 
    l.ID,
    lc.ClassName,
    p.NationalNumber,
    CONCAT_WS(' ',p.FirstName, p.SecondName, p.ThirdName, p.LastName) AS Fullname,
    a.ApplicationDate,
    SUM(
	    Case
		    WHEN t.TestResult = 'P' THEN 1
		    ELSE 0
	    END
    ) AS PassedTests, 
    ast.StatusName
FROM LocalDrivingLicenseApplications l
LEFT JOIN Applications a ON l.ApplicationID = a.ID
LEFT JOIN Persons p ON a.PersonID = p.ID
LEFT JOIN LicenseClasses lc ON l.LicenseClassID = lc.ID
LEFT JOIN ApplicationStatuses ast ON a.ApplicationStatusID = ast.ID
LEFT JOIN TestAppointments ta ON ta.LocalDrivingLicenseApplicationID = l.ID
LEFT JOIN Tests t ON t.TestAppointmentID = ta.ID
WHERE ast.ID = @ID
GROUP BY 
    l.ID,
    lc.ClassName,
    p.NationalNumber,
    a.ApplicationDate,
    CONCAT_WS(' ',p.FirstName, p.SecondName, p.ThirdName, p.LastName),
    ast.StatusName;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", StatusID);

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
        public static DataTable GetAllFilterBy(string filter, string search)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);
            string WhereClause = "";

            switch (filter)
            {
                case "None":
                    {
                        break;
                    }
                case "LDL_Application_ID":
                    {
                        WhereClause = "l.ID = @Search";
                        break;
                    }
                case "NationalNum":
                    {
                        WhereClause = "p.NationalNumber LIKE '%' + @Search + '%'";
                        break;
                    }
                // If filter by Full name remove the white spaces to fix the problem with null Sec and Thr name.
                case "FullName":
                    {
                        WhereClause = "CONCAT(p.FirstName,p.SecondName,p.ThirdName,p.LastName) LIKE '%' + @Search + '%'";
                        search = search.Replace(" ",null);
                        break;
                    }
            }

            string query = $@"
SELECT 
    l.ID,
    lc.ClassName,
    p.NationalNumber,
    CONCAT_WS(' ',p.FirstName, p.SecondName, p.ThirdName, p.LastName) AS Fullname,
    a.ApplicationDate,
    SUM(
	    Case
		    WHEN t.TestResult = 'P' THEN 1
		    ELSE 0
	    END
    ) AS PassedTests, 
    ast.StatusName
FROM LocalDrivingLicenseApplications l
LEFT JOIN Applications a ON l.ApplicationID = a.ID
LEFT JOIN Persons p ON a.PersonID = p.ID
LEFT JOIN LicenseClasses lc ON l.LicenseClassID = lc.ID
LEFT JOIN ApplicationStatuses ast ON a.ApplicationStatusID = ast.ID
LEFT JOIN TestAppointments ta ON ta.LocalDrivingLicenseApplicationID = l.ID
LEFT JOIN Tests t ON t.TestAppointmentID = ta.ID
WHERE {WhereClause}
GROUP BY 
    l.ID,
    lc.ClassName,
    p.NationalNumber,
    a.ApplicationDate,
    CONCAT_WS(' ',p.FirstName, p.SecondName, p.ThirdName, p.LastName),
    ast.StatusName;";

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
        public static int Delete(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"DELETE FROM LocalDrivingLicenseApplications 
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
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }
        }
        public static int CancelApplication(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"UPDATE Applications
                            SET
                                ApplicationStatusID = 2 -- 2 Is the ID for Cancel status
                            WHERE ID = (SELECT a.ID FROM LocalDrivingLicenseApplications l
                            JOIN Applications a ON l.ApplicationID = a.ID
                            WHERE l.ID = @ID)";

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
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }
        }
        public static int GetNumberOfPassedTests(int applicationID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT COUNT(t.TestResult) FROM LocalDrivingLicenseApplications l
	JOIN TestAppointments ta ON ta.LocalDrivingLicenseApplicationID = l.ID
	JOIN Tests t ON t.TestAppointmentID = ta.ID
	WHERE t.TestResult = 'P' AND l.ID = @ID;";

            using var cmd = new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@ID", applicationID);
            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result is not null && int.TryParse(result.ToString(), out int PassedTests))
                {
                    return PassedTests;
                }

                // (-1) for not found.
                return -1; 
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
