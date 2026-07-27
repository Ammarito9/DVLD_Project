using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.DTO
{
    public class ApplicationDTO
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public int ServiceID { get; set; }
        public int ApplicationStatusID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime LastStatusDate { get; set; }
        public Decimal ApplicationPaidFee { get; set; }

        public ApplicationDTO() { }
        public ApplicationDTO(int iD, int personID, int serviceID, int applicationStatusID, int createdByUserID, DateTime applicationDate, DateTime lastStatusDate, decimal applicationPaidFee)
        {
            ID = iD;
            PersonID = personID;
            ServiceID = serviceID;
            ApplicationStatusID = applicationStatusID;
            CreatedByUserID = createdByUserID;
            ApplicationDate = applicationDate;
            LastStatusDate = lastStatusDate;
            ApplicationPaidFee = applicationPaidFee;
        }
    }
}
