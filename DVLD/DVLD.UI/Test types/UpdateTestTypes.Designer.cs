namespace DVLD.UI.Test_types
{
    partial class UpdateTestTypes
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
            lbl_Title = new Label();
            lbl_Id = new Label();
            lbl_TestTitle = new Label();
            lbl_Fee = new Label();
            txt_TestTitleValue = new TextBox();
            txt_FeeValue = new TextBox();
            lbl_IdValue = new Label();
            btn_Save = new Button();
            btn_Close = new Button();
            txt_Description = new TextBox();
            lbl_Description = new Label();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lbl_Title.Location = new Point(132, 37);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(241, 38);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "Update Test Type";
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize = true;
            lbl_Id.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_Id.Location = new Point(97, 137);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(30, 28);
            lbl_Id.TabIndex = 1;
            lbl_Id.Text = "Id";
            // 
            // lbl_TestTitle
            // 
            lbl_TestTitle.AutoSize = true;
            lbl_TestTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_TestTitle.Location = new Point(76, 179);
            lbl_TestTitle.Name = "lbl_TestTitle";
            lbl_TestTitle.Size = new Size(51, 28);
            lbl_TestTitle.TabIndex = 2;
            lbl_TestTitle.Text = "Title";
            // 
            // lbl_Fee
            // 
            lbl_Fee.AutoSize = true;
            lbl_Fee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_Fee.Location = new Point(83, 354);
            lbl_Fee.Name = "lbl_Fee";
            lbl_Fee.Size = new Size(44, 28);
            lbl_Fee.TabIndex = 3;
            lbl_Fee.Text = "Fee";
            // 
            // txt_TestTitleValue
            // 
            txt_TestTitleValue.Location = new Point(132, 179);
            txt_TestTitleValue.Name = "txt_TestTitleValue";
            txt_TestTitleValue.Size = new Size(361, 27);
            txt_TestTitleValue.TabIndex = 5;
            // 
            // txt_FeeValue
            // 
            txt_FeeValue.Location = new Point(133, 354);
            txt_FeeValue.Name = "txt_FeeValue";
            txt_FeeValue.Size = new Size(361, 27);
            txt_FeeValue.TabIndex = 7;
            // 
            // lbl_IdValue
            // 
            lbl_IdValue.AutoSize = true;
            lbl_IdValue.Location = new Point(133, 144);
            lbl_IdValue.Name = "lbl_IdValue";
            lbl_IdValue.Size = new Size(23, 20);
            lbl_IdValue.TabIndex = 8;
            lbl_IdValue.Text = "??";
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(299, 421);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(94, 29);
            btn_Save.TabIndex = 9;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(399, 421);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(94, 29);
            btn_Close.TabIndex = 10;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(132, 221);
            txt_Description.Multiline = true;
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(361, 116);
            txt_Description.TabIndex = 12;
            // 
            // lbl_Description
            // 
            lbl_Description.AutoSize = true;
            lbl_Description.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_Description.Location = new Point(12, 217);
            lbl_Description.Name = "lbl_Description";
            lbl_Description.Size = new Size(115, 28);
            lbl_Description.TabIndex = 11;
            lbl_Description.Text = "Description";
            // 
            // UpdateTestTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 462);
            Controls.Add(txt_Description);
            Controls.Add(lbl_Description);
            Controls.Add(btn_Close);
            Controls.Add(btn_Save);
            Controls.Add(lbl_IdValue);
            Controls.Add(txt_FeeValue);
            Controls.Add(txt_TestTitleValue);
            Controls.Add(lbl_Fee);
            Controls.Add(lbl_TestTitle);
            Controls.Add(lbl_Id);
            Controls.Add(lbl_Title);
            Name = "UpdateTestTypes";
            Text = "UpdateTestType";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title;
        private Label lbl_Id;
        private Label lbl_TestTitle;
        private Label lbl_Fee;
        private TextBox txt_TestTitleValue;
        private TextBox txt_FeeValue;
        private Label lbl_IdValue;
        private Button btn_Save;
        private Button btn_Close;
        private TextBox txt_Description;
        private Label lbl_Description;
    }
}