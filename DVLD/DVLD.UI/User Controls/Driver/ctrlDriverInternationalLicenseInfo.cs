using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD.BLL.Entities.License;
using DVLD.BLL.DTO;
using DVLD.BLL.Entities;

namespace DVLD.UI.User_Controls
{
    public partial class ctrlDriverInternationalLicenseInfo : UserControl
    {
        public bool isFound { get; private set; } = false;
        public DriverInternationalLicenseInfoDTO? driverInternationalLicenseInfoDTO { get; private set; } = null;
        public ctrlDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }
        public ctrlDriverInternationalLicenseInfo(int internationalLicenseID) : this()
        {
            LoadDriverLicenseInfo(internationalLicenseID);
        }

        public void LoadDriverLicenseInfo(int internationalLicenseID)
        {
            driverInternationalLicenseInfoDTO = InternationalLicense.GetDriverInternationalLicenseInfo(internationalLicenseID);

            if (driverInternationalLicenseInfoDTO is null)
            {
                isFound = false;
                MessageBox.Show("The license is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblInternationalLicenseIDValue.Text = driverInternationalLicenseInfoDTO.internationalLicenseID.ToString();
            lblNameValue.Text = driverInternationalLicenseInfoDTO.fullName;
            lblLicenseIDValue.Text = driverInternationalLicenseInfoDTO.localLicenseID.ToString();
            lblNationalNumberValue.Text = driverInternationalLicenseInfoDTO.nationalNumber;
            lblGenderValue.Text = driverInternationalLicenseInfoDTO.gender;
            lblIssueDateValue.Text = driverInternationalLicenseInfoDTO.issueDate.ToShortDateString();
            lblIsActiveValue.Text = driverInternationalLicenseInfoDTO.isActive.ToString();
            lblDateOfBirthValue.Text = driverInternationalLicenseInfoDTO.dateOfBirth.ToShortDateString();
            lblDriverIDValue.Text = driverInternationalLicenseInfoDTO.driverID.ToString();
            lblExpirationDateValue.Text = driverInternationalLicenseInfoDTO.expirationDate.ToShortDateString();
            lblApplicationIDValue.Text = driverInternationalLicenseInfoDTO.applicationID.ToString();

            if (!Convert.IsDBNull(driverInternationalLicenseInfoDTO.PersonalImagePath) && driverInternationalLicenseInfoDTO.PersonalImagePath is not null)
                pbPersonImage.ImageLocation = driverInternationalLicenseInfoDTO.PersonalImagePath;

            isFound = true;
        }

    }
}
