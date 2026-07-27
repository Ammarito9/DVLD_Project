using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.BLL.DTO
{
    public class DriverInternationalLicenseInfoDTO
    {
        public string fullName { get; set; }
        public int internationalLicenseID { get; set; }
        public int localLicenseID { get; set; }
        public int driverID { get; set; }
        public int applicationID { get; set; }
        public string nationalNumber { get; set; }
        public string gender { get; set; }
        public DateTime issueDate { get; set; }
        public DateTime expirationDate { get; set; }
        public DateTime dateOfBirth { get; set; }
        public bool isActive { get; set; }
        public string PersonalImagePath { get; set; }
        public DriverInternationalLicenseInfoDTO()
        {

        }
        public DriverInternationalLicenseInfoDTO(string fullName, int internationalLicenseID, int localLicenseID, int driverID, int applicationID, string nationalNumber, string gender, DateTime issueDate, DateTime expirationDate, DateTime dateOfBirth, bool isActive, string personalImagePath)
        {
            this.fullName = fullName;
            this.internationalLicenseID = internationalLicenseID;
            this.localLicenseID = localLicenseID;
            this.driverID = driverID;
            this.applicationID = applicationID;
            this.nationalNumber = nationalNumber;
            this.gender = gender;
            this.issueDate = issueDate;
            this.expirationDate = expirationDate;
            this.dateOfBirth = dateOfBirth;
            this.isActive = isActive;
            PersonalImagePath = personalImagePath;
        }
    }
}
