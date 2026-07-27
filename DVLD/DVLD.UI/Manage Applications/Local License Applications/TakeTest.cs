using DVLD.BLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Manage_Applications
{
    public partial class TakeTest : Form
    {
        int NumberOfTestTrials;
        Test.TestType _testType;
        DataRow _localDrivingLicenseApplication;
        TestType testTypeObj;
        TestAppointment appointment;
        public TakeTest()
        {
            InitializeComponent();
        }
        public TakeTest(int AppointmentID, int localDrivingLicenseApplicationID, Test.TestType testType) : this()
        {
            _testType = testType;
            testTypeObj = TestType.Find((int)testType);
            appointment = TestAppointment.Find(AppointmentID);
            _localDrivingLicenseApplication = LocalDrivingLicenseApplication.GetByIDDetailed(localDrivingLicenseApplicationID).Rows[0];
            NumberOfTestTrials = TestAppointment.GetNumberOfTestTrials(localDrivingLicenseApplicationID, testType);

            FillControllersWithData();
        }
        private void FillControllersWithData()
        {

            gb_TestTypeTitle.Text = $"{_testType} Test";
            lbl_ApplicationIDValue.Text = _localDrivingLicenseApplication[LocalDrivingLicenseApplication.GetByIDDetailedDataTableAttribute.ID.ToString()].ToString();
            lbl_LicenseClassValue.Text = _localDrivingLicenseApplication[LocalDrivingLicenseApplication.GetByIDDetailedDataTableAttribute.ClassName.ToString()].ToString();
            lbl_FullNameValue.Text = _localDrivingLicenseApplication[LocalDrivingLicenseApplication.GetByIDDetailedDataTableAttribute.Fullname.ToString()].ToString();
            lbl_FeeValue.Text = testTypeObj.TestFee.ToString();
            lbl_TrialsValue.Text = NumberOfTestTrials.ToString();
            lbl_DateValue.Text = appointment.ScheduledDate.ToShortDateString();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Test test = new Test();

            test.TestAppointmentID = appointment.ID;
            if (rb_Fail.Checked)
                test.TestResultCharacter = 'F';
            else
                test.TestResultCharacter = 'P';
            test.CreatedByUserID = CurrentUser.LoggedInUser.ID;
            test.Note = txt_Notes.Text;

            if (!test.Save())
            {
                MessageBox.Show("Test is not stored!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Test is stored successfully", "Complited", MessageBoxButtons.OK);
            lbl_TestIDValue.Text = test.ID.ToString();

            appointment.IsLocked = true;
            appointment.Save();

            btn_Save.Enabled = false;
        }
    }
}
