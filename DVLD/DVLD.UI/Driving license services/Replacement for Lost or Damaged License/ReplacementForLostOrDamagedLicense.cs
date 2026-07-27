using DVLD.BLL.Entities;
using DVLD.UI.Manage_Applications;
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

namespace DVLD.UI.Driving_license_services.Replacement_for_Lost_or_Damaged_License
{
    public partial class ReplacementForLostOrDamagedLicense : Form
    {
        Application replacementApplication;
        License oldLicense;
        License newLicense;
        Service lostService;
        Service damagedService;
        bool isDamaged = true;

        public ReplacementForLostOrDamagedLicense()
        {
            InitializeComponent();
            ctrlReplacementLicenseApplicationBasicInfo1.InitializeInitialApplicationInfo();
            damagedService = Service.Find(((int)Service.Services.REPLACEMENT_OF_DAMAGED_LICENSE));
            ctrlReplacementLicenseApplicationBasicInfo1.SetFees(damagedService);

        }

        private void findDriverByLicenseId_OnLicenseSelected(int obj)
        {
            oldLicense = License.Find(obj);
            if (oldLicense.IsActive == false)
            {
                MessageBox.Show("The license is inactive!", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }

            if (obj != 0)
            {
                btnIssue.Enabled = true;
                llblShowLicenseHistory.Enabled = true;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (lostService is null)
                lostService = Service.Find(((int)Service.Services.REPLACEMENT_OF_LOST_LICENSE));

            ctrlReplacementLicenseApplicationBasicInfo1.SetFees(lostService);
            isDamaged = false;
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (damagedService is null)
                damagedService = Service.Find(((int)Service.Services.REPLACEMENT_OF_DAMAGED_LICENSE));

            ctrlReplacementLicenseApplicationBasicInfo1.SetFees(damagedService);
            isDamaged = true;
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfo internationalLicenseInfo = new LicenseInfo(newLicense.ID);
            internationalLicenseInfo.ShowDialog();
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistory licenseHistory = new LicenseHistory(oldLicense.DriverId, Driver.Find(oldLicense.DriverId).PersonID);
            licenseHistory.ShowDialog();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            LicenseClass licenseClass = LicenseClass.Find(oldLicense.LicenseClassId);

            replacementApplication = new();

            replacementApplication.PersonID = Driver.Find(oldLicense.DriverId).PersonID;

            if (isDamaged)
            {
                replacementApplication.ServiceID = damagedService.ID;
                replacementApplication.ApplicationPaidFee = damagedService.ServiceFee;
            }
            else
            {
                replacementApplication.ServiceID = lostService.ID;
                replacementApplication.ApplicationPaidFee = lostService.ServiceFee;
            }

            replacementApplication.ApplicationStatusID = ((int)ApplicationStatus.ApplicationStatuses.Completed);
            replacementApplication.CreatedByUserID = CurrentUser.LoggedInUser.ID;
            replacementApplication.ApplicationDate = DateTime.Now;
            replacementApplication.LastStatusDate = DateTime.Now;

            if (!replacementApplication.Save())
            {
                MessageBox.Show("Replacement application is NOT created!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            newLicense = new();
            newLicense.DriverId = oldLicense.DriverId;
            newLicense.LicenseClassId = oldLicense.LicenseClassId;
            newLicense.LicenseClassName = oldLicense.LicenseClassName;

            if (isDamaged)
                newLicense.LicenseTypeId = ((int)License.LicenseType.REPLACEMENT_DAMAGED);
            else
                newLicense.LicenseTypeId = ((int)License.LicenseType.REPLACEMENT_LOST);

            newLicense.LicenseTypeName = oldLicense.LicenseTypeName;
            newLicense.CreatedByUserId = oldLicense.CreatedByUserId;
            newLicense.CreatedByUsername = oldLicense.CreatedByUsername;
            newLicense.ApplicationId = replacementApplication.ID;
            newLicense.IssueDate = oldLicense.IssueDate;
            newLicense.ExpiryDate = oldLicense.ExpiryDate;
            newLicense.IsActive = true;
            newLicense.LicenseNumber = Guid.NewGuid().ToString();
            newLicense.LicenseNote = null;
            newLicense.PaidFee = licenseClass.ClassFees;

            if (!newLicense.Save())
            {
                MessageBox.Show("The license failed to be replaced", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Delete(replacementApplication.ID);
                return;
            }

            oldLicense.IsActive = false;
            if (!oldLicense.Save())
            {
                License.Delete(newLicense.ID);
                Application.Delete(replacementApplication.ID);
                return;
            }

            MessageBox.Show($"The new license created with id {newLicense.ID}", "Successful", MessageBoxButtons.OK);
            ctrlReplacementLicenseApplicationBasicInfo1.FillApplicationInfo(newLicense, oldLicense, replacementApplication);
            llblShowLicenseInfo.Enabled = true;
            btnIssue.Enabled = false;

        }
    }
}
