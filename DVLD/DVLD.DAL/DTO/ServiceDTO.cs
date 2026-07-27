using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.DTO
{
    public class ServiceDTO
    {
        public int ID { get; set; }
        public string ServiceName { get; set; }
        public Decimal ServiceFee { get; set; }

        public ServiceDTO(int ID, string ServiceName, Decimal ServiceFee) 
        {
            this.ID = ID;
            this.ServiceName = ServiceName;
            this.ServiceFee = ServiceFee;
        }
        public ServiceDTO(string ServiceName, Decimal ServiceFee)
        {
            this.ServiceName = ServiceName;
            this.ServiceFee = ServiceFee;
        }
    }
}
