using DVLD.BLL.Entities;
using DVLD.UI.Common_Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Driving_license_services.New_driving_license
{
    public partial class NewLocalLicense : Form
    {
        private Service NewLocalLicenseService = Service.Find(((int)Service.Services.FIRST_TIME_DRIVING_LICENSE_ISSUANCE));
        private LicenseClass LicenseClass = new LicenseClass();
        public NewLocalLicense()
        {
            InitializeComponent();
            cb_LicenceClasses.DataSource = LicenseClass.GetAllClassNames();
            cb_LicenceClasses.SelectedIndex = 0;
            cb_FilterBy.SelectedIndex = 0;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_FilterByValue.Text))
            {
                MessageBox.Show("The search box can't be empty!");
                return;
            }

            // Filter by National number
            if (cb_FilterBy.SelectedIndex == 0)
            {
                ucPersonDetails1.LoadPersonDetails(txt_FilterByValue.Text);

                return;
            }
            // Filter by Person Id
            else if (cb_FilterBy.SelectedIndex == 1)
            {
                ucPersonDetails1.LoadPersonDetails(Convert.ToInt16(txt_FilterByValue.Text));
                return;
            }
            else
            {
                MessageBox.Show("Please choose how to filter!");
                return;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            addPerson.ShowDialog();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            LicenseClass = LicenseClass.Find(cb_LicenceClasses.SelectedIndex + 1);
            if (LocalDrivingLicenseApplication.CheckIfPersonHasLicenseForLicenseClass(ucPersonDetails1.person.ID, LicenseClass.ID))
            {
                MessageBox.Show("The person already have an license for the applied class!", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LicenseClass.MinimumAllowedAge > ucPersonDetails1.person.GetAge())
            {
                MessageBox.Show("The person Age is less then the minimum allowed age for the license class!");
                return;
            }
            if (LocalDrivingLicenseApplication.CheckIfPersonHasApplicationForLicenseClassExist(ucPersonDetails1.person.ID, LicenseClass.ID))
            {
                MessageBox.Show("The person already has active application or active license for this license class!");
                return;
            }
            var application = new DVLD.BLL.Entities.Application();

            application.PersonID = ucPersonDetails1.person.ID;
            application.ServiceID = NewLocalLicenseService.ID;
            application.ApplicationStatusID = ((int)ApplicationStatus.ApplicationStatuses.New);
            application.CreatedByUserID = CurrentUser.LoggedInUser.ID;
            DateTime.TryParse(lbl_ApplicationDateValue.Text, out DateTime result);
            application.ApplicationDate = result;
            application.LastStatusDate = DateTime.Today;
            application.ApplicationPaidFee = NewLocalLicenseService.ServiceFee;

            if (!application.Save())
            {
                MessageBox.Show("Error! application is not created.");
                return;
            }
            
            var localDrivingLicenseApplication = new LocalDrivingLicenseApplication();
            localDrivingLicenseApplication.ApplicationID = application.ID;
            localDrivingLicenseApplication.LicenseClassID = LicenseClass.ID;

            if (!localDrivingLicenseApplication.Add())
            {
                MessageBox.Show("Error! application is not created.");
                DVLD.BLL.Entities.Application.Delete(application.ID);
                return;
            }

            lbl_ApplicationIdValue.Text = application.ID.ToString();
            btn_Save.Visible = false;
            MessageBox.Show("application created successfully!");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_FilterByValue.Text))
            {
                MessageBox.Show("The search box can't be empty!");
                return;
            }

            if (ucPersonDetails1.person.ID == 0 || ucPersonDetails1.person is null)
            {
                MessageBox.Show("There is no person to connect with!");
                return;
            }

            lbl_ApplicationDateValue.Text = DateTime.Now.ToShortDateString();
            lbl_ApplicationFeeValue.Text = NewLocalLicenseService.ServiceFee.ToString();
            lbl_CreatedByValue.Text = CurrentUser.LoggedInUser.UserName;

            tabControl1.SelectedIndex = 1;
            btn_Save.Enabled = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                btn_Save.Enabled = false;
        }
    }
}
