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

namespace DVLD.UI.Manage_Applications
{
    public partial class TestAppointmentForm : Form
    {
        Test.TestType testType;
        int localDrivingApplicationID = 0;
        public TestAppointmentForm()
        {
            InitializeComponent();
        }
        public TestAppointmentForm(Test.TestType testType, int localDrivingApplicationID) : this()
        {
            this.localDrivingApplicationID = localDrivingApplicationID;
            this.testType = testType;

            InitializeUserControls();
            UpdateControllers();
            FillAppointmentsToDataView(TestAppointment.GetAllFiltered(testType, localDrivingApplicationID));
        }
        private void InitializeUserControls()
        {
            uc_ApplicationBasicInfo1 = new Common_Forms.UserForms.uc_ApplicationBasicInfo(LocalDrivingLicenseApplication.Find(localDrivingApplicationID).ApplicationID);

            uc_DrivingLicenseApplicationInfo1 = new Common_Forms.UserForms.uc_DrivingLicenseApplicationInfo(localDrivingApplicationID);

            uc_DrivingLicenseApplicationInfo1.Location = new Point(12, 110);
            uc_ApplicationBasicInfo1.Location = new Point(12, 210);

            this.Controls.Add(uc_DrivingLicenseApplicationInfo1);
            this.Controls.Add(uc_ApplicationBasicInfo1);
        }
        private void UpdateControllers()
        {
            lbl_Title.Text = $"{testType} Test Appointment";


        }
        private void FillAppointmentsToDataView(DataTable dt = null)
        {
            if (dt is not null)
                dgv_Appointments.DataSource = dt;
            else
                dgv_Appointments.DataSource = TestAppointment.GetAllFiltered(testType, localDrivingApplicationID);
            if (dgv_Appointments.RowCount > 0)
            {
                dgv_Appointments.Columns["ID"].HeaderText = "Appointment ID";
                dgv_Appointments.Columns["TestTypeID"].Visible = false;
                dgv_Appointments.Columns["LocalDrivingLicenseApplicationID"].Visible = false;
                dgv_Appointments.Columns["CreatedByUserID"].Visible = false;
                dgv_Appointments.Columns["ScheduledDate"].HeaderText = "Appointment Date";
                dgv_Appointments.Columns["PaidFee"].HeaderText = "Paid Fees";
                dgv_Appointments.Columns["IsLocked"].HeaderText = "Is Locked";
                dgv_Appointments.Columns["RetakeTestApplicationID"].Visible = false;
            }

            lbl_NumberOfRowsValue.Text = Convert.ToString(dgv_Appointments.Rows.Count);
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Appointments.CurrentRow is null)
            {
                MessageBox.Show("Please select an appointment to edit on!", "No appointment selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int appointemntID = (int)dgv_Appointments.CurrentRow.Cells["ID"].Value;
            ScheduleTest scheduleTest = new ScheduleTest(appointemntID);
            scheduleTest.ShowDialog();
            FillAppointmentsToDataView();
        }

        private void btn_Schedule_Click(object sender, EventArgs e)
        {
            // Check if person has already active appointment (not locked) before scheduling
            if (TestAppointment.IsThereActiveAppointment(localDrivingApplicationID))
            {
                MessageBox.Show("Person already has an active appointment for this test. You can't add a new one!", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            // THIS Solution is wrong to check if the test already passed to do not schedule 
            //int appointmentID = (int)dgv_Appointments.CurrentRow.Cells["ID"].Value;
            //// Check if the test already passed
            //if(LocalDrivingLicenseApplication.GetNumberOfPassedTests(appointmentID) == ((int)testType))
            //{
            //    MessageBox.Show($"Person already has passed {testType}. You can't take it again!", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            ScheduleTest scheduleTest = new ScheduleTest(localDrivingApplicationID, testType);
            scheduleTest.ShowDialog();
            FillAppointmentsToDataView();
        }
        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Appointments.CurrentRow is null)
            {
                MessageBox.Show("Please select an appointment to edit on!", "No appointment selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int appointemntID = (int)dgv_Appointments.CurrentRow.Cells["ID"].Value;
            TakeTest takeTest = new TakeTest(appointemntID, localDrivingApplicationID, testType);
            takeTest.ShowDialog();
            FillAppointmentsToDataView();
        }
    }
}
