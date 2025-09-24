using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.BLL.Entities
{
    internal class Country
    {
        private enum Mode
        {
            Update,
            AddNew
        };

        private Mode mode;

        public int ID { get; private set; }
        public string CountryName { get; set; }

        private Country(int iD,string countryName)
        {
            mode = Mode.Update;
            ID = iD;
            CountryName = countryName;
        }

        public Country()
        {
            mode = Mode.AddNew;
            ID = 0;
            CountryName = string.Empty;
        }


    }
}
