using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.DTO
{
    public class TestTypeDTO
    {
        public int ID { get; set; }
        public string TestTypeName { get; set; }
        public string TestTypeDescription { get; set; }
        public float TestFee { get; set; }

        public TestTypeDTO(int ID, string TestTypeName, string TestTypeDescription, float TestFee)
        {
            this.ID = ID;
            this.TestTypeName = TestTypeName;
            this.TestTypeDescription = TestTypeDescription;
            this.TestFee = TestFee;
        }
        public TestTypeDTO(string TestTypeName, string TestTypeDescription, float TestFee)
        {
            this.TestTypeName = TestTypeName;
            this.TestTypeDescription = TestTypeDescription;
            this.TestFee = TestFee;
        }
    }
}
