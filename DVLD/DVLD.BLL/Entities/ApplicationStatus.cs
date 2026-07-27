using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLD.DAL.Data;


namespace DVLD.BLL.Entities
{
    public class ApplicationStatus
    {
        public enum ApplicationStatuses
        {
            New = 1,
            Canceled,
            Completed
        }
        public int ID { get; set; }
        public string StatusName { get; set; }
        public ApplicationStatus() { }
        public ApplicationStatus(int iD, string statusName)
        {
            ID = iD;
            StatusName = statusName;
        }
        public static ApplicationStatus Find(int ID)
        {
            DataTable dt = ApplicationStatusData.GetByID(ID);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                return new ApplicationStatus(ID, (string)dr["StatusName"]);
            }
            else
                return null;
        }
        public static DataTable GetAll() => ApplicationStatusData.GetAll();
    }
}
