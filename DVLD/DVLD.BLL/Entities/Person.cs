using System.Net;
using System.Reflection;
using DVLD.DAL.DTO;
using System.Data;
using DVLD.DAL.Data;

namespace DVLD.BLL.Entities
{
    public class Person
    {
        private enum Mode
        {
            Update,
            AddNew
        }

        Mode mode;
        public int ID { get; private set; }
        public int NationalityCountryID { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string PersonalPhotoPath { get; set; }

        private Person(int iD, int nationalityCountryID, string nationalNumber, string firstName, string secondName, string thirdName, string lastName, string gender, DateTime dateOfBirth, string email, string address, string phoneNumber, string personalPhotoPath)
        {
            mode = Mode.Update;
            ID = iD;
            NationalityCountryID = nationalityCountryID;
            NationalNumber = nationalNumber;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Email = email;
            Address = address;
            PhoneNumber = phoneNumber;
            PersonalPhotoPath = personalPhotoPath;
        }
        public Person()
        {
            mode = Mode.AddNew;
            ID = 0;
            NationalityCountryID = 0;
            NationalNumber = string.Empty;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            Gender = string.Empty;
            DateOfBirth = DateTime.Now;
            Email = string.Empty;
            Address = string.Empty;
            PhoneNumber = string.Empty;
            PersonalPhotoPath = string.Empty;

        }

        private static string HandleDBNull(object value)
        {
            return value == DBNull.Value ? "" : (string)value;
        }
        public static Person Find(int ID)
        {
            DataTable dt = PersonData.GetByID(ID);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                return new Person(
                     ID
                    ,(int)dr["NationalityCountryID"]
                    ,(string)dr["NationalNumber"]
                    ,(string)dr["FirstName"]
                    ,HandleDBNull(dr["SecondName"])
                    ,HandleDBNull(dr["ThirdName"])
                    ,(string)dr["LastName"]
                    ,(string)dr["Gender"]
                    ,(DateTime)dr["DateOfBirth"]
                    ,HandleDBNull(dr["Email"])
                    ,(string)dr["Address"]
                    ,(string)dr["PhoneNumber"]
                    ,HandleDBNull(dr["PersonalPhotoPath"])
                );
            }
            else
                return null;
        }
        public static Person Find(string NationalNumber)
        {
            var person = new Person();

            DataTable dt = PersonData.GetByNationalNumber(NationalNumber);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                return new Person(
                      (int)dr["ID"]
                    , (int)dr["NationalityCountryID"]
                    , NationalNumber
                    , (string)dr["FirstName"]
                    , HandleDBNull(dr["SecondName"])
                    , HandleDBNull(dr["ThirdName"])
                    , (string)dr["LastName"]
                    , (string)dr["Gender"]
                    , (DateTime)dr["DateOfBirth"]
                    , HandleDBNull(dr["Email"])
                    , (string)dr["Address"]
                    , (string)dr["PhoneNumber"]
                    , HandleDBNull(dr["PersonalPhotoPath"])
                );
            }
            else
                return null;
        }
        public bool Add()
        {
            var personDTO = new PersonDTO();

            personDTO.NationalityCountryID = NationalityCountryID;
            personDTO.NationalNumber = NationalNumber;
            personDTO.FirstName = FirstName;
            personDTO.SecondName = SecondName;
            personDTO.ThirdName = ThirdName;
            personDTO.LastName = LastName;
            personDTO.Gender = Gender;
            personDTO.DateOfBirth = DateOfBirth;
            personDTO.Email = Email;
            personDTO.Address = Address;
            personDTO.PhoneNumber = PhoneNumber;
            personDTO.PersonalPhotoPath = PersonalPhotoPath;
            ID = PersonData.Add(personDTO);

            return (ID != 0);
        }
        public bool Update()
        {
            if(!PersonData.IsExist(ID)) return false;

            var personDTO = new PersonDTO();

            personDTO.NationalityCountryID = NationalityCountryID;
            personDTO.NationalNumber = NationalNumber;
            personDTO.FirstName = FirstName;
            personDTO.SecondName = SecondName;
            personDTO.ThirdName = ThirdName;
            personDTO.LastName = LastName;
            personDTO.Gender = Gender;
            personDTO.DateOfBirth = DateOfBirth;
            personDTO.Email = Email;
            personDTO.Address = Address;
            personDTO.PhoneNumber = PhoneNumber;
            personDTO.PersonalPhotoPath = PersonalPhotoPath;


            return (PersonData.Update(personDTO) > 0);
        }
        public static bool Delete(int ID) => (PersonData.Delete(ID) > 0);
        public static DataTable GetAll() => PersonData.GetAll();

        public bool Save()
        {
            switch (mode)
            {
                case Mode.AddNew:
                    if (Add())
                    {
                        mode = Mode.Update;
                        return true;
                    }
                    return false;
                case Mode.Update:
                    return Update();

                default: return false;
            }
        }
    }
}
