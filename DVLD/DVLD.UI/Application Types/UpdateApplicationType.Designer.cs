namespace DVLD.UI.Application_Types
{
    partial class UpdateApplicationType
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
            lbl_ApplicationTitle = new Label();
            lbl_Fee = new Label();
            txt_ApplicationTitleValue = new TextBox();
            txt_FeeValue = new TextBox();
            lbl_IdValue = new Label();
            btn_Save = new Button();
            btn_Close = new Button();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lbl_Title.Location = new Point(21, 37);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(341, 38);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "Update Application Type";
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize = true;
            lbl_Id.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_Id.Location = new Point(31, 137);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(30, 28);
            lbl_Id.TabIndex = 1;
            lbl_Id.Text = "Id";
            // 
            // lbl_ApplicationTitle
            // 
            lbl_ApplicationTitle.AutoSize = true;
            lbl_ApplicationTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_ApplicationTitle.Location = new Point(10, 179);
            lbl_ApplicationTitle.Name = "lbl_ApplicationTitle";
            lbl_ApplicationTitle.Size = new Size(51, 28);
            lbl_ApplicationTitle.TabIndex = 2;
            lbl_ApplicationTitle.Text = "Title";
            // 
            // lbl_Fee
            // 
            lbl_Fee.AutoSize = true;
            lbl_Fee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_Fee.Location = new Point(17, 222);
            lbl_Fee.Name = "lbl_Fee";
            lbl_Fee.Size = new Size(44, 28);
            lbl_Fee.TabIndex = 3;
            lbl_Fee.Text = "Fee";
            // 
            // txt_ApplicationTitleValue
            // 
            txt_ApplicationTitleValue.Location = new Point(67, 180);
            txt_ApplicationTitleValue.Name = "txt_ApplicationTitleValue";
            txt_ApplicationTitleValue.Size = new Size(295, 27);
            txt_ApplicationTitleValue.TabIndex = 5;
            // 
            // txt_FeeValue
            // 
            txt_FeeValue.Location = new Point(67, 223);
            txt_FeeValue.Name = "txt_FeeValue";
            txt_FeeValue.Size = new Size(295, 27);
            txt_FeeValue.TabIndex = 7;
            // 
            // lbl_IdValue
            // 
            lbl_IdValue.AutoSize = true;
            lbl_IdValue.Location = new Point(67, 144);
            lbl_IdValue.Name = "lbl_IdValue";
            lbl_IdValue.Size = new Size(23, 20);
            lbl_IdValue.TabIndex = 8;
            lbl_IdValue.Text = "??";
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(176, 339);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(94, 29);
            btn_Save.TabIndex = 9;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(276, 339);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(94, 29);
            btn_Close.TabIndex = 10;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // UpdateApplicationType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 380);
            Controls.Add(btn_Close);
            Controls.Add(btn_Save);
            Controls.Add(lbl_IdValue);
            Controls.Add(txt_FeeValue);
            Controls.Add(txt_ApplicationTitleValue);
            Controls.Add(lbl_Fee);
            Controls.Add(lbl_ApplicationTitle);
            Controls.Add(lbl_Id);
            Controls.Add(lbl_Title);
            Name = "UpdateApplicationType";
            Text = "UpdateApplicationType";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title;
        private Label lbl_Id;
        private Label lbl_ApplicationTitle;
        private Label lbl_Fee;
        private TextBox txt_ApplicationTitleValue;
        private TextBox txt_FeeValue;
        private Label lbl_IdValue;
        private Button btn_Save;
        private Button btn_Close;
    }
}