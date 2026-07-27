using DVLD.BLL.Entities;
using DVLD.UI.Driving_license_services.New_driving_license;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD.BLL.Entities.Person;

namespace DVLD.UI.Manage_Applications
{
    public partial class LocalDrivingLicenseApplicationsForm : Form
    {
        public LocalDrivingLicenseApplicationsForm()
        {
            InitializeComponent();
            UpdateFilterControls();

            cb_StatusFilterValue.DataSource = Enum.GetNames(typeof(LocalDrivingLicenseApplication.StatusFilter));

            cb_WhatToFilterBy.SelectedIndex = 0;
            cb_StatusFilterValue.SelectedIndex = 0;

            FillApplicationsToDataView(LocalDrivingLicenseApplication.GetAll());
        }
        private void FillApplicationsToDataView(DataTable applications)
        {
            dgv_Applications.DataSource = applications;
            lbl_NumberOfRecords.Text = applications.Rows.Count.ToString();
        }
        private void ResetDataGridView()
        {
            FillApplicationsToDataView(LocalDrivingLicenseApplication.GetAll());
            cb_WhatToFilterBy.SelectedIndex = 0;
            cb_StatusFilterValue.SelectedIndex = 0;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            NewLocalLicense newLocalLicense = new NewLocalLicense();
            newLocalLicense.ShowDialog();
            ResetDataGridView();
        }
        public void UpdateFilterControls()
        {
            cb_StatusFilterValue.Visible = false;
            txt_FilterValue.Visible = false;

            if (cb_WhatToFilterBy.SelectedIndex == ((int)LocalDrivingLicenseApplication.Filters.Status))
            {
                cb_StatusFilterValue.Visible = true;
            }
            else if (!(cb_WhatToFilterBy.SelectedIndex == ((int)LocalDrivingLicenseApplication.Filters.None)))
            {
                txt_FilterValue.Visible = true;
            }
        }
        private void cb_WhatToFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_WhatToFilterBy.SelectedIndex == ((int)LocalDrivingLicenseApplication.Filters.None))
            {
                ResetDataGridView();
            }
            UpdateFilterControls();
        }
        private void cb_StatusFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_StatusFilterValue.SelectedIndex == ((int)LocalDrivingLicenseApplication.StatusFilter.None))
            {
                FillApplicationsToDataView(LocalDrivingLicenseApplication.GetAll());
                return;
            }
            FillApplicationsToDataView(LocalDrivingLicenseApplication.GetAllFilterByStatus((LocalDrivingLicenseApplication.StatusFilter)cb_StatusFilterValue.SelectedIndex));
        }

        private void txt_FilterValue_TextChanged(object sender, EventArgs e)
        {
            if (txt_FilterValue.Text == string.Empty || txt_FilterValue.Text is null) FillApplicationsToDataView(LocalDrivingLicenseApplication.GetAll());

            FillApplicationsToDataView(LocalDrivingLicenseApplication.GetAllFilterBy((LocalDrivingLicenseApplication.Filters)cb_WhatToFilterBy.SelectedIndex, txt_FilterValue.Text));
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Applications.CurrentRow is null)
            {
                MessageBox.Show("Please select an application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int applicationId = Convert.ToInt32(dgv_Applications.CurrentRow.Cells["ID"].Value);

            if (MessageBox.Show("Are you sure you want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (LocalDrivingLicenseApplication.CancelApplication(applicationId))
                {
                    MessageBox.Show("Application has canceled successfully!", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    return;

                ResetDataGridView();
            }
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Applications.CurrentRow is null)
            {
                MessageBox.Show("Please select an application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int applicationId = Convert.ToInt32(dgv_Applications.CurrentRow.Cells["ID"].Value);

            if (MessageBox.Show("Are you sure you want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (LocalDrivingLicenseApplication.Delete(applicationId))
                {
                    MessageBox.Show("Application has deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    return;

                ResetDataGridView();
            }
        }
        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Applications.CurrentRow == null)
            {
                MessageBox.Show("Application is not found!", "Error");
                return;
            }

            int applicationID = Convert.ToInt32(dgv_Applications.CurrentRow.Cells["ID"].Value);
            TestAppointmentForm visionTestAppointment = new TestAppointmentForm(Test.TestType.Visual, applicationID);
            visionTestAppointment.ShowDialog();
        }
        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Applications.CurrentRow == null)
            {
                MessageBox.Show("Application is not found!", "Error");
                return;
            }

            int applicationID = Convert.ToInt32(dgv_Applications.CurrentRow.Cells["ID"].Value);
            TestAppointmentForm writtenTestAppointment = new TestAppointmentForm(Test.TestType.Written, applicationID);
            writtenTestAppointment.ShowDialog();
        }
        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Applications.CurrentRow == null)
            {
                MessageBox.Show("Application is not found!", "Error");
                return;
            }

            int applicationID = Convert.ToInt32(dgv_Applications.CurrentRow.Cells["ID"].Value);
            TestAppointmentForm streetTestAppointment = new TestAppointmentForm(Test.TestType.Street, applicationID);
            streetTestAppointment.ShowDialog();
        }
        private void cms_localLicenseApplications_Opening(object sender, CancelEventArgs e)
        {
            if (dgv_Applications.CurrentRow == null)
            {
                MessageBox.Show("Please select an application!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            int passedTests = Convert.ToInt32(dgv_Applications.CurrentRow.Cells["PassedTests"].Value);

            if (dgv_Applications.CurrentRow.Cells["StatusName"].Value.ToString() == ApplicationStatus.ApplicationStatuses.New.ToString())
            {
                editApplicationToolStripMenuItem.Enabled = true;
                deleteApplicationToolStripMenuItem.Enabled = true;
                cancelApplicationToolStripMenuItem.Enabled = true;
                scheduleTestToolStripMenuItem.Enabled = true;
                issueDrivingLicenseFirsttimeToolStripMenuItem.Enabled = false;
                showLicneseToolStripMenuItem.Enabled = false;

                switch (passedTests)
                {
                    case 0:
                        {
                            issueDrivingLicenseFirsttimeToolStripMenuItem.Enabled = false;
                            scheduleVisionTestToolStripMenuItem.Enabled = true;
                            scheduleWrittenTestToolStripMenuItem.Enabled = false;
                            scheduleStreetTestToolStripMenuItem.Enabled = false;
                            break;
                        }
                    case 1:
                        {
                            issueDrivingLicenseFirsttimeToolStripMenuItem.Enabled = false;
                            scheduleVisionTestToolStripMenuItem.Enabled = false;
                            scheduleWrittenTestToolStripMenuItem.Enabled = true;
                            scheduleStreetTestToolStripMenuItem.Enabled = false;
                            break;
                        }
                    case 2:
                        {
                            issueDrivingLicenseFirsttimeToolStripMenuItem.Enabled = false;
                            scheduleVisionTestToolStripMenuItem.Enabled = false;
                            scheduleWrittenTestToolStripMenuItem.Enabled = false;
                            scheduleStreetTestToolStripMenuItem.Enabled = true;
                            break;
                        }
                    case 3:
                        {
                            scheduleTestToolStripMenuItem.Enabled = false;
                            issueDrivingLicenseFirsttimeToolStripMenuItem.Enabled = true;
                            scheduleVisionTestToolStripMenuItem.Enabled = false;
                            scheduleWrittenTestToolStripMenuItem.Enabled = false;
                            scheduleStreetTestToolStripMenuItem.Enabled = false;
                            break;
                        }
                    default:
                        {
                            issueDrivingLicenseFirsttimeToolStripMenuItem.Enabled = false;
                            scheduleVisionTestToolStripMenuItem.Enabled = false;
                            scheduleWrittenTestToolStripMenuItem.Enabled = false;
                            scheduleStreetTestToolStripMenuItem.Enabled = false;
                            break;
                        }
                }

            }

            if (dgv_Applications.CurrentRow.Cells["StatusName"].Value.ToString() == ApplicationStatus.ApplicationStatuses.Canceled.ToString())
            {
                editApplicationToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = true;
                cancelApplicationToolStripMenuItem.Enabled = false;
                scheduleTestToolStripMenuItem.Enabled = false;
                issueDrivingLicenseFirsttimeToolStripMenuItem.Enabled = false;
                showLicneseToolStripMenuItem.Enabled = false;
            }

            if (dgv_Applications.CurrentRow.Cells["StatusName"].Value.ToString() == ApplicationStatus.ApplicationStatuses.Completed.ToString())
            {
                editApplicationToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;
                scheduleTestToolStripMenuItem.Enabled = false;
                issueDrivingLicenseFirsttimeToolStripMenuItem.Enabled = false;
                showLicneseToolStripMenuItem.Enabled = true;
            }
        }

        private void issueDrivingLicenseFirsttimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Applications.CurrentRow == null)
            {
                MessageBox.Show("Application is not found!", "Error");
                return;
            }

            int localDrivingLicenseApplicationID = Convert.ToInt32(dgv_Applications.CurrentRow.Cells["ID"].Value);
            IssueDriverLicenseFirstTime issueDriverLicenseFirstTime = new IssueDriverLicenseFirstTime(localDrivingLicenseApplicationID);
            issueDriverLicenseFirstTime.ShowDialog();

            ResetDataGridView();
        }

        private void showLicneseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Applications.CurrentRow == null)
            {
                MessageBox.Show("Application is not found!", "Error");
                return;
            }

            string nationalNumber = dgv_Applications.CurrentRow.Cells["nationalNumber"].Value.ToString();
            int licenseClassID = LocalDrivingLicenseApplication.Find((int)dgv_Applications.CurrentRow.Cells["ID"].Value).LicenseClassID;

            int licenseID = DVLD.BLL.Entities.License.Find(nationalNumber, licenseClassID).ID;
            LicenseInfo licenseInfo = new LicenseInfo(licenseID);
            licenseInfo.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Applications.CurrentRow == null)
            {
                MessageBox.Show("Application is not found!", "Error");
                return;
            }

            int driverID, personID;

            string nationalNumber = dgv_Applications.CurrentRow.Cells["nationalNumber"].Value.ToString();

            personID = Person.Find(nationalNumber).ID;
            driverID = Driver.FindByPersonID(personID).ID;

            LicenseHistory licenseHistory = new LicenseHistory(driverID, personID);
            licenseHistory.ShowDialog();
        }
    }
}
