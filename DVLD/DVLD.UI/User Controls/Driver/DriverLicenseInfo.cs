using DVLD.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseInfoDetailedAttr = DVLD.BLL.Entities.License.LicenseInfoDetailedAttr;

namespace DVLD.UI.User_Controls.Driver
{
    public partial class DriverLicenseInfo : UserControl
    {
        public bool isFound { get; private set; } = false;
        public DataRow? _driverLicenseInfoDetailed { get; private set; }
        public DriverLicenseInfo()
        {
            InitializeComponent();
        }
        public DriverLicenseInfo(int licenseID) : this()
        {
            LoadDriverLicenseInfo(licenseID);
        }
        private string? GetLicenseInfo(License.LicenseInfoDetailedAttr attr)
        {
            if (_driverLicenseInfoDetailed[attr.ToString()] is DateTime)
                return ((DateTime)_driverLicenseInfoDetailed[attr.ToString()]).ToShortDateString();

            return _driverLicenseInfoDetailed[attr.ToString()].ToString();
        }
        public void LoadDriverLicenseInfo(int licenseID)
        {
            _driverLicenseInfoDetailed = License.GetLicenseInfoDetailed(licenseID);

            if (_driverLicenseInfoDetailed is null)
            {
                isFound = false;
                MessageBox.Show("The license is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string? PersonImagePath = GetLicenseInfo(LicenseInfoDetailedAttr.PersonalPhotoPath);

            lblClassValue.Text = GetLicenseInfo(LicenseInfoDetailedAttr.ClassName);
            lblNameValue.Text = GetLicenseInfo(LicenseInfoDetailedAttr.Fullname);
            lblLicenseIDValue.Text = GetLicenseInfo(LicenseInfoDetailedAttr.LicenseID);
            lblNationalNumberValue.Text = GetLicenseInfo(LicenseInfoDetailedAttr.NationalNumber);
            lblGenderValue.Text = GetLicenseInfo(LicenseInfoDetailedAttr.Gender);
            lblIssueDateValue.Text = GetLicenseInfo(LicenseInfoDetailedAttr.IssueDate);
            lblIssueReasonValue.Text = GetLicenseInfo(LicenseInfoDetailedAttr.IssueReason);

            if(!String.IsNullOrEmpty(GetLicenseInfo(LicenseInfoDetailedAttr.LicenseNote)))
                lblNotesValue.Text = GetLicenseInfo(LicenseInfoDetailedAttr.LicenseNote);

            lblIsActiveValue.Text = GetLicenseInfo(LicenseInfoDetailedAttr.IsActive);
            lblDateOfBirthValue.Text = GetLicenseInfo(LicenseInfoDetailedAttr.DateOfBirth);
            lblDriverIDValue.Text = GetLicenseInfo(LicenseInfoDetailedAttr.DriverID);
            lblExpirationDateValue.Text = GetLicenseInfo(LicenseInfoDetailedAttr.ExpiryDate);
            lblIsDetainedValue.Text = GetLicenseInfo(LicenseInfoDetailedAttr.IsDetained);

            if (!Convert.IsDBNull(PersonImagePath) && PersonImagePath is not null)
                pbPersonImage.ImageLocation = PersonImagePath;

            isFound = true;
        }
    }
}
