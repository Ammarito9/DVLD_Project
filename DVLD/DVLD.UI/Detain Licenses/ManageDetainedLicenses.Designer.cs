namespace DVLD.UI.Detain_Licenses
{
    partial class ManageDetainedLicenses
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
            btnDetain = new Button();
            lblTitle = new Label();
            cbWhatToFilterBy = new ComboBox();
            lblFilterBy = new Label();
            dgvDetainedLicenses = new DataGridView();
            cmsDetainedLicenseOperation = new ContextMenuStrip(components);
            showPersonInfoToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailesToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            btnClose = new Button();
            lblRecords = new Label();
            lblNumberOfRecords = new Label();
            txtFilterBy = new TextBox();
            btnRelease = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetainedLicenses).BeginInit();
            cmsDetainedLicenseOperation.SuspendLayout();
            SuspendLayout();
            // 
            // btnDetain
            // 
            btnDetain.Location = new Point(1306, 114);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(94, 29);
            btnDetain.TabIndex = 0;
            btnDetain.Text = "Detain";
            btnDetain.UseVisualStyleBackColor = true;
            btnDetain.Click += btnDetain_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(519, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(364, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Manage Detained Licenses";
            // 
            // cbWhatToFilterBy
            // 
            cbWhatToFilterBy.FormattingEnabled = true;
            cbWhatToFilterBy.Items.AddRange(new object[] { "None", "Detain ID", "Is Released", "National Number", "FullName", "Release Application ID" });
            cbWhatToFilterBy.Location = new Point(104, 118);
            cbWhatToFilterBy.Name = "cbWhatToFilterBy";
            cbWhatToFilterBy.Size = new Size(210, 28);
            cbWhatToFilterBy.TabIndex = 2;
            cbWhatToFilterBy.SelectedIndexChanged += cbWhatToFilterBy_SelectedIndexChanged;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterBy.Location = new Point(12, 118);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(86, 28);
            lblFilterBy.TabIndex = 3;
            lblFilterBy.Text = "FIlter By";
            // 
            // dgvDetainedLicenses
            // 
            dgvDetainedLicenses.AllowUserToAddRows = false;
            dgvDetainedLicenses.AllowUserToDeleteRows = false;
            dgvDetainedLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDetainedLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetainedLicenses.ContextMenuStrip = cmsDetainedLicenseOperation;
            dgvDetainedLicenses.Location = new Point(12, 153);
            dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            dgvDetainedLicenses.ReadOnly = true;
            dgvDetainedLicenses.RowHeadersWidth = 51;
            dgvDetainedLicenses.Size = new Size(1388, 349);
            dgvDetainedLicenses.TabIndex = 4;
            // 
            // cmsDetainedLicenseOperation
            // 
            cmsDetainedLicenseOperation.ImageScalingSize = new Size(20, 20);
            cmsDetainedLicenseOperation.Items.AddRange(new ToolStripItem[] { showPersonInfoToolStripMenuItem, showLicenseDetailesToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem, toolStripSeparator1, releaseDetainedLicenseToolStripMenuItem });
            cmsDetainedLicenseOperation.Name = "cmsPeopleData";
            cmsDetainedLicenseOperation.Size = new Size(265, 134);
            cmsDetainedLicenseOperation.Opening += cmsDetainedLicenseOperation_Opening;
            // 
            // showPersonInfoToolStripMenuItem
            // 
            showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            showPersonInfoToolStripMenuItem.Size = new Size(264, 24);
            showPersonInfoToolStripMenuItem.Text = "Show Person Info";
            showPersonInfoToolStripMenuItem.Click += showPersonInfoToolStripMenuItem_Click;
            // 
            // showLicenseDetailesToolStripMenuItem
            // 
            showLicenseDetailesToolStripMenuItem.Name = "showLicenseDetailesToolStripMenuItem";
            showLicenseDetailesToolStripMenuItem.Size = new Size(264, 24);
            showLicenseDetailesToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailesToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(264, 24);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(261, 6);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.Enabled = false;
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(264, 24);
            releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            releaseDetainedLicenseToolStripMenuItem.Click += releaseDetainedLicenseToolStripMenuItem_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1306, 508);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 9F);
            lblRecords.Location = new Point(12, 512);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(134, 20);
            lblRecords.TabIndex = 6;
            lblRecords.Text = "Number of records";
            // 
            // lblNumberOfRecords
            // 
            lblNumberOfRecords.AutoSize = true;
            lblNumberOfRecords.Font = new Font("Segoe UI", 9F);
            lblNumberOfRecords.Location = new Point(152, 512);
            lblNumberOfRecords.Name = "lblNumberOfRecords";
            lblNumberOfRecords.Size = new Size(25, 20);
            lblNumberOfRecords.TabIndex = 7;
            lblNumberOfRecords.Text = "00";
            // 
            // txtFilterBy
            // 
            txtFilterBy.Location = new Point(320, 118);
            txtFilterBy.Name = "txtFilterBy";
            txtFilterBy.Size = new Size(207, 27);
            txtFilterBy.TabIndex = 9;
            txtFilterBy.Visible = false;
            txtFilterBy.TextChanged += txtFilterBy_TextChanged;
            // 
            // btnRelease
            // 
            btnRelease.Location = new Point(1206, 114);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(94, 29);
            btnRelease.TabIndex = 10;
            btnRelease.Text = "Release";
            btnRelease.UseVisualStyleBackColor = true;
            btnRelease.Click += btnRelease_Click;
            // 
            // ManageDetainedLicenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1404, 539);
            ControlBox = false;
            Controls.Add(btnRelease);
            Controls.Add(lblNumberOfRecords);
            Controls.Add(lblRecords);
            Controls.Add(btnClose);
            Controls.Add(dgvDetainedLicenses);
            Controls.Add(lblFilterBy);
            Controls.Add(cbWhatToFilterBy);
            Controls.Add(lblTitle);
            Controls.Add(btnDetain);
            Controls.Add(txtFilterBy);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ManageDetainedLicenses";
            ShowIcon = false;
            Text = "Manage Detained Licenses";
            ((System.ComponentModel.ISupportInitialize)dgvDetainedLicenses).EndInit();
            cmsDetainedLicenseOperation.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDetain;
        private Label lblTitle;
        private ComboBox cbWhatToFilterBy;
        private Label lblFilterBy;
        private DataGridView dgvDetainedLicenses;
        private Button btnClose;
        private Label lblRecords;
        private Label lblNumberOfRecords;
        private TextBox txtFilterBy;
        private ContextMenuStrip cmsDetainedLicenseOperation;
        private Button btnRelease;
        private ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailesToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}