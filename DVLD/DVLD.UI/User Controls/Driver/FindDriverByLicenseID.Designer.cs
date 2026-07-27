namespace DVLD.UI.User_Controls.Driver
{
    partial class FindDriverByLicenseID
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
            gbFilter = new GroupBox();
            btnSearch = new Button();
            txtLicenseIDValue = new TextBox();
            lblLicenseID = new Label();
            driverLicenseInfo1 = new DriverLicenseInfo();
            gbFilter.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(427, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtLicenseIDValue
            // 
            txtLicenseIDValue.Location = new Point(120, 38);
            txtLicenseIDValue.Name = "txtLicenseIDValue";
            txtLicenseIDValue.Size = new Size(271, 27);
            txtLicenseIDValue.TabIndex = 1;
            // 
            // lblLicenseID
            // 
            lblLicenseID.AutoSize = true;
            lblLicenseID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicenseID.Location = new Point(6, 37);
            lblLicenseID.Name = "lblLicenseID";
            lblLicenseID.Size = new Size(108, 28);
            lblLicenseID.TabIndex = 0;
            lblLicenseID.Text = "License ID";
            // 
            // driverLicenseInfo1
            // 
            driverLicenseInfo1.Dock = DockStyle.Bottom;
            driverLicenseInfo1.Location = new Point(0, 101);
            driverLicenseInfo1.Name = "driverLicenseInfo1";
            driverLicenseInfo1.Size = new Size(1129, 489);
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnSearch);
            gbFilter.Controls.Add(txtLicenseIDValue);
            gbFilter.Controls.Add(lblLicenseID);
            gbFilter.Dock = DockStyle.Top;
            gbFilter.Location = new Point(0, 0);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(1129, 91);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // FindDriverByLicenseID
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(driverLicenseInfo1);
            Controls.Add(gbFilter);
            Name = "FindDriverByLicenseID";
            Size = new Size(1129, 590);
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DriverLicenseInfo driverLicenseInfo1;
        private GroupBox gbFilter;
        private Button btnSearch;
        private TextBox txtLicenseIDValue;
        private Label lblLicenseID;
    }
}
