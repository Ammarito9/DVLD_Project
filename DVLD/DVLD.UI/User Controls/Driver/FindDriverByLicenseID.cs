using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.BLL.Entities;

namespace DVLD.UI.User_Controls.Driver
{
    public partial class FindDriverByLicenseID : UserControl
    {
        public event Action<int> OnLicenseSelected;
        protected virtual void LicenseSelected(int licenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
                handler(licenseID);
        }
        public DataRow? driverLicenseInfoDetailed { get; private set; }

        public FindDriverByLicenseID()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseIDValue.Text))
            {
                MessageBox.Show("Please enter a license id to search for!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            driverLicenseInfo1.LoadDriverLicenseInfo(int.Parse(txtLicenseIDValue.Text));

            driverLicenseInfoDetailed = driverLicenseInfo1._driverLicenseInfoDetailed;

            if (OnLicenseSelected != null && driverLicenseInfoDetailed is not null)
                OnLicenseSelected((int)driverLicenseInfo1._driverLicenseInfoDetailed[DVLD.BLL.Entities.License.LicenseInfoDetailedAttr.LicenseID.ToString()]);
        }
        private void DisableSearch()
        {
            gbFilter.Enabled = false;
        }
        public void Search(int licenseID)
        {
            DisableSearch();
            txtLicenseIDValue.Text = licenseID.ToString();

            driverLicenseInfo1.LoadDriverLicenseInfo(licenseID);

            driverLicenseInfoDetailed = driverLicenseInfo1._driverLicenseInfoDetailed;

            if (OnLicenseSelected != null && driverLicenseInfoDetailed is not null)
                OnLicenseSelected((int)driverLicenseInfo1._driverLicenseInfoDetailed[DVLD.BLL.Entities.License.LicenseInfoDetailedAttr.LicenseID.ToString()]);
        }
    }
}
