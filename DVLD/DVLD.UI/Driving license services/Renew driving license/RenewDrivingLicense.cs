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

namespace DVLD.UI.Driving_license_services.Renew_driving_license
{
    public partial class RenewDrivingLicense : Form
    {
        Application renewApplication;
        License oldLicense;
        License newLicense;
        public RenewDrivingLicense()
        {
            InitializeComponent();
            renewLicenseApplication1.InitializeInitialApplicationInfo();
        }

        private void findDriverByLicenseId_OnLicenseSelected(int obj)
        {
            oldLicense = License.Find(obj);
            if (oldLicense.ExpiryDate > DateTime.Today)
            {
                MessageBox.Show("The expiration date not ended!", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            if (obj != 0)
            {
                btnRenew.Enabled = true;
                llblShowLicenseHistory.Enabled = true;
            }
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            LicenseClass licenseClass = LicenseClass.Find(oldLicense.LicenseClassId);

            Service renewalService = Service.Find((int)Service.Services.DRIVING_LICENSE_RENEWAL);

            renewApplication = new Application();

            renewApplication.PersonID = Driver.Find(oldLicense.DriverId).PersonID;
            renewApplication.ServiceID = renewalService.ID;
            renewApplication.ApplicationStatusID = ((int)ApplicationStatus.ApplicationStatuses.Completed);
            renewApplication.CreatedByUserID = CurrentUser.LoggedInUser.ID;
            renewApplication.ApplicationDate = DateTime.Now;
            renewApplication.LastStatusDate = DateTime.Now;
            renewApplication.ApplicationPaidFee = renewalService.ServiceFee;

            if (!renewApplication.Save())
            {
                MessageBox.Show("Renewal application is NOT created!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            newLicense = new License();
            newLicense.DriverId = oldLicense.DriverId;
            newLicense.LicenseClassId = oldLicense.LicenseClassId;
            newLicense.LicenseClassName = oldLicense.LicenseClassName;
            newLicense.LicenseTypeId = ((int)License.LicenseType.RENEWAL);
            newLicense.LicenseTypeName = oldLicense.LicenseTypeName;
            newLicense.CreatedByUserId = oldLicense.CreatedByUserId;
            newLicense.CreatedByUsername = oldLicense.CreatedByUsername;
            newLicense.ApplicationId = renewApplication.ID;
            newLicense.IssueDate = DateTime.Now;
            newLicense.ExpiryDate = DateTime.Now.AddYears(licenseClass.ValidityLengthInYears);
            newLicense.IsActive = true;
            newLicense.LicenseNumber = Guid.NewGuid().ToString();
            newLicense.LicenseNote = renewLicenseApplication1.notes;
            newLicense.PaidFee = licenseClass.ClassFees;

            if (!newLicense.Save())
            {
                MessageBox.Show("The license failed to renewal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Delete(renewApplication.ID);
                return;
            }

            oldLicense.IsActive = false;
            if (!oldLicense.Save())
            {
                License.Delete(newLicense.ID);
                Application.Delete(renewApplication.ID);
                return;
            }

            MessageBox.Show($"The new license created with id {newLicense.ID}", "Successful", MessageBoxButtons.OK);
            renewLicenseApplication1.FillApplicationInfo(oldLicense, newLicense, renewApplication.ID);
            llblShowLicenseInfo.Enabled = true;
            btnRenew.Enabled = false;
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistory licenseHistory = new LicenseHistory(newLicense.DriverId, renewApplication.PersonID);
            licenseHistory.ShowDialog();
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfo internationalLicenseInfo = new LicenseInfo(newLicense.ID);
            internationalLicenseInfo.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
