namespace DVLD.UI.Common_Forms.UserForms
{
    partial class ManageUsers
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
            dgvUsers = new DataGridView();
            cms_UserOperation = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addNewUserToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            lbl_NumberOfRecords = new Label();
            lbl_NumberOfRecordsValue = new Label();
            lbl_ManageUsers = new Label();
            lbl_FilterBy = new Label();
            cb_FilterByValue = new ComboBox();
            btn_Close = new Button();
            btn_Add = new Button();
            txt_FilterByValue = new TextBox();
            cb_FilterByIsActiveValue = new ComboBox();
            txt_FilterByValueNumeric = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            cms_UserOperation.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.ContextMenuStrip = cms_UserOperation;
            dgvUsers.Location = new Point(12, 106);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(776, 312);
            dgvUsers.TabIndex = 0;
            // 
            // cms_UserOperation
            // 
            cms_UserOperation.ImageScalingSize = new Size(20, 20);
            cms_UserOperation.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripSeparator1, addNewUserToolStripMenuItem, deleteToolStripMenuItem, editToolStripMenuItem, toolStripSeparator2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            cms_UserOperation.Name = "cms_UserOperation";
            cms_UserOperation.Size = new Size(169, 160);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(168, 24);
            showDetailsToolStripMenuItem.Text = "Show details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(165, 6);
            // 
            // addNewUserToolStripMenuItem
            // 
            addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            addNewUserToolStripMenuItem.Size = new Size(168, 24);
            addNewUserToolStripMenuItem.Text = "Add new user";
            addNewUserToolStripMenuItem.Click += addNewUserToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(168, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(168, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(165, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(168, 24);
            sendEmailToolStripMenuItem.Text = "Send email";
            sendEmailToolStripMenuItem.Click += sendEmailToolStripMenuItem_Click;
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(168, 24);
            phoneCallToolStripMenuItem.Text = "Phone call";
            phoneCallToolStripMenuItem.Click += phoneCallToolStripMenuItem_Click;
            // 
            // lbl_NumberOfRecords
            // 
            lbl_NumberOfRecords.AutoSize = true;
            lbl_NumberOfRecords.Location = new Point(12, 425);
            lbl_NumberOfRecords.Name = "lbl_NumberOfRecords";
            lbl_NumberOfRecords.Size = new Size(134, 20);
            lbl_NumberOfRecords.TabIndex = 1;
            lbl_NumberOfRecords.Text = "Number of records";
            // 
            // lbl_NumberOfRecordsValue
            // 
            lbl_NumberOfRecordsValue.AutoSize = true;
            lbl_NumberOfRecordsValue.Location = new Point(152, 425);
            lbl_NumberOfRecordsValue.Name = "lbl_NumberOfRecordsValue";
            lbl_NumberOfRecordsValue.Size = new Size(25, 20);
            lbl_NumberOfRecordsValue.TabIndex = 2;
            lbl_NumberOfRecordsValue.Text = "00";
            // 
            // lbl_ManageUsers
            // 
            lbl_ManageUsers.AutoSize = true;
            lbl_ManageUsers.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lbl_ManageUsers.Location = new Point(300, 21);
            lbl_ManageUsers.Name = "lbl_ManageUsers";
            lbl_ManageUsers.Size = new Size(201, 38);
            lbl_ManageUsers.TabIndex = 3;
            lbl_ManageUsers.Text = "Manage Users";
            // 
            // lbl_FilterBy
            // 
            lbl_FilterBy.AutoSize = true;
            lbl_FilterBy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_FilterBy.Location = new Point(12, 75);
            lbl_FilterBy.Name = "lbl_FilterBy";
            lbl_FilterBy.Size = new Size(85, 28);
            lbl_FilterBy.TabIndex = 4;
            lbl_FilterBy.Text = "Filter by";
            // 
            // cb_FilterByValue
            // 
            cb_FilterByValue.FormattingEnabled = true;
            cb_FilterByValue.Items.AddRange(new object[] { "None", "User id", "Person id", "Full name", "Username", "Is active" });
            cb_FilterByValue.Location = new Point(103, 75);
            cb_FilterByValue.Name = "cb_FilterByValue";
            cb_FilterByValue.Size = new Size(180, 28);
            cb_FilterByValue.TabIndex = 5;
            cb_FilterByValue.SelectedIndexChanged += cb_FilterByValue_SelectedIndexChanged;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(694, 421);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(94, 29);
            btn_Close.TabIndex = 6;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(694, 74);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 29);
            btn_Add.TabIndex = 7;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // txt_FilterByValue
            // 
            txt_FilterByValue.Location = new Point(289, 75);
            txt_FilterByValue.Name = "txt_FilterByValue";
            txt_FilterByValue.Size = new Size(189, 27);
            txt_FilterByValue.TabIndex = 8;
            txt_FilterByValue.TextChanged += txt_FilterByValue_TextChanged;
            // 
            // cb_FilterByIsActiveValue
            // 
            cb_FilterByIsActiveValue.FormattingEnabled = true;
            cb_FilterByIsActiveValue.Items.AddRange(new object[] { "All", "Yes", "No" });
            cb_FilterByIsActiveValue.Location = new Point(289, 75);
            cb_FilterByIsActiveValue.Name = "cb_FilterByIsActiveValue";
            cb_FilterByIsActiveValue.Size = new Size(84, 28);
            cb_FilterByIsActiveValue.TabIndex = 9;
            cb_FilterByIsActiveValue.SelectedIndexChanged += cb_FilterByIsActiveValue_SelectedIndexChanged;
            // 
            // txt_FilterByValueNumeric
            // 
            txt_FilterByValueNumeric.Location = new Point(289, 76);
            txt_FilterByValueNumeric.Name = "txt_FilterByValueNumeric";
            txt_FilterByValueNumeric.Size = new Size(189, 27);
            txt_FilterByValueNumeric.TabIndex = 10;
            txt_FilterByValueNumeric.TextChanged += txt_FilterByValueNumeric_TextChanged;
            txt_FilterByValueNumeric.KeyPress += txt_FilterByValueNumeric_KeyPress;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 458);
            Controls.Add(cb_FilterByIsActiveValue);
            Controls.Add(txt_FilterByValue);
            Controls.Add(btn_Add);
            Controls.Add(btn_Close);
            Controls.Add(cb_FilterByValue);
            Controls.Add(lbl_FilterBy);
            Controls.Add(lbl_ManageUsers);
            Controls.Add(lbl_NumberOfRecordsValue);
            Controls.Add(lbl_NumberOfRecords);
            Controls.Add(dgvUsers);
            Controls.Add(txt_FilterByValueNumeric);
            Name = "ManageUsers";
            Text = "ManageUsers";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            cms_UserOperation.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Label lbl_NumberOfRecords;
        private Label lbl_NumberOfRecordsValue;
        private Label lbl_ManageUsers;
        private Label lbl_FilterBy;
        private ComboBox cb_FilterByValue;
        private Button btn_Close;
        private Button btn_Add;
        private TextBox txt_FilterByValue;
        private ComboBox cb_FilterByIsActiveValue;
        private TextBox txt_FilterByValueNumeric;
        private ContextMenuStrip cms_UserOperation;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem addNewUserToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}