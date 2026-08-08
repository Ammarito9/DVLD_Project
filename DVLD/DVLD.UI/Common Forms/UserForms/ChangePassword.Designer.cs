namespace DVLD.UI.Common_Forms.UserForms
{
    partial class ChangePassword
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
            lblCurrentPassword = new Label();
            txt_CurrentPasswordValue = new TextBox();
            lbl_NewPassword = new Label();
            lbl_ConfirmPassword = new Label();
            txt_NewPasswordValue = new TextBox();
            txt_ConfirmPasswordValue = new TextBox();
            btn_Close = new Button();
            btn_Save = new Button();
            ep_HandleEmptyTestBox = new ErrorProvider(components);
            ep_PasswordDoesNotMatch = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ep_HandleEmptyTestBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ep_PasswordDoesNotMatch).BeginInit();
            SuspendLayout();
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentPassword.Location = new Point(52, 625);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(156, 23);
            lblCurrentPassword.TabIndex = 1;
            lblCurrentPassword.Text = "Current Password:";
            // 
            // txt_CurrentPasswordValue
            // 
            txt_CurrentPasswordValue.Location = new Point(252, 621);
            txt_CurrentPasswordValue.Name = "txt_CurrentPasswordValue";
            txt_CurrentPasswordValue.Size = new Size(204, 27);
            txt_CurrentPasswordValue.TabIndex = 2;
            txt_CurrentPasswordValue.Leave += txt_CurrentPasswordValue_Leave;
            // 
            // lbl_NewPassword
            // 
            lbl_NewPassword.AutoSize = true;
            lbl_NewPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NewPassword.Location = new Point(77, 668);
            lbl_NewPassword.Name = "lbl_NewPassword";
            lbl_NewPassword.Size = new Size(131, 23);
            lbl_NewPassword.TabIndex = 3;
            lbl_NewPassword.Text = "New Password:";
            // 
            // lbl_ConfirmPassword
            // 
            lbl_ConfirmPassword.AutoSize = true;
            lbl_ConfirmPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ConfirmPassword.Location = new Point(47, 707);
            lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            lbl_ConfirmPassword.Size = new Size(161, 23);
            lbl_ConfirmPassword.TabIndex = 4;
            lbl_ConfirmPassword.Text = "Confirm Password:";
            // 
            // txt_NewPasswordValue
            // 
            txt_NewPasswordValue.Location = new Point(252, 664);
            txt_NewPasswordValue.Name = "txt_NewPasswordValue";
            txt_NewPasswordValue.Size = new Size(204, 27);
            txt_NewPasswordValue.TabIndex = 5;
            // 
            // txt_ConfirmPasswordValue
            // 
            txt_ConfirmPasswordValue.Location = new Point(252, 703);
            txt_ConfirmPasswordValue.Name = "txt_ConfirmPasswordValue";
            txt_ConfirmPasswordValue.Size = new Size(204, 27);
            txt_ConfirmPasswordValue.TabIndex = 6;
            txt_ConfirmPasswordValue.Leave += txt_ConfirmPasswordValue_Leave;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(823, 760);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(94, 29);
            btn_Close.TabIndex = 7;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(712, 760);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(94, 29);
            btn_Save.TabIndex = 8;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click_1;
            // 
            // ep_HandleEmptyTestBox
            // 
            ep_HandleEmptyTestBox.ContainerControl = this;
            // 
            // ep_PasswordDoesNotMatch
            // 
            ep_PasswordDoesNotMatch.ContainerControl = this;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 798);
            Controls.Add(btn_Save);
            Controls.Add(btn_Close);
            Controls.Add(txt_ConfirmPasswordValue);
            Controls.Add(txt_NewPasswordValue);
            Controls.Add(lbl_ConfirmPassword);
            Controls.Add(lbl_NewPassword);
            Controls.Add(txt_CurrentPasswordValue);
            Controls.Add(lblCurrentPassword);
            Name = "ChangePassword";
            Text = "ChangePassword";
            Load += ChangePassword_Load;
            ((System.ComponentModel.ISupportInitialize)ep_HandleEmptyTestBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep_PasswordDoesNotMatch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private uc.ucUserInfo ucUserInfo1;
        private Label lblCurrentPassword;
        private TextBox txt_CurrentPasswordValue;
        private Label lbl_NewPassword;
        private Label lbl_ConfirmPassword;
        private TextBox txt_NewPasswordValue;
        private TextBox txt_ConfirmPasswordValue;
        private Button btn_Close;
        private Button btn_Save;
        private ErrorProvider ep_HandleEmptyTestBox;
        private ErrorProvider ep_PasswordDoesNotMatch;
    }
}