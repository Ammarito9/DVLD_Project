namespace DVLD.UI.Application_Types
{
    partial class ManageApplicationTypes
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
            dgv_ApplicationTypes = new DataGridView();
            cms_ApplicationTypeOperation = new ContextMenuStrip(components);
            editApplicationTypeToolStripMenuItem = new ToolStripMenuItem();
            btn_Close = new Button();
            lbl_NumberOfRecords = new Label();
            lbl_NumberOfRecordsValue = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ApplicationTypes).BeginInit();
            cms_ApplicationTypeOperation.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lbl_Title.Location = new Point(134, 32);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(364, 38);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "Manage Application Types";
            // 
            // dgv_ApplicationTypes
            // 
            dgv_ApplicationTypes.AllowUserToAddRows = false;
            dgv_ApplicationTypes.AllowUserToDeleteRows = false;
            dgv_ApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ApplicationTypes.ContextMenuStrip = cms_ApplicationTypeOperation;
            dgv_ApplicationTypes.Location = new Point(12, 96);
            dgv_ApplicationTypes.Name = "dgv_ApplicationTypes";
            dgv_ApplicationTypes.ReadOnly = true;
            dgv_ApplicationTypes.RowHeadersWidth = 51;
            dgv_ApplicationTypes.Size = new Size(608, 433);
            dgv_ApplicationTypes.TabIndex = 1;
            // 
            // cms_ApplicationTypeOperation
            // 
            cms_ApplicationTypeOperation.ImageScalingSize = new Size(20, 20);
            cms_ApplicationTypeOperation.Items.AddRange(new ToolStripItem[] { editApplicationTypeToolStripMenuItem });
            cms_ApplicationTypeOperation.Name = "cms_ApplicationTypeOperation";
            cms_ApplicationTypeOperation.Size = new Size(217, 28);
            // 
            // editApplicationTypeToolStripMenuItem
            // 
            editApplicationTypeToolStripMenuItem.Name = "editApplicationTypeToolStripMenuItem";
            editApplicationTypeToolStripMenuItem.Size = new Size(216, 24);
            editApplicationTypeToolStripMenuItem.Text = "Edit application type";
            editApplicationTypeToolStripMenuItem.Click += editApplicationTypeToolStripMenuItem_Click;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(526, 535);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(94, 29);
            btn_Close.TabIndex = 2;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // lbl_NumberOfRecords
            // 
            lbl_NumberOfRecords.AutoSize = true;
            lbl_NumberOfRecords.Location = new Point(12, 539);
            lbl_NumberOfRecords.Name = "lbl_NumberOfRecords";
            lbl_NumberOfRecords.Size = new Size(75, 20);
            lbl_NumberOfRecords.TabIndex = 4;
            lbl_NumberOfRecords.Text = "# Records";
            // 
            // lbl_NumberOfRecordsValue
            // 
            lbl_NumberOfRecordsValue.AutoSize = true;
            lbl_NumberOfRecordsValue.Location = new Point(93, 539);
            lbl_NumberOfRecordsValue.Name = "lbl_NumberOfRecordsValue";
            lbl_NumberOfRecordsValue.Size = new Size(25, 20);
            lbl_NumberOfRecordsValue.TabIndex = 5;
            lbl_NumberOfRecordsValue.Text = "00";
            // 
            // ManageApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 576);
            Controls.Add(lbl_NumberOfRecordsValue);
            Controls.Add(lbl_NumberOfRecords);
            Controls.Add(btn_Close);
            Controls.Add(dgv_ApplicationTypes);
            Controls.Add(lbl_Title);
            Name = "ManageApplicationTypes";
            Text = "ManageApplicationType";
            ((System.ComponentModel.ISupportInitialize)dgv_ApplicationTypes).EndInit();
            cms_ApplicationTypeOperation.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title;
        private DataGridView dgv_ApplicationTypes;
        private Button btn_Close;
        private ContextMenuStrip cms_ApplicationTypeOperation;
        private ToolStripMenuItem editApplicationTypeToolStripMenuItem;
        private Label lbl_NumberOfRecords;
        private Label lbl_NumberOfRecordsValue;
    }
}