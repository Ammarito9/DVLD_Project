using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.DAL.DTO
{
    public class LicenseDTO
    {
        public int ID { get; set; }
        public int DriverId { get; set; }
        public int LicenseClassId { get; set; }
        public int LicenseTypeId { get; set; }
        public int CreatedByUserId { get; set; }
        public int ApplicationId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public string LicenseNumber { get; set; }
        public string LicenseNote { get; set; }
        public Decimal PaidFee { get; set; }
        public LicenseDTO() { }
        public LicenseDTO(
int id, int driverId, int licenseClassId, int licenseTypeId, int createdByUserId, int applicationId, DateTime issueDate, DateTime expiryDate, bool isActive, string licenseNumber, string licenseNote, decimal paidFee)
        {
            ID = id;
            DriverId = driverId;
            LicenseClassId = licenseClassId;
            LicenseTypeId = licenseTypeId;
            CreatedByUserId = createdByUserId;
            ApplicationId = applicationId;
            IssueDate = issueDate;
            ExpiryDate = expiryDate;
            IsActive = isActive;
            LicenseNumber = licenseNumber;
            LicenseNote = licenseNote;
            PaidFee = paidFee;
        }
    }
}
