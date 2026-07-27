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
using Application = DVLD.BLL.Entities.Application;

namespace DVLD.UI.User_Controls.Applications
{
    public partial class InternationalLicenseApplicationBasicInfo : UserControl
    {
        public InternationalLicenseApplicationBasicInfo()
        {
            InitializeComponent();
        }
        
        public void FillApplicationInfo(int internationalLicenseID)
        {
            InternationalLicense internationalLicense = InternationalLicense.Find(internationalLicenseID);
            Application application = Application.Find(internationalLicense.ApplicationID);

            lblApplicationIDValue.Text = internationalLicense.ApplicationID.ToString();
            lbl_FeeValue.Text = application.ApplicationPaidFee.ToString();

            lblInternationalLicenseIDValue.Text = internationalLicense.ID.ToString();
            lblLocalLicenseIDValue.Text = internationalLicense.IssuedUsingLocalLicenseID.ToString();
        }
        public void InitializeInitialApplicationInfo()
        {
            lblApplicationDateValue.Text = DateTime.Now.ToShortDateString();
            lblIssueDateValue.Text = DateTime.Now.ToShortDateString();
            lblExpirationDateValue.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lbl_CreatedByValue.Text = CurrentUser.LoggedInUser.ID.ToString();
        }
    }
}
