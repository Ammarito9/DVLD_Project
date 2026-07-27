namespace DVLD.UI.Driving_license_services.Renew_driving_license
{
    partial class RenewDrivingLicense
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
            btnRenew = new Button();
            btnClose = new Button();
            llblShowLicenseHistory = new LinkLabel();
            llblShowLicenseInfo = new LinkLabel();
            renewLicenseApplication1 = new DVLD.UI.User_Controls.Applications.RenewLicenseApplication();
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
            lblTitle.Location = new Point(257, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(642, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "International License Application";
            // 
            // btnRenew
            // 
            btnRenew.Enabled = false;
            btnRenew.Location = new Point(947, 989);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(94, 29);
            btnRenew.TabIndex = 2;
            btnRenew.Text = "Renew";
            btnRenew.UseVisualStyleBackColor = true;
            btnRenew.Click += btnRenew_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1047, 989);
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
            llblShowLicenseHistory.Location = new Point(12, 993);
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
            llblShowLicenseInfo.Location = new Point(176, 993);
            llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            llblShowLicenseInfo.Size = new Size(127, 20);
            llblShowLicenseInfo.TabIndex = 6;
            llblShowLicenseInfo.TabStop = true;
            llblShowLicenseInfo.Text = "Show License Info";
            llblShowLicenseInfo.LinkClicked += llblShowLicenseInfo_LinkClicked;
            // 
            // renewLicenseApplication1
            // 
            renewLicenseApplication1.Location = new Point(12, 681);
            renewLicenseApplication1.Name = "renewLicenseApplication1";
            renewLicenseApplication1.Size = new Size(1129, 302);
            renewLicenseApplication1.TabIndex = 7;
            // 
            // RenewDrivingLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 1026);
            Controls.Add(llblShowLicenseInfo);
            Controls.Add(llblShowLicenseHistory);
            Controls.Add(btnClose);
            Controls.Add(btnRenew);
            Controls.Add(lblTitle);
            Controls.Add(findDriverByLicenseId);
            Controls.Add(renewLicenseApplication1);
            Name = "RenewDrivingLicense";
            Text = "Renew Driving License";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private User_Controls.Driver.FindDriverByLicenseID findDriverByLicenseId;
        private User_Controls.Applications.InternationalLicenseApplicationBasicInfo applicationBasicInfo;
        private Label lblTitle;
        private Button btnRenew;
        private Button btnClose;
        private LinkLabel llblShowLicenseHistory;
        private LinkLabel llblShowLicenseInfo;
        private User_Controls.Applications.RenewLicenseApplication renewLicenseApplication1;
    }
}