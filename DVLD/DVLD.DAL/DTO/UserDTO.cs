using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.DTO
{
    public class UserDTO
    {
        public int ID { get; private set; }
        public int PersonID { get; private set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
        public bool IsActive { get; set; }


        public UserDTO(int ID, string UserName, string Password, bool IsActive, int personID)
        {
            this.ID = ID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            PersonID = personID;
        }

        public UserDTO(string UserName, int PersonID, string Password, bool IsActive)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.PersonID = PersonID;
        }
    }
}
