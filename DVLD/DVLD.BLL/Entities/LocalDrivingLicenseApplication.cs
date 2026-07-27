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
    public class LocalDrivingLicenseApplication
    {
        public enum GetByIDDetailedDataTableAttribute
        {
            ID, //Local Driving License Application Id
            ApplicationID,
            PersonID,
            ClassName,
            Fullname
        }

        public enum StatusFilter
        {
            None,
            New,
            Canceled,
            Completed
        }
        public enum Filters
        {
            None,
            LDL_Application_ID,
            NationalNum,
            FullName,
            Status
        }
        public int ID { get; set; }
        public int LicenseClassID { get; set; }
        public int ApplicationID { get; set; }
        public LocalDrivingLicenseApplication() { }
        public LocalDrivingLicenseApplication(int licenseClassID, int applicationID)
        {
            LicenseClassID = licenseClassID;
            ApplicationID = applicationID;
        }
        public bool Add()
        {
            var localDrivingLicenseApplication = new LocalDrivingLicenseApplicationDTO();

            localDrivingLicenseApplication.LicenseClassID = LicenseClassID;
            localDrivingLicenseApplication.ApplicationID = ApplicationID;
            ID = LocalDrivingLicenseApplicationData.Add(localDrivingLicenseApplication);

            return ID != 0;
        }
        public static bool CheckIfPersonHasApplicationForLicenseClassExist(int personID, int licenseClassID) => LocalDrivingLicenseApplicationData.CheckIfPersonHasApplicationForLicenseClassExist(personID, licenseClassID);
        public static bool CheckIfPersonHasLicenseForLicenseClass(int personID, int licenseClassID) => LocalDrivingLicenseApplicationData.CheckIfPersonHasLicenseForLicenseClass(personID, licenseClassID);
        public static LocalDrivingLicenseApplication? Find(int ID)
        {
            DataTable dt = LocalDrivingLicenseApplicationData.GetByID(ID);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                return new LocalDrivingLicenseApplication(
                    (int)dr["LicenseClassID"],
                    (int)dr["ApplicationID"]
                    );
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetAll() => LocalDrivingLicenseApplicationData.GetAll();
        public static DataTable GetAllFilterByStatus(StatusFilter filter) => LocalDrivingLicenseApplicationData.GetAllFilterByStatus(((int)filter));
        public static DataTable GetAllFilterBy(Filters filter, string search) => LocalDrivingLicenseApplicationData.GetAllFilterBy(filter.ToString(), search);
        public static bool Delete(int ID) => (LocalDrivingLicenseApplicationData.Delete(ID) > 0);
        public static bool CancelApplication(int ID) => (LocalDrivingLicenseApplicationData.CancelApplication(ID) > 0);
        public static int GetNumberOfPassedTests(int ID) => LocalDrivingLicenseApplicationData.GetNumberOfPassedTests(ID);
        // It will return a data table that contain (Local Driving License Application Id, PersonID ,ClassName,Full name, application Id)
        public static DataTable GetByIDDetailed(int ID) => LocalDrivingLicenseApplicationData.GetByIDDetailed(ID);
    }
}
