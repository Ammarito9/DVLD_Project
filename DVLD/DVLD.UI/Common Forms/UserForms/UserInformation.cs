using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Common_Forms.UserForms
{
    public partial class UserInformation : Form
    {
        private int Id;
        public UserInformation(int id) : base()
        {
            Id = id;
            InitializeUserInfo();
            InitializeComponent();
        }

        private void InitializeUserInfo()
        {
            ucUserInfo1 = new uc.ucUserInfo(Id);
            SuspendLayout();

            ucUserInfo1.Location = new Point(-1, -100);
            ucUserInfo1.Name = "ucUserInfo1";
            ucUserInfo1.Size = new Size(915, 595);
            ucUserInfo1.TabIndex = 0;
            this.Controls.Add(ucUserInfo1);
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
