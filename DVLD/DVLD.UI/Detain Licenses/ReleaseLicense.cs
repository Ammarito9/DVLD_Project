using DVLD.BLL.Entities;
using DVLD.UI.Manage_Applications;
using DVLD.UI.Manage_Applications.International_License_Applications;
using DVLD.UI.User_Controls.Applications;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = DVLD.BLL.Entities.Application;


namespace DVLD.UI.Detain_Licenses
{
    public partial class ReleaseLicense : Form
    {
        License detainedLicense;
        LicenseDetention licenseDetention;
        public ReleaseLicense()
        {
            InitializeComponent();
        }
        public ReleaseLicense(int licenseID) : this()
        {
            findDriverByLicenseId.Search(licenseID);
        }
        private void findDriverByLicenseId_OnLicenseSelected(int obj)
        {
            detainedLicense = License.Find(obj);
            licenseDetention = LicenseDetention.FindByLicenseID(obj);

            if ((string)findDriverByLicenseId.driverLicenseInfoDetailed["IsDetained"] == "No")
            {
                MessageBox.Show("The license is NOT detained!", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRelease.Enabled = false;
                llblShowLicenseHistory.Enabled = true;
                return;
            }

            ctrlReleaseApplicationInfo1.FillReleaseData(licenseDetention);

            if (licenseDetention.IsReleased)
            {
                MessageBox.Show("The license is already released!", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRelease.Enabled = false;
                llblShowLicenseHistory.Enabled = true;
                return;
            }

            if (obj != 0)
            {
                llblShowLicenseHistory.Enabled = true;
                btnRelease.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnRelease_Click(object sender, EventArgs e)
        {
            Service releaseService = Service.Find((int)Service.Services.RELEASE_OF_DETAINED_LICENSE);
            Application releaseApplication = new Application();
            releaseApplication.PersonID = Driver.Find(detainedLicense.DriverId).PersonID;
            releaseApplication.ServiceID = releaseService.ID;
            releaseApplication.ApplicationPaidFee = releaseService.ServiceFee;
            releaseApplication.ApplicationStatusID = ((int)ApplicationStatus.ApplicationStatuses.Completed);
            releaseApplication.CreatedByUserID = CurrentUser.LoggedInUser.ID;
            releaseApplication.ApplicationDate = DateTime.Now;
            releaseApplication.LastStatusDate = DateTime.Now;

            if (!releaseApplication.Save())
            {
                MessageBox.Show("Release application is NOT created!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            licenseDetention.ReleaseApplicationID = releaseApplication.ID;
            licenseDetention.ReleasedByUserID = CurrentUser.LoggedInUser.ID;
            licenseDetention.ReleaseDate = DateTime.Now;
            licenseDetention.IsReleased = true;

            if (!licenseDetention.Save())
            {
                MessageBox.Show("The license failed to be released", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Delete(releaseApplication.ID);
                return;
            }

            MessageBox.Show($"The license released.", "Successful", MessageBoxButtons.OK);
            ctrlReleaseApplicationInfo1.SetApplicationID(releaseApplication.ID);
            llblShowLicenseInfo.Enabled = true;
            btnRelease.Enabled = false;
        }
    }
}
