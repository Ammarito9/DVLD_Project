using DVLD.BLL.Entities;

namespace DVLD.UI.Manage_Applications
{
    partial class LicenseInfo
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
            btnClose = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1046, 639);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(391, 44);
            label1.Name = "label1";
            label1.Size = new Size(374, 54);
            label1.TabIndex = 2;
            label1.Text = "Driver License Info";
            // 
            // LicenseInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 680);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Name = "LicenseInfo";
            Text = "LicenseInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private User_Controls.Driver.DriverLicenseInfo driverLicenseInfo1;
        private Button btnClose;
        private Label label1;
    }
}