namespace DVLD.UI.Detain_Licenses
{
    partial class DetainLicense
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
            btnDetain = new Button();
            btnClose = new Button();
            llblShowLicenseHistory = new LinkLabel();
            llblShowLicenseInfo = new LinkLabel();
            ctrlDetainInfo1 = new DVLD.UI.User_Controls.ctrlDetainInfo();
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
            lblTitle.Size = new Size(522, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Detain License Application";
            // 
            // btnDetain
            // 
            btnDetain.Enabled = false;
            btnDetain.Location = new Point(947, 843);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(94, 29);
            btnDetain.TabIndex = 2;
            btnDetain.Text = "Detain";
            btnDetain.UseVisualStyleBackColor = true;
            btnDetain.Click += btnDetain_Click;
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
            // ctrlDetainInfo1
            // 
            ctrlDetainInfo1.Location = new Point(12, 681);
            ctrlDetainInfo1.Name = "ctrlDetainInfo1";
            ctrlDetainInfo1.Size = new Size(1129, 156);
            ctrlDetainInfo1.TabIndex = 7;
            // 
            // DetainLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 878);
            Controls.Add(ctrlDetainInfo1);
            Controls.Add(llblShowLicenseInfo);
            Controls.Add(llblShowLicenseHistory);
            Controls.Add(btnClose);
            Controls.Add(btnDetain);
            Controls.Add(lblTitle);
            Controls.Add(findDriverByLicenseId);
            Name = "DetainLicense";
            Text = "Detain License";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private User_Controls.Driver.FindDriverByLicenseID findDriverByLicenseId;
        private Label lblTitle;
        private Button btnDetain;
        private Button btnClose;
        private LinkLabel llblShowLicenseHistory;
        private LinkLabel llblShowLicenseInfo;
        private User_Controls.ctrlDetainInfo ctrlDetainInfo1;
    }
}