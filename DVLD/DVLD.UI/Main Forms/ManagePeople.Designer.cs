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
            components = new System.ComponentModel.Container();
            btnAdd = new Button();
            lblManagePeople = new Label();
            cbWhatToFilterBy = new ComboBox();
            lblFIlterBy = new Label();
            dgvPeople = new DataGridView();
            cmsPeopleData = new ContextMenuStrip(components);
            miShowDetails = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            miAddNewPerson = new ToolStripMenuItem();
            miEdit = new ToolStripMenuItem();
            miDelete = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            miSendEmail = new ToolStripMenuItem();
            miPhoneCall = new ToolStripMenuItem();
            btnClose = new Button();
            lblRecords = new Label();
            lblNumberOfRecords = new Label();
            txtOnlyDigitFilterBy = new TextBox();
            txtFilterBy = new TextBox();
            cbFilterByCountry = new ComboBox();
            rbFilterByMale = new RadioButton();
            rbFilterByFemale = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            cmsPeopleData.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1306, 114);
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
            lblManagePeople.Location = new Point(595, 42);
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
            dgvPeople.ContextMenuStrip = cmsPeopleData;
            dgvPeople.Location = new Point(12, 153);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.RowHeadersWidth = 51;
            dgvPeople.Size = new Size(1388, 349);
            dgvPeople.TabIndex = 4;
            // 
            // cmsPeopleData
            // 
            cmsPeopleData.ImageScalingSize = new Size(20, 20);
            cmsPeopleData.Items.AddRange(new ToolStripItem[] { miShowDetails, toolStripSeparator1, miAddNewPerson, miEdit, miDelete, toolStripSeparator2, miSendEmail, miPhoneCall });
            cmsPeopleData.Name = "cmsPeopleData";
            cmsPeopleData.Size = new Size(187, 160);
            // 
            // miShowDetails
            // 
            miShowDetails.Name = "miShowDetails";
            miShowDetails.Size = new Size(186, 24);
            miShowDetails.Text = "Show details";
            miShowDetails.Click += miShowDetails_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(183, 6);
            // 
            // miAddNewPerson
            // 
            miAddNewPerson.Name = "miAddNewPerson";
            miAddNewPerson.Size = new Size(186, 24);
            miAddNewPerson.Text = "Add new person";
            miAddNewPerson.Click += miAddNewPerson_Click;
            // 
            // miEdit
            // 
            miEdit.Name = "miEdit";
            miEdit.Size = new Size(186, 24);
            miEdit.Text = "Edit";
            // 
            // miDelete
            // 
            miDelete.Name = "miDelete";
            miDelete.Size = new Size(186, 24);
            miDelete.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(183, 6);
            // 
            // miSendEmail
            // 
            miSendEmail.Name = "miSendEmail";
            miSendEmail.Size = new Size(186, 24);
            miSendEmail.Text = "Send email";
            // 
            // miPhoneCall
            // 
            miPhoneCall.Name = "miPhoneCall";
            miPhoneCall.Size = new Size(186, 24);
            miPhoneCall.Text = "Phone call";
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
            // txtOnlyDigitFilterBy
            // 
            txtOnlyDigitFilterBy.Location = new Point(276, 118);
            txtOnlyDigitFilterBy.Name = "txtOnlyDigitFilterBy";
            txtOnlyDigitFilterBy.Size = new Size(207, 27);
            txtOnlyDigitFilterBy.TabIndex = 8;
            txtOnlyDigitFilterBy.Visible = false;
            txtOnlyDigitFilterBy.TextChanged += OnlyDigitFilterBy_TextChanged;
            txtOnlyDigitFilterBy.KeyPress += txtOnlyDigitFilterBy_KeyPress;
            // 
            // txtFilterBy
            // 
            txtFilterBy.Location = new Point(276, 118);
            txtFilterBy.Name = "txtFilterBy";
            txtFilterBy.Size = new Size(207, 27);
            txtFilterBy.TabIndex = 9;
            txtFilterBy.Visible = false;
            txtFilterBy.TextChanged += txtFilterBy_TextChanged;
            // 
            // cbFilterByCountry
            // 
            cbFilterByCountry.FormattingEnabled = true;
            cbFilterByCountry.Location = new Point(276, 117);
            cbFilterByCountry.Name = "cbFilterByCountry";
            cbFilterByCountry.Size = new Size(207, 28);
            cbFilterByCountry.TabIndex = 10;
            cbFilterByCountry.Visible = false;
            cbFilterByCountry.SelectedIndexChanged += cbFilterByCountry_SelectedIndexChanged;
            // 
            // rbFilterByMale
            // 
            rbFilterByMale.AutoSize = true;
            rbFilterByMale.Location = new Point(276, 119);
            rbFilterByMale.Name = "rbFilterByMale";
            rbFilterByMale.Size = new Size(63, 24);
            rbFilterByMale.TabIndex = 11;
            rbFilterByMale.TabStop = true;
            rbFilterByMale.Text = "Male";
            rbFilterByMale.UseVisualStyleBackColor = true;
            rbFilterByMale.Visible = false;
            rbFilterByMale.CheckedChanged += rbFilterByMale_CheckedChanged;
            // 
            // rbFilterByFemale
            // 
            rbFilterByFemale.AutoSize = true;
            rbFilterByFemale.Location = new Point(369, 118);
            rbFilterByFemale.Name = "rbFilterByFemale";
            rbFilterByFemale.Size = new Size(78, 24);
            rbFilterByFemale.TabIndex = 12;
            rbFilterByFemale.TabStop = true;
            rbFilterByFemale.Text = "Female";
            rbFilterByFemale.UseVisualStyleBackColor = true;
            rbFilterByFemale.Visible = false;
            rbFilterByFemale.CheckedChanged += rbFilterByFemale_CheckedChanged;
            // 
            // ManagePeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1408, 549);
            ControlBox = false;
            Controls.Add(rbFilterByFemale);
            Controls.Add(rbFilterByMale);
            Controls.Add(lblNumberOfRecords);
            Controls.Add(lblRecords);
            Controls.Add(btnClose);
            Controls.Add(dgvPeople);
            Controls.Add(lblFIlterBy);
            Controls.Add(cbWhatToFilterBy);
            Controls.Add(lblManagePeople);
            Controls.Add(btnAdd);
            Controls.Add(cbFilterByCountry);
            Controls.Add(txtFilterBy);
            Controls.Add(txtOnlyDigitFilterBy);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ManagePeople";
            ShowIcon = false;
            Text = "ManagePeople";
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            cmsPeopleData.ResumeLayout(false);
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
        private TextBox txtOnlyDigitFilterBy;
        private TextBox txtFilterBy;
        private ComboBox cbFilterByCountry;
        private RadioButton rbFilterByMale;
        private RadioButton rbFilterByFemale;
        private ContextMenuStrip cmsPeopleData;
        private ToolStripMenuItem miShowDetails;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem miAddNewPerson;
        private ToolStripMenuItem miEdit;
        private ToolStripMenuItem miDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem miSendEmail;
        private ToolStripMenuItem miPhoneCall;
    }
}