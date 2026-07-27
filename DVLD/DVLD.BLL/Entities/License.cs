using DVLD.DAL.Data;
using DVLD.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 There is a problem here n + 1 query problem because of loading everything
 */
namespace DVLD.BLL.Entities
{
    public class License
    {
        public enum LicenseInfoDetailedAttr : byte
        {
            ClassName,
            ClassID,
            Fullname,
            LicenseID,
            NationalNumber,
            Gender,
            IssueDate,
            IssueReason,
            LicenseNote,
            IsActive,
            DateOfBirth,
            DriverID,
            ExpiryDate,
            IsDetained,
            PersonalPhotoPath
        }

        public enum LicenseType
        {
            NEW = 1,
            RENEWAL,
            REPLACEMENT_LOST,
            REPLACEMENT_DAMAGED,
        }

        private enum Mode
        {
            Update,
            AddNew
        }
        private Mode mode;
        public int ID { get; set; }
        public int DriverId { get; set; }
        public int LicenseClassId { get; set; }
        public string LicenseClassName { get; set; } //
        public int LicenseTypeId { get; set; }
        public string LicenseTypeName { get; set; } //
        public int CreatedByUserId { get; set; }
        public string CreatedByUsername { get; set; }
        public int ApplicationId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public string LicenseNumber { get; set; }
        public string LicenseNote { get; set; }
        public Decimal PaidFee { get; set; }
        public License() { mode = Mode.AddNew; }
        private License(
int id, int driverId, int licenseClassId, string licenseClassName, int licenseTypeId, string licenseTypeName, int createdByUserId, string createdByUsername, int applicationId, DateTime issueDate, DateTime expiryDate, bool isActive, string licenseNumber, string licenseNote, decimal paidFee)
        {
            mode = Mode.Update;
            ID = id;
            DriverId = driverId;
            LicenseClassId = licenseClassId;
            LicenseClassName = licenseClassName;
            LicenseTypeId = licenseTypeId;
            LicenseTypeName = licenseTypeName;
            CreatedByUserId = createdByUserId;
            CreatedByUsername = createdByUsername;
            ApplicationId = applicationId;
            IssueDate = issueDate;
            ExpiryDate = expiryDate;
            IsActive = isActive;
            LicenseNumber = licenseNumber;
            LicenseNote = licenseNote;
            PaidFee = paidFee;
        }
        public static DataTable GetAll() => LicenseData.GetAll();
        public static License Find(int ID)
        {
            DataTable dt = LicenseData.GetByID(ID);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                string licenseNote;

                if (Convert.IsDBNull(dr["LicenseNote"]))
                    licenseNote = null;
                else
                    licenseNote = (string)dr["LicenseNote"];

                return new License(
                    ID,
                    (int)dr["DriverId"],
                    (int)dr["LicenseClassId"],
                    (string)dr["ClassName"],
                    (int)dr["LicenseTypeId"],
                    (string)dr["TypeName"],
                    (int)dr["CreatedByUserId"],
                    (string)dr["username"],
                    (int)dr["ApplicationId"],
                    (DateTime)dr["IssueDate"],
                    (DateTime)dr["ExpiryDate"],
                    (bool)dr["IsActive"],
                    (string)dr["LicenseNumber"],
                    licenseNote,
                    (Decimal)dr["PaidFee"]
                );
            }
            else
                return null;
        }
        public static License Find(string nationalNumber, int licenseClassID)
        {
            DataTable dt = LicenseData.GetLicense(nationalNumber , licenseClassID);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                string licenseNote;

                if (Convert.IsDBNull(dr["LicenseNote"]))
                    licenseNote = null;
                else
                    licenseNote = (string)dr["LicenseNote"];

                return new License(
                        (int)dr["ID"],
                        (int)dr["DriverId"],
                        (int)dr["LicenseClassId"],
                        (string)dr["ClassName"],
                        (int)dr["LicenseTypeId"],
                        (string)dr["TypeName"],
                        (int)dr["CreatedByUserId"],
                        (string)dr["username"],
                        (int)dr["ApplicationId"],
                        (DateTime)dr["IssueDate"],
                        (DateTime)dr["ExpiryDate"],
                        (bool)dr["IsActive"],
                        (string)dr["LicenseNumber"],
                        licenseNote,
                        (Decimal)dr["PaidFee"]
                    );
            }
            else
                return null;
        }

        /// <Summary>  
        /// It will return a data row with (ClassName, ClassID, Fullname, LicenseID, NationalNumber, Gender, IssueDate, IssueReason, LicenseNote, IsActive, DateOfBirth, DriverID, ExpiryDate, IsDetained, PersonalPhotoPath).
        /// Use LicenseInfoDetailedAttr enum to fetch data from row.
        /// <Summary>  
        public static DataRow? GetLicenseInfoDetailed(int licenseID) => LicenseData.GetLicenseInfoDetailed(licenseID);
        private bool Add()
        {
            var license = new LicenseDTO();

            license.DriverId = DriverId;
            license.LicenseClassId = LicenseClassId;
            license.LicenseTypeId = LicenseTypeId;
            license.CreatedByUserId = CreatedByUserId;
            license.IssueDate = IssueDate;
            license.ExpiryDate = ExpiryDate;
            license.IsActive = IsActive;
            license.LicenseNumber = LicenseNumber;
            license.LicenseNote = LicenseNote;
            license.ApplicationId = ApplicationId;
            license.PaidFee = PaidFee;

            ID = LicenseData.Add(license) ;

            return (ID != 0);
        }
        private bool Update()
        {
            if (!LicenseData.IsExist(ID))
                return false;

            var license = new LicenseDTO();

            license.ID = ID;
            license.LicenseClassId = LicenseClassId;
            license.DriverId = DriverId;
            license.LicenseTypeId = LicenseTypeId;
            license.CreatedByUserId = CreatedByUserId;
            license.ApplicationId = ApplicationId;
            license.IssueDate = IssueDate;
            license.ExpiryDate = ExpiryDate;
            license.IsActive = IsActive;
            license.LicenseNumber = LicenseNumber;
            license.LicenseNote = LicenseNote;
            license.PaidFee = PaidFee;

            return (LicenseData.Update(license) > 0);
        }
        public static bool Delete(int ID) => (LicenseData.Delete(ID) > 0);
        public static bool IsExist(int ID) => LicenseData.IsExist(ID);
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
