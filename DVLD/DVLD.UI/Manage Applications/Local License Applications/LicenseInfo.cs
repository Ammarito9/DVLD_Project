using DVLD.BLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Manage_Applications
{
    public partial class LicenseInfo : Form
    {
        public LicenseInfo()
        {
            InitializeComponent();
        }
        public LicenseInfo(int LicenseID) : this()
        {
            InitializeDriverLicenseInfo(LicenseID);
        }
        private void InitializeDriverLicenseInfo(int LicenseID)
        {
            driverLicenseInfo1 = new User_Controls.Driver.DriverLicenseInfo(LicenseID);

            driverLicenseInfo1.Location = new Point(12, 139);
            driverLicenseInfo1.Name = "driverLicenseInfo1";
            driverLicenseInfo1.Size = new Size(1129, 489);

            Controls.Add(driverLicenseInfo1);
            PerformLayout();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
