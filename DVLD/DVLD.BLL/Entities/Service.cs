using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLD.DAL.Data;
using DVLD.DAL.DTO;

namespace DVLD.BLL.Entities
{
    public class Service
    {
        public int ID { get; set; }
        public string ServiceName { get; set; }
        public float ServiceFee { get; set; }

        private Service(int ID, string ServiceName, float ServiceFee)
        {
            this.ID = ID;
            this.ServiceName = ServiceName;
            this.ServiceFee = ServiceFee;
        }

        public static Service Find(int ID)
        {
            DataTable dt = ServiceData.GetByID(ID);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            return new Service((int)dr["ID"], (string)dr["ServiceName"], (float)dr["ServiceFee"]);
        }
        private bool Update()
        {
            if(!ServiceData.IsExist(ID)) return false;

            var ServiceDTO = new ServiceDTO(ServiceName, ServiceFee);
            int rows = ServiceData.Update(ServiceDTO);
            return rows > 0;
        }
        public static DataTable GetAll() => ServiceData.GetAll();

        public bool Save() => Update();
    }
}
