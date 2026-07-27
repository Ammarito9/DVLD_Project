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

namespace DVLD.UI.User_Controls.Applications
{
    public partial class ctrlReleaseApplicationInfo : UserControl
    {
        public ctrlReleaseApplicationInfo()
        {
            InitializeComponent();
        }
        public void SetApplicationID(int applicationID)
        {
            lblApplicationIDValue.Text = applicationID.ToString();
        }
        public void FillReleaseData(in LicenseDetention licenseDetention)
        {
            decimal serviceFee = Service.Find(((int)Service.Services.RELEASE_OF_DETAINED_LICENSE)).ServiceFee;
            lblDetainIDValue.Text = licenseDetention.ID.ToString();
            lblDetainDateValue.Text = licenseDetention.DateOfDetain.ToString();
            lblFineFeeValue.Text = licenseDetention.DetainFee.ToString();
            lblLicenseIDValue.Text = licenseDetention.LicenseID.ToString();
            lbl_CreatedByValue.Text = CurrentUser.LoggedInUser.UserName;
            lblApplicationFeesValue.Text = serviceFee.ToString();
            lblTotalFeesValue.Text = (serviceFee + licenseDetention.DetainFee).ToString();
        }
    }
}
