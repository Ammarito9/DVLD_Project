using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.BLL.Entities;
using DVLD.UI.Driving_license_services;
using Application = DVLD.BLL.Entities.Application;
using DVLD.UI.Common_Forms;

namespace DVLD.UI.Manage_Applications.International_License_Applications
{
    public partial class InternationalDrivingLicenseApplications : Form
    {
        InternationalLicense.Filter filter;
        public InternationalDrivingLicenseApplications()
        {
            InitializeComponent();

            ResetDataGridView();
        }
        private void FillApplicationsToDataView(DataTable applications)
        {
            dgv_Applications.DataSource = applications;
            lbl_NumberOfRecords.Text = applications.Rows.Count.ToString();

            if (dgv_Applications.Rows.Count > 0)
                dgv_Applications.Columns["CreatedByUserID"].Visible = false;
        }
        private void ResetDataGridView()
        {
            FillApplicationsToDataView(InternationalLicense.GetAll());
            cb_WhatToFilterBy.SelectedIndex = 0;
            txt_FilterValue.Text = string.Empty;
            txt_FilterValue.Visible = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            NewInternationalLicense newInternationalLicense = new NewInternationalLicense();
            newInternationalLicense.ShowDialog();
            ResetDataGridView();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Applications.CurrentRow == null)
            {
                MessageBox.Show("Application is not found!", "Error");
                return;
            }

            int personID, applicationID;

            applicationID = (int)dgv_Applications.CurrentRow.Cells["ApplicationID"].Value;
            personID = Application.Find(applicationID).PersonID;

            PersonDetails personDetails = new PersonDetails(personID);
            personDetails.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Applications.CurrentRow == null)
            {
                MessageBox.Show("Application is not found!", "Error");
                return;
            }

            int internationalLicenseID = (int)dgv_Applications.CurrentRow.Cells["ID"].Value;
            InternationalLicenseInfo internationalLicenseInfo = new InternationalLicenseInfo(internationalLicenseID);
            internationalLicenseInfo.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Applications.CurrentRow == null)
            {
                MessageBox.Show("Application is not found!", "Error");
                return;
            }

            int driverID, personID, applicationID;

            applicationID = (int)dgv_Applications.CurrentRow.Cells["ApplicationID"].Value;

            personID = Application.Find(applicationID).PersonID;
            driverID = Driver.FindByPersonID(personID).ID;

            LicenseHistory licenseHistory = new LicenseHistory(driverID, personID);
            licenseHistory.ShowDialog();
        }

        private void cb_WhatToFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = (InternationalLicense.Filter)cb_WhatToFilterBy.SelectedIndex;

            if (filter == (int)InternationalLicense.Filter.NONE)
                ResetDataGridView();
            else
                txt_FilterValue.Visible = true;
        }

        private void txt_FilterValue_TextChanged(object sender, EventArgs e)
        {
            if (txt_FilterValue.Text == string.Empty || txt_FilterValue.Text is null) 
                FillApplicationsToDataView(InternationalLicense.GetAll());

            FillApplicationsToDataView(InternationalLicense.GetFiltered(filter, txt_FilterValue.Text));
        }
    }
}
