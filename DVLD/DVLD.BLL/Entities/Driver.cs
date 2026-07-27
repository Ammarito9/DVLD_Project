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
    public class Driver
    {
        public enum Filters
        {
            NONE,
            DRIVER_ID,
            PERSON_ID,
            NATIONAL_NUMBER,
            FULL_NAME
        }
        private enum Mode
        {
            Update,
            AddNew
        }
        private Mode mode;
        public int ID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public User CreatedByUser { get; set; }
        public DateTime CreateDate { get; set; }
        public Driver() { mode = Mode.AddNew; }
        private Driver(int iD, int personID, int createdByUserID, DateTime createDate)
        {
            mode = Mode.AddNew;
            ID = iD;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreateDate = createDate;
        }
        public static Driver Find(int ID)
        {
            DataTable dt = DriverData.GetByID(ID);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                return new Driver(
                    ID,
                    (int)dr["PersonID"],
                    (int)dr["CreatedByUserID"],
                    (DateTime)dr["CreateDate"]
                    );
            }
            else
                return null;
        }
        public static Driver FindByPersonID(int personID)
        {
            DataTable dt = DriverData.GetByPersonID(personID);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                return new Driver(
                    (int)dr["ID"],
                    personID,
                    (int)dr["CreatedByUserID"],
                    (DateTime)dr["CreateDate"]
                    );
            }
            else
                return null;
        }
        public static DataTable GetDriverFiltered(Filters filter, string search = "") => DriverData.GetDriverFiltered(filter.ToString(), search);
        public static DataTable GetDriverInternationalLicenses(int driverID) => DriverData.GetDriverInternationalLicenses(driverID);
        public static DataTable GetDriverLocalLicenses(int driverID) => DriverData.GetDriverLocalLicenses(driverID);
        private bool Add()
        {
            var driver = new DriverDTO();
            driver.PersonID = PersonID;
            driver.CreatedByUserID = CreatedByUserID;
            driver.CreateDate = CreateDate;

            ID = DriverData.Add(driver);

            return (ID != 0);
        }
        private bool Update()
        {
            if (!DriverData.IsExist(ID))
                return false;

            var driver = new DriverDTO();
            driver.ID = ID;
            driver.PersonID = PersonID;
            driver.CreatedByUserID = CreatedByUserID;
            driver.CreateDate = CreateDate;

            return (DriverData.Update(driver) > 0);
        }
        public static bool Delete(int ID) => (DriverData.Delete(ID) > 0);
        public static bool IsExist(int ID) => DriverData.IsExist(ID);
        public static bool DoesPersonHasDriverEntry(int personID) => DriverData.DoesPersonHasDriverEntry(personID);
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
