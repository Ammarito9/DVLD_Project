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
    public partial class UpdatePerson : Form
    {
        public UpdatePerson()
        {
            InitializeComponent();
        }
        public UpdatePerson(int ID) : this()
        {
            //InitializeComponent();
            ucAddUpdatePerson ucUpdateControl = new ucAddUpdatePerson(true, ID);
            ucUpdateControl.Name = "ucUpdateControl";
            ucUpdateControl.Dock = DockStyle.Fill;
            this.Controls.Add(ucUpdateControl);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
