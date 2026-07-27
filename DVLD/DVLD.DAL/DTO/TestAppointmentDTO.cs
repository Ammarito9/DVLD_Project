using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.DTO
{
    public class TestAppointmentDTO
    {
        public int ID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime ScheduledDate { get; set; }
        public Decimal PaidFee { get; set; }
        public bool IsLocked { get; set; }
        public int? RetakeTestApplicationID { get; set; }
        public TestAppointmentDTO() { }
        public TestAppointmentDTO(int testTypeID, int localDrivingLicenseApplicationID, int createdByUserID, DateTime scheduledDate, decimal paidFee, bool isLocked, int? retakeTestApplicationID)
        {
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            CreatedByUserID = createdByUserID;
            ScheduledDate = scheduledDate;
            PaidFee = paidFee;
            IsLocked = isLocked;
            RetakeTestApplicationID = retakeTestApplicationID;
        }
    }
}
