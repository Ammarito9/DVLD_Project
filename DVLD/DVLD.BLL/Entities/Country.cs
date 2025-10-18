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
    public class Country
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

        private static string HandleDBNull(object value)
        {
            return value == DBNull.Value ? "" : (string)value;
        }

        public static Country Find(int ID)
        {
            DataTable dt = CountryData.GetByID(ID);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            return new Country((int)dr["ID"], (string)dr["CountryName"]);
        }

        public static Country Find(string CountryName)
        {
            DataTable dt = CountryData.GetByCountryName(CountryName);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            return new Country((int)dr["ID"], (string)dr["CountryName"]);
        }

        private bool Add()
        {
            var countryDTO = new CountryDTO(CountryName);
            ID = CountryData.Add(countryDTO);

            return (ID != 0);
        }

        private bool Update()
        {
            if(!CountryData.IsExist(ID)) return false;

            var countryDTO = new CountryDTO(ID, CountryName);
            int rows = CountryData.Update(countryDTO);

            return (rows > 0);
        }
        public static bool Delete(int ID) => (CountryData.Delete(ID) > 0);
        public static DataTable GetAll() => CountryData.GetAll();

        public static List<string> GetAllCountryNames() => CountryData.GetAllCountryNames();
        public bool Save()
        {
            switch (mode)
            {
                case Mode.AddNew:
                {
                    if(!Add())
                        return false;

                    mode = Mode.Update;
                    return true;
                }
                case Mode.Update:
                    return Update();

                default: return false;
            }
        }
    }
}
