using DVLD.BLL.Entities;
using DVLD.UI.Manage_Applications;
using DVLD.UI.Manage_Applications.International_License_Applications;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Detain_Licenses
{
    public partial class DetainLicense : Form
    {
        License detainedLicense;
        public DetainLicense()
        {
            InitializeComponent();
        }

        private void findDriverByLicenseId_OnLicenseSelected(int obj)
        {
            detainedLicense = License.Find(obj);

            ctrlDetainInfo1.FillBasicInfo(detainedLicense);
            
            if ((string)findDriverByLicenseId.driverLicenseInfoDetailed["IsDetained"] == "Yes")
            {
                MessageBox.Show("The license is already detained!", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
                llblShowLicenseHistory.Enabled = true;
                return;
            }

            if (obj != 0)
            {
                llblShowLicenseHistory.Enabled = true;
                btnDetain.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            LicenseDetention licenseDetention = new LicenseDetention();
            licenseDetention.LicenseID = detainedLicense.ID;
            licenseDetention.ReleaseApplicationID = null;
            licenseDetention.CreatedByUserID = CurrentUser.LoggedInUser.ID;
            licenseDetention.ReleasedByUserID = null;
            licenseDetention.DetainFee = ctrlDetainInfo1.fineFee;
            licenseDetention.DateOfDetain = DateTime.Now;
            licenseDetention.ReleaseDate = null;
            licenseDetention.IsReleased = false;

            if (!licenseDetention.Save())
            {
                MessageBox.Show("The detention is not created!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"The license is detained, detention ID {licenseDetention.ID}!", "Detained", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ctrlDetainInfo1.FillDetainInfo(licenseDetention);
            llblShowLicenseInfo.Enabled = true;
            btnDetain.Enabled = false;
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistory licenseHistory = new LicenseHistory(detainedLicense.DriverId, Driver.Find(detainedLicense.DriverId).PersonID);
            licenseHistory.ShowDialog();
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfo licenseInfo = new LicenseInfo(detainedLicense.ID);
            licenseInfo.ShowDialog();
        }
    }
}
