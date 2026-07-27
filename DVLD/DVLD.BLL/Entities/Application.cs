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
    public class Application
    {
        public enum DetailedApplicationAttribute
        {
            ID,
            PersonID,
            Fullname,
            ServiceName,
            StatusName,
            Username,
            ApplicationDate,
            LastStatusDate,
            ApplicationPaidFee
        }
        private enum Mode
        {
            Update,
            AddNew
        }
        private Mode mode;
        public int ID { get; set; }
        public int PersonID { get; set; }
        public int ServiceID { get; set; }
        public int ApplicationStatusID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime LastStatusDate { get; set; }
        public Decimal ApplicationPaidFee { get; set; }

        private Application(int iD, int personID, int serviceID, int applicationStatusID, int createdByUserID, DateTime applicationDate, DateTime lastStatusDate, decimal applicationPaidFee)
        {
            this.mode = Mode.Update;
            ID = iD;
            PersonID = personID;
            ServiceID = serviceID;
            ApplicationStatusID = applicationStatusID;
            CreatedByUserID = createdByUserID;
            ApplicationDate = applicationDate;
            LastStatusDate = lastStatusDate;
            ApplicationPaidFee = applicationPaidFee;
        }
        public Application()
        {
            mode = Mode.AddNew;
        }
        public static Application Find(int iD)
        {
            DataTable dt = ApplicationData.GetByID(iD);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                return new Application(
                    iD,
                    (int)dr["PersonID"],
                    (int)dr["ServiceID"],
                    (int)dr["ApplicationStatusID"],
                    (int)dr["CreatedByUserID"],
                    (DateTime)dr["ApplicationDate"],
                    (DateTime)dr["LastStatusDate"],
                    (Decimal)dr["ApplicationPaidFee"]
                    );
            }
            else
                return null;
                
        }
        public static DataRow GetByIDDetailed(int ID) => ApplicationData.GetByIDDetailed(ID);
        public static DataTable GetAll() => ApplicationData.GetAll();
        private bool Add()
        {
            ApplicationDTO newApplication = new ApplicationDTO();

            newApplication.PersonID = PersonID;
            newApplication.ServiceID = ServiceID;
            newApplication.ApplicationStatusID = ApplicationStatusID;
            newApplication.CreatedByUserID = CreatedByUserID;
            newApplication.ApplicationDate = ApplicationDate;
            newApplication.LastStatusDate = LastStatusDate;
            newApplication.ApplicationPaidFee = ApplicationPaidFee;
            ID =  ApplicationData.Add(newApplication);

            return ID != 0;
        }
        private bool Update()
        {
            if(!ApplicationData.IsExist(ID))
                return false;

            ApplicationDTO newApplication = new ApplicationDTO();

            newApplication.ID = ID;
            newApplication.PersonID = PersonID;
            newApplication.ServiceID = ServiceID;
            newApplication.ApplicationStatusID = ApplicationStatusID;
            newApplication.CreatedByUserID = CreatedByUserID;
            newApplication.ApplicationDate = ApplicationDate;
            newApplication.LastStatusDate = LastStatusDate;
            newApplication.ApplicationPaidFee = ApplicationPaidFee;

            return (ApplicationData.Update(newApplication) > 0);
        }
        public static bool Delete(int ID) => (ApplicationData.Delete(ID) > 0);
        public static bool IsExist(int ID) => ApplicationData.IsExist(ID);
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
