namespace DVLD.UI.Main_Forms
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            applicationsToolStripMenuItem = new ToolStripMenuItem();
            drivingLicensesServicesToolStripMenuItem = new ToolStripMenuItem();
            newDeivingLicensesToolStripMenuItem = new ToolStripMenuItem();
            localLicenseToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseToolStripMenuItem = new ToolStripMenuItem();
            renewDrivingLicensesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            replacmentToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            releseDetainedDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            retakeTestToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationsToolStripMenuItem = new ToolStripMenuItem();
            localLicenseApplicationsToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseApplicationsToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem = new ToolStripMenuItem();
            manToolStripMenuItem = new ToolStripMenuItem();
            manageTestTypesToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            currentUserInfoToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            manageDetainedLicensesToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem1 = new ToolStripMenuItem();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { applicationsToolStripMenuItem, peopleToolStripMenuItem, driversToolStripMenuItem, usersToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(788, 48);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // applicationsToolStripMenuItem
            // 
            applicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drivingLicensesServicesToolStripMenuItem, manageApplicationsToolStripMenuItem, detainLicenseToolStripMenuItem, manToolStripMenuItem, manageTestTypesToolStripMenuItem });
            applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            applicationsToolStripMenuItem.Size = new Size(144, 44);
            applicationsToolStripMenuItem.Text = "Applications";
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDeivingLicensesToolStripMenuItem, renewDrivingLicensesToolStripMenuItem, toolStripSeparator2, replacmentToolStripMenuItem, toolStripSeparator3, releseDetainedDrivingLicenseToolStripMenuItem, retakeTestToolStripMenuItem });
            drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            drivingLicensesServicesToolStripMenuItem.Size = new Size(343, 32);
            drivingLicensesServicesToolStripMenuItem.Text = "Driving licenses services";
            // 
            // newDeivingLicensesToolStripMenuItem
            // 
            newDeivingLicensesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localLicenseToolStripMenuItem, internationalLicenseToolStripMenuItem });
            newDeivingLicensesToolStripMenuItem.Name = "newDeivingLicensesToolStripMenuItem";
            newDeivingLicensesToolStripMenuItem.Size = new Size(497, 32);
            newDeivingLicensesToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            localLicenseToolStripMenuItem.Size = new Size(296, 32);
            localLicenseToolStripMenuItem.Text = "Local License";
            localLicenseToolStripMenuItem.Click += localLicenseToolStripMenuItem_Click;
            // 
            // internationalLicenseToolStripMenuItem
            // 
            internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            internationalLicenseToolStripMenuItem.Size = new Size(296, 32);
            internationalLicenseToolStripMenuItem.Text = "International License";
            internationalLicenseToolStripMenuItem.Click += internationalLicenseToolStripMenuItem_Click;
            // 
            // renewDrivingLicensesToolStripMenuItem
            // 
            renewDrivingLicensesToolStripMenuItem.Name = "renewDrivingLicensesToolStripMenuItem";
            renewDrivingLicensesToolStripMenuItem.Size = new Size(497, 32);
            renewDrivingLicensesToolStripMenuItem.Text = "Renew Driving License";
            renewDrivingLicensesToolStripMenuItem.Click += renewDrivingLicensesToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(494, 6);
            // 
            // replacmentToolStripMenuItem
            // 
            replacmentToolStripMenuItem.Name = "replacmentToolStripMenuItem";
            replacmentToolStripMenuItem.Size = new Size(497, 32);
            replacmentToolStripMenuItem.Text = "Replacement for Lost or Damaged License";
            replacmentToolStripMenuItem.Click += replacementToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(494, 6);
            // 
            // releseDetainedDrivingLicenseToolStripMenuItem
            // 
            releseDetainedDrivingLicenseToolStripMenuItem.Name = "releseDetainedDrivingLicenseToolStripMenuItem";
            releseDetainedDrivingLicenseToolStripMenuItem.Size = new Size(497, 32);
            releseDetainedDrivingLicenseToolStripMenuItem.Text = "Relese Detained Driving License";
            // 
            // retakeTestToolStripMenuItem
            // 
            retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            retakeTestToolStripMenuItem.Size = new Size(497, 32);
            retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // manageApplicationsToolStripMenuItem
            // 
            manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localLicenseApplicationsToolStripMenuItem, internationalLicenseApplicationsToolStripMenuItem });
            manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            manageApplicationsToolStripMenuItem.Size = new Size(343, 32);
            manageApplicationsToolStripMenuItem.Text = "Manage applications";
            // 
            // localLicenseApplicationsToolStripMenuItem
            // 
            localLicenseApplicationsToolStripMenuItem.Name = "localLicenseApplicationsToolStripMenuItem";
            localLicenseApplicationsToolStripMenuItem.Size = new Size(420, 32);
            localLicenseApplicationsToolStripMenuItem.Text = "Local License Applications";
            localLicenseApplicationsToolStripMenuItem.Click += localLicenseApplicationsToolStripMenuItem_Click;
            // 
            // internationalLicenseApplicationsToolStripMenuItem
            // 
            internationalLicenseApplicationsToolStripMenuItem.Name = "internationalLicenseApplicationsToolStripMenuItem";
            internationalLicenseApplicationsToolStripMenuItem.Size = new Size(420, 32);
            internationalLicenseApplicationsToolStripMenuItem.Text = "International License Applications";
            internationalLicenseApplicationsToolStripMenuItem.Click += internationalLicenseApplicationsToolStripMenuItem_Click;
            // 
            // detainLicenseToolStripMenuItem
            // 
            detainLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageDetainedLicensesToolStripMenuItem, detainLicenseToolStripMenuItem1, releaseDetainedLicenseToolStripMenuItem });
            detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            detainLicenseToolStripMenuItem.Size = new Size(343, 32);
            detainLicenseToolStripMenuItem.Text = "Detain license";
            // 
            // manToolStripMenuItem
            // 
            manToolStripMenuItem.Name = "manToolStripMenuItem";
            manToolStripMenuItem.Size = new Size(343, 32);
            manToolStripMenuItem.Text = "Manage application types";
            manToolStripMenuItem.Click += manToolStripMenuItem_Click;
            // 
            // manageTestTypesToolStripMenuItem
            // 
            manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            manageTestTypesToolStripMenuItem.Size = new Size(343, 32);
            manageTestTypesToolStripMenuItem.Text = "Manage test types";
            manageTestTypesToolStripMenuItem.Click += manageTestTypesToolStripMenuItem_Click;
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.Image = Properties.Resources.Businessman;
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(129, 44);
            peopleToolStripMenuItem.Text = "People";
            peopleToolStripMenuItem.Click += peopleToolStripMenuItem_Click;
            // 
            // driversToolStripMenuItem
            // 
            driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            driversToolStripMenuItem.Size = new Size(94, 44);
            driversToolStripMenuItem.Text = "Drivers";
            driversToolStripMenuItem.Click += driversToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(77, 44);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentUserInfoToolStripMenuItem, changePasswordToolStripMenuItem, toolStripSeparator1, signOutToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(103, 44);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            currentUserInfoToolStripMenuItem.Size = new Size(263, 32);
            currentUserInfoToolStripMenuItem.Text = "Current User Info";
            currentUserInfoToolStripMenuItem.Click += currentUserInfoToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(263, 32);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(260, 6);
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(263, 32);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            manageDetainedLicensesToolStripMenuItem.Size = new Size(350, 32);
            manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            manageDetainedLicensesToolStripMenuItem.Click += manageDetainedLicensesToolStripMenuItem_Click;
            // 
            // detainLicenseToolStripMenuItem1
            // 
            detainLicenseToolStripMenuItem1.Name = "detainLicenseToolStripMenuItem1";
            detainLicenseToolStripMenuItem1.Size = new Size(350, 32);
            detainLicenseToolStripMenuItem1.Text = "Detain License";
            detainLicenseToolStripMenuItem1.Click += detainLicenseToolStripMenuItem1_Click;
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(350, 32);
            releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            releaseDetainedLicenseToolStripMenuItem.Click += releaseDetainedLicenseToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 438);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem driversToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private ToolStripMenuItem detainLicenseToolStripMenuItem;
        private ToolStripMenuItem manToolStripMenuItem;
        private ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private ToolStripMenuItem newDeivingLicensesToolStripMenuItem;
        private ToolStripMenuItem localLicenseToolStripMenuItem;
        private ToolStripMenuItem renewDrivingLicensesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem replacmentToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem releseDetainedDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem retakeTestToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private ToolStripMenuItem localLicenseApplicationsToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseApplicationsToolStripMenuItem;
        private ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private ToolStripMenuItem detainLicenseToolStripMenuItem1;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}