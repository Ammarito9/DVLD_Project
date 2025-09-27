using DVLD.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.Data
{
    public class TestTypeData
    {
        public static DataTable GetByID(int ID)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"SELECT * FROM TestTypes WHERE ID = @ID;";

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
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }

        }
        public static int Update(TestTypeDTO TestType)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"UPDATE TestTypes
                            SET
                                TestTypeName = @TestTypeName,
                                TestTypeDescription = @TestTypeDescription,
                                TestFee = @TestFee
                            WHERE ID = @ID;";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", TestType.ID);
            cmd.Parameters.AddWithValue("@TestTypeName", TestType.TestTypeName);
            cmd.Parameters.AddWithValue("@TestTypeDescription", TestType.TestTypeDescription);
            cmd.Parameters.AddWithValue("@TestFee", TestType.TestFee);

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
        public static DataTable GetAll()
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"SELECT * FROM TestTypes;";

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
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }

        }
        public static bool IsExist(int ID)
        {
            using var conn = new SqlConnection(Connection.ConnectionString);

            string query = @"SELECT 1 FROM TestTypes
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
                throw new Exception("Error Occurred from the database!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occurred in DAL!", ex);
            }
        }
    }
}
