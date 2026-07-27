namespace DVLD.UI.Main_Forms
{
    partial class ManageDrivers
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
            dgvDrivers = new DataGridView();
            lblManageDrivers = new Label();
            lblNumberOfRecords = new Label();
            lblFilter = new Label();
            lblNumberOfRecordsValue = new Label();
            btnClose = new Button();
            cbFilter = new ComboBox();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            SuspendLayout();
            // 
            // dgvDrivers
            // 
            dgvDrivers.AllowUserToAddRows = false;
            dgvDrivers.AllowUserToDeleteRows = false;
            dgvDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.Location = new Point(8, 163);
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.ReadOnly = true;
            dgvDrivers.RowHeadersWidth = 51;
            dgvDrivers.Size = new Size(962, 393);
            dgvDrivers.TabIndex = 0;
            // 
            // lblManageDrivers
            // 
            lblManageDrivers.AutoSize = true;
            lblManageDrivers.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblManageDrivers.ForeColor = Color.Firebrick;
            lblManageDrivers.Location = new Point(330, 45);
            lblManageDrivers.Name = "lblManageDrivers";
            lblManageDrivers.Size = new Size(322, 54);
            lblManageDrivers.TabIndex = 1;
            lblManageDrivers.Text = "Manage Drivers";
            // 
            // lblNumberOfRecords
            // 
            lblNumberOfRecords.AutoSize = true;
            lblNumberOfRecords.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNumberOfRecords.Location = new Point(8, 562);
            lblNumberOfRecords.Name = "lblNumberOfRecords";
            lblNumberOfRecords.Size = new Size(105, 28);
            lblNumberOfRecords.TabIndex = 2;
            lblNumberOfRecords.Text = "# Records";
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFilter.Location = new Point(8, 125);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(61, 28);
            lblFilter.TabIndex = 3;
            lblFilter.Text = "Filter";
            // 
            // lblNumberOfRecordsValue
            // 
            lblNumberOfRecordsValue.AutoSize = true;
            lblNumberOfRecordsValue.Font = new Font("Segoe UI", 12F);
            lblNumberOfRecordsValue.Location = new Point(119, 562);
            lblNumberOfRecordsValue.Name = "lblNumberOfRecordsValue";
            lblNumberOfRecordsValue.Size = new Size(34, 28);
            lblNumberOfRecordsValue.TabIndex = 4;
            lblNumberOfRecordsValue.Text = "00";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(876, 562);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "Driver ID", "Person ID", "National Number", "Full name" });
            cbFilter.Location = new Point(88, 125);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(220, 28);
            cbFilter.TabIndex = 6;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(314, 125);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(254, 27);
            txtSearch.TabIndex = 7;
            txtSearch.Visible = false;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // ManageDrivers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(txtSearch);
            Controls.Add(cbFilter);
            Controls.Add(btnClose);
            Controls.Add(lblNumberOfRecordsValue);
            Controls.Add(lblFilter);
            Controls.Add(lblNumberOfRecords);
            Controls.Add(lblManageDrivers);
            Controls.Add(dgvDrivers);
            Name = "ManageDrivers";
            Text = "Drivers";
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDrivers;
        private Label lblManageDrivers;
        private Label lblNumberOfRecords;
        private Label lblFilter;
        private Label lblNumberOfRecordsValue;
        private Button btnClose;
        private ComboBox cbFilter;
        private TextBox txtSearch;
    }
}