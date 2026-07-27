namespace DVLD.UI.Driving_license_services.Replacement_for_Lost_or_Damaged_License
{
    partial class ReplacementForLostOrDamagedLicense
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
            findDriverByLicenseId = new DVLD.UI.User_Controls.Driver.FindDriverByLicenseID();
            lblTitle = new Label();
            btnIssue = new Button();
            btnClose = new Button();
            llblShowLicenseHistory = new LinkLabel();
            llblShowLicenseInfo = new LinkLabel();
            ctrlReplacementLicenseApplicationBasicInfo1 = new DVLD.UI.User_Controls.Applications.ctrlReplacementLicenseApplicationBasicInfo();
            gbReplacementReason = new GroupBox();
            rbLostLicense = new RadioButton();
            rbDamagedLicense = new RadioButton();
            gbReplacementReason.SuspendLayout();
            SuspendLayout();
            // 
            // findDriverByLicenseId
            // 
            findDriverByLicenseId.Location = new Point(12, 85);
            findDriverByLicenseId.Name = "findDriverByLicenseId";
            findDriverByLicenseId.Size = new Size(1129, 590);
            findDriverByLicenseId.TabIndex = 0;
            findDriverByLicenseId.OnLicenseSelected += findDriverByLicenseId_OnLicenseSelected;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(296, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(565, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Repleace License Application";
            // 
            // btnIssue
            // 
            btnIssue.Enabled = false;
            btnIssue.Location = new Point(947, 843);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(94, 29);
            btnIssue.TabIndex = 2;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1047, 843);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // llblShowLicenseHistory
            // 
            llblShowLicenseHistory.AutoSize = true;
            llblShowLicenseHistory.Enabled = false;
            llblShowLicenseHistory.Location = new Point(12, 847);
            llblShowLicenseHistory.Name = "llblShowLicenseHistory";
            llblShowLicenseHistory.Size = new Size(148, 20);
            llblShowLicenseHistory.TabIndex = 5;
            llblShowLicenseHistory.TabStop = true;
            llblShowLicenseHistory.Text = "Show License History";
            llblShowLicenseHistory.LinkClicked += llblShowLicenseHistory_LinkClicked;
            // 
            // llblShowLicenseInfo
            // 
            llblShowLicenseInfo.AutoSize = true;
            llblShowLicenseInfo.Enabled = false;
            llblShowLicenseInfo.Location = new Point(176, 847);
            llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            llblShowLicenseInfo.Size = new Size(127, 20);
            llblShowLicenseInfo.TabIndex = 6;
            llblShowLicenseInfo.TabStop = true;
            llblShowLicenseInfo.Text = "Show License Info";
            llblShowLicenseInfo.LinkClicked += llblShowLicenseInfo_LinkClicked;
            // 
            // ctrlReplacementLicenseApplicationBasicInfo1
            // 
            ctrlReplacementLicenseApplicationBasicInfo1.Location = new Point(12, 681);
            ctrlReplacementLicenseApplicationBasicInfo1.Name = "ctrlReplacementLicenseApplicationBasicInfo1";
            ctrlReplacementLicenseApplicationBasicInfo1.Size = new Size(1129, 156);
            ctrlReplacementLicenseApplicationBasicInfo1.TabIndex = 7;
            // 
            // gbReplacementReason
            // 
            gbReplacementReason.Controls.Add(rbLostLicense);
            gbReplacementReason.Controls.Add(rbDamagedLicense);
            gbReplacementReason.Location = new Point(817, 85);
            gbReplacementReason.Name = "gbReplacementReason";
            gbReplacementReason.Size = new Size(324, 90);
            gbReplacementReason.TabIndex = 8;
            gbReplacementReason.TabStop = false;
            gbReplacementReason.Text = "Replacement Reason";
            // 
            // rbLostLicense
            // 
            rbLostLicense.AutoSize = true;
            rbLostLicense.Location = new Point(191, 39);
            rbLostLicense.Name = "rbLostLicense";
            rbLostLicense.Size = new Size(109, 24);
            rbLostLicense.TabIndex = 1;
            rbLostLicense.Text = "Lost License";
            rbLostLicense.UseVisualStyleBackColor = true;
            rbLostLicense.CheckedChanged += rbLostLicense_CheckedChanged;
            // 
            // rbDamagedLicense
            // 
            rbDamagedLicense.AutoSize = true;
            rbDamagedLicense.Checked = true;
            rbDamagedLicense.Location = new Point(18, 39);
            rbDamagedLicense.Name = "rbDamagedLicense";
            rbDamagedLicense.Size = new Size(148, 24);
            rbDamagedLicense.TabIndex = 0;
            rbDamagedLicense.TabStop = true;
            rbDamagedLicense.Text = "Damaged License";
            rbDamagedLicense.UseVisualStyleBackColor = true;
            rbDamagedLicense.CheckedChanged += rbDamagedLicense_CheckedChanged;
            // 
            // ReplacementForLostOrDamagedLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 878);
            Controls.Add(gbReplacementReason);
            Controls.Add(ctrlReplacementLicenseApplicationBasicInfo1);
            Controls.Add(llblShowLicenseInfo);
            Controls.Add(llblShowLicenseHistory);
            Controls.Add(btnClose);
            Controls.Add(btnIssue);
            Controls.Add(lblTitle);
            Controls.Add(findDriverByLicenseId);
            Name = "ReplacementForLostOrDamagedLicense";
            Text = "Replacement for Lost or Damaged License";
            gbReplacementReason.ResumeLayout(false);
            gbReplacementReason.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private User_Controls.Driver.FindDriverByLicenseID findDriverByLicenseId;
        private User_Controls.Applications.InternationalLicenseApplicationBasicInfo applicationBasicInfo;
        private Label lblTitle;
        private Button btnIssue;
        private Button btnClose;
        private LinkLabel llblShowLicenseHistory;
        private LinkLabel llblShowLicenseInfo;
        private User_Controls.Applications.ctrlReplacementLicenseApplicationBasicInfo ctrlReplacementLicenseApplicationBasicInfo1;
        private GroupBox gbReplacementReason;
        private RadioButton rbLostLicense;
        private RadioButton rbDamagedLicense;
    }
}