using DVLD.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = DVLD.BLL.Entities.Application;

namespace DVLD.UI.User_Controls.Applications
{
    public partial class RenewLicenseApplication : UserControl
    {
        public string notes { get; private set; }
        public RenewLicenseApplication()
        {
            InitializeComponent();
        }
        public void FillApplicationInfo(in License oldLicense, in License newLicense, int applicationID)
        {
            Application renewApplication = Application.Find(newLicense.ApplicationId);

            lblApplicationIDValue.Text = applicationID.ToString();
            lblRenewedLicenseIDValue.Text = renewApplication.ID.ToString();
            lblRenewedLicenseIDValue.Text = newLicense.ID.ToString();
            lblApplicationFeeValue.Text = renewApplication.ApplicationPaidFee.ToString();
            lblLicenseFeeValue.Text = newLicense.PaidFee.ToString();
            lblOldLicenseIDValue.Text = oldLicense.ID.ToString();
            lblExpirationDateValue.Text = (DateTime.Now.AddYears(LicenseClass.Find(oldLicense.LicenseClassId).ValidityLengthInYears)).ToShortDateString();

            if (!Decimal.TryParse(lblApplicationFeeValue.Text, out decimal applicationFee))
                applicationFee = 0;
            if (!Decimal.TryParse(lblLicenseFeeValue.Text, out decimal licenseFee))
                licenseFee = 0;

            lblTotalFeesValue.Text = (applicationFee + licenseFee).ToString();

            if(!string.IsNullOrEmpty(newLicense.LicenseNote))
                txtNotes.Text = newLicense.LicenseNote;

            notes = txtNotes.Text;
        }
        public void InitializeInitialApplicationInfo()
        {
            lblApplicationDateValue.Text = DateTime.Now.ToShortDateString();
            lblIssueDateValue.Text = DateTime.Now.ToShortDateString();
            lbl_CreatedByValue.Text = CurrentUser.LoggedInUser.ID.ToString();
        }
    }
}
