namespace DVLD.UI.Manage_Applications
{
    partial class LicenseHistory
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
            lblLicenseHistory = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblLicenseHistory
            // 
            lblLicenseHistory.AutoSize = true;
            lblLicenseHistory.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicenseHistory.ForeColor = Color.Firebrick;
            lblLicenseHistory.Location = new Point(361, 19);
            lblLicenseHistory.Name = "lblLicenseHistory";
            lblLicenseHistory.Size = new Size(310, 54);
            lblLicenseHistory.TabIndex = 2;
            lblLicenseHistory.Text = "License History";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(918, 798);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // LicenseHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 839);
            Controls.Add(btnClose);
            Controls.Add(lblLicenseHistory);

            Name = "LicenseHistory";
            Text = "LicenseHistory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private User_Controls.Driver.DriverLicenses driverLicenses1;
        private Common_Forms.ucPersonDetails ucPersonDetails1;
        private Label lblLicenseHistory;
        private Button btnClose;
    }
}