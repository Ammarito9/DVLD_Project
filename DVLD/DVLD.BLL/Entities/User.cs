using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD.DAL.Data;
using DVLD.DAL.DTO;
using System.Data;


namespace DVLD.BLL.Entities
{
    public class User
    {
        private static readonly string PathOfRememberMeFile = @"D:\programming\programmingAdvices\Programming advices trining Code\DVLD_PROJECT\rememberme.txt";

        private enum Mode
        {
            Update,
            AddNew
        }
        public enum Filters
        {
            None,
            UserId,
            PersonId,
            FullName,
            Username,
            IsActive
        }

        Mode mode;
        public int ID { get; private set; }
        public Person Person { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
        public bool IsActive { get; set; }

        private User(int iD, int personID, string userName, string password, int permissions, bool isActive)
        {
            mode = Mode.Update;
            ID = iD;
            Person = Person.Find(personID);
            UserName = userName;
            Password = password;
            Permissions = permissions;
            IsActive = isActive;
        }

        public User()
        {
            mode = Mode.AddNew;
            ID = 0;
            Person = null;
            UserName = string.Empty;
            Password = string.Empty;
            Permissions = 0;
            IsActive = false;
        }

        public static User Find(int ID)
        {
            DataTable dt = UserData.GetByID(ID);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            return new User((int)dr["ID"], (int)dr["PersonID"], (string)dr["UserName"], (string)dr["Password"], (byte)dr["Permissions"], (bool)dr["IsActive"]);
        }
        public static User Find(string Username)
        {
            DataTable dt = UserData.GetByUsername(Username);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            return new User((int)dr["ID"], (int)dr["PersonID"], (string)dr["UserName"], (string)dr["Password"], (byte)dr["Permissions"], (bool)dr["IsActive"]);
        }
        private bool Add()
        {
            var UserDTO = new UserDTO(UserName, Person.ID, Password,IsActive);

            ID = UserData.Add(UserDTO);

            return ID != 0;
        }
        private bool Update()
        {
            if(!UserData.IsExist(ID))
                return false;

            var UserDTO = new UserDTO(ID, UserName, Password, IsActive, Person.ID);
            int rows = UserData.Update(UserDTO);

            return (rows > 0);
        }
        public static bool Delete(int ID) => (UserData.Delete(ID) != 0);
        public static DataTable GetAll() => UserData.GetAll();

        public static DataTable GetFilterBy(Filters filter, String FilterValue) => UserData.GetAllFiltered(filter.ToString(), FilterValue);
        public bool Save()
        {
            switch (mode)
            {
                case Mode.Update:
                    return Update();
                case Mode.AddNew:
                    if (Add())
                    {
                        mode = Mode.Update;
                        return true;
                    }
                    return false;
                default : return false;
            }
        }
        public static User CheckCredentials(string username, string password)
        {
            User user = new User();
            user = Find(username);

            if (user is null)
                return null;

            if (user.IsActive == false) 
                user.IsActive = false;
            if (user.Password != password) 
                user.Password = String.Empty;

            return user;
        }

        [Obsolete]
        public static void AddCredentialsToRememberMe(string UserName) => FileDataAccess.WriteToFile(PathOfRememberMeFile, UserName);

        [Obsolete]
        public static User GetCredentialsFromRememberMe()
        {
            List<string> ls = FileDataAccess.ReadFromFile(PathOfRememberMeFile);

            if (ls.Count == 0)
                return null;

            string RememberMeLine = ls.First();

            if (RememberMeLine != string.Empty)
            {
                return User.Find(RememberMeLine);
            }

            return null;
        }
        public static void StoreUserCredentials(string username, string password) => Util.StoreUserCredentialsToRegistry(username, password);
        /// <summary>
        /// 
        /// </summary>
        /// <returns>It return a filled object if found; other ways null</returns>
        public static User? GetStoredUserCredentials()
        {
            string[]? userCredentials = Util.GetUserCredentialsFromRegistry();

            if (userCredentials is null)
                return null;

            User user = Find(userCredentials[0]); // Find by username
            return user;
        }

        public static bool DoesPersonIdConnectedToUser(int Id) => UserData.DoesPersonIdConnectedToUser(Id);

        public static bool IsExist(int id) => UserData.IsExist(id);
        public static bool IsExist(String Username) => UserData.IsExist(Username);
    }
}
