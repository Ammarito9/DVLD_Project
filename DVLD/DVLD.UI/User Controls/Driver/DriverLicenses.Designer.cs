namespace DVLD.UI.User_Controls.Driver
{
    partial class DriverLicenses
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
            components = new System.ComponentModel.Container();
            gbDriverLicenses = new GroupBox();
            lblNumberOfRecordsValue = new Label();
            tabControl1 = new TabControl();
            tpLocal = new TabPage();
            dgvLocalLicenses = new DataGridView();
            cmsShowLocalLicense = new ContextMenuStrip(components);
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            tbInternational = new TabPage();
            dgvInternationalLicenses = new DataGridView();
            lblInternationalLicenseHistory = new Label();
            lblNumberOfRecords = new Label();
            gbDriverLicenses.SuspendLayout();
            tabControl1.SuspendLayout();
            tpLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicenses).BeginInit();
            cmsShowLocalLicense.SuspendLayout();
            tbInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).BeginInit();
            SuspendLayout();
            // 
            // gbDriverLicenses
            // 
            gbDriverLicenses.Controls.Add(lblNumberOfRecordsValue);
            gbDriverLicenses.Controls.Add(tabControl1);
            gbDriverLicenses.Controls.Add(lblNumberOfRecords);
            gbDriverLicenses.Dock = DockStyle.Fill;
            gbDriverLicenses.Location = new Point(0, 0);
            gbDriverLicenses.Name = "gbDriverLicenses";
            gbDriverLicenses.Size = new Size(1000, 350);
            gbDriverLicenses.TabIndex = 0;
            gbDriverLicenses.TabStop = false;
            gbDriverLicenses.Text = "Driver Licenses";
            // 
            // lblNumberOfRecordsValue
            // 
            lblNumberOfRecordsValue.AutoSize = true;
            lblNumberOfRecordsValue.Font = new Font("Segoe UI", 12F);
            lblNumberOfRecordsValue.Location = new Point(118, 306);
            lblNumberOfRecordsValue.Name = "lblNumberOfRecordsValue";
            lblNumberOfRecordsValue.Size = new Size(34, 28);
            lblNumberOfRecordsValue.TabIndex = 1;
            lblNumberOfRecordsValue.Text = "00";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpLocal);
            tabControl1.Controls.Add(tbInternational);
            tabControl1.Location = new Point(3, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(994, 268);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tpLocal
            // 
            tpLocal.Controls.Add(dgvLocalLicenses);
            tpLocal.Controls.Add(label1);
            tpLocal.Location = new Point(4, 29);
            tpLocal.Name = "tpLocal";
            tpLocal.Padding = new Padding(3);
            tpLocal.Size = new Size(986, 235);
            tpLocal.TabIndex = 0;
            tpLocal.Text = "Local";
            tpLocal.UseVisualStyleBackColor = true;
            // 
            // dgvLocalLicenses
            // 
            dgvLocalLicenses.AllowUserToAddRows = false;
            dgvLocalLicenses.AllowUserToDeleteRows = false;
            dgvLocalLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLocalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalLicenses.ContextMenuStrip = cmsShowLocalLicense;
            dgvLocalLicenses.Location = new Point(6, 45);
            dgvLocalLicenses.Name = "dgvLocalLicenses";
            dgvLocalLicenses.ReadOnly = true;
            dgvLocalLicenses.RowHeadersWidth = 51;
            dgvLocalLicenses.Size = new Size(974, 184);
            dgvLocalLicenses.TabIndex = 2;
            // 
            // cmsShowLocalLicense
            // 
            cmsShowLocalLicense.ImageScalingSize = new Size(20, 20);
            cmsShowLocalLicense.Items.AddRange(new ToolStripItem[] { showLicenseToolStripMenuItem });
            cmsShowLocalLicense.Name = "cmsShowLicense";
            cmsShowLocalLicense.Size = new Size(211, 56);
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(210, 24);
            showLicenseToolStripMenuItem.Text = "Show License";
            showLicenseToolStripMenuItem.Click += showLicenseToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(212, 28);
            label1.TabIndex = 1;
            label1.Text = "Local License History";
            // 
            // tbInternational
            // 
            tbInternational.Controls.Add(dgvInternationalLicenses);
            tbInternational.Controls.Add(lblInternationalLicenseHistory);
            tbInternational.Location = new Point(4, 29);
            tbInternational.Name = "tbInternational";
            tbInternational.Padding = new Padding(3);
            tbInternational.Size = new Size(986, 235);
            tbInternational.TabIndex = 1;
            tbInternational.Text = "International";
            tbInternational.UseVisualStyleBackColor = true;
            // 
            // dgvInternationalLicenses
            // 
            dgvInternationalLicenses.AllowUserToAddRows = false;
            dgvInternationalLicenses.AllowUserToDeleteRows = false;
            dgvInternationalLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInternationalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternationalLicenses.ContextMenuStrip = cmsShowLocalLicense;
            dgvInternationalLicenses.Location = new Point(6, 45);
            dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            dgvInternationalLicenses.ReadOnly = true;
            dgvInternationalLicenses.RowHeadersWidth = 51;
            dgvInternationalLicenses.Size = new Size(974, 184);
            dgvInternationalLicenses.TabIndex = 1;
            // 
            // lblInternationalLicenseHistory
            // 
            lblInternationalLicenseHistory.AutoSize = true;
            lblInternationalLicenseHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInternationalLicenseHistory.Location = new Point(6, 14);
            lblInternationalLicenseHistory.Name = "lblInternationalLicenseHistory";
            lblInternationalLicenseHistory.Size = new Size(286, 28);
            lblInternationalLicenseHistory.TabIndex = 0;
            lblInternationalLicenseHistory.Text = "International License History";
            // 
            // lblNumberOfRecords
            // 
            lblNumberOfRecords.AutoSize = true;
            lblNumberOfRecords.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberOfRecords.Location = new Point(7, 306);
            lblNumberOfRecords.Name = "lblNumberOfRecords";
            lblNumberOfRecords.Size = new Size(105, 28);
            lblNumberOfRecords.TabIndex = 0;
            lblNumberOfRecords.Text = "# Records";
            // 
            // DriverLicenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbDriverLicenses);
            Name = "DriverLicenses";
            Size = new Size(1000, 350);
            gbDriverLicenses.ResumeLayout(false);
            gbDriverLicenses.PerformLayout();
            tabControl1.ResumeLayout(false);
            tpLocal.ResumeLayout(false);
            tpLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicenses).EndInit();
            cmsShowLocalLicense.ResumeLayout(false);
            tbInternational.ResumeLayout(false);
            tbInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDriverLicenses;
        private TabControl tabControl1;
        private TabPage tpLocal;
        private Label lblNumberOfRecords;
        private TabPage tbInternational;
        private Label lblNumberOfRecordsValue;
        private Label lblInternationalLicenseHistory;
        private Label label1;
        private DataGridView dgvLocalLicenses;
        private DataGridView dgvInternationalLicenses;
        private ContextMenuStrip cmsShowLocalLicense;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
    }
}
