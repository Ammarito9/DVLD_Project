using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.DTO
{
    public class LicenseClassDTO
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public short MinimumAllowedAge { get; set; }
        public short DefaultValidityLength { get; set; }
        public Decimal ClassFees { get; set; }

        public LicenseClassDTO() { }
        public LicenseClassDTO(int iD, string className, string classDescription, short minimumAllowedAge, short defaultValidityLength, Decimal classFees)
        {
            ID = iD;
            ClassName = className;
            ClassDescription = classDescription;
            MinimumAllowedAge = minimumAllowedAge;
            DefaultValidityLength = defaultValidityLength;
            ClassFees = classFees;
        }
    }
}
