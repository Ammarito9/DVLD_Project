using DVLD.DAL.Data;
using DVLD.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD.BLL.Entities.Service;

namespace DVLD.BLL.Entities
{
    public class TestAppointment
    {
        private enum Mode
        {
            Update,
            AddNew
        }
        private Mode mode;
        public int ID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime ScheduledDate { get; set; }
        public Decimal PaidFee { get; set; }
        public bool IsLocked { get; set; }
        public int? RetakeTestTestAppointmentsID { get; set; }
        public TestAppointment() { mode = Mode.AddNew; }
        public TestAppointment(int iD, int testTypeID, int localDrivingLicenseApplicationID, int createdByUserID, DateTime scheduledDate, decimal paidFee, bool isLocked, int? retakeTestTestAppointmentsID)
        {
            mode = Mode.Update;
            ID = iD;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            CreatedByUserID = createdByUserID;
            ScheduledDate = scheduledDate;
            PaidFee = paidFee;
            IsLocked = isLocked;
            RetakeTestTestAppointmentsID = retakeTestTestAppointmentsID;
        }
        public static TestAppointment Find(int ID)
        {
            DataRow dr = TestAppointmentData.GetByID(ID);

            if (dr is not null)
            {
                return new TestAppointment(
                    ID,
                    (int)dr["TestTypeID"],
                    (int)dr["LocalDrivingLicenseApplicationID"],
                    (int)dr["CreatedByUserID"],
                    (DateTime)dr["ScheduledDate"],
                    (Decimal)dr["PaidFee"],
                    (bool)dr["IsLocked"],
                    Convert.IsDBNull(dr["RetakeTestApplicationID"]) ? null : (int)dr["RetakeTestApplicationID"]
                    );
                
            }
            else
                return null;

        }
        public static DataTable GetAll() => TestAppointmentData.GetAll();
        public static DataTable GetAllFiltered(Test.TestType testType, int localDrivingLicenseApplicationID) => TestAppointmentData.GetAllFiltered(((int)testType), localDrivingLicenseApplicationID);
        private bool Add()
        {
            TestAppointmentDTO newTestAppointments = new TestAppointmentDTO();

            newTestAppointments.TestTypeID = TestTypeID;
            newTestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            newTestAppointments.CreatedByUserID = CreatedByUserID;
            newTestAppointments.ScheduledDate = ScheduledDate;
            newTestAppointments.PaidFee = PaidFee;
            newTestAppointments.IsLocked = IsLocked;
            newTestAppointments.RetakeTestApplicationID = RetakeTestTestAppointmentsID;
            ID = TestAppointmentData.Add(newTestAppointments);

            return ID != 0;
        }
        private bool Update()
        {
            if (!TestAppointmentData.IsExist(ID))
                return false;

            TestAppointmentDTO newTestAppointments = new TestAppointmentDTO();

            newTestAppointments.ID = ID;
            newTestAppointments.TestTypeID = TestTypeID;
            newTestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            newTestAppointments.CreatedByUserID = CreatedByUserID;
            newTestAppointments.ScheduledDate = ScheduledDate;
            newTestAppointments.PaidFee = PaidFee;
            newTestAppointments.IsLocked = IsLocked;
            newTestAppointments.RetakeTestApplicationID = RetakeTestTestAppointmentsID;

            return (TestAppointmentData.Update(newTestAppointments) > 0);
        }
        public static bool Delete(int ID) => (TestAppointmentData.Delete(ID) > 0);
        public static bool IsExist(int ID) => TestAppointmentData.IsExist(ID);
        public static int GetNumberOfTestTrials(int localDrivingLicenseID, Test.TestType testType) => TestAppointmentData.GetNumberOfTestTrials(localDrivingLicenseID, (int)testType);
        public static bool IsThereActiveAppointment(int localDrivingLicenseID) => TestAppointmentData.IsThereActiveAppointment(localDrivingLicenseID);
        public bool Save()
        {
            switch (mode)
            {
                case Mode.AddNew:
                    if (Add())
                    {
                        mode = Mode.Update;
                        return true;
                    }
                    return false;
                case Mode.Update:
                    return Update();

                default:
                    return false;
            }
        }
    }
}
