using DVLD.DAL.Data;
using DVLD.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD.BLL.Entities.License;

namespace DVLD.BLL.Entities
{
    public class LicenseDetention
    {
        public enum Filter
        {
            NONE,
            DETAIN_ID,
            DATE_OF_DETAIN,
            IS_RELEASED,
            DETAIN_FEES,
            RELEASE_DATE,
            NATIONAL_NUMBER,
            FULL_NAME,
            RELEASE_APPLICATION_ID
        }

        private enum Mode
        {
            Update,
            AddNew
        }
        private Mode mode;
        public int ID { get; set; }
        public int LicenseID { get; set; }
        public int? ReleaseApplicationID { get; set; }
        public int CreatedByUserID { get; set; }
        public int? ReleasedByUserID { get; set; }
        public Decimal DetainFee { get; set; }
        public DateTime DateOfDetain { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public bool IsReleased { get; set; }
        public LicenseDetention() { mode = Mode.AddNew; }
        public LicenseDetention(int iD, int licenseID, int? releaseApplicationID, int createdByUserID, int? releasedByUserID, decimal detainFee, DateTime dateOfDetain, DateTime? releaseDate, bool isReleased)
        {
            mode = Mode.Update;
            ID = iD;
            LicenseID = licenseID;
            ReleaseApplicationID = releaseApplicationID;
            CreatedByUserID = createdByUserID;
            ReleasedByUserID = releasedByUserID;
            DetainFee = detainFee;
            DateOfDetain = dateOfDetain;
            ReleaseDate = releaseDate;
            IsReleased = isReleased;
        }
        public static DataTable GetAll() => LicenseDetentionData.GetAll();
        public static DataTable GetDetailed(Filter filter = Filter.NONE, string? search = null) => LicenseDetentionData.GetDetailed(filter.ToString(), search);
        public static LicenseDetention? Find(int ID)
        {
            DataTable dt = LicenseDetentionData.GetByID(ID);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                int? ReleaseApplicationID;
                if (Convert.IsDBNull(dr["ReleaseApplicationID"]))
                    ReleaseApplicationID = null;
                else
                    ReleaseApplicationID = (int)dr["ReleaseApplicationID"];

                int? ReleasedByUserID;
                if (Convert.IsDBNull(dr["ReleasedByUserID"]))
                    ReleasedByUserID = null;
                else
                    ReleasedByUserID = (int)dr["ReleasedByUserID"];

                DateTime? ReleaseDate;
                if (Convert.IsDBNull(dr["ReleaseDate"]))
                    ReleaseDate = null;
                else
                    ReleaseDate = (DateTime)dr["ReleaseDate"];

                return new LicenseDetention(
                    (int)dr["ID"],
                    (int)dr["LicenseID"],
                    ReleaseApplicationID,
                    (int)dr["CreatedByUserID"],
                    ReleasedByUserID,
                    (Decimal)dr["DetainFees"],
                    (DateTime)dr["DateOfDetain"],
                    ReleaseDate,
                    (bool)dr["IsReleased"]
                );
            }
            else
                return null;
        }
        public static LicenseDetention? FindByLicenseID(int licenseID)
        {
            DataTable dt = LicenseDetentionData.GetByLicenseID(licenseID);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                int? ReleaseApplicationID;
                if (Convert.IsDBNull(dr["ReleaseApplicationID"]))
                    ReleaseApplicationID = null;
                else
                    ReleaseApplicationID = (int)dr["ReleaseApplicationID"];

                int? ReleasedByUserID;
                if (Convert.IsDBNull(dr["ReleasedByUserID"]))
                    ReleasedByUserID = null;
                else
                    ReleasedByUserID = (int)dr["ReleasedByUserID"];

                DateTime? ReleaseDate;
                if (Convert.IsDBNull(dr["ReleaseDate"]))
                    ReleaseDate = null;
                else
                    ReleaseDate = (DateTime)dr["ReleaseDate"];

                return new LicenseDetention(
                    (int)dr["ID"],
                    (int)dr["LicenseID"],
                    ReleaseApplicationID,
                    (int)dr["CreatedByUserID"],
                    ReleasedByUserID,
                    (Decimal)dr["DetainFees"],
                    (DateTime)dr["DateOfDetain"],
                    ReleaseDate,
                    (bool)dr["IsReleased"]
                );
            }
            else
                return null;
        }
        private bool Add()
        {
            ID = LicenseDetentionData.Add(
                    LicenseID,
                    ReleaseApplicationID,
                    ReleasedByUserID,
                    CreatedByUserID,
                    DetainFee,
                    DateOfDetain,
                    ReleaseDate,
                    IsReleased
                );

            return (ID != 0);
        }
        private bool Update()
        {
            if (!LicenseDetentionData.IsExist(ID))
                return false;

            return (LicenseDetentionData.Update(
                    ID,
                    LicenseID,
                    ReleaseApplicationID,
                    ReleasedByUserID,
                    CreatedByUserID,
                    DetainFee,
                    DateOfDetain,
                    ReleaseDate,
                    IsReleased
                ) > 0);
        }
        public static bool Delete(int ID) => (LicenseDetentionData.Delete(ID) > 0);
        public static bool IsExist(int ID) => LicenseDetentionData.IsExist(ID);
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
