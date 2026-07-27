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
using Application = DVLD.BLL.Entities.Application;

namespace DVLD.UI.Common_Forms.UserForms
{
    public partial class uc_ApplicationBasicInfo : UserControl
    {
        int applicationID = 0;
        DataRow application;
        public Decimal Fee { get; private set; }
        
        public uc_ApplicationBasicInfo()
        {
            InitializeComponent();
        }
        public uc_ApplicationBasicInfo(int applicationID) : this()
        {
            this.applicationID = applicationID;
            application = Application.GetByIDDetailed(applicationID);
            FillApplicationBasicInfo();

            Fee = Decimal.Parse(application[Application.DetailedApplicationAttribute.ApplicationPaidFee.ToString()].ToString());
        }
        private void FillApplicationBasicInfo()
        {
            lbl_IDValue.Text = applicationID.ToString();
            lbl_StatusValue.Text = application[Application.DetailedApplicationAttribute.StatusName.ToString()].ToString();
            lbl_FeeValue.Text = Fee.ToString();
            lbl_TypeValue.Text = application[Application.DetailedApplicationAttribute.ServiceName.ToString()].ToString();
            lbl_ApplicantValue.Text = application[Application.DetailedApplicationAttribute.Fullname.ToString()].ToString();
            lbl_DateValue.Text = ((DateTime)application[Application.DetailedApplicationAttribute.ApplicationDate.ToString()]).ToShortDateString();
            lbl_StatusDateValue.Text = ((DateTime)application[Application.DetailedApplicationAttribute.LastStatusDate.ToString()]).ToShortDateString();
            lbl_CreatedByValue.Text = application[Application.DetailedApplicationAttribute.Username.ToString()].ToString();
        }

        private void llbl_ShowApplicantInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonDetails personDetails = new PersonDetails(((int)Application.DetailedApplicationAttribute.PersonID));
            personDetails.ShowDialog();
        }
    }
}
