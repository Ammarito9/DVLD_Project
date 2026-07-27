using DVLD.BLL.Entities;
using DVLD.UI.Application_Types;
using DVLD.UI.Common_Forms.UserForms;
using DVLD.UI.Driving_license_services.New_driving_license;
using DVLD.UI.Manage_Applications;
using DVLD.UI.Test_types;
using DVLD.UI.Driving_license_services;
using DVLD.UI.Driving_license_services.Renew_driving_license;
using DVLD.UI.Manage_Applications.International_License_Applications;
using DVLD.UI.Driving_license_services.Replacement_for_Lost_or_Damaged_License;
using DVLD.UI.Detain_Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Main_Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePeople mp = new ManagePeople();
            mp.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();


            LoginScreen loginScreen = new LoginScreen();
            loginScreen.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInformation userInformation = new UserInformation(CurrentUser.LoggedInUser.ID);
            userInformation.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(CurrentUser.LoggedInUser.ID);
            changePassword.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.ShowDialog();
        }

        private void manToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageApplicationTypes manageApplicationTypes = new ManageApplicationTypes();
            manageApplicationTypes.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypes manageTestTypes = new ManageTestTypes();
            manageTestTypes.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocalLicense newLocalLicense = new NewLocalLicense();
            newLocalLicense.ShowDialog();
        }

        private void localLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplicationsForm localDrivingLicenseApplicationsForm = new LocalDrivingLicenseApplicationsForm();
            localDrivingLicenseApplicationsForm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDrivers manageDrivers = new();
            manageDrivers.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInternationalLicense internationalLicense = new NewInternationalLicense();
            internationalLicense.ShowDialog();
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternationalDrivingLicenseApplications internationalDrivingLicenseApplications = new InternationalDrivingLicenseApplications();
            internationalDrivingLicenseApplications.ShowDialog();
        }

        private void renewDrivingLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewDrivingLicense renewDrivingLicense = new RenewDrivingLicense();
            renewDrivingLicense.ShowDialog();
        }

        private void replacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplacementForLostOrDamagedLicense replacementForLostOrDamagedLicense = new ReplacementForLostOrDamagedLicense();
            replacementForLostOrDamagedLicense.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DetainLicense detainLicense = new DetainLicense();
            detainLicense.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseLicense releaseLicense = new ReleaseLicense();
            releaseLicense.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDetainedLicenses manageDetainedLicenses = new ManageDetainedLicenses();
            manageDetainedLicenses.ShowDialog();
        }
    }
}
