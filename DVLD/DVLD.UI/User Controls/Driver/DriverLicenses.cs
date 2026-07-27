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
using DriverEntity = DVLD.BLL.Entities.Driver;

namespace DVLD.UI.User_Controls.Driver
{
    public partial class DriverLicenses : UserControl
    {
        int driverID;
        public DriverLicenses()
        {
            InitializeComponent();
            LoadInternationalLicenseData();
        }
        public DriverLicenses(int driverID) : this()
        {
            this.driverID = driverID;
            LoadInternationalLicenseData();
            LoadLocalLicenseData();
        }
        private void LoadLocalLicenseData()
        {
            dgvLocalLicenses.DataSource = DriverEntity.GetDriverLocalLicenses(driverID);
            lblNumberOfRecordsValue.Text = dgvLocalLicenses.Rows.Count.ToString();
        }
        private void LoadInternationalLicenseData()
        {
            dgvInternationalLicenses.DataSource = DriverEntity.GetDriverInternationalLicenses(driverID);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                lblNumberOfRecordsValue.Text = dgvLocalLicenses.Rows.Count.ToString();
            else
                lblNumberOfRecordsValue.Text = dgvInternationalLicenses.Rows.Count.ToString();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID;
            // Local licenses
            if (tabControl1.SelectedIndex == 0)
            {
                if (dgvLocalLicenses.CurrentRow is null)
                {
                    MessageBox.Show("Please select a license!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ID = (int)dgvLocalLicenses.CurrentRow.Cells["ID"].Value;

                LicenseInfo licenseInfo = new LicenseInfo(ID);
                licenseInfo.ShowDialog();
                return;
            }

            // International Licenses
            if (dgvInternationalLicenses.CurrentRow is null)
            {
                MessageBox.Show("Please select a license!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ID = (int)dgvInternationalLicenses.CurrentRow.Cells["ID"].Value;

            InternationalLicenseInfo internationalLicenseInfo = new InternationalLicenseInfo(ID);
            internationalLicenseInfo.ShowDialog();
            
        }
    }
}
