using DVLD.BLL.Entities;
using DVLD.UI.Common_Forms.UserForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = DVLD.BLL.Entities.Application;
namespace DVLD.UI.Manage_Applications
{
    public partial class IssueDriverLicenseFirstTime : Form
    {
        int _localDrivingLicenseApplicationID, applicationID;
        DataRow localDrivingLicenseApplication;
        public IssueDriverLicenseFirstTime()
        {
            InitializeComponent();
        }
        public IssueDriverLicenseFirstTime(int localDrivingLicenseApplicationID) : this()
        {
            _localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            localDrivingLicenseApplication = LocalDrivingLicenseApplication.GetByIDDetailed(localDrivingLicenseApplicationID).Rows[0];

            InitializeUserControls();
        }
        private void InitializeUserControls()
        {
            applicationID = LocalDrivingLicenseApplication.Find(_localDrivingLicenseApplicationID).ApplicationID;

            uc_ApplicationBasicInfo1 = new Common_Forms.UserForms.uc_ApplicationBasicInfo(applicationID);

            uc_DrivingLicenseApplicationInfo1 = new Common_Forms.UserForms.uc_DrivingLicenseApplicationInfo(_localDrivingLicenseApplicationID);

            uc_DrivingLicenseApplicationInfo1.Location = new Point(12, 30);
            uc_ApplicationBasicInfo1.Location = new Point(12, 130);

            this.Controls.Add(uc_DrivingLicenseApplicationInfo1);
            this.Controls.Add(uc_ApplicationBasicInfo1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int personID = (int)localDrivingLicenseApplication[LocalDrivingLicenseApplication.GetByIDDetailedDataTableAttribute.PersonID.ToString()];
            Driver driver = Driver.FindByPersonID(personID);
            if (driver is null)
            {
                driver = new Driver();

                driver.PersonID = personID;
                driver.CreatedByUserID = CurrentUser.LoggedInUser.ID;
                driver.CreateDate = DateTime.Now;

                if (!driver.Save())
                    return;
            }

            License license = new License();
            license.DriverId = driver.ID;
            license.LicenseClassId = uc_DrivingLicenseApplicationInfo1.license.ID;
            license.LicenseTypeId = (int)License.LicenseType.NEW;
            license.CreatedByUserId = CurrentUser.LoggedInUser.ID;
            license.IssueDate = DateTime.Now;
            license.ExpiryDate = DateTime.Now.AddYears(uc_DrivingLicenseApplicationInfo1.license.ValidityLengthInYears);
            license.IsActive = true;
            license.LicenseNumber = Guid.NewGuid().ToString();
            license.LicenseNote = txtNotes.Text;
            license.ApplicationId = applicationID;
            license.PaidFee = uc_DrivingLicenseApplicationInfo1.license.ClassFees;

            if (!license.Save())
            {
                MessageBox.Show("Can't issue license! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("License issued successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application applicationCompleted = Application.Find(applicationID);

            btnIssue.Enabled = false;

            applicationCompleted.ApplicationStatusID = ((int)ApplicationStatus.ApplicationStatuses.Completed);
            applicationCompleted.Save();
            
        }
    }
}
