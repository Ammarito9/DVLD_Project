namespace DVLD.UI.Common_Forms
{
    partial class ucAddUpdatePerson
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
            components = new System.ComponentModel.Container();
            gbPersonData = new GroupBox();
            llblRemove = new LinkLabel();
            lblLast = new Label();
            lblThird = new Label();
            lblSecond = new Label();
            lblFirst = new Label();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            pbAddress = new PictureBox();
            pbEmail = new PictureBox();
            pbGender = new PictureBox();
            pbNationalNumber = new PictureBox();
            pbDateOfBirth = new PictureBox();
            pbPhone = new PictureBox();
            pbCountry = new PictureBox();
            pbName = new PictureBox();
            llblSelectImage = new LinkLabel();
            pbPersonImage = new PictureBox();
            dtpDateOfBirth = new DateTimePicker();
            cbCountry = new ComboBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            txtNationalNumber = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtThirdName = new TextBox();
            txtSecondName = new TextBox();
            txtFirstName = new TextBox();
            lblCountry = new Label();
            lblPhone = new Label();
            lblDateOfBirth = new Label();
            lblAddress = new Label();
            lblEmail = new Label();
            lblGender = new Label();
            lblNationalnumber = new Label();
            lblName = new Label();
            lblCardTitle = new Label();
            lblPersonId = new Label();
            lblID = new Label();
            pictureBox10 = new PictureBox();
            epNonNullFields = new ErrorProvider(components);
            epHandleEmailFormatting = new ErrorProvider(components);
            epNationalNumberAvailable = new ErrorProvider(components);
            openFileDialog = new OpenFileDialog();
            btnSave = new Button();
            epGender = new ErrorProvider(components);
            gbPersonData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNationalNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDateOfBirth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCountry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epNonNullFields).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epHandleEmailFormatting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epNationalNumberAvailable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epGender).BeginInit();
            SuspendLayout();
            // 
            // gbPersonData
            // 
            gbPersonData.Controls.Add(llblRemove);
            gbPersonData.Controls.Add(lblLast);
            gbPersonData.Controls.Add(lblThird);
            gbPersonData.Controls.Add(lblSecond);
            gbPersonData.Controls.Add(lblFirst);
            gbPersonData.Controls.Add(rbFemale);
            gbPersonData.Controls.Add(rbMale);
            gbPersonData.Controls.Add(pbAddress);
            gbPersonData.Controls.Add(pbEmail);
            gbPersonData.Controls.Add(pbGender);
            gbPersonData.Controls.Add(pbNationalNumber);
            gbPersonData.Controls.Add(pbDateOfBirth);
            gbPersonData.Controls.Add(pbPhone);
            gbPersonData.Controls.Add(pbCountry);
            gbPersonData.Controls.Add(pbName);
            gbPersonData.Controls.Add(llblSelectImage);
            gbPersonData.Controls.Add(pbPersonImage);
            gbPersonData.Controls.Add(dtpDateOfBirth);
            gbPersonData.Controls.Add(cbCountry);
            gbPersonData.Controls.Add(txtPhoneNumber);
            gbPersonData.Controls.Add(txtAddress);
            gbPersonData.Controls.Add(txtNationalNumber);
            gbPersonData.Controls.Add(txtEmail);
            gbPersonData.Controls.Add(txtLastName);
            gbPersonData.Controls.Add(txtThirdName);
            gbPersonData.Controls.Add(txtSecondName);
            gbPersonData.Controls.Add(txtFirstName);
            gbPersonData.Controls.Add(lblCountry);
            gbPersonData.Controls.Add(lblPhone);
            gbPersonData.Controls.Add(lblDateOfBirth);
            gbPersonData.Controls.Add(lblAddress);
            gbPersonData.Controls.Add(lblEmail);
            gbPersonData.Controls.Add(lblGender);
            gbPersonData.Controls.Add(lblNationalnumber);
            gbPersonData.Controls.Add(lblName);
            gbPersonData.FlatStyle = FlatStyle.System;
            gbPersonData.Location = new Point(3, 88);
            gbPersonData.Name = "gbPersonData";
            gbPersonData.Size = new Size(894, 346);
            gbPersonData.TabIndex = 0;
            gbPersonData.TabStop = false;
            // 
            // llblRemove
            // 
            llblRemove.AutoSize = true;
            llblRemove.Location = new Point(719, 264);
            llblRemove.Name = "llblRemove";
            llblRemove.Size = new Size(63, 20);
            llblRemove.TabIndex = 40;
            llblRemove.TabStop = true;
            llblRemove.Text = "Remove";
            llblRemove.LinkClicked += llblRemove_LinkClicked;
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Location = new Point(770, 13);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(35, 20);
            lblLast.TabIndex = 39;
            lblLast.Text = "Last";
            // 
            // lblThird
            // 
            lblThird.AutoSize = true;
            lblThird.Location = new Point(601, 13);
            lblThird.Name = "lblThird";
            lblThird.Size = new Size(43, 20);
            lblThird.TabIndex = 38;
            lblThird.Text = "Third";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Location = new Point(432, 13);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(58, 20);
            lblSecond.TabIndex = 37;
            lblSecond.Text = "Second";
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Location = new Point(263, 13);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(36, 20);
            lblFirst.TabIndex = 36;
            lblFirst.Text = "First";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(212, 154);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 34;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.Validated += rbFemale_Validated;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(212, 124);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 35;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.Validated += rbMale_Validated;
            // 
            // pbAddress
            // 
            pbAddress.Image = Properties.Resources.Address;
            pbAddress.InitialImage = Properties.Resources.Name;
            pbAddress.Location = new Point(27, 239);
            pbAddress.Name = "pbAddress";
            pbAddress.Size = new Size(30, 30);
            pbAddress.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAddress.TabIndex = 32;
            pbAddress.TabStop = false;
            // 
            // pbEmail
            // 
            pbEmail.Image = Properties.Resources.Email;
            pbEmail.InitialImage = Properties.Resources.Name;
            pbEmail.Location = new Point(27, 188);
            pbEmail.Name = "pbEmail";
            pbEmail.Size = new Size(30, 30);
            pbEmail.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEmail.TabIndex = 31;
            pbEmail.TabStop = false;
            // 
            // pbGender
            // 
            pbGender.Image = Properties.Resources.Gender;
            pbGender.InitialImage = Properties.Resources.Name;
            pbGender.Location = new Point(27, 136);
            pbGender.Name = "pbGender";
            pbGender.Size = new Size(30, 30);
            pbGender.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGender.TabIndex = 30;
            pbGender.TabStop = false;
            // 
            // pbNationalNumber
            // 
            pbNationalNumber.Image = Properties.Resources.NationalNo;
            pbNationalNumber.InitialImage = Properties.Resources.Name;
            pbNationalNumber.Location = new Point(27, 84);
            pbNationalNumber.Name = "pbNationalNumber";
            pbNationalNumber.Size = new Size(30, 30);
            pbNationalNumber.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNationalNumber.TabIndex = 29;
            pbNationalNumber.TabStop = false;
            // 
            // pbDateOfBirth
            // 
            pbDateOfBirth.Image = Properties.Resources.Date;
            pbDateOfBirth.InitialImage = Properties.Resources.Name;
            pbDateOfBirth.Location = new Point(381, 85);
            pbDateOfBirth.Name = "pbDateOfBirth";
            pbDateOfBirth.Size = new Size(30, 30);
            pbDateOfBirth.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDateOfBirth.TabIndex = 28;
            pbDateOfBirth.TabStop = false;
            // 
            // pbPhone
            // 
            pbPhone.Image = Properties.Resources.Phone;
            pbPhone.InitialImage = Properties.Resources.Name;
            pbPhone.Location = new Point(381, 136);
            pbPhone.Name = "pbPhone";
            pbPhone.Size = new Size(30, 30);
            pbPhone.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPhone.TabIndex = 27;
            pbPhone.TabStop = false;
            // 
            // pbCountry
            // 
            pbCountry.Image = Properties.Resources.Country;
            pbCountry.InitialImage = Properties.Resources.Name;
            pbCountry.Location = new Point(381, 188);
            pbCountry.Name = "pbCountry";
            pbCountry.Size = new Size(30, 30);
            pbCountry.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCountry.TabIndex = 26;
            pbCountry.TabStop = false;
            // 
            // pbName
            // 
            pbName.Image = Properties.Resources.Name;
            pbName.InitialImage = Properties.Resources.Name;
            pbName.Location = new Point(27, 35);
            pbName.Name = "pbName";
            pbName.Size = new Size(30, 30);
            pbName.SizeMode = PictureBoxSizeMode.StretchImage;
            pbName.TabIndex = 25;
            pbName.TabStop = false;
            // 
            // llblSelectImage
            // 
            llblSelectImage.AutoSize = true;
            llblSelectImage.Location = new Point(719, 244);
            llblSelectImage.Name = "llblSelectImage";
            llblSelectImage.Size = new Size(95, 20);
            llblSelectImage.TabIndex = 21;
            llblSelectImage.TabStop = true;
            llblSelectImage.Text = "Select image";
            llblSelectImage.LinkClicked += llblSelectImage_LinkClicked;
            // 
            // pbPersonImage
            // 
            pbPersonImage.InitialImage = Properties.Resources.Businessman;
            pbPersonImage.Location = new Point(719, 69);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(153, 172);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 20;
            pbPersonImage.TabStop = false;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(548, 85);
            dtpDateOfBirth.MaxDate = new DateTime(2025, 10, 14, 0, 0, 0, 0);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(155, 27);
            dtpDateOfBirth.TabIndex = 19;
            dtpDateOfBirth.Value = new DateTime(2025, 10, 14, 0, 0, 0, 0);
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(548, 188);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(155, 28);
            cbCountry.TabIndex = 18;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(548, 137);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(155, 27);
            txtPhoneNumber.TabIndex = 17;
            txtPhoneNumber.Validated += txtPhoneNumber_Validated;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(212, 244);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(491, 85);
            txtAddress.TabIndex = 16;
            txtAddress.Validated += txtAddress_Validated;
            // 
            // txtNationalNumber
            // 
            txtNationalNumber.Location = new Point(212, 85);
            txtNationalNumber.Name = "txtNationalNumber";
            txtNationalNumber.Size = new Size(153, 27);
            txtNationalNumber.TabIndex = 15;
            txtNationalNumber.Validated += txtNationalNumber_Validated;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(212, 189);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(153, 27);
            txtEmail.TabIndex = 13;
            txtEmail.Validated += txtEmail_Validated;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(719, 36);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(153, 27);
            txtLastName.TabIndex = 12;
            txtLastName.Validated += txtLastName_Validated;
            // 
            // txtThirdName
            // 
            txtThirdName.Location = new Point(550, 36);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Size = new Size(153, 27);
            txtThirdName.TabIndex = 11;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(381, 36);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(153, 27);
            txtSecondName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(212, 36);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(153, 27);
            txtFirstName.TabIndex = 9;
            txtFirstName.Validated += txtFirstName_Validated;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCountry.Location = new Point(415, 193);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(65, 20);
            lblCountry.TabIndex = 8;
            lblCountry.Text = "Country";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPhone.Location = new Point(415, 141);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(53, 20);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDateOfBirth.Location = new Point(415, 89);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(98, 20);
            lblDateOfBirth.TabIndex = 6;
            lblDateOfBirth.Text = "Date Of Birth";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblAddress.Location = new Point(63, 244);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(63, 20);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Address";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(63, 193);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblGender.Location = new Point(63, 141);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(59, 20);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender";
            // 
            // lblNationalnumber
            // 
            lblNationalnumber.AutoSize = true;
            lblNationalnumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNationalnumber.Location = new Point(63, 89);
            lblNationalnumber.Name = "lblNationalnumber";
            lblNationalnumber.Size = new Size(129, 20);
            lblNationalnumber.TabIndex = 2;
            lblNationalnumber.Text = "National Number";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblName.Location = new Point(63, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblCardTitle
            // 
            lblCardTitle.AutoSize = true;
            lblCardTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardTitle.Location = new Point(333, 34);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(234, 38);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Add New Person";
            // 
            // lblPersonId
            // 
            lblPersonId.AutoSize = true;
            lblPersonId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPersonId.Location = new Point(66, 446);
            lblPersonId.Name = "lblPersonId";
            lblPersonId.Size = new Size(74, 20);
            lblPersonId.TabIndex = 22;
            lblPersonId.Text = "Person ID";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblID.Location = new Point(146, 446);
            lblID.Name = "lblID";
            lblID.Size = new Size(25, 20);
            lblID.TabIndex = 24;
            lblID.Text = "00";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.ID;
            pictureBox10.InitialImage = Properties.Resources.Name;
            pictureBox10.Location = new Point(30, 441);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(30, 30);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 33;
            pictureBox10.TabStop = false;
            // 
            // epNonNullFields
            // 
            epNonNullFields.ContainerControl = this;
            // 
            // epHandleEmailFormatting
            // 
            epHandleEmailFormatting.ContainerControl = this;
            // 
            // epNationalNumberAvailable
            // 
            epNationalNumberAvailable.ContainerControl = this;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select Image";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(691, 442);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 41;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // epGender
            // 
            epGender.ContainerControl = this;
            // 
            // ucAddUpdatePerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSave);
            Controls.Add(pictureBox10);
            Controls.Add(lblID);
            Controls.Add(lblPersonId);
            Controls.Add(gbPersonData);
            Controls.Add(lblCardTitle);
            Name = "ucAddUpdatePerson";
            Size = new Size(900, 495);
            gbPersonData.ResumeLayout(false);
            gbPersonData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGender).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNationalNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDateOfBirth).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCountry).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)epNonNullFields).EndInit();
            ((System.ComponentModel.ISupportInitialize)epHandleEmailFormatting).EndInit();
            ((System.ComponentModel.ISupportInitialize)epNationalNumberAvailable).EndInit();
            ((System.ComponentModel.ISupportInitialize)epGender).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbPersonData;
        private Label lblCountry;
        private Label lblPhone;
        private Label lblDateOfBirth;
        private Label lblAddress;
        private Label lblEmail;
        private Label lblGender;
        private Label lblNationalnumber;
        private Label lblName;
        private Label lblCardTitle;
        private TextBox txtNationalNumber;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtThirdName;
        private TextBox txtSecondName;
        private TextBox txtFirstName;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cbCountry;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private LinkLabel llblSelectImage;
        private PictureBox pbPersonImage;
        private Label lblPersonId;
        private Label lblID;
        private PictureBox pbName;
        private PictureBox pbAddress;
        private PictureBox pbEmail;
        private PictureBox pbGender;
        private PictureBox pbNationalNumber;
        private PictureBox pbDateOfBirth;
        private PictureBox pbPhone;
        private PictureBox pbCountry;
        private PictureBox pictureBox10;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label lblLast;
        private Label lblThird;
        private Label lblSecond;
        private Label lblFirst;
        private ErrorProvider epNonNullFields;
        private ErrorProvider epHandleEmailFormatting;
        private ErrorProvider epNationalNumberAvailable;
        private LinkLabel llblRemove;
        private OpenFileDialog openFileDialog;
        private Button btnSave;
        private ErrorProvider epGender;
    }
}
