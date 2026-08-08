using System.Data;
using Microsoft.Win32;

namespace DVLD.DAL
{
    public static class Connection
    {
        public static string DBConnectionString = "Server=.;Database=DVLD;User Id=sa;Password=sa123456;TrustServerCertificate=True;";
        public static string RegistryKeyName = Registry.CurrentUser.ToString() + @"\Software\DVLD\Credentials";
    }
}
