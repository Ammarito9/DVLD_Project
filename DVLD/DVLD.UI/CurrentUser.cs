using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD.BLL.Entities;

namespace DVLD.UI
{
    public class CurrentUser
    {
        public static User LoggedInUser { get; set; }
    }
}
