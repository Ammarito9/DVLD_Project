using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Common_Forms
{
    public partial class PersonDetails : Form
    {
        public PersonDetails(int ID)
        {
            InitializeComponent(ID);
        }
    }
}
