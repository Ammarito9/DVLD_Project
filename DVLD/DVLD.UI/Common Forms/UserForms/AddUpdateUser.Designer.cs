namespace DVLD.UI.Common_Forms.UserForms
{
    partial class AddUpdateUser
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
            tabControl1 = new TabControl();
            tb_PersonInfo = new TabPage();
            btn_Next = new Button();
            gb_Filter = new GroupBox();
            btn_Search = new Button();
            btn_Add = new Button();
            txt_FilterByValue = new TextBox();
            cb_FilterBy = new ComboBox();
            ucPersonDetails1 = new ucPersonDetails();
            tb_LoginInfo = new TabPage();
            cb_IsActiveValue = new CheckBox();
            txt_ConfirmPasswordValue = new TextBox();
            txt_PasswordValue = new TextBox();
            txt_UsernameValue = new TextBox();
            lbl_UserIdValue = new Label();
            lbl_IsActive = new Label();
            lbl_ConfirmPassword = new Label();
            lbl_Password = new Label();
            lbl_Username = new Label();
            lbl_UserId = new Label();
            btn_Close = new Button();
            btn_Save = new Button();
            lbl_Title = new Label();
            ep_UsernameNotAvailable = new ErrorProvider(components);
            ep_CantBeEmpty = new ErrorProvider(components);
            ep_PasswordDoesNotMatch = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tb_PersonInfo.SuspendLayout();
            gb_Filter.SuspendLayout();
            tb_LoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ep_UsernameNotAvailable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ep_CantBeEmpty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ep_PasswordDoesNotMatch).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tb_PersonInfo);
            tabControl1.Controls.Add(tb_LoginInfo);
            tabControl1.Location = new Point(12, 96);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(912, 552);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tb_PersonInfo
            // 
            tb_PersonInfo.Controls.Add(btn_Next);
            tb_PersonInfo.Controls.Add(gb_Filter);
            tb_PersonInfo.Controls.Add(ucPersonDetails1);
            tb_PersonInfo.Location = new Point(4, 29);
            tb_PersonInfo.Name = "tb_PersonInfo";
            tb_PersonInfo.Padding = new Padding(3);
            tb_PersonInfo.Size = new Size(904, 519);
            tb_PersonInfo.TabIndex = 0;
            tb_PersonInfo.Text = "Person Info";
            tb_PersonInfo.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            btn_Next.Location = new Point(798, 477);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(94, 29);
            btn_Next.TabIndex = 2;
            btn_Next.Text = "Next";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // gb_Filter
            // 
            gb_Filter.Controls.Add(btn_Search);
            gb_Filter.Controls.Add(btn_Add);
            gb_Filter.Controls.Add(txt_FilterByValue);
            gb_Filter.Controls.Add(cb_FilterBy);
            gb_Filter.Location = new Point(6, 6);
            gb_Filter.Name = "gb_Filter";
            gb_Filter.Size = new Size(892, 125);
            gb_Filter.TabIndex = 1;
            gb_Filter.TabStop = false;
            gb_Filter.Text = "Filter";
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(692, 51);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(94, 29);
            btn_Search.TabIndex = 1;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(792, 51);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 29);
            btn_Add.TabIndex = 2;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // txt_FilterByValue
            // 
            txt_FilterByValue.Location = new Point(261, 51);
            txt_FilterByValue.Name = "txt_FilterByValue";
            txt_FilterByValue.Size = new Size(251, 27);
            txt_FilterByValue.TabIndex = 1;
            // 
            // cb_FilterBy
            // 
            cb_FilterBy.FormattingEnabled = true;
            cb_FilterBy.Items.AddRange(new object[] { "National Id", "Person Id" });
            cb_FilterBy.Location = new Point(6, 50);
            cb_FilterBy.Name = "cb_FilterBy";
            cb_FilterBy.Size = new Size(249, 28);
            cb_FilterBy.TabIndex = 0;
            // 
            // ucPersonDetails1
            // 
            ucPersonDetails1.Location = new Point(3, 27);
            ucPersonDetails1.Name = "ucPersonDetails1";
            ucPersonDetails1.Size = new Size(905, 444);
            ucPersonDetails1.TabIndex = 3;
            // 
            // tb_LoginInfo
            // 
            tb_LoginInfo.Controls.Add(cb_IsActiveValue);
            tb_LoginInfo.Controls.Add(txt_ConfirmPasswordValue);
            tb_LoginInfo.Controls.Add(txt_PasswordValue);
            tb_LoginInfo.Controls.Add(txt_UsernameValue);
            tb_LoginInfo.Controls.Add(lbl_UserIdValue);
            tb_LoginInfo.Controls.Add(lbl_IsActive);
            tb_LoginInfo.Controls.Add(lbl_ConfirmPassword);
            tb_LoginInfo.Controls.Add(lbl_Password);
            tb_LoginInfo.Controls.Add(lbl_Username);
            tb_LoginInfo.Controls.Add(lbl_UserId);
            tb_LoginInfo.Location = new Point(4, 29);
            tb_LoginInfo.Name = "tb_LoginInfo";
            tb_LoginInfo.Padding = new Padding(3);
            tb_LoginInfo.Size = new Size(904, 519);
            tb_LoginInfo.TabIndex = 1;
            tb_LoginInfo.Text = "Login info";
            tb_LoginInfo.UseVisualStyleBackColor = true;
            // 
            // cb_IsActiveValue
            // 
            cb_IsActiveValue.AutoSize = true;
            cb_IsActiveValue.Location = new Point(221, 332);
            cb_IsActiveValue.Name = "cb_IsActiveValue";
            cb_IsActiveValue.Size = new Size(18, 17);
            cb_IsActiveValue.TabIndex = 9;
            cb_IsActiveValue.UseVisualStyleBackColor = true;
            // 
            // txt_ConfirmPasswordValue
            // 
            txt_ConfirmPasswordValue.Location = new Point(221, 289);
            txt_ConfirmPasswordValue.Name = "txt_ConfirmPasswordValue";
            txt_ConfirmPasswordValue.Size = new Size(125, 27);
            txt_ConfirmPasswordValue.TabIndex = 8;
            txt_ConfirmPasswordValue.Leave += txt_ConfirmPasswordValue_Leave;
            // 
            // txt_PasswordValue
            // 
            txt_PasswordValue.Location = new Point(221, 252);
            txt_PasswordValue.Name = "txt_PasswordValue";
            txt_PasswordValue.Size = new Size(125, 27);
            txt_PasswordValue.TabIndex = 7;
            txt_PasswordValue.Leave += txt_PasswordValue_Leave;
            // 
            // txt_UsernameValue
            // 
            txt_UsernameValue.Location = new Point(221, 215);
            txt_UsernameValue.Name = "txt_UsernameValue";
            txt_UsernameValue.Size = new Size(125, 27);
            txt_UsernameValue.TabIndex = 6;
            txt_UsernameValue.Leave += txt_UsernameValue_Leave;
            // 
            // lbl_UserIdValue
            // 
            lbl_UserIdValue.AutoSize = true;
            lbl_UserIdValue.Location = new Point(221, 181);
            lbl_UserIdValue.Name = "lbl_UserIdValue";
            lbl_UserIdValue.Size = new Size(30, 20);
            lbl_UserIdValue.TabIndex = 5;
            lbl_UserIdValue.Text = "???";
            // 
            // lbl_IsActive
            // 
            lbl_IsActive.AutoSize = true;
            lbl_IsActive.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_IsActive.Location = new Point(117, 322);
            lbl_IsActive.Name = "lbl_IsActive";
            lbl_IsActive.Size = new Size(85, 28);
            lbl_IsActive.TabIndex = 4;
            lbl_IsActive.Text = "Is active";
            // 
            // lbl_ConfirmPassword
            // 
            lbl_ConfirmPassword.AutoSize = true;
            lbl_ConfirmPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_ConfirmPassword.Location = new Point(25, 285);
            lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            lbl_ConfirmPassword.Size = new Size(177, 28);
            lbl_ConfirmPassword.TabIndex = 3;
            lbl_ConfirmPassword.Text = "Confirm password";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_Password.Location = new Point(105, 248);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(97, 28);
            lbl_Password.TabIndex = 2;
            lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_Username.Location = new Point(98, 211);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(104, 28);
            lbl_Username.TabIndex = 1;
            lbl_Username.Text = "Username";
            // 
            // lbl_UserId
            // 
            lbl_UserId.AutoSize = true;
            lbl_UserId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_UserId.Location = new Point(125, 174);
            lbl_UserId.Name = "lbl_UserId";
            lbl_UserId.Size = new Size(77, 28);
            lbl_UserId.TabIndex = 0;
            lbl_UserId.Text = "User Id";
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(814, 654);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(94, 29);
            btn_Close.TabIndex = 3;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_Save
            // 
            btn_Save.Enabled = false;
            btn_Save.Location = new Point(714, 654);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(94, 29);
            btn_Save.TabIndex = 4;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lbl_Title.Location = new Point(390, 36);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(152, 38);
            lbl_Title.TabIndex = 5;
            lbl_Title.Text = "Form Title";
            // 
            // ep_UsernameNotAvailable
            // 
            ep_UsernameNotAvailable.ContainerControl = this;
            // 
            // ep_CantBeEmpty
            // 
            ep_CantBeEmpty.ContainerControl = this;
            // 
            // ep_PasswordDoesNotMatch
            // 
            ep_PasswordDoesNotMatch.ContainerControl = this;
            // 
            // AddUpdateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 689);
            Controls.Add(lbl_Title);
            Controls.Add(btn_Save);
            Controls.Add(btn_Close);
            Controls.Add(tabControl1);
            Name = "AddUpdateUser";
            Text = "AddUpdateUser";
            tabControl1.ResumeLayout(false);
            tb_PersonInfo.ResumeLayout(false);
            gb_Filter.ResumeLayout(false);
            gb_Filter.PerformLayout();
            tb_LoginInfo.ResumeLayout(false);
            tb_LoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ep_UsernameNotAvailable).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep_CantBeEmpty).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep_PasswordDoesNotMatch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tb_PersonInfo;
        private TabPage tb_LoginInfo;
        private GroupBox gb_Filter;
        private TextBox txt_FilterByValue;
        private ComboBox cb_FilterBy;
        private Button btn_Search;
        private Button btn_Add;
        private Button btn_Next;
        private Button btn_Close;
        private Button btn_Save;
        private Label lbl_Title;
        private ucPersonDetails ucPersonDetails1;
        private Label lbl_IsActive;
        private Label lbl_ConfirmPassword;
        private Label lbl_Password;
        private Label lbl_Username;
        private Label lbl_UserId;
        private CheckBox cb_IsActiveValue;
        private TextBox txt_ConfirmPasswordValue;
        private TextBox txt_PasswordValue;
        private TextBox txt_UsernameValue;
        private Label lbl_UserIdValue;
        private ErrorProvider ep_UsernameNotAvailable;
        private ErrorProvider ep_CantBeEmpty;
        private ErrorProvider ep_PasswordDoesNotMatch;
    }
}