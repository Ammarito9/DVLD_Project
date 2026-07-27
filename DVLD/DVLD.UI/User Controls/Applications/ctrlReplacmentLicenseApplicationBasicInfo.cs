using DVLD.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = DVLD.BLL.Entities.Application;

namespace DVLD.UI.User_Controls.Applications
{
    public partial class ctrlReplacementLicenseApplicationBasicInfo : UserControl
    {
        public ctrlReplacementLicenseApplicationBasicInfo()
        {
            InitializeComponent();
        }
        public void FillApplicationInfo(in License replacementLicense, in License oldLicense, in Application application)
        {
            lblApplicationIDValue.Text = replacementLicense.ApplicationId.ToString();
            lblReplacedLicenseIDValue.Text = replacementLicense.ID.ToString();
            lblOldLicenseIDValue.Text = oldLicense.ID.ToString();
        }
        public void InitializeInitialApplicationInfo()
        {
            lblApplicationDateValue.Text = DateTime.Now.ToShortDateString();
            lbl_CreatedByValue.Text = CurrentUser.LoggedInUser.ID.ToString();
        }
        public void SetFees(in Service service)
        {
            lbl_FeeValue.Text = service.ServiceFee.ToString();
        }
    }
}
