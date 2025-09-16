using System.Net;
using System.Reflection;
using DVLD.DAL;

namespace DVLD.BLL.Entities
{
    public class Person
    {
        public int ID { get; set; }
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
        public static Person Find(int ID)
        {
            int nationalityCountryID = 0;
            string nationalNumber = string.Empty,firstName = string.Empty,lastName = string.Empty,gender = string.Empty,address = string.Empty,phoneNumber = string.Empty;
            string? secondName = string.Empty, thirdName = string.Empty, email = string.Empty, personalPhotoPath = string.Empty;
            DateTime dateOfBirth = DateTime.Now;

            if (PersonData.GetByID(ID, ref nationalityCountryID, ref nationalNumber, ref firstName, ref secondName, ref thirdName, ref lastName, ref gender, ref dateOfBirth, ref email, ref address, ref phoneNumber, ref personalPhotoPath))
            {
                //Defaulting the nulls to Empty string
                secondName = secondName == null ? string.Empty : secondName;
                thirdName = thirdName == null ? string.Empty : thirdName;
                email = email == null ? string.Empty : email;
                personalPhotoPath = personalPhotoPath == null ? string.Empty : personalPhotoPath;

                return new Person(ID, nationalityCountryID, nationalNumber, firstName, secondName, thirdName, lastName, gender, dateOfBirth, email, address, phoneNumber, personalPhotoPath);
            }
            else
                return null;
        }

        public static Person Find(string NationalNumber)
        { 
            int nationalityCountryID = 0, ID = 0;
            string firstName = string.Empty, lastName = string.Empty, gender = string.Empty, address = string.Empty, phoneNumber = string.Empty;
            string? secondName = string.Empty, thirdName = string.Empty, email = string.Empty, personalPhotoPath = string.Empty;
            DateTime dateOfBirth = DateTime.Now;

            if (PersonData.GetByNationalNumber(ref ID, ref nationalityCountryID, NationalNumber, ref firstName, ref secondName, ref thirdName, ref lastName, ref gender, ref dateOfBirth, ref email, ref address, ref phoneNumber, ref personalPhotoPath))
            {
                //Defaulting the nulls to Empty string
                secondName = secondName == null ? string.Empty : secondName;
                thirdName = thirdName == null ? string.Empty : thirdName;
                email = email == null ? string.Empty : email;
                personalPhotoPath = personalPhotoPath == null ? string.Empty : personalPhotoPath;

                return new Person(ID, nationalityCountryID, NationalNumber, firstName, secondName, thirdName, lastName, gender, dateOfBirth, email, address, phoneNumber, personalPhotoPath);
            }
            else
                return null;
        }
    }
}
