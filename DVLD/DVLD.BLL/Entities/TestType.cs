using DVLD.DAL.Data;
using DVLD.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVLD.BLL.Entities
{
    public class TestType
    {
        public int ID { get; set; }
        public string TestTypeName { get; set; }
        public string TestTypeDescription { get; set; }
        public float TestFee { get; set; }

        private TestType(int ID, string TestTypeName, string TestTypeDescription, float TestFee)
        {
            this.ID = ID;
            this.TestTypeName = TestTypeName;
            this.TestTypeDescription = TestTypeDescription;
            this.TestFee = TestFee;
        }

        public static TestType Find(int ID)
        {
            DataTable dt = TestTypeData.GetByID(ID);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            return new TestType((int)dr["ID"], (string)dr["TestTypeName"], (string)dr["TestTypeDescription"], (float)dr["TestFee"]);
        }
        private bool Update()
        {
            if (!ServiceData.IsExist(ID)) return false;

            var TestTypeDTO = new TestTypeDTO(TestTypeName, TestTypeDescription, TestFee);
            int rows = TestTypeData.Update(TestTypeDTO);
            return rows > 0;
        }
        public static DataTable GetAll() => TestTypeData.GetAll();

        public bool Save() => Update();
    }
}
