namespace DVLD.UI.Driving_license_services
{
    partial class NewInternationalLicense
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
            applicationBasicInfo = new DVLD.UI.User_Controls.Applications.InternationalLicenseApplicationBasicInfo();
            lblTitle = new Label();
            btnIssue = new Button();
            btnClose = new Button();
            llblShowLicenseHistory = new LinkLabel();
            llblShowLicenseInfo = new LinkLabel();
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
            // applicationBasicInfo
            // 
            applicationBasicInfo.Location = new Point(12, 681);
            applicationBasicInfo.Name = "applicationBasicInfo";
            applicationBasicInfo.Size = new Size(1129, 200);
            applicationBasicInfo.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(257, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(642, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "International License Application";
            // 
            // btnIssue
            // 
            btnIssue.Enabled = false;
            btnIssue.Location = new Point(947, 887);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(94, 29);
            btnIssue.TabIndex = 2;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1047, 887);
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
            llblShowLicenseHistory.Location = new Point(12, 891);
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
            llblShowLicenseInfo.Location = new Point(176, 891);
            llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            llblShowLicenseInfo.Size = new Size(127, 20);
            llblShowLicenseInfo.TabIndex = 6;
            llblShowLicenseInfo.TabStop = true;
            llblShowLicenseInfo.Text = "Show License Info";
            llblShowLicenseInfo.LinkClicked += llblShowLicenseInfo_LinkClicked;
            // 
            // NewInternationalLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 923);
            Controls.Add(llblShowLicenseInfo);
            Controls.Add(llblShowLicenseHistory);
            Controls.Add(btnClose);
            Controls.Add(btnIssue);
            Controls.Add(lblTitle);
            Controls.Add(findDriverByLicenseId);
            Controls.Add(applicationBasicInfo);
            Name = "NewInternationalLicense";
            Text = "New International License";
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
    }
}