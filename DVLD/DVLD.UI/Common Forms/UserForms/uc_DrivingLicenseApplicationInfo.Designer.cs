namespace DVLD.UI.Common_Forms.UserForms
{
    partial class uc_DrivingLicenseApplicationInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb_DrivingLicenseApplicationInfo = new GroupBox();
            llbl_ShowLicenseInfo = new LinkLabel();
            lbl_LicenseClassValue = new Label();
            lbl_LicenseClass = new Label();
            lbl_PassedTestsValue = new Label();
            lbl_PassedTests = new Label();
            lbl_ApplicationIDValue = new Label();
            lbl_ApplicationID = new Label();
            gb_DrivingLicenseApplicationInfo.SuspendLayout();
            SuspendLayout();
            // 
            // gb_DrivingLicenseApplicationInfo
            // 
            gb_DrivingLicenseApplicationInfo.Controls.Add(llbl_ShowLicenseInfo);
            gb_DrivingLicenseApplicationInfo.Controls.Add(lbl_LicenseClassValue);
            gb_DrivingLicenseApplicationInfo.Controls.Add(lbl_LicenseClass);
            gb_DrivingLicenseApplicationInfo.Controls.Add(lbl_PassedTestsValue);
            gb_DrivingLicenseApplicationInfo.Controls.Add(lbl_PassedTests);
            gb_DrivingLicenseApplicationInfo.Controls.Add(lbl_ApplicationIDValue);
            gb_DrivingLicenseApplicationInfo.Controls.Add(lbl_ApplicationID);
            gb_DrivingLicenseApplicationInfo.Dock = DockStyle.Fill;
            gb_DrivingLicenseApplicationInfo.Location = new Point(0, 0);
            gb_DrivingLicenseApplicationInfo.Name = "gb_DrivingLicenseApplicationInfo";
            gb_DrivingLicenseApplicationInfo.Size = new Size(1000, 100);
            gb_DrivingLicenseApplicationInfo.TabIndex = 0;
            gb_DrivingLicenseApplicationInfo.TabStop = false;
            gb_DrivingLicenseApplicationInfo.Text = "Driving License Application Info";
            // 
            // llbl_ShowLicenseInfo
            // 
            llbl_ShowLicenseInfo.AutoSize = true;
            llbl_ShowLicenseInfo.Enabled = false;
            llbl_ShowLicenseInfo.Font = new Font("Segoe UI", 12F);
            llbl_ShowLicenseInfo.Location = new Point(437, 60);
            llbl_ShowLicenseInfo.Name = "llbl_ShowLicenseInfo";
            llbl_ShowLicenseInfo.Size = new Size(162, 28);
            llbl_ShowLicenseInfo.TabIndex = 6;
            llbl_ShowLicenseInfo.TabStop = true;
            llbl_ShowLicenseInfo.Text = "Show license info";
            // 
            // lbl_LicenseClassValue
            // 
            lbl_LicenseClassValue.AutoSize = true;
            lbl_LicenseClassValue.Font = new Font("Segoe UI", 12F);
            lbl_LicenseClassValue.Location = new Point(605, 30);
            lbl_LicenseClassValue.Name = "lbl_LicenseClassValue";
            lbl_LicenseClassValue.Size = new Size(231, 28);
            lbl_LicenseClassValue.TabIndex = 5;
            lbl_LicenseClassValue.Text = "license class is not found!";
            // 
            // lbl_LicenseClass
            // 
            lbl_LicenseClass.AutoSize = true;
            lbl_LicenseClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_LicenseClass.Location = new Point(409, 30);
            lbl_LicenseClass.Name = "lbl_LicenseClass";
            lbl_LicenseClass.Size = new Size(190, 28);
            lbl_LicenseClass.TabIndex = 4;
            lbl_LicenseClass.Text = "Applied for license";
            // 
            // lbl_PassedTestsValue
            // 
            lbl_PassedTestsValue.AutoSize = true;
            lbl_PassedTestsValue.Font = new Font("Segoe UI", 12F);
            lbl_PassedTestsValue.Location = new Point(159, 60);
            lbl_PassedTestsValue.Name = "lbl_PassedTestsValue";
            lbl_PassedTestsValue.Size = new Size(40, 28);
            lbl_PassedTestsValue.TabIndex = 3;
            lbl_PassedTestsValue.Text = "?/3";
            // 
            // lbl_PassedTests
            // 
            lbl_PassedTests.AutoSize = true;
            lbl_PassedTests.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_PassedTests.Location = new Point(26, 60);
            lbl_PassedTests.Name = "lbl_PassedTests";
            lbl_PassedTests.Size = new Size(127, 28);
            lbl_PassedTests.TabIndex = 2;
            lbl_PassedTests.Text = "Passed tests";
            // 
            // lbl_ApplicationIDValue
            // 
            lbl_ApplicationIDValue.AutoSize = true;
            lbl_ApplicationIDValue.Font = new Font("Segoe UI", 12F);
            lbl_ApplicationIDValue.Location = new Point(159, 32);
            lbl_ApplicationIDValue.Name = "lbl_ApplicationIDValue";
            lbl_ApplicationIDValue.Size = new Size(39, 28);
            lbl_ApplicationIDValue.TabIndex = 1;
            lbl_ApplicationIDValue.Text = "???";
            // 
            // lbl_ApplicationID
            // 
            lbl_ApplicationID.AutoSize = true;
            lbl_ApplicationID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_ApplicationID.Location = new Point(6, 30);
            lbl_ApplicationID.Name = "lbl_ApplicationID";
            lbl_ApplicationID.Size = new Size(148, 28);
            lbl_ApplicationID.TabIndex = 0;
            lbl_ApplicationID.Text = "Application ID";
            // 
            // uc_DrivingLicenseApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gb_DrivingLicenseApplicationInfo);
            Name = "uc_DrivingLicenseApplicationInfo";
            Size = new Size(1000, 100);
            gb_DrivingLicenseApplicationInfo.ResumeLayout(false);
            gb_DrivingLicenseApplicationInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_DrivingLicenseApplicationInfo;
        private LinkLabel llbl_ShowLicenseInfo;
        private Label lbl_LicenseClassValue;
        private Label lbl_LicenseClass;
        private Label lbl_PassedTestsValue;
        private Label lbl_PassedTests;
        private Label lbl_ApplicationIDValue;
        private Label lbl_ApplicationID;
    }
}
