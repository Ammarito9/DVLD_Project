namespace DVLD.UI.Manage_Applications
{
    partial class LocalDrivingLicenseApplicationsForm
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
            components = new System.ComponentModel.Container();
            lbl_Title = new Label();
            dgv_Applications = new DataGridView();
            cms_localLicenseApplications = new ContextMenuStrip(components);
            showApplicationDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            editApplicationToolStripMenuItem = new ToolStripMenuItem();
            deleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            cancelApplicationToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            scheduleTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleVisionTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleWrittenTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleStreetTestToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            issueDrivingLicenseFirsttimeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            showLicneseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            btn_Add = new Button();
            btn_Close = new Button();
            lbl_Records = new Label();
            lbl_NumberOfRecords = new Label();
            lbl_FilterBy = new Label();
            cb_WhatToFilterBy = new ComboBox();
            txt_FilterValue = new TextBox();
            cb_StatusFilterValue = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Applications).BeginInit();
            cms_localLicenseApplications.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(263, 42);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(462, 38);
            lbl_Title.TabIndex = 1;
            lbl_Title.Text = "Local Driving License Applications";
            // 
            // dgv_Applications
            // 
            dgv_Applications.AllowUserToAddRows = false;
            dgv_Applications.AllowUserToDeleteRows = false;
            dgv_Applications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Applications.ContextMenuStrip = cms_localLicenseApplications;
            dgv_Applications.Location = new Point(12, 134);
            dgv_Applications.Name = "dgv_Applications";
            dgv_Applications.ReadOnly = true;
            dgv_Applications.RowHeadersWidth = 51;
            dgv_Applications.Size = new Size(964, 269);
            dgv_Applications.TabIndex = 2;
            // 
            // cms_localLicenseApplications
            // 
            cms_localLicenseApplications.ImageScalingSize = new Size(20, 20);
            cms_localLicenseApplications.Items.AddRange(new ToolStripItem[] { showApplicationDetailsToolStripMenuItem, toolStripSeparator1, editApplicationToolStripMenuItem, deleteApplicationToolStripMenuItem, toolStripSeparator2, cancelApplicationToolStripMenuItem, toolStripSeparator3, scheduleTestToolStripMenuItem, toolStripSeparator4, issueDrivingLicenseFirsttimeToolStripMenuItem, toolStripSeparator5, showLicneseToolStripMenuItem, toolStripSeparator6, showPersonLicenseHistoryToolStripMenuItem });
            cms_localLicenseApplications.Name = "cms_localLicenseApplications";
            cms_localLicenseApplications.ShowImageMargin = false;
            cms_localLicenseApplications.Size = new Size(262, 232);
            cms_localLicenseApplications.Opening += cms_localLicenseApplications_Opening;
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            showApplicationDetailsToolStripMenuItem.Size = new Size(261, 24);
            showApplicationDetailsToolStripMenuItem.Text = "Show application details";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(258, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            editApplicationToolStripMenuItem.Size = new Size(261, 24);
            editApplicationToolStripMenuItem.Text = "Edit application";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            deleteApplicationToolStripMenuItem.Size = new Size(261, 24);
            deleteApplicationToolStripMenuItem.Text = "Delete application";
            deleteApplicationToolStripMenuItem.Click += deleteApplicationToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(258, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            cancelApplicationToolStripMenuItem.Size = new Size(261, 24);
            cancelApplicationToolStripMenuItem.Text = "Cancel application";
            cancelApplicationToolStripMenuItem.Click += cancelApplicationToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(258, 6);
            // 
            // scheduleTestToolStripMenuItem
            // 
            scheduleTestToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scheduleVisionTestToolStripMenuItem, scheduleWrittenTestToolStripMenuItem, scheduleStreetTestToolStripMenuItem });
            scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            scheduleTestToolStripMenuItem.Size = new Size(261, 24);
            scheduleTestToolStripMenuItem.Text = "Sechdule Test";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            scheduleVisionTestToolStripMenuItem.Enabled = false;
            scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            scheduleVisionTestToolStripMenuItem.Size = new Size(230, 26);
            scheduleVisionTestToolStripMenuItem.Text = "Schedule vision test";
            scheduleVisionTestToolStripMenuItem.Click += scheduleVisionTestToolStripMenuItem_Click;
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            scheduleWrittenTestToolStripMenuItem.Enabled = false;
            scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            scheduleWrittenTestToolStripMenuItem.Size = new Size(230, 26);
            scheduleWrittenTestToolStripMenuItem.Text = "Schedule written test";
            scheduleWrittenTestToolStripMenuItem.Click += scheduleWrittenTestToolStripMenuItem_Click;
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            scheduleStreetTestToolStripMenuItem.Enabled = false;
            scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            scheduleStreetTestToolStripMenuItem.Size = new Size(230, 26);
            scheduleStreetTestToolStripMenuItem.Text = "Schedule street test";
            scheduleStreetTestToolStripMenuItem.Click += scheduleStreetTestToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(258, 6);
            // 
            // issueDrivingLicenseFirsttimeToolStripMenuItem
            // 
            issueDrivingLicenseFirsttimeToolStripMenuItem.Enabled = false;
            issueDrivingLicenseFirsttimeToolStripMenuItem.Name = "issueDrivingLicenseFirsttimeToolStripMenuItem";
            issueDrivingLicenseFirsttimeToolStripMenuItem.Size = new Size(261, 24);
            issueDrivingLicenseFirsttimeToolStripMenuItem.Text = "Issue driving license (First-time)";
            issueDrivingLicenseFirsttimeToolStripMenuItem.Click += issueDrivingLicenseFirsttimeToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(258, 6);
            // 
            // showLicneseToolStripMenuItem
            // 
            showLicneseToolStripMenuItem.Enabled = false;
            showLicneseToolStripMenuItem.Name = "showLicneseToolStripMenuItem";
            showLicneseToolStripMenuItem.Size = new Size(261, 24);
            showLicneseToolStripMenuItem.Text = "Show license";
            showLicneseToolStripMenuItem.Click += showLicneseToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(258, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(261, 24);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show person license history";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(882, 99);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 29);
            btn_Add.TabIndex = 3;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(882, 409);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(94, 29);
            btn_Close.TabIndex = 4;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // lbl_Records
            // 
            lbl_Records.AutoSize = true;
            lbl_Records.Font = new Font("Segoe UI", 9F);
            lbl_Records.Location = new Point(12, 413);
            lbl_Records.Name = "lbl_Records";
            lbl_Records.Size = new Size(134, 20);
            lbl_Records.TabIndex = 6;
            lbl_Records.Text = "Number of records";
            // 
            // lbl_NumberOfRecords
            // 
            lbl_NumberOfRecords.AutoSize = true;
            lbl_NumberOfRecords.Font = new Font("Segoe UI", 9F);
            lbl_NumberOfRecords.Location = new Point(152, 413);
            lbl_NumberOfRecords.Name = "lbl_NumberOfRecords";
            lbl_NumberOfRecords.Size = new Size(25, 20);
            lbl_NumberOfRecords.TabIndex = 7;
            lbl_NumberOfRecords.Text = "00";
            // 
            // lbl_FilterBy
            // 
            lbl_FilterBy.AutoSize = true;
            lbl_FilterBy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FilterBy.Location = new Point(12, 99);
            lbl_FilterBy.Name = "lbl_FilterBy";
            lbl_FilterBy.Size = new Size(85, 28);
            lbl_FilterBy.TabIndex = 3;
            lbl_FilterBy.Text = "Filter By";
            // 
            // cb_WhatToFilterBy
            // 
            cb_WhatToFilterBy.FormattingEnabled = true;
            cb_WhatToFilterBy.Items.AddRange(new object[] { "None", "L.D.L Application ID", "National Num.", "Full name", "Status" });
            cb_WhatToFilterBy.Location = new Point(103, 100);
            cb_WhatToFilterBy.Name = "cb_WhatToFilterBy";
            cb_WhatToFilterBy.Size = new Size(216, 28);
            cb_WhatToFilterBy.TabIndex = 2;
            cb_WhatToFilterBy.SelectedIndexChanged += cb_WhatToFilterBy_SelectedIndexChanged;
            // 
            // txt_FilterValue
            // 
            txt_FilterValue.Location = new Point(325, 100);
            txt_FilterValue.Name = "txt_FilterValue";
            txt_FilterValue.Size = new Size(214, 27);
            txt_FilterValue.TabIndex = 8;
            txt_FilterValue.TextChanged += txt_FilterValue_TextChanged;
            // 
            // cb_StatusFilterValue
            // 
            cb_StatusFilterValue.FormattingEnabled = true;
            cb_StatusFilterValue.Location = new Point(325, 99);
            cb_StatusFilterValue.Name = "cb_StatusFilterValue";
            cb_StatusFilterValue.Size = new Size(178, 28);
            cb_StatusFilterValue.TabIndex = 9;
            cb_StatusFilterValue.SelectedIndexChanged += cb_StatusFilterValue_SelectedIndexChanged;
            // 
            // LocalDrivingLicenseApplicationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Close;
            ClientSize = new Size(988, 450);
            ControlBox = false;
            Controls.Add(cb_StatusFilterValue);
            Controls.Add(txt_FilterValue);
            Controls.Add(btn_Close);
            Controls.Add(btn_Add);
            Controls.Add(dgv_Applications);
            Controls.Add(lbl_Title);
            Controls.Add(lbl_Records);
            Controls.Add(lbl_NumberOfRecords);
            Controls.Add(lbl_FilterBy);
            Controls.Add(cb_WhatToFilterBy);
            Name = "LocalDrivingLicenseApplicationsForm";
            Text = "Local Driving License Applications";
            ((System.ComponentModel.ISupportInitialize)dgv_Applications).EndInit();
            cms_localLicenseApplications.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title;
        private DataGridView dgv_Applications;
        private Button btn_Add;
        private Button btn_Close;
        private Label lbl_Records;
        private Label lbl_NumberOfRecords;
        private Label lbl_FilterBy;
        private ComboBox cb_WhatToFilterBy;
        private TextBox txt_FilterValue;
        private ContextMenuStrip cms_localLicenseApplications;
        private ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem editApplicationToolStripMenuItem;
        private ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem scheduleTestToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem issueDrivingLicenseFirsttimeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem showLicneseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private ComboBox cb_StatusFilterValue;
    }
}