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
        public enum Services
        {
            FIRST_TIME_DRIVING_LICENSE_ISSUANCE = 1,
            DRIVING_LICENSE_RENEWAL,
            REPLACEMENT_OF_LOST_LICENSE,
            REPLACEMENT_OF_DAMAGED_LICENSE,
            RELEASE_OF_DETAINED_LICENSE,
            INTERNATIONAL_DRIVING_LICENSE_ISSUANCE,
            RETAKE_TEST = 1008,
        }
        public int ID { get; set; }
        public string ServiceName { get; set; }
        public Decimal ServiceFee { get; set; }

        private Service(int ID, string ServiceName, Decimal ServiceFee)
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
            return new Service((int)dr["ID"], (string)dr["ServiceName"], (Decimal)dr["ServiceFee"]);
        }
        private bool Update()
        {
            if(!ServiceData.IsExist(ID)) return false;

            var ServiceDTO = new ServiceDTO(ID, ServiceName, ServiceFee);
            int rows = ServiceData.Update(ServiceDTO);

            return rows > 0;
        }
        public static DataTable GetAll() => ServiceData.GetAll();

        public bool Save() => Update();
    }
}
