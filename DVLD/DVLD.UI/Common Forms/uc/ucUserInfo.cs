using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.BLL.Entities;
namespace DVLD.UI.Common_Forms.uc
{
    public partial class ucUserInfo : UserControl
    {
        private int Id;
        private User user;
        public ucUserInfo()
        {
            InitializeComponent();
        }

        public ucUserInfo(int ID) : this()
        {
            Id = ID;
            user = User.Find(Id);

            LoadLoginInformation();
            InitializeAndLoadPersonDetails();

            InitializeComponent();
        }

        public void InitializeAndLoadPersonDetails()
        {
            ucPersonDetails1 = new ucPersonDetails(user.Person.ID);
            SuspendLayout();

            ucPersonDetails1.Location = new Point(3, 0);
            ucPersonDetails1.Name = "ucPersonDetails1";
            ucPersonDetails1.Size = new Size(901, 439);
            ucPersonDetails1.TabIndex = 0;
            this.Controls.Add(ucPersonDetails1);
        }

        public void LoadLoginInformation()
        {
            lbl_UserIdValue.Text = user.ID.ToString();
            lbl_UsernameValue.Text = user.UserName;
            lbl_IsActiveValue.Text = user.IsActive.ToString();
        }
    }
}
