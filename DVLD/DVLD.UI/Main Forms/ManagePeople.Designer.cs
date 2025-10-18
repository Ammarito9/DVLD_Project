namespace DVLD.UI.Main_Forms
{
    partial class ManagePeople
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
            btnAdd = new Button();
            lblManagePeople = new Label();
            cbWhatToFilterBy = new ComboBox();
            lblFIlterBy = new Label();
            dgvPeople = new DataGridView();
            btnClose = new Button();
            lblRecords = new Label();
            lblNumberOfRecords = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1072, 118);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblManagePeople
            // 
            lblManagePeople.AutoSize = true;
            lblManagePeople.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManagePeople.Location = new Point(480, 42);
            lblManagePeople.Name = "lblManagePeople";
            lblManagePeople.Size = new Size(219, 38);
            lblManagePeople.TabIndex = 1;
            lblManagePeople.Text = "Manage People";
            // 
            // cbWhatToFilterBy
            // 
            cbWhatToFilterBy.FormattingEnabled = true;
            cbWhatToFilterBy.Items.AddRange(new object[] { "None", "National Num.", "Country" });
            cbWhatToFilterBy.Location = new Point(104, 118);
            cbWhatToFilterBy.Name = "cbWhatToFilterBy";
            cbWhatToFilterBy.Size = new Size(166, 28);
            cbWhatToFilterBy.TabIndex = 2;
            cbWhatToFilterBy.SelectedIndexChanged += cbWhatToFilterBy_SelectedIndexChanged;
            // 
            // lblFIlterBy
            // 
            lblFIlterBy.AutoSize = true;
            lblFIlterBy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFIlterBy.Location = new Point(12, 118);
            lblFIlterBy.Name = "lblFIlterBy";
            lblFIlterBy.Size = new Size(86, 28);
            lblFIlterBy.TabIndex = 3;
            lblFIlterBy.Text = "FIlter By";
            // 
            // dgvPeople
            // 
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Location = new Point(12, 153);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.RowHeadersWidth = 51;
            dgvPeople.Size = new Size(1154, 349);
            dgvPeople.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1072, 508);
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
            // ManagePeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1166, 537);
            ControlBox = false;
            Controls.Add(lblNumberOfRecords);
            Controls.Add(lblRecords);
            Controls.Add(btnClose);
            Controls.Add(dgvPeople);
            Controls.Add(lblFIlterBy);
            Controls.Add(cbWhatToFilterBy);
            Controls.Add(lblManagePeople);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ManagePeople";
            ShowIcon = false;
            Text = "ManagePeople";
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label lblManagePeople;
        private ComboBox cbWhatToFilterBy;
        private Label lblFIlterBy;
        private DataGridView dgvPeople;
        private Button btnClose;
        private Label lblRecords;
        private Label lblNumberOfRecords;
    }
}