using DVLD.BLL.Entities;
using DVLD.DAL.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.UI.Manage_Applications
{
    public partial class ScheduleTest : Form
    {
        int _localDrivingLicenseApplicationID = 0, NumberOfTestTrials = 0, appointmentID = 0;
        bool update = false;
        Test.TestType testType;
        TestType testTypeObj;
        TestAppointment testAppointment;
        DataRow _localDrivingLicenseApplication;
        public ScheduleTest()
        {
            InitializeComponent();
        }
        public ScheduleTest(int localDriverLicenseApplicationID, Test.TestType testType) : this()
        {
            this.testType = testType;
            _localDrivingLicenseApplicationID = localDriverLicenseApplicationID;
            NumberOfTestTrials = TestAppointment.GetNumberOfTestTrials(_localDrivingLicenseApplicationID, testType);

            testTypeObj = TestType.Find((int)testType);

            _localDrivingLicenseApplication = LocalDrivingLicenseApplication.GetByIDDetailed(_localDrivingLicenseApplicationID).Rows[0];

            FillControllersWithData();
        }
        public ScheduleTest(int appointmentID) : this()
        {
            update = true;
            btn_Save.Enabled = false;

            this.appointmentID = appointmentID;
            testAppointment = TestAppointment.Find(appointmentID);
            _localDrivingLicenseApplicationID = testAppointment.LocalDrivingLicenseApplicationID;
            testType = (Test.TestType)testAppointment.TestTypeID;
            testTypeObj = TestType.Find(testAppointment.TestTypeID);
            _localDrivingLicenseApplication = LocalDrivingLicenseApplication.GetByIDDetailed(_localDrivingLicenseApplicationID).Rows[0];
            NumberOfTestTrials = TestAppointment.GetNumberOfTestTrials(_localDrivingLicenseApplicationID, testType);
            dtp_Date.Value = testAppointment.ScheduledDate;

            if (update)
                NumberOfTestTrials -= 1;

            if (LocalDrivingLicenseApplication.GetNumberOfPassedTests(appointmentID) == ((int)testType))
            {
                lbl_TestAlreadyTooked.Visible = true;
            }

            FillControllersWithData();
        }
        private void FillControllersWithData()
        {
            dtp_Date.MinDate = DateTime.Now.AddDays(1);

            gb_RetakeTestInfo.Enabled = false;

            // Then it's a retake test
            if (NumberOfTestTrials > 0)
            {
                lbl_ScheduleTestTitle.Text = "Schedule Retake Test";
                lbl_RetakeApplicationFeeValue.Text = Service.Find((int)Service.Services.RETAKE_TEST).ServiceFee.ToString();
                gb_RetakeTestInfo.Enabled = true;
            }

            gb_TestTypeTitle.Text = $"{testType} Test";
            lbl_ApplicationIDValue.Text = _localDrivingLicenseApplicationID.ToString();
            lbl_LicenseClassValue.Text = _localDrivingLicenseApplication[LocalDrivingLicenseApplication.GetByIDDetailedDataTableAttribute.ClassName.ToString()].ToString();
            lbl_FullNameValue.Text = _localDrivingLicenseApplication[LocalDrivingLicenseApplication.GetByIDDetailedDataTableAttribute.Fullname.ToString()].ToString();

            if(testAppointment is null)
                lbl_FeeValue.Text = testTypeObj.TestFee.ToString();
            else 
                lbl_FeeValue.Text = testAppointment.PaidFee.ToString();

            lbl_TrialsValue.Text = NumberOfTestTrials.ToString();

            lbl_TotalFeesValue.Text = (Decimal.Parse(lbl_RetakeApplicationFeeValue.Text) + Decimal.Parse(lbl_FeeValue.Text)).ToString();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool Save(TestAppointment testAppointment)
        {
            testAppointment.RetakeTestTestAppointmentsID = null;

            if (NumberOfTestTrials > 0)
            {
                var retakeApplication = new BLL.Entities.Application();
                retakeApplication.PersonID = (int)_localDrivingLicenseApplication[LocalDrivingLicenseApplication.GetByIDDetailedDataTableAttribute.PersonID.ToString()];
                retakeApplication.ServiceID = (int)Service.Services.RETAKE_TEST;
                retakeApplication.ApplicationStatusID = (int)ApplicationStatus.ApplicationStatuses.New;
                retakeApplication.CreatedByUserID = CurrentUser.LoggedInUser.ID;
                retakeApplication.ApplicationDate = DateTime.Now;
                retakeApplication.LastStatusDate = DateTime.Now;
                retakeApplication.ApplicationPaidFee = Decimal.Parse(lbl_TotalFeesValue.Text);

                if (!retakeApplication.Save())
                {
                    MessageBox.Show("Retake test application is not created!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                testAppointment.RetakeTestTestAppointmentsID = retakeApplication.ID;
                lbl_RetakeApplicationIDValue.Text = retakeApplication.ID.ToString();
            }

            testAppointment.TestTypeID = (int)testType;
            testAppointment.LocalDrivingLicenseApplicationID = _localDrivingLicenseApplicationID;
            testAppointment.CreatedByUserID = CurrentUser.LoggedInUser.ID;
            testAppointment.PaidFee = testTypeObj.TestFee;
            testAppointment.ScheduledDate = dtp_Date.Value;
            testAppointment.IsLocked = false;

            if (!testAppointment.Save())
            {
                MessageBox.Show("Test appointment is not scheduled!", "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private bool UpdateTest(TestAppointment testAppointment)
        {
            testAppointment.ScheduledDate = dtp_Date.Value;
 

            if (!testAppointment.Save())
            {
                MessageBox.Show("Test appointment is not updated!", "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            MessageBox.Show("Test appointment updated successfully", "Schedule", MessageBoxButtons.OK);
            return true;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (testAppointment is null)
            {
                testAppointment = new TestAppointment();
                if(!Save(testAppointment))
                    return;

                btn_Save.Enabled = false;
                dtp_Date.Enabled = false;
                return;
            }

            if (!UpdateTest(testAppointment))
                return;

            this.Close();
        }
    }
}
