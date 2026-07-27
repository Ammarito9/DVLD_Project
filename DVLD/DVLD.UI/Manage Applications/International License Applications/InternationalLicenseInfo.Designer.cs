namespace DVLD.UI.Manage_Applications.International_License_Applications
{
    partial class InternationalLicenseInfo
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
            ctrlDriverInternationalLicenseInfo1 = new DVLD.UI.User_Controls.ctrlDriverInternationalLicenseInfo();
            lblDriverInternationalLicenseInfo = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ctrlDriverInternationalLicenseInfo1
            // 
            ctrlDriverInternationalLicenseInfo1.Location = new Point(12, 106);
            ctrlDriverInternationalLicenseInfo1.Name = "ctrlDriverInternationalLicenseInfo1";
            ctrlDriverInternationalLicenseInfo1.Size = new Size(1129, 332);
            ctrlDriverInternationalLicenseInfo1.TabIndex = 0;
            // 
            // lblDriverInternationalLicenseInfo
            // 
            lblDriverInternationalLicenseInfo.AutoSize = true;
            lblDriverInternationalLicenseInfo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDriverInternationalLicenseInfo.ForeColor = Color.Firebrick;
            lblDriverInternationalLicenseInfo.Location = new Point(259, 28);
            lblDriverInternationalLicenseInfo.Name = "lblDriverInternationalLicenseInfo";
            lblDriverInternationalLicenseInfo.Size = new Size(630, 54);
            lblDriverInternationalLicenseInfo.TabIndex = 1;
            lblDriverInternationalLicenseInfo.Text = "Driver International License Info";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1047, 444);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // InternationalLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 483);
            Controls.Add(btnClose);
            Controls.Add(lblDriverInternationalLicenseInfo);
            Controls.Add(ctrlDriverInternationalLicenseInfo1);
            Name = "InternationalLicenseInfo";
            Text = "InternationalLicenseInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private User_Controls.ctrlDriverInternationalLicenseInfo ctrlDriverInternationalLicenseInfo1;
        private Label lblDriverInternationalLicenseInfo;
        private Button btnClose;
    }
}