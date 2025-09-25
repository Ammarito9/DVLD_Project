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
        public float ServiceFee { get; set; }

        public ServiceDTO(int ID, string ServiceName, float ServiceFee) 
        {
            this.ID = ID;
            this.ServiceName = ServiceName;
            this.ServiceFee = ServiceFee;
        }
        public ServiceDTO(string ServiceName, float ServiceFee)
        {
            this.ServiceName = ServiceName;
            this.ServiceFee = ServiceFee;
        }
    }
}
