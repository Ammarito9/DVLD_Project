using DVLD.BLL.Entities;
using DVLD.UI.Detain_Licenses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.User_Controls
{
    public partial class ctrlDetainInfo : UserControl
    {
        public decimal fineFee { get; private set; }
        public ctrlDetainInfo()
        {
            InitializeComponent();
        }
        public void FillDetainInfo(in LicenseDetention licenseDetention)
        {
            lblDetainIDValue.Text = licenseDetention.ID.ToString();
            lblDetainDateValue.Text = licenseDetention.DateOfDetain.ToShortDateString();
        }
        public void FillBasicInfo(in License detainedLicense)
        {
            lblLicenseIDValue.Text = detainedLicense.ID.ToString();
            lbl_CreatedByValue.Text = CurrentUser.LoggedInUser.ID.ToString();
        }
        private void txtFineFee_Leave(object sender, EventArgs e)
        {
            if(Decimal.TryParse(txtFineFee.Text, out decimal fee))
                fineFee = fee;
        }
    }
}
