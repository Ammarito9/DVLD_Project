using DVLD.DAL.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.BLL.Entities
{
    public class LicenseClass
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte ValidityLengthInYears { get; set; }
        public Decimal ClassFees { get; set; }

        public LicenseClass() { }
        public LicenseClass(int iD, string className, string classDescription, byte minimumAllowedAge, byte validityLengthInYears, Decimal classFees)
        {
            ID = iD;
            ClassName = className;
            ClassDescription = classDescription;
            MinimumAllowedAge = minimumAllowedAge;
            ValidityLengthInYears = validityLengthInYears;
            ClassFees = classFees;
        }
        public static LicenseClass Find(int ID)
        {
            DataTable dt = LicenseClassData.GetByID(ID);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                return new LicenseClass(
                    ID,
                    (string)dr["ClassName"],
                    (string)dr["ClassDescription"],
                    (byte)dr["MinimumAllowedAge"],
                    (byte)dr["ValidityLengthInYears"],
                    (Decimal)dr["ClassFees"]
                    );
            }

            return null;
        }
        public static DataTable GetAll() => LicenseClassData.GetAll();
        public static List<string> GetAllClassNames() => LicenseClassData.GetAllClassNames();
    }
}
