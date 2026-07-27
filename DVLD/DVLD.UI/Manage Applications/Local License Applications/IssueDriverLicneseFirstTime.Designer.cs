using DVLD.UI.Common_Forms.UserForms;

namespace DVLD.UI.Manage_Applications
{
    partial class IssueDriverLicenseFirstTime
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
            uc_ApplicationBasicInfo1 = new uc_ApplicationBasicInfo();
            uc_DrivingLicenseApplicationInfo1 = new uc_DrivingLicenseApplicationInfo();
            txtNotes = new TextBox();
            lblNotes = new Label();
            btnIssue = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // uc_ApplicationBasicInfo1
            // 
            uc_ApplicationBasicInfo1.Location = new Point(0, 0);
            uc_ApplicationBasicInfo1.Name = "uc_ApplicationBasicInfo1";
            uc_ApplicationBasicInfo1.Size = new Size(1000, 200);
            uc_ApplicationBasicInfo1.TabIndex = 0;
            // 
            // uc_DrivingLicenseApplicationInfo1
            // 
            uc_DrivingLicenseApplicationInfo1.Location = new Point(0, 0);
            uc_DrivingLicenseApplicationInfo1.Name = "uc_DrivingLicenseApplicationInfo1";
            uc_DrivingLicenseApplicationInfo1.Size = new Size(1000, 100);
            uc_DrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(149, 342);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(854, 169);
            txtNotes.TabIndex = 0;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotes.Location = new Point(75, 338);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(68, 28);
            lblNotes.TabIndex = 1;
            lblNotes.Text = "Notes";
            // 
            // btnIssue
            // 
            btnIssue.Location = new Point(809, 517);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(94, 29);
            btnIssue.TabIndex = 2;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(909, 517);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // IssueDriverLicenseFirstTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 553);
            Controls.Add(btnClose);
            Controls.Add(btnIssue);
            Controls.Add(lblNotes);
            Controls.Add(txtNotes);
            Name = "IssueDriverLicenseFirstTime";
            Text = "IssueDriverLicenseFirstTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Common_Forms.UserForms.uc_DrivingLicenseApplicationInfo uc_DrivingLicenseApplicationInfo1;
        private Common_Forms.UserForms.uc_ApplicationBasicInfo uc_ApplicationBasicInfo1;
        private TextBox txtNotes;
        private Label lblNotes;
        private Button btnIssue;
        private Button btnClose;
    }
}