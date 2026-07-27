namespace DVLD.UI.Manage_Applications.International_License_Applications
{
    partial class InternationalDrivingLicenseApplications
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
            cmsInternationalLicenseApplications = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            btn_Add = new Button();
            btn_Close = new Button();
            lbl_Records = new Label();
            lbl_NumberOfRecords = new Label();
            lbl_FilterBy = new Label();
            cb_WhatToFilterBy = new ComboBox();
            txt_FilterValue = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Applications).BeginInit();
            cmsInternationalLicenseApplications.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(211, 42);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(566, 38);
            lbl_Title.TabIndex = 1;
            lbl_Title.Text = "International Driving License Applications";
            // 
            // dgv_Applications
            // 
            dgv_Applications.AllowUserToAddRows = false;
            dgv_Applications.AllowUserToDeleteRows = false;
            dgv_Applications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_Applications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Applications.ContextMenuStrip = cmsInternationalLicenseApplications;
            dgv_Applications.Location = new Point(12, 134);
            dgv_Applications.Name = "dgv_Applications";
            dgv_Applications.ReadOnly = true;
            dgv_Applications.RowHeadersWidth = 51;
            dgv_Applications.Size = new Size(964, 269);
            dgv_Applications.TabIndex = 2;
            // 
            // cmsInternationalLicenseApplications
            // 
            cmsInternationalLicenseApplications.ImageScalingSize = new Size(20, 20);
            cmsInternationalLicenseApplications.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem });
            cmsInternationalLicenseApplications.Name = "cms_localLicenseApplications";
            cmsInternationalLicenseApplications.ShowImageMargin = false;
            cmsInternationalLicenseApplications.Size = new Size(236, 76);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(235, 24);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(235, 24);
            showLicenseToolStripMenuItem.Text = "Show license";
            showLicenseToolStripMenuItem.Click += showLicenseToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(235, 24);
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
            cb_WhatToFilterBy.Items.AddRange(new object[] { "None", "Inter. License ID", "Application ID", "Driver ID", "Local License ID" });
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
            // InternationalDrivingLicenseApplications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Close;
            ClientSize = new Size(988, 450);
            ControlBox = false;
            Controls.Add(txt_FilterValue);
            Controls.Add(btn_Close);
            Controls.Add(btn_Add);
            Controls.Add(dgv_Applications);
            Controls.Add(lbl_Title);
            Controls.Add(lbl_Records);
            Controls.Add(lbl_NumberOfRecords);
            Controls.Add(lbl_FilterBy);
            Controls.Add(cb_WhatToFilterBy);
            Name = "InternationalDrivingLicenseApplications";
            Text = "International Driving License Applications";
            ((System.ComponentModel.ISupportInitialize)dgv_Applications).EndInit();
            cmsInternationalLicenseApplications.ResumeLayout(false);
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
        private ContextMenuStrip cmsInternationalLicenseApplications;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
    }
}