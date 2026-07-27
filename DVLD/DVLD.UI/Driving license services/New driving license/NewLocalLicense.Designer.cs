using DVLD.UI.Common_Forms;

namespace DVLD.UI.Driving_license_services.New_driving_license
{
    partial class NewLocalLicense
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
            tabControl1 = new TabControl();
            tb_PersonInfo = new TabPage();
            btn_Next = new Button();
            gb_Filter = new GroupBox();
            btn_Search = new Button();
            btn_Add = new Button();
            txt_FilterByValue = new TextBox();
            cb_FilterBy = new ComboBox();
            ucPersonDetails1 = new ucPersonDetails();
            tb_ApplicationInfo = new TabPage();
            lbl_CreatedByValue = new Label();
            lbl_ApplicationFeeValue = new Label();
            cb_LicenceClasses = new ComboBox();
            lbl_ApplicationDateValue = new Label();
            lbl_ApplicationIdValue = new Label();
            lbl_CreatedBy = new Label();
            lbl_ApplicationFee = new Label();
            lbl_LicenseClass = new Label();
            lbl_ApplicationDate = new Label();
            lbl_ApplicationId = new Label();
            btn_Close = new Button();
            btn_Save = new Button();
            lbl_Title = new Label();
            tabControl1.SuspendLayout();
            tb_PersonInfo.SuspendLayout();
            gb_Filter.SuspendLayout();
            tb_ApplicationInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tb_PersonInfo);
            tabControl1.Controls.Add(tb_ApplicationInfo);
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
            // tb_ApplicationInfo
            // 
            tb_ApplicationInfo.Controls.Add(lbl_CreatedByValue);
            tb_ApplicationInfo.Controls.Add(lbl_ApplicationFeeValue);
            tb_ApplicationInfo.Controls.Add(cb_LicenceClasses);
            tb_ApplicationInfo.Controls.Add(lbl_ApplicationDateValue);
            tb_ApplicationInfo.Controls.Add(lbl_ApplicationIdValue);
            tb_ApplicationInfo.Controls.Add(lbl_CreatedBy);
            tb_ApplicationInfo.Controls.Add(lbl_ApplicationFee);
            tb_ApplicationInfo.Controls.Add(lbl_LicenseClass);
            tb_ApplicationInfo.Controls.Add(lbl_ApplicationDate);
            tb_ApplicationInfo.Controls.Add(lbl_ApplicationId);
            tb_ApplicationInfo.Location = new Point(4, 29);
            tb_ApplicationInfo.Name = "tb_ApplicationInfo";
            tb_ApplicationInfo.Padding = new Padding(3);
            tb_ApplicationInfo.Size = new Size(904, 519);
            tb_ApplicationInfo.TabIndex = 1;
            tb_ApplicationInfo.Text = "Application info";
            tb_ApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // lbl_CreatedByValue
            // 
            lbl_CreatedByValue.AutoSize = true;
            lbl_CreatedByValue.Location = new Point(236, 330);
            lbl_CreatedByValue.Name = "lbl_CreatedByValue";
            lbl_CreatedByValue.Size = new Size(30, 20);
            lbl_CreatedByValue.TabIndex = 9;
            lbl_CreatedByValue.Text = "???";
            // 
            // lbl_ApplicationFeeValue
            // 
            lbl_ApplicationFeeValue.AutoSize = true;
            lbl_ApplicationFeeValue.Location = new Point(233, 292);
            lbl_ApplicationFeeValue.Name = "lbl_ApplicationFeeValue";
            lbl_ApplicationFeeValue.Size = new Size(33, 20);
            lbl_ApplicationFeeValue.TabIndex = 8;
            lbl_ApplicationFeeValue.Text = "000";
            // 
            // cb_LicenceClasses
            // 
            cb_LicenceClasses.FormattingEnabled = true;
            cb_LicenceClasses.Location = new Point(233, 252);
            cb_LicenceClasses.Name = "cb_LicenceClasses";
            cb_LicenceClasses.Size = new Size(361, 28);
            cb_LicenceClasses.TabIndex = 7;
            // 
            // lbl_ApplicationDateValue
            // 
            lbl_ApplicationDateValue.AutoSize = true;
            lbl_ApplicationDateValue.Location = new Point(233, 218);
            lbl_ApplicationDateValue.Name = "lbl_ApplicationDateValue";
            lbl_ApplicationDateValue.Size = new Size(85, 20);
            lbl_ApplicationDateValue.TabIndex = 6;
            lbl_ApplicationDateValue.Text = "00/00/0000";
            // 
            // lbl_ApplicationIdValue
            // 
            lbl_ApplicationIdValue.AutoSize = true;
            lbl_ApplicationIdValue.Location = new Point(233, 181);
            lbl_ApplicationIdValue.Name = "lbl_ApplicationIdValue";
            lbl_ApplicationIdValue.Size = new Size(30, 20);
            lbl_ApplicationIdValue.TabIndex = 5;
            lbl_ApplicationIdValue.Text = "???";
            // 
            // lbl_CreatedBy
            // 
            lbl_CreatedBy.AutoSize = true;
            lbl_CreatedBy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_CreatedBy.Location = new Point(117, 322);
            lbl_CreatedBy.Name = "lbl_CreatedBy";
            lbl_CreatedBy.Size = new Size(110, 28);
            lbl_CreatedBy.TabIndex = 4;
            lbl_CreatedBy.Text = "Created By";
            // 
            // lbl_ApplicationFee
            // 
            lbl_ApplicationFee.AutoSize = true;
            lbl_ApplicationFee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_ApplicationFee.Location = new Point(75, 285);
            lbl_ApplicationFee.Name = "lbl_ApplicationFee";
            lbl_ApplicationFee.Size = new Size(152, 28);
            lbl_ApplicationFee.TabIndex = 3;
            lbl_ApplicationFee.Text = "Application Fee";
            // 
            // lbl_LicenseClass
            // 
            lbl_LicenseClass.AutoSize = true;
            lbl_LicenseClass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_LicenseClass.Location = new Point(97, 248);
            lbl_LicenseClass.Name = "lbl_LicenseClass";
            lbl_LicenseClass.Size = new Size(130, 28);
            lbl_LicenseClass.TabIndex = 2;
            lbl_LicenseClass.Text = "License Class";
            // 
            // lbl_ApplicationDate
            // 
            lbl_ApplicationDate.AutoSize = true;
            lbl_ApplicationDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_ApplicationDate.Location = new Point(65, 211);
            lbl_ApplicationDate.Name = "lbl_ApplicationDate";
            lbl_ApplicationDate.Size = new Size(162, 28);
            lbl_ApplicationDate.TabIndex = 1;
            lbl_ApplicationDate.Text = "Application Date";
            // 
            // lbl_ApplicationId
            // 
            lbl_ApplicationId.AutoSize = true;
            lbl_ApplicationId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_ApplicationId.Location = new Point(87, 174);
            lbl_ApplicationId.Name = "lbl_ApplicationId";
            lbl_ApplicationId.Size = new Size(140, 28);
            lbl_ApplicationId.TabIndex = 0;
            lbl_ApplicationId.Text = "Application ID";
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
            lbl_Title.Location = new Point(208, 36);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(517, 38);
            lbl_Title.TabIndex = 5;
            lbl_Title.Text = "New Local Driving License Application";
            // 
            // NewLocalLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 689);
            Controls.Add(lbl_Title);
            Controls.Add(btn_Save);
            Controls.Add(btn_Close);
            Controls.Add(tabControl1);
            Name = "NewLocalLicense";
            Text = "New Local Driving License Application";
            tabControl1.ResumeLayout(false);
            tb_PersonInfo.ResumeLayout(false);
            gb_Filter.ResumeLayout(false);
            gb_Filter.PerformLayout();
            tb_ApplicationInfo.ResumeLayout(false);
            tb_ApplicationInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tb_PersonInfo;
        private TabPage tb_ApplicationInfo;
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
        private Label lbl_CreatedBy;
        private Label lbl_ApplicationFee;
        private Label lbl_LicenseClass;
        private Label lbl_ApplicationDate;
        private Label lbl_ApplicationId;
        private Label lbl_ApplicationIdValue;
        private Label lbl_ApplicationDateValue;
        private Label lbl_CreatedByValue;
        private Label lbl_ApplicationFeeValue;
        private ComboBox cb_LicenceClasses;
    }
}