namespace DVLD.UI.Detain_Licenses
{
    partial class ReleaseLicense
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
            btnRelease = new Button();
            btnClose = new Button();
            llblShowLicenseHistory = new LinkLabel();
            llblShowLicenseInfo = new LinkLabel();
            ctrlReleaseApplicationInfo1 = new DVLD.UI.User_Controls.Applications.ctrlReleaseApplicationInfo();
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
            lblTitle.Location = new Point(317, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(539, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Release License Application";
            // 
            // btnRelease
            // 
            btnRelease.Enabled = false;
            btnRelease.Location = new Point(950, 876);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(94, 29);
            btnRelease.TabIndex = 2;
            btnRelease.Text = "Release";
            btnRelease.UseVisualStyleBackColor = true;
            btnRelease.Click += btnRelease_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1050, 876);
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
            llblShowLicenseHistory.Location = new Point(15, 880);
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
            llblShowLicenseInfo.Location = new Point(179, 880);
            llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            llblShowLicenseInfo.Size = new Size(127, 20);
            llblShowLicenseInfo.TabIndex = 6;
            llblShowLicenseInfo.TabStop = true;
            llblShowLicenseInfo.Text = "Show License Info";
            llblShowLicenseInfo.LinkClicked += llblShowLicenseInfo_LinkClicked;
            // 
            // ctrlReleaseApplicationInfo1
            // 
            ctrlReleaseApplicationInfo1.Location = new Point(12, 681);
            ctrlReleaseApplicationInfo1.Name = "ctrlReleaseApplicationInfo1";
            ctrlReleaseApplicationInfo1.Size = new Size(1129, 189);
            ctrlReleaseApplicationInfo1.TabIndex = 7;
            // 
            // ReleaseLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 914);
            Controls.Add(llblShowLicenseInfo);
            Controls.Add(llblShowLicenseHistory);
            Controls.Add(btnClose);
            Controls.Add(btnRelease);
            Controls.Add(lblTitle);
            Controls.Add(findDriverByLicenseId);
            Controls.Add(ctrlReleaseApplicationInfo1);
            Name = "ReleaseLicense";
            Text = "Release License";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private User_Controls.Driver.FindDriverByLicenseID findDriverByLicenseId;
        private Label lblTitle;
        private Button btnRelease;
        private Button btnClose;
        private LinkLabel llblShowLicenseHistory;
        private LinkLabel llblShowLicenseInfo;
        private User_Controls.Applications.ctrlReleaseApplicationInfo ctrlReleaseApplicationInfo1;
    }
}