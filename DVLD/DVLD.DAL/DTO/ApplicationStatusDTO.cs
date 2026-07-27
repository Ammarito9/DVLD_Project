using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.DTO
{
    public class ApplicationStatusDTO
    {
        public int ID { get; set; }
        public string StatusName { get; set; }
        public ApplicationStatusDTO() { }
        public ApplicationStatusDTO(int iD, string statusName)
        {
            ID = iD;
            StatusName = statusName;
        }
    }
}
