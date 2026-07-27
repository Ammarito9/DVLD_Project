using DVLD.DAL.Data;
using DVLD.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVLD.BLL.Entities
{
    public class InternationalLicense
    {
        public enum Filter
        {
            NONE,
            INTERNATIONAL_LICENSE_ID,
            APPLICATIONID,
            DRIVERID,
            LOCAL_LICENSEID
        }

        public int ID { get; set; }
        public int DriverID { get; set; }
        public int ApplicationID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsActive { get; set; }

        public InternationalLicense() { }
        public InternationalLicense(int iD, int driverID, int applicationID, int issuedUsingLocalLicenseID, int createdByUserID, DateTime issueDate, DateTime expiryDate, bool isActive)
        {
            ID = iD;
            DriverID = driverID;
            ApplicationID = applicationID;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            CreatedByUserID = createdByUserID;
            IssueDate = issueDate;
            ExpiryDate = expiryDate;
            IsActive = isActive;
        }

        public static InternationalLicense Find(int ID)
        {
            DataTable dt = InternationalLicenseData.GetByID(ID);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                return new InternationalLicense(
                    (int)dr["ID"],
                    (int)dr["DriverId"],
                    (int)dr["ApplicationID"],
                    (int)dr["IssuedUsingLocalLicenseID"],
                    (int)dr["CreatedByUserId"],
                    (DateTime)dr["IssueDate"],
                    (DateTime)dr["ExpiryDate"],
                    (bool)dr["IsActive"]
                );
            }
            else
                return null;
        }
        public static InternationalLicense FindByPersonID(int personID)
        {
            DataTable dt = InternationalLicenseData.GetByPersonID(personID);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                return new InternationalLicense(
                    (int)dr["ID"],
                    (int)dr["DriverId"],
                    (int)dr["ApplicationID"],
                    (int)dr["IssuedUsingLocalLicenseID"],
                    (int)dr["CreatedByUserId"],
                    (DateTime)dr["IssueDate"],
                    (DateTime)dr["ExpiryDate"],
                    (bool)dr["IsActive"]
                );
            }
            else
                return null;
        }
        public static DriverInternationalLicenseInfoDTO GetDriverInternationalLicenseInfo(int ID)
        {
            DataTable dt = InternationalLicenseData.GetDriverInternationalLicenseInfo(ID);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                return new DriverInternationalLicenseInfoDTO(
                    (string)dr["Fullname"],
                    (int)dr["InternationalLicenseID"],
                    (int)dr["LocalLicenseID"],
                    (int)dr["DriverID"],
                    (int)dr["ApplicationID"],
                    (string)dr["NationalNumber"],
                    (string)dr["Gender"],
                    (DateTime)dr["IssueDate"],
                    (DateTime)dr["ExpiryDate"],
                    (DateTime)dr["DateOfBirth"],
                    (bool)dr["IsActive"],
                    (string)dr["PersonalPhotoPath"]
                );
            }
            else
                return null;
        }
        public static DataTable GetAll() => InternationalLicenseData.GetAll();
        public static DataTable GetFiltered(Filter filter, string search) => InternationalLicenseData.GetFiltered(filter.ToString(), search);
        private bool Add()
        {
            ID = InternationalLicenseData.Add(
                    DriverID,
                    ApplicationID,
                    IssuedUsingLocalLicenseID,
                    CreatedByUserID,
                    IssueDate,
                    ExpiryDate,
                    IsActive
                );

            return ID != 0;
        }
        public bool Save() => Add();
        public static bool IsExist(int ID) => InternationalLicenseData.IsExist(ID);
        public static bool DoesPersonHasInternationalLicense(int personID) => InternationalLicenseData.DoesPersonHasInternationalLicense(personID);
    }
}
