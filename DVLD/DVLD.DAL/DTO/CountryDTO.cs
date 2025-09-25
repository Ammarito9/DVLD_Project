using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.DTO
{
    public class CountryDTO
    {
        public int ID { get; private set; }
        public string CountryName { get; set; }

        public CountryDTO(string CountryName)
        {
            this.CountryName = CountryName;
        }
        public CountryDTO(int ID, string CountryName)
        {
            this.ID = ID;
            this.CountryName = CountryName;
        }
    }
}
