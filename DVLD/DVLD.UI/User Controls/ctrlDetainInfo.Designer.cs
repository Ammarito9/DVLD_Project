namespace DVLD.UI.User_Controls
{
    partial class ctrlDetainInfo
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
            gbTitle = new GroupBox();
            txtFineFee = new TextBox();
            lbl_CreatedByValue = new Label();
            lbl_CreatedBy = new Label();
            lblDetainDateValue = new Label();
            lblDetainDate = new Label();
            lblLicenseIDValue = new Label();
            lblLicenseID = new Label();
            lblFineFee = new Label();
            lblDetainIDValue = new Label();
            lblDetainID = new Label();
            gbTitle.SuspendLayout();
            SuspendLayout();
            // 
            // gbTitle
            // 
            gbTitle.Controls.Add(txtFineFee);
            gbTitle.Controls.Add(lbl_CreatedByValue);
            gbTitle.Controls.Add(lbl_CreatedBy);
            gbTitle.Controls.Add(lblDetainDateValue);
            gbTitle.Controls.Add(lblDetainDate);
            gbTitle.Controls.Add(lblLicenseIDValue);
            gbTitle.Controls.Add(lblLicenseID);
            gbTitle.Controls.Add(lblFineFee);
            gbTitle.Controls.Add(lblDetainIDValue);
            gbTitle.Controls.Add(lblDetainID);
            gbTitle.Dock = DockStyle.Fill;
            gbTitle.Location = new Point(0, 0);
            gbTitle.Name = "gbTitle";
            gbTitle.Size = new Size(1129, 156);
            gbTitle.TabIndex = 0;
            gbTitle.TabStop = false;
            gbTitle.Text = "Detain Info";
            // 
            // txtFineFee
            // 
            txtFineFee.Location = new Point(198, 115);
            txtFineFee.Name = "txtFineFee";
            txtFineFee.Size = new Size(88, 27);
            txtFineFee.TabIndex = 20;
            txtFineFee.Leave += txtFineFee_Leave;
            // 
            // lbl_CreatedByValue
            // 
            lbl_CreatedByValue.AutoSize = true;
            lbl_CreatedByValue.Font = new Font("Segoe UI", 12F);
            lbl_CreatedByValue.Location = new Point(771, 71);
            lbl_CreatedByValue.Name = "lbl_CreatedByValue";
            lbl_CreatedByValue.Size = new Size(39, 28);
            lbl_CreatedByValue.TabIndex = 19;
            lbl_CreatedByValue.Text = "???";
            // 
            // lbl_CreatedBy
            // 
            lbl_CreatedBy.AutoSize = true;
            lbl_CreatedBy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_CreatedBy.Location = new Point(498, 71);
            lbl_CreatedBy.Name = "lbl_CreatedBy";
            lbl_CreatedBy.Size = new Size(115, 28);
            lbl_CreatedBy.TabIndex = 18;
            lbl_CreatedBy.Text = "Created By";
            // 
            // lblDetainDateValue
            // 
            lblDetainDateValue.AutoSize = true;
            lblDetainDateValue.Font = new Font("Segoe UI", 12F);
            lblDetainDateValue.Location = new Point(198, 71);
            lblDetainDateValue.Name = "lblDetainDateValue";
            lblDetainDateValue.Size = new Size(39, 28);
            lblDetainDateValue.TabIndex = 15;
            lblDetainDateValue.Text = "???";
            // 
            // lblDetainDate
            // 
            lblDetainDate.AutoSize = true;
            lblDetainDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDetainDate.Location = new Point(6, 71);
            lblDetainDate.Name = "lblDetainDate";
            lblDetainDate.Size = new Size(126, 28);
            lblDetainDate.TabIndex = 14;
            lblDetainDate.Text = "Detain Date";
            // 
            // lblLicenseIDValue
            // 
            lblLicenseIDValue.AutoSize = true;
            lblLicenseIDValue.Font = new Font("Segoe UI", 12F);
            lblLicenseIDValue.Location = new Point(771, 31);
            lblLicenseIDValue.Name = "lblLicenseIDValue";
            lblLicenseIDValue.Size = new Size(39, 28);
            lblLicenseIDValue.TabIndex = 11;
            lblLicenseIDValue.Text = "???";
            // 
            // lblLicenseID
            // 
            lblLicenseID.AutoSize = true;
            lblLicenseID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLicenseID.Location = new Point(498, 31);
            lblLicenseID.Name = "lblLicenseID";
            lblLicenseID.Size = new Size(108, 28);
            lblLicenseID.TabIndex = 10;
            lblLicenseID.Text = "License ID";
            // 
            // lblFineFee
            // 
            lblFineFee.AutoSize = true;
            lblFineFee.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFineFee.Location = new Point(6, 111);
            lblFineFee.Name = "lblFineFee";
            lblFineFee.Size = new Size(89, 28);
            lblFineFee.TabIndex = 8;
            lblFineFee.Text = "Fine Fee";
            // 
            // lblDetainIDValue
            // 
            lblDetainIDValue.AutoSize = true;
            lblDetainIDValue.Font = new Font("Segoe UI", 12F);
            lblDetainIDValue.Location = new Point(198, 31);
            lblDetainIDValue.Name = "lblDetainIDValue";
            lblDetainIDValue.Size = new Size(39, 28);
            lblDetainIDValue.TabIndex = 5;
            lblDetainIDValue.Text = "???";
            // 
            // lblDetainID
            // 
            lblDetainID.AutoSize = true;
            lblDetainID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDetainID.Location = new Point(6, 31);
            lblDetainID.Name = "lblDetainID";
            lblDetainID.Size = new Size(102, 28);
            lblDetainID.TabIndex = 4;
            lblDetainID.Text = "Detain ID";
            // 
            // ctrlDetainInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbTitle);
            Name = "ctrlDetainInfo";
            Size = new Size(1129, 156);
            gbTitle.ResumeLayout(false);
            gbTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTitle;
        private Label lblDetainIDValue;
        private Label lblDetainID;
        private Label lbl_CreatedByValue;
        private Label lbl_CreatedBy;
        private Label lblDetainDateValue;
        private Label lblDetainDate;
        private Label lblLicenseIDValue;
        private Label lblLicenseID;
        private Label lblFineFee;
        private TextBox txtFineFee;
    }
}
