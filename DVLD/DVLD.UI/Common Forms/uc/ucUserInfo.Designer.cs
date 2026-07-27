namespace DVLD.UI.Common_Forms.uc
{
    partial class ucUserInfo
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
            Login_Information = new GroupBox();
            lbl_IsActiveValue = new Label();
            lbl_IsActive = new Label();
            lbl_UsernameValue = new Label();
            lbl_Username = new Label();
            lbl_UserIdValue = new Label();
            lbl_UserId = new Label();
            Login_Information.SuspendLayout();
            SuspendLayout();
            // 
            // Login_Information
            // 
            Login_Information.Controls.Add(lbl_IsActiveValue);
            Login_Information.Controls.Add(lbl_IsActive);
            Login_Information.Controls.Add(lbl_UsernameValue);
            Login_Information.Controls.Add(lbl_Username);
            Login_Information.Controls.Add(lbl_UserIdValue);
            Login_Information.Controls.Add(lbl_UserId);
            Login_Information.Location = new Point(3, 445);
            Login_Information.Name = "Login_Information";
            Login_Information.Size = new Size(901, 131);
            Login_Information.TabIndex = 1;
            Login_Information.TabStop = false;
            Login_Information.Text = "Login Information";
            // 
            // lbl_IsActiveValue
            // 
            lbl_IsActiveValue.AutoSize = true;
            lbl_IsActiveValue.Location = new Point(729, 65);
            lbl_IsActiveValue.Name = "lbl_IsActiveValue";
            lbl_IsActiveValue.Size = new Size(23, 20);
            lbl_IsActiveValue.TabIndex = 5;
            lbl_IsActiveValue.Text = "??";
            // 
            // lbl_IsActive
            // 
            lbl_IsActive.AutoSize = true;
            lbl_IsActive.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_IsActive.Location = new Point(641, 62);
            lbl_IsActive.Name = "lbl_IsActive";
            lbl_IsActive.Size = new Size(82, 23);
            lbl_IsActive.TabIndex = 4;
            lbl_IsActive.Text = "Is Active:";
            // 
            // lbl_UsernameValue
            // 
            lbl_UsernameValue.AutoSize = true;
            lbl_UsernameValue.Location = new Point(499, 65);
            lbl_UsernameValue.Name = "lbl_UsernameValue";
            lbl_UsernameValue.Size = new Size(23, 20);
            lbl_UsernameValue.TabIndex = 3;
            lbl_UsernameValue.Text = "??";
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Username.Location = new Point(399, 62);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(94, 23);
            lbl_Username.TabIndex = 2;
            lbl_Username.Text = "Username:";
            // 
            // lbl_UserIdValue
            // 
            lbl_UserIdValue.AutoSize = true;
            lbl_UserIdValue.Location = new Point(234, 65);
            lbl_UserIdValue.Name = "lbl_UserIdValue";
            lbl_UserIdValue.Size = new Size(23, 20);
            lbl_UserIdValue.TabIndex = 1;
            lbl_UserIdValue.Text = "??";
            // 
            // lbl_UserId
            // 
            lbl_UserId.AutoSize = true;
            lbl_UserId.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_UserId.Location = new Point(157, 62);
            lbl_UserId.Name = "lbl_UserId";
            lbl_UserId.Size = new Size(71, 23);
            lbl_UserId.TabIndex = 0;
            lbl_UserId.Text = "User Id:";
            // 
            // ucUserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Login_Information);
            Name = "ucUserInfo";
            Size = new Size(907, 589);
            Login_Information.ResumeLayout(false);
            Login_Information.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ucPersonDetails ucPersonDetails1;
        private GroupBox Login_Information;
        private Label lbl_IsActiveValue;
        private Label lbl_IsActive;
        private Label lbl_UsernameValue;
        private Label lbl_Username;
        private Label lbl_UserIdValue;
        private Label lbl_UserId;
    }
}
