using DVLD.DAL.DTO;

namespace DVLD.DAL.Data
{
    public static class DriverData
    {
        public static DataTable GetAll()
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT * FROM Drivers;";

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

            string query = @"SELECT * FROM Drivers
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
        public static DataTable GetDriverLocalLicenses(int driverID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"
SELECT l.ID, l.ApplicationID, lc.ClassName, l.IssueDate, l.ExpiryDate, l.IsActive FROM Licenses l
JOIN LicenseClasses lc ON l.LicenseClassID = lc.ID
JOIN Drivers d ON l.DriverID = d.ID
WHERE d.ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", driverID);

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
        public static DataTable GetDriverInternationalLicenses(int driverID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"
SELECT 
    il.ID,
    il.ApplicationID,
    il.IssuedUsingLocalLicenseID,
    il.IssueDate,
    il.ExpiryDate,
    il.IsActive 
FROM InternationalLicenses il
JOIN Drivers d ON il.DriverID = d.ID
JOIN Licenses l ON il.IssuedUsingLocalLicenseID = l.ID
WHERE d.ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", driverID);

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
        public static DataTable GetDriverFiltered(string filter, string search)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);
            string WhereClause = "";

            switch (filter)
            {
                case "DRIVER_ID":
                    WhereClause = "d.ID = @search";
                    break;
                case "PERSON_ID":
                    WhereClause = "p.ID = @search";
                    break;
                case "NATIONAL_NUMBER":
                    WhereClause = "p.NationalNumber = @search";
                    break;
                // removing the white spaces between the name to fix the problem with null Sec and Thr name.
                case "FULL_NAME":
                    WhereClause = "CONCAT(p.FirstName,p.SecondName,p.ThirdName,p.LastName) LIKE '%' + @Search + '%'";
                    search = search.Replace(" ", null);
                    break;
                default:
                    WhereClause = "1 = 1";
                    break;
            }

            string query = $@"
SELECT 
	d.ID AS DriverID,
	p.ID AS PersonID,
	p.NationalNumber,
	CONCAT_WS(' ',p.FirstName, p.SecondName, p.ThirdName, p.LastName) AS Fullname,
	d.CreateDate,
	SUM(CASE
			WHEN l.IsActive = 1 then 1
			ELSE 0
		END) AS ActiveLicenses
FROM Licenses l
JOIN Drivers d ON l.DriverID = d.ID
JOIN Persons p ON d.PersonID = p.ID
WHERE {WhereClause}
GROUP BY
	d.ID,
	p.ID,
	p.NationalNumber,
	CONCAT_WS(' ',p.FirstName, p.SecondName, p.ThirdName, p.LastName),
	d.CreateDate;";

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

        public static DataTable GetByPersonID(int personID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT * FROM Drivers
                            WHERE PersonID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", personID);

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

        public static int Add(DriverDTO driver)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"INSERT INTO Drivers
                            (PersonID, CreatedByUserID, CreateDate) 
                            VALUES
                            (@PersonID, @CreatedByUserID, @CreateDate);

                            SELECT SCOPE_IDENTITY();";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@PersonID", driver.PersonID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", driver.CreatedByUserID);
            cmd.Parameters.AddWithValue("@CreateDate", driver.CreateDate);

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
        public static int Update(DriverDTO driver)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"UPDATE Drivers
                            SET
                            PersonID = @PersonID,
                            CreatedByUserID = @CreatedByUserID, 
                            CreateDate = @CreateDate
                            WHERE ID = @ID;";

            using var cmd = new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@ID", driver.ID);
            cmd.Parameters.AddWithValue("@PersonID", driver.PersonID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", driver.CreatedByUserID);
            cmd.Parameters.AddWithValue("@CreateDate", driver.CreateDate);

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
        public static int Delete(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"DELETE FROM Drivers
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
        public static bool IsExist(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT * FROM Drivers
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
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }
        }
        public static bool DoesPersonHasDriverEntry(int ID)
        {
            using var conn = new SqlConnection(Connection.DBConnectionString);

            string query = @"SELECT * FROM Drivers
                            WHERE PersonID = @ID";

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
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }
        }

    }
}
