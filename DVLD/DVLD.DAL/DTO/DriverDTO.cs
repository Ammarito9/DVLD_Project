using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.DTO
{
    public class DriverDTO
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreateDate { get; set; }

        public DriverDTO() { }
        public DriverDTO(int iD, int personID, int createdByUserID, DateTime createDate)
        {
            ID = iD;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreateDate = createDate;
        }
    }
}
