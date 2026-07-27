namespace DVLD.UI.Manage_Applications
{
    partial class ScheduleTest
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb_TestTypeTitle = new GroupBox();
            lbl_TestAlreadyTooked = new Label();
            dtp_Date = new DateTimePicker();
            lbl_ScheduleTestTitle = new Label();
            lbl_FeeValue = new Label();
            lbl_Fee = new Label();
            lbl_Date = new Label();
            lbl_TrialsValue = new Label();
            lbl_Trials = new Label();
            lbl_FullName = new Label();
            lbl_FullNameValue = new Label();
            lbl_LicenseClassValue = new Label();
            lbl_LicenseClass = new Label();
            lbl_ApplicationIDValue = new Label();
            lbl_ApplicationID = new Label();
            gb_RetakeTestInfo = new GroupBox();
            lbl_TotalFeesValue = new Label();
            lbl_RetakeApplicationIDValue = new Label();
            lbl_RetakeApplicationFeeValue = new Label();
            lbl_TotalFees = new Label();
            lbl_RetakeApplicationID = new Label();
            lbl_RetakeApplicationFee = new Label();
            btn_Save = new Button();
            btn_Close = new Button();
            gb_TestTypeTitle.SuspendLayout();
            gb_RetakeTestInfo.SuspendLayout();
            SuspendLayout();
            // 
            // gb_TestTypeTitle
            // 
            gb_TestTypeTitle.Controls.Add(lbl_TestAlreadyTooked);
            gb_TestTypeTitle.Controls.Add(dtp_Date);
            gb_TestTypeTitle.Controls.Add(lbl_ScheduleTestTitle);
            gb_TestTypeTitle.Controls.Add(lbl_FeeValue);
            gb_TestTypeTitle.Controls.Add(lbl_Fee);
            gb_TestTypeTitle.Controls.Add(lbl_Date);
            gb_TestTypeTitle.Controls.Add(lbl_TrialsValue);
            gb_TestTypeTitle.Controls.Add(lbl_Trials);
            gb_TestTypeTitle.Controls.Add(lbl_FullName);
            gb_TestTypeTitle.Controls.Add(lbl_FullNameValue);
            gb_TestTypeTitle.Controls.Add(lbl_LicenseClassValue);
            gb_TestTypeTitle.Controls.Add(lbl_LicenseClass);
            gb_TestTypeTitle.Controls.Add(lbl_ApplicationIDValue);
            gb_TestTypeTitle.Controls.Add(lbl_ApplicationID);
            gb_TestTypeTitle.Location = new Point(12, 12);
            gb_TestTypeTitle.Name = "gb_TestTypeTitle";
            gb_TestTypeTitle.Size = new Size(558, 348);
            gb_TestTypeTitle.TabIndex = 0;
            gb_TestTypeTitle.TabStop = false;
            gb_TestTypeTitle.Text = "Test Type Title";
            // 
            // lbl_TestAlreadyTooked
            // 
            lbl_TestAlreadyTooked.AutoSize = true;
            lbl_TestAlreadyTooked.Font = new Font("Segoe UI", 12F);
            lbl_TestAlreadyTooked.Location = new Point(44, 83);
            lbl_TestAlreadyTooked.Name = "lbl_TestAlreadyTooked";
            lbl_TestAlreadyTooked.Size = new Size(470, 28);
            lbl_TestAlreadyTooked.TabIndex = 3;
            lbl_TestAlreadyTooked.Text = "Applicant already took this test, appointment locked";
            lbl_TestAlreadyTooked.Visible = false;
            // 
            // dtp_Date
            // 
            dtp_Date.Format = DateTimePickerFormat.Short;
            dtp_Date.Location = new Point(176, 270);
            dtp_Date.Name = "dtp_Date";
            dtp_Date.Size = new Size(168, 27);
            dtp_Date.TabIndex = 14;
            // 
            // lbl_ScheduleTestTitle
            // 
            lbl_ScheduleTestTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_ScheduleTestTitle.AutoSize = true;
            lbl_ScheduleTestTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbl_ScheduleTestTitle.ForeColor = Color.Brown;
            lbl_ScheduleTestTitle.Location = new Point(175, 42);
            lbl_ScheduleTestTitle.Name = "lbl_ScheduleTestTitle";
            lbl_ScheduleTestTitle.Size = new Size(209, 41);
            lbl_ScheduleTestTitle.TabIndex = 1;
            lbl_ScheduleTestTitle.Text = "Schedule Test";
            lbl_ScheduleTestTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_FeeValue
            // 
            lbl_FeeValue.AutoSize = true;
            lbl_FeeValue.Font = new Font("Segoe UI", 12F);
            lbl_FeeValue.Location = new Point(176, 304);
            lbl_FeeValue.Name = "lbl_FeeValue";
            lbl_FeeValue.Size = new Size(39, 28);
            lbl_FeeValue.TabIndex = 13;
            lbl_FeeValue.Text = "???";
            // 
            // lbl_Fee
            // 
            lbl_Fee.AutoSize = true;
            lbl_Fee.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Fee.Location = new Point(126, 304);
            lbl_Fee.Name = "lbl_Fee";
            lbl_Fee.Size = new Size(44, 28);
            lbl_Fee.TabIndex = 12;
            lbl_Fee.Text = "Fee";
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Date.Location = new Point(113, 268);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(57, 28);
            lbl_Date.TabIndex = 10;
            lbl_Date.Text = "Date";
            // 
            // lbl_TrialsValue
            // 
            lbl_TrialsValue.AutoSize = true;
            lbl_TrialsValue.Font = new Font("Segoe UI", 12F);
            lbl_TrialsValue.Location = new Point(176, 232);
            lbl_TrialsValue.Name = "lbl_TrialsValue";
            lbl_TrialsValue.Size = new Size(39, 28);
            lbl_TrialsValue.TabIndex = 9;
            lbl_TrialsValue.Text = "???";
            // 
            // lbl_Trials
            // 
            lbl_Trials.AutoSize = true;
            lbl_Trials.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Trials.Location = new Point(108, 232);
            lbl_Trials.Name = "lbl_Trials";
            lbl_Trials.Size = new Size(62, 28);
            lbl_Trials.TabIndex = 8;
            lbl_Trials.Text = "Trials";
            // 
            // lbl_FullName
            // 
            lbl_FullName.AutoSize = true;
            lbl_FullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_FullName.Location = new Point(62, 196);
            lbl_FullName.Name = "lbl_FullName";
            lbl_FullName.Size = new Size(108, 28);
            lbl_FullName.TabIndex = 7;
            lbl_FullName.Text = "Full Name";
            // 
            // lbl_FullNameValue
            // 
            lbl_FullNameValue.AutoSize = true;
            lbl_FullNameValue.Font = new Font("Segoe UI", 12F);
            lbl_FullNameValue.Location = new Point(176, 196);
            lbl_FullNameValue.Name = "lbl_FullNameValue";
            lbl_FullNameValue.Size = new Size(39, 28);
            lbl_FullNameValue.TabIndex = 6;
            lbl_FullNameValue.Text = "???";
            // 
            // lbl_LicenseClassValue
            // 
            lbl_LicenseClassValue.AutoSize = true;
            lbl_LicenseClassValue.Font = new Font("Segoe UI", 12F);
            lbl_LicenseClassValue.Location = new Point(176, 160);
            lbl_LicenseClassValue.Name = "lbl_LicenseClassValue";
            lbl_LicenseClassValue.Size = new Size(39, 28);
            lbl_LicenseClassValue.TabIndex = 5;
            lbl_LicenseClassValue.Text = "???";
            // 
            // lbl_LicenseClass
            // 
            lbl_LicenseClass.AutoSize = true;
            lbl_LicenseClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_LicenseClass.Location = new Point(36, 160);
            lbl_LicenseClass.Name = "lbl_LicenseClass";
            lbl_LicenseClass.Size = new Size(134, 28);
            lbl_LicenseClass.TabIndex = 4;
            lbl_LicenseClass.Text = "License Class";
            // 
            // lbl_ApplicationIDValue
            // 
            lbl_ApplicationIDValue.AutoSize = true;
            lbl_ApplicationIDValue.Font = new Font("Segoe UI", 12F);
            lbl_ApplicationIDValue.Location = new Point(176, 124);
            lbl_ApplicationIDValue.Name = "lbl_ApplicationIDValue";
            lbl_ApplicationIDValue.Size = new Size(39, 28);
            lbl_ApplicationIDValue.TabIndex = 3;
            lbl_ApplicationIDValue.Text = "???";
            // 
            // lbl_ApplicationID
            // 
            lbl_ApplicationID.AutoSize = true;
            lbl_ApplicationID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_ApplicationID.Location = new Point(22, 124);
            lbl_ApplicationID.Name = "lbl_ApplicationID";
            lbl_ApplicationID.Size = new Size(148, 28);
            lbl_ApplicationID.TabIndex = 2;
            lbl_ApplicationID.Text = "Application ID";
            // 
            // gb_RetakeTestInfo
            // 
            gb_RetakeTestInfo.Controls.Add(lbl_TotalFeesValue);
            gb_RetakeTestInfo.Controls.Add(lbl_RetakeApplicationIDValue);
            gb_RetakeTestInfo.Controls.Add(lbl_RetakeApplicationFeeValue);
            gb_RetakeTestInfo.Controls.Add(lbl_TotalFees);
            gb_RetakeTestInfo.Controls.Add(lbl_RetakeApplicationID);
            gb_RetakeTestInfo.Controls.Add(lbl_RetakeApplicationFee);
            gb_RetakeTestInfo.Location = new Point(12, 366);
            gb_RetakeTestInfo.Name = "gb_RetakeTestInfo";
            gb_RetakeTestInfo.Size = new Size(558, 150);
            gb_RetakeTestInfo.TabIndex = 0;
            gb_RetakeTestInfo.TabStop = false;
            gb_RetakeTestInfo.Text = "Retake Test Info";
            // 
            // lbl_TotalFeesValue
            // 
            lbl_TotalFeesValue.AutoSize = true;
            lbl_TotalFeesValue.Font = new Font("Segoe UI", 12F);
            lbl_TotalFeesValue.Location = new Point(176, 104);
            lbl_TotalFeesValue.Name = "lbl_TotalFeesValue";
            lbl_TotalFeesValue.Size = new Size(39, 28);
            lbl_TotalFeesValue.TabIndex = 5;
            lbl_TotalFeesValue.Text = "???";
            // 
            // lbl_RetakeApplicationIDValue
            // 
            lbl_RetakeApplicationIDValue.AutoSize = true;
            lbl_RetakeApplicationIDValue.Font = new Font("Segoe UI", 12F);
            lbl_RetakeApplicationIDValue.Location = new Point(176, 68);
            lbl_RetakeApplicationIDValue.Name = "lbl_RetakeApplicationIDValue";
            lbl_RetakeApplicationIDValue.Size = new Size(48, 28);
            lbl_RetakeApplicationIDValue.TabIndex = 4;
            lbl_RetakeApplicationIDValue.Text = "N/A";
            // 
            // lbl_RetakeApplicationFeeValue
            // 
            lbl_RetakeApplicationFeeValue.AutoSize = true;
            lbl_RetakeApplicationFeeValue.Font = new Font("Segoe UI", 12F);
            lbl_RetakeApplicationFeeValue.Location = new Point(176, 32);
            lbl_RetakeApplicationFeeValue.Name = "lbl_RetakeApplicationFeeValue";
            lbl_RetakeApplicationFeeValue.Size = new Size(23, 28);
            lbl_RetakeApplicationFeeValue.TabIndex = 3;
            lbl_RetakeApplicationFeeValue.Text = "0";
            // 
            // lbl_TotalFees
            // 
            lbl_TotalFees.AutoSize = true;
            lbl_TotalFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_TotalFees.Location = new Point(64, 104);
            lbl_TotalFees.Name = "lbl_TotalFees";
            lbl_TotalFees.Size = new Size(106, 28);
            lbl_TotalFees.TabIndex = 2;
            lbl_TotalFees.Text = "Total Fees";
            // 
            // lbl_RetakeApplicationID
            // 
            lbl_RetakeApplicationID.AutoSize = true;
            lbl_RetakeApplicationID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_RetakeApplicationID.Location = new Point(17, 68);
            lbl_RetakeApplicationID.Name = "lbl_RetakeApplicationID";
            lbl_RetakeApplicationID.Size = new Size(153, 28);
            lbl_RetakeApplicationID.TabIndex = 1;
            lbl_RetakeApplicationID.Text = "Retake App. ID";
            // 
            // lbl_RetakeApplicationFee
            // 
            lbl_RetakeApplicationFee.AutoSize = true;
            lbl_RetakeApplicationFee.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_RetakeApplicationFee.Location = new Point(6, 32);
            lbl_RetakeApplicationFee.Name = "lbl_RetakeApplicationFee";
            lbl_RetakeApplicationFee.Size = new Size(164, 28);
            lbl_RetakeApplicationFee.TabIndex = 0;
            lbl_RetakeApplicationFee.Text = "Retake App. Fee";
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(376, 522);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(94, 29);
            btn_Save.TabIndex = 1;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(476, 522);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(94, 29);
            btn_Close.TabIndex = 2;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // ScheduleTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 558);
            Controls.Add(btn_Close);
            Controls.Add(btn_Save);
            Controls.Add(gb_RetakeTestInfo);
            Controls.Add(gb_TestTypeTitle);
            Name = "ScheduleTest";
            Text = "Schedule Test";
            gb_TestTypeTitle.ResumeLayout(false);
            gb_TestTypeTitle.PerformLayout();
            gb_RetakeTestInfo.ResumeLayout(false);
            gb_RetakeTestInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_TestTypeTitle;
        private GroupBox gb_RetakeTestInfo;
        private Label lbl_ScheduleTestTitle;
        private Label lbl_ApplicationID;
        private Label lbl_FeeValue;
        private Label lbl_Fee;
        private Label lbl_Date;
        private Label lbl_TrialsValue;
        private Label lbl_Trials;
        private Label lbl_FullName;
        private Label lbl_FullNameValue;
        private Label lbl_LicenseClassValue;
        private Label lbl_LicenseClass;
        private Label lbl_ApplicationIDValue;
        private DateTimePicker dtp_Date;
        private Label lbl_TotalFeesValue;
        private Label lbl_RetakeApplicationIDValue;
        private Label lbl_RetakeApplicationFeeValue;
        private Label lbl_TotalFees;
        private Label lbl_RetakeApplicationID;
        private Label lbl_RetakeApplicationFee;
        private Button btn_Save;
        private Button btn_Close;
        private Label lbl_TestAlreadyTooked;
    }
}