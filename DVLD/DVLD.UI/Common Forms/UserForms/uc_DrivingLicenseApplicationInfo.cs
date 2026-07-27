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

namespace DVLD.UI.Common_Forms.UserForms
{
    public partial class uc_DrivingLicenseApplicationInfo : UserControl
    {
        LocalDrivingLicenseApplication localDrivingLicenseApplication;
        int ApplicationId = 0;
        public LicenseClass license {get; private set;}
        public uc_DrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }
        public uc_DrivingLicenseApplicationInfo(int applicationID) : this()
        {
            ApplicationId = applicationID;
            localDrivingLicenseApplication = LocalDrivingLicenseApplication.Find(applicationID);

            license = LicenseClass.Find(localDrivingLicenseApplication.LicenseClassID);
            FillApplicationInfo(ApplicationId);
        }
        private void FillApplicationInfo(int applicationID)
        {
            lbl_ApplicationIDValue.Text = applicationID.ToString();
            lbl_LicenseClassValue.Text = license.ClassName;
            lbl_PassedTestsValue.Text = LocalDrivingLicenseApplication.GetNumberOfPassedTests(applicationID).ToString() + "/3";
        }
        private void EnableLicenseInfo()
        {
            llbl_ShowLicenseInfo.Enabled = true;
        }
    }
}
