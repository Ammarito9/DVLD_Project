namespace DVLD.UI.Manage_Applications
{
    partial class TakeTest
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
            gb_TestTypeTitle = new GroupBox();
            lbl_TestID = new Label();
            lbl_TestIDValue = new Label();
            lbl_DateValue = new Label();
            lbl_TakeTestTitle = new Label();
            lbl_FeeValue = new Label();
            lbl_Fee = new Label();
            lbl_Date = new Label();
            lbl_TrialsValue = new Label();
            lbl_Trials = new Label();
            lbl_FullName = new Label();
            lbl_FullNameValue = new Label();
            lbl_LicenseClassValue = new Label();
            lbl_LicenseClass = new Label();
            lbl_ApplicationIDValue = new Label();
            lbl_ApplicationID = new Label();
            btn_Save = new Button();
            btn_Close = new Button();
            rb_Pass = new RadioButton();
            rb_Fail = new RadioButton();
            lbl_Notes = new Label();
            lbl_Result = new Label();
            txt_Notes = new TextBox();
            gb_TestTypeTitle.SuspendLayout();
            SuspendLayout();
            // 
            // gb_TestTypeTitle
            // 
            gb_TestTypeTitle.Controls.Add(lbl_TestID);
            gb_TestTypeTitle.Controls.Add(lbl_TestIDValue);
            gb_TestTypeTitle.Controls.Add(lbl_DateValue);
            gb_TestTypeTitle.Controls.Add(lbl_TakeTestTitle);
            gb_TestTypeTitle.Controls.Add(lbl_FeeValue);
            gb_TestTypeTitle.Controls.Add(lbl_Fee);
            gb_TestTypeTitle.Controls.Add(lbl_Date);
            gb_TestTypeTitle.Controls.Add(lbl_TrialsValue);
            gb_TestTypeTitle.Controls.Add(lbl_Trials);
            gb_TestTypeTitle.Controls.Add(lbl_FullName);
            gb_TestTypeTitle.Controls.Add(lbl_FullNameValue);
            gb_TestTypeTitle.Controls.Add(lbl_LicenseClassValue);
            gb_TestTypeTitle.Controls.Add(lbl_LicenseClass);
            gb_TestTypeTitle.Controls.Add(lbl_ApplicationIDValue);
            gb_TestTypeTitle.Controls.Add(lbl_ApplicationID);
            gb_TestTypeTitle.Location = new Point(12, 12);
            gb_TestTypeTitle.Name = "gb_TestTypeTitle";
            gb_TestTypeTitle.Size = new Size(558, 389);
            gb_TestTypeTitle.TabIndex = 0;
            gb_TestTypeTitle.TabStop = false;
            gb_TestTypeTitle.Text = "Test Type Title";
            // 
            // lbl_TestID
            // 
            lbl_TestID.AutoSize = true;
            lbl_TestID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TestID.Location = new Point(93, 340);
            lbl_TestID.Name = "lbl_TestID";
            lbl_TestID.Size = new Size(77, 28);
            lbl_TestID.TabIndex = 16;
            lbl_TestID.Text = "Test ID";
            // 
            // lbl_TestIDValue
            // 
            lbl_TestIDValue.AutoSize = true;
            lbl_TestIDValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_TestIDValue.Location = new Point(176, 340);
            lbl_TestIDValue.Name = "lbl_TestIDValue";
            lbl_TestIDValue.Size = new Size(48, 28);
            lbl_TestIDValue.TabIndex = 15;
            lbl_TestIDValue.Text = "N/A";
            // 
            // lbl_DateValue
            // 
            lbl_DateValue.AutoSize = true;
            lbl_DateValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DateValue.Location = new Point(176, 268);
            lbl_DateValue.Name = "lbl_DateValue";
            lbl_DateValue.Size = new Size(116, 28);
            lbl_DateValue.TabIndex = 14;
            lbl_DateValue.Text = "00/00/0000";
            // 
            // lbl_TakeTestTitle
            // 
            lbl_TakeTestTitle.AutoSize = true;
            lbl_TakeTestTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbl_TakeTestTitle.ForeColor = Color.Brown;
            lbl_TakeTestTitle.Location = new Point(206, 42);
            lbl_TakeTestTitle.Name = "lbl_TakeTestTitle";
            lbl_TakeTestTitle.Size = new Size(146, 41);
            lbl_TakeTestTitle.TabIndex = 1;
            lbl_TakeTestTitle.Text = "Take Test";
            lbl_TakeTestTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_FeeValue
            // 
            lbl_FeeValue.AutoSize = true;
            lbl_FeeValue.Font = new Font("Segoe UI", 12F);
            lbl_FeeValue.Location = new Point(176, 304);
            lbl_FeeValue.Name = "lbl_FeeValue";
            lbl_FeeValue.Size = new Size(39, 28);
            lbl_FeeValue.TabIndex = 13;
            lbl_FeeValue.Text = "???";
            // 
            // lbl_Fee
            // 
            lbl_Fee.AutoSize = true;
            lbl_Fee.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Fee.Location = new Point(126, 304);
            lbl_Fee.Name = "lbl_Fee";
            lbl_Fee.Size = new Size(44, 28);
            lbl_Fee.TabIndex = 12;
            lbl_Fee.Text = "Fee";
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Date.Location = new Point(113, 268);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(57, 28);
            lbl_Date.TabIndex = 10;
            lbl_Date.Text = "Date";
            // 
            // lbl_TrialsValue
            // 
            lbl_TrialsValue.AutoSize = true;
            lbl_TrialsValue.Font = new Font("Segoe UI", 12F);
            lbl_TrialsValue.Location = new Point(176, 232);
            lbl_TrialsValue.Name = "lbl_TrialsValue";
            lbl_TrialsValue.Size = new Size(39, 28);
            lbl_TrialsValue.TabIndex = 9;
            lbl_TrialsValue.Text = "???";
            // 
            // lbl_Trials
            // 
            lbl_Trials.AutoSize = true;
            lbl_Trials.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Trials.Location = new Point(108, 232);
            lbl_Trials.Name = "lbl_Trials";
            lbl_Trials.Size = new Size(62, 28);
            lbl_Trials.TabIndex = 8;
            lbl_Trials.Text = "Trials";
            // 
            // lbl_FullName
            // 
            lbl_FullName.AutoSize = true;
            lbl_FullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_FullName.Location = new Point(62, 196);
            lbl_FullName.Name = "lbl_FullName";
            lbl_FullName.Size = new Size(108, 28);
            lbl_FullName.TabIndex = 7;
            lbl_FullName.Text = "Full Name";
            // 
            // lbl_FullNameValue
            // 
            lbl_FullNameValue.AutoSize = true;
            lbl_FullNameValue.Font = new Font("Segoe UI", 12F);
            lbl_FullNameValue.Location = new Point(176, 196);
            lbl_FullNameValue.Name = "lbl_FullNameValue";
            lbl_FullNameValue.Size = new Size(39, 28);
            lbl_FullNameValue.TabIndex = 6;
            lbl_FullNameValue.Text = "???";
            // 
            // lbl_LicenseClassValue
            // 
            lbl_LicenseClassValue.AutoSize = true;
            lbl_LicenseClassValue.Font = new Font("Segoe UI", 12F);
            lbl_LicenseClassValue.Location = new Point(176, 160);
            lbl_LicenseClassValue.Name = "lbl_LicenseClassValue";
            lbl_LicenseClassValue.Size = new Size(39, 28);
            lbl_LicenseClassValue.TabIndex = 5;
            lbl_LicenseClassValue.Text = "???";
            // 
            // lbl_LicenseClass
            // 
            lbl_LicenseClass.AutoSize = true;
            lbl_LicenseClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_LicenseClass.Location = new Point(36, 160);
            lbl_LicenseClass.Name = "lbl_LicenseClass";
            lbl_LicenseClass.Size = new Size(134, 28);
            lbl_LicenseClass.TabIndex = 4;
            lbl_LicenseClass.Text = "License Class";
            // 
            // lbl_ApplicationIDValue
            // 
            lbl_ApplicationIDValue.AutoSize = true;
            lbl_ApplicationIDValue.Font = new Font("Segoe UI", 12F);
            lbl_ApplicationIDValue.Location = new Point(176, 124);
            lbl_ApplicationIDValue.Name = "lbl_ApplicationIDValue";
            lbl_ApplicationIDValue.Size = new Size(39, 28);
            lbl_ApplicationIDValue.TabIndex = 3;
            lbl_ApplicationIDValue.Text = "???";
            // 
            // lbl_ApplicationID
            // 
            lbl_ApplicationID.AutoSize = true;
            lbl_ApplicationID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_ApplicationID.Location = new Point(22, 124);
            lbl_ApplicationID.Name = "lbl_ApplicationID";
            lbl_ApplicationID.Size = new Size(148, 28);
            lbl_ApplicationID.TabIndex = 2;
            lbl_ApplicationID.Text = "Application ID";
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(376, 616);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(94, 29);
            btn_Save.TabIndex = 1;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(476, 616);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(94, 29);
            btn_Close.TabIndex = 2;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // rb_Pass
            // 
            rb_Pass.AutoSize = true;
            rb_Pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rb_Pass.Location = new Point(187, 418);
            rb_Pass.Name = "rb_Pass";
            rb_Pass.Size = new Size(69, 32);
            rb_Pass.TabIndex = 17;
            rb_Pass.TabStop = true;
            rb_Pass.Text = "Pass";
            rb_Pass.UseVisualStyleBackColor = true;
            // 
            // rb_Fail
            // 
            rb_Fail.AutoSize = true;
            rb_Fail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rb_Fail.Location = new Point(262, 418);
            rb_Fail.Name = "rb_Fail";
            rb_Fail.Size = new Size(62, 32);
            rb_Fail.TabIndex = 18;
            rb_Fail.TabStop = true;
            rb_Fail.Text = "Fail";
            rb_Fail.UseVisualStyleBackColor = true;
            // 
            // lbl_Notes
            // 
            lbl_Notes.AutoSize = true;
            lbl_Notes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Notes.Location = new Point(105, 460);
            lbl_Notes.Name = "lbl_Notes";
            lbl_Notes.Size = new Size(68, 28);
            lbl_Notes.TabIndex = 19;
            lbl_Notes.Text = "Notes";
            // 
            // lbl_Result
            // 
            lbl_Result.AutoSize = true;
            lbl_Result.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Result.Location = new Point(102, 418);
            lbl_Result.Name = "lbl_Result";
            lbl_Result.Size = new Size(71, 28);
            lbl_Result.TabIndex = 20;
            lbl_Result.Text = "Result";
            // 
            // txt_Notes
            // 
            txt_Notes.Location = new Point(187, 464);
            txt_Notes.Multiline = true;
            txt_Notes.Name = "txt_Notes";
            txt_Notes.Size = new Size(383, 146);
            txt_Notes.TabIndex = 21;
            // 
            // TakeTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 657);
            Controls.Add(rb_Fail);
            Controls.Add(rb_Pass);
            Controls.Add(lbl_Result);
            Controls.Add(txt_Notes);
            Controls.Add(lbl_Notes);
            Controls.Add(btn_Close);
            Controls.Add(btn_Save);
            Controls.Add(gb_TestTypeTitle);
            Name = "TakeTest";
            Text = "TakeTest";
            gb_TestTypeTitle.ResumeLayout(false);
            gb_TestTypeTitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_TestTypeTitle;
        private Label lbl_TakeTestTitle;
        private Label lbl_ApplicationID;
        private Label lbl_FeeValue;
        private Label lbl_Fee;
        private Label lbl_Date;
        private Label lbl_TrialsValue;
        private Label lbl_Trials;
        private Label lbl_FullName;
        private Label lbl_FullNameValue;
        private Label lbl_LicenseClassValue;
        private Label lbl_LicenseClass;
        private Label lbl_ApplicationIDValue;
        private Button btn_Save;
        private Button btn_Close;
        private Label lbl_TestID;
        private Label lbl_TestIDValue;
        private Label lbl_DateValue;
        private RadioButton rb_Pass;
        private RadioButton rb_Fail;
        private Label lbl_Notes;
        private Label lbl_Result;
        private TextBox txt_Notes;
    }
}