using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.DAL.DTO
{
    public class LocalDrivingLicenseApplicationDTO
    {
        public int ID { get; set; }
        public int LicenseClassID { get; set; }
        public int ApplicationID { get; set; }
        public LocalDrivingLicenseApplicationDTO() { }
        public LocalDrivingLicenseApplicationDTO(int iD, int licenseClassID ,int applicationID) 
        {
            ID = iD;
            LicenseClassID = licenseClassID;
            ApplicationID = applicationID;
        }

    }
}
