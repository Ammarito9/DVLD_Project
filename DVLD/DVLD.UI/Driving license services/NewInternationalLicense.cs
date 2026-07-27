using DVLD.BLL.Entities;
using DVLD.UI.Manage_Applications;
using DVLD.UI.Manage_Applications.International_License_Applications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = DVLD.BLL.Entities.Application;
using Attr = DVLD.BLL.Entities.License.LicenseInfoDetailedAttr;

namespace DVLD.UI.Driving_license_services
{
    public partial class NewInternationalLicense : Form
    {
        InternationalLicense internationalLicense;
        Application internationalLicenseApplication;
        int personID;
        public NewInternationalLicense()
        {
            InitializeComponent();
            applicationBasicInfo.InitializeInitialApplicationInfo();
        }

        private void findDriverByLicenseId_OnLicenseSelected(int obj)
        {
            personID = Person.Find((string)findDriverByLicenseId.driverLicenseInfoDetailed[Attr.NationalNumber.ToString()]).ID;
            if (InternationalLicense.DoesPersonHasInternationalLicense(personID))
            {
                MessageBox.Show("The person already has an international license!", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                internationalLicense = InternationalLicense.FindByPersonID(personID);
                btnIssue.Enabled = false;
                llblShowLicenseHistory.Enabled = true;
                llblShowLicenseInfo.Enabled = true;
                return;
            }

            int licenseClass = (int)findDriverByLicenseId.driverLicenseInfoDetailed[Attr.ClassID.ToString()];
            if (licenseClass < 3)
            {
                MessageBox.Show("The license is from class below 3! Minimum class 3.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }

            DateTime ExpiryDate = ((DateTime)findDriverByLicenseId.driverLicenseInfoDetailed[Attr.ExpiryDate.ToString()]);
            if (ExpiryDate < DateTime.Now)
            {
                MessageBox.Show("The license expired!", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }

            bool isActive = (bool)findDriverByLicenseId.driverLicenseInfoDetailed[Attr.IsActive.ToString()];
            if (!isActive)
            {
                MessageBox.Show("The license is not active!", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }

            if (obj != 0)
            {
                llblShowLicenseHistory.Enabled = true;
                btnIssue.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            internationalLicenseApplication = new Application();

            internationalLicenseApplication.PersonID = personID;
            internationalLicenseApplication.ServiceID = ((int)Service.Services.INTERNATIONAL_DRIVING_LICENSE_ISSUANCE);
            internationalLicenseApplication.ApplicationStatusID = ((int)ApplicationStatus.ApplicationStatuses.Completed);
            internationalLicenseApplication.CreatedByUserID = CurrentUser.LoggedInUser.ID;
            internationalLicenseApplication.ApplicationDate = DateTime.Now;
            internationalLicenseApplication.LastStatusDate = DateTime.Now;
            internationalLicenseApplication.ApplicationPaidFee = Service.Find((int)Service.Services.INTERNATIONAL_DRIVING_LICENSE_ISSUANCE).ServiceFee;

            if (!internationalLicenseApplication.Save())
            {
                MessageBox.Show("The application is not created!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            internationalLicense = new InternationalLicense();

            internationalLicense.DriverID = (int)findDriverByLicenseId.driverLicenseInfoDetailed[Attr.DriverID.ToString()];
            internationalLicense.ApplicationID = internationalLicenseApplication.ID;
            internationalLicense.IssuedUsingLocalLicenseID = (int)findDriverByLicenseId.driverLicenseInfoDetailed[Attr.LicenseID.ToString()];
            internationalLicense.CreatedByUserID = CurrentUser.LoggedInUser.ID;
            internationalLicense.IssueDate = DateTime.Now;
            internationalLicense.ExpiryDate = DateTime.Now.AddYears(1);
            internationalLicense.IsActive = true;

            if (internationalLicense.Save())
            {
                MessageBox.Show($"The license Issued successfully! ID = {internationalLicense.ID}", "Issued", MessageBoxButtons.OK);
                llblShowLicenseInfo.Enabled = true;
                btnIssue.Enabled = false;
                applicationBasicInfo.FillApplicationInfo(internationalLicense.ID);
                return;
            }
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistory licenseHistory = new LicenseHistory(internationalLicense.DriverID, personID);
            licenseHistory.ShowDialog();
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InternationalLicenseInfo internationalLicenseInfo = new InternationalLicenseInfo(internationalLicense.ID);
            internationalLicenseInfo.ShowDialog();
        }
    }
}
