using DVLD.BLL.Entities;
using DVLD.UI.Manage_Applications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.UI.Common_Forms;
using License = DVLD.BLL.Entities.License;

namespace DVLD.UI.Detain_Licenses
{
    public partial class ManageDetainedLicenses : Form
    {
        LicenseDetention.Filter filter;
        public ManageDetainedLicenses()
        {
            InitializeComponent();
            cbWhatToFilterBy.SelectedIndex = 0;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            DetainLicense detainLicense = new DetainLicense();
            detainLicense.ShowDialog();

            LoadDetainRecordsToView(LicenseDetention.GetDetailed(filter));
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            ReleaseLicense releaseLicense = new ReleaseLicense();
            releaseLicense.ShowDialog();

            LoadDetainRecordsToView(LicenseDetention.GetDetailed(filter));
        }
        private void LoadDetainRecordsToView(DataTable source)
        {
            dgvDetainedLicenses.DataSource = source;
            lblNumberOfRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();
        }
        private void cbWhatToFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbWhatToFilterBy.SelectedIndex)
            {
                case 1:
                    filter = LicenseDetention.Filter.DETAIN_ID;
                    break;
                case 2:
                    filter = LicenseDetention.Filter.IS_RELEASED;
                    break;
                case 3:
                    filter = LicenseDetention.Filter.NATIONAL_NUMBER;
                    break;
                case 4:
                    filter = LicenseDetention.Filter.FULL_NAME;
                    break;
                case 5:
                    filter = LicenseDetention.Filter.RELEASE_APPLICATION_ID;
                    break;
                default:
                    filter = LicenseDetention.Filter.NONE;
                    LoadDetainRecordsToView(LicenseDetention.GetDetailed(filter));
                    break;
            }

            if (filter == LicenseDetention.Filter.NONE)
                txtFilterBy.Visible = false;
            else
                txtFilterBy.Visible = true;
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            LoadDetainRecordsToView(LicenseDetention.GetDetailed(filter, txtFilterBy.Text));
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null)
            {
                MessageBox.Show("Please select a row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string nationalNumber = dgvDetainedLicenses.CurrentRow.Cells["NationalNumber"].Value
                .ToString();

            PersonDetails personDetails = new PersonDetails(Person.Find(nationalNumber).ID);
            personDetails.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null)
            {
                MessageBox.Show("Please select a row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int licenseID = LicenseDetention.Find((int)dgvDetainedLicenses.CurrentRow.Cells["DetainID"].Value).LicenseID;

            LicenseInfo licenseInfo = new LicenseInfo(licenseID);
            licenseInfo.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null)
            {
                MessageBox.Show("Please select a row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int licenseID = LicenseDetention.Find((int)dgvDetainedLicenses.CurrentRow.Cells["DetainID"].Value).LicenseID;

            License license = License.Find(licenseID);

            LicenseHistory licenseHistory = new LicenseHistory(license.DriverId, Driver.Find(license.DriverId).PersonID);
            licenseHistory.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null)
            {
                MessageBox.Show("Please select a row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int licenseID = LicenseDetention.Find((int)dgvDetainedLicenses.CurrentRow.Cells["DetainID"].Value).LicenseID;

            ReleaseLicense releaseLicense = new ReleaseLicense(licenseID);
            releaseLicense.ShowDialog();

            LoadDetainRecordsToView(LicenseDetention.GetDetailed(filter));
        }

        private void cmsDetainedLicenseOperation_Opening(object sender, CancelEventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null)
            {
                MessageBox.Show("Please select a row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isReleased = Convert.ToBoolean(dgvDetainedLicenses.CurrentRow.Cells["IsReleased"].Value);

            if (isReleased)
                releaseDetainedLicenseToolStripMenuItem.Enabled = false;
            else
                releaseDetainedLicenseToolStripMenuItem.Enabled = true;
        }
    }
}
