using DVLD.UI.Common_Forms.UserForms;

namespace DVLD.UI.Manage_Applications
{
    partial class TestAppointmentForm
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
            uc_ApplicationBasicInfo1 = new uc_ApplicationBasicInfo();
            uc_DrivingLicenseApplicationInfo1 = new uc_DrivingLicenseApplicationInfo();
            dgv_Appointments = new DataGridView();
            cms_AppointementOperations = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            lbl_Appointment = new Label();
            btn_Schedule = new Button();
            btn_Close = new Button();
            lbl_NumberOfRows = new Label();
            lbl_NumberOfRowsValue = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Appointments).BeginInit();
            cms_AppointementOperations.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.Firebrick;
            lbl_Title.Location = new Point(320, 30);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(343, 41);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "Title Test Appointment";
            // 
            // uc_ApplicationBasicInfo1
            // 
            uc_ApplicationBasicInfo1.Location = new Point(0, 0);
            uc_ApplicationBasicInfo1.Name = "uc_ApplicationBasicInfo1";
            uc_ApplicationBasicInfo1.Size = new Size(1000, 200);
            uc_ApplicationBasicInfo1.TabIndex = 0;
            // 
            // uc_DrivingLicenseApplicationInfo1
            // 
            uc_DrivingLicenseApplicationInfo1.Location = new Point(0, 0);
            uc_DrivingLicenseApplicationInfo1.Name = "uc_DrivingLicenseApplicationInfo1";
            uc_DrivingLicenseApplicationInfo1.Size = new Size(1000, 100);
            uc_DrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // dgv_Appointments
            // 
            dgv_Appointments.AllowUserToAddRows = false;
            dgv_Appointments.AllowUserToDeleteRows = false;
            dgv_Appointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Appointments.ContextMenuStrip = cms_AppointementOperations;
            dgv_Appointments.Location = new Point(12, 460);
            dgv_Appointments.Name = "dgv_Appointments";
            dgv_Appointments.ReadOnly = true;
            dgv_Appointments.RowHeadersWidth = 51;
            dgv_Appointments.Size = new Size(958, 245);
            dgv_Appointments.TabIndex = 3;
            // 
            // cms_AppointementOperations
            // 
            cms_AppointementOperations.ImageScalingSize = new Size(20, 20);
            cms_AppointementOperations.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, takeTestToolStripMenuItem });
            cms_AppointementOperations.Name = "cms_AppointementOperations";
            cms_AppointementOperations.Size = new Size(211, 80);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(210, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(210, 24);
            takeTestToolStripMenuItem.Text = "Take test";
            takeTestToolStripMenuItem.Click += takeTestToolStripMenuItem_Click;
            // 
            // lbl_Appointment
            // 
            lbl_Appointment.AutoSize = true;
            lbl_Appointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Appointment.Location = new Point(12, 429);
            lbl_Appointment.Name = "lbl_Appointment";
            lbl_Appointment.Size = new Size(137, 28);
            lbl_Appointment.TabIndex = 4;
            lbl_Appointment.Text = "Appointment";
            // 
            // btn_Schedule
            // 
            btn_Schedule.Location = new Point(876, 425);
            btn_Schedule.Name = "btn_Schedule";
            btn_Schedule.Size = new Size(94, 29);
            btn_Schedule.TabIndex = 5;
            btn_Schedule.Text = "Schedule";
            btn_Schedule.UseVisualStyleBackColor = true;
            btn_Schedule.Click += btn_Schedule_Click;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(876, 711);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(94, 29);
            btn_Close.TabIndex = 6;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // lbl_NumberOfRows
            // 
            lbl_NumberOfRows.AutoSize = true;
            lbl_NumberOfRows.Location = new Point(12, 715);
            lbl_NumberOfRows.Name = "lbl_NumberOfRows";
            lbl_NumberOfRows.Size = new Size(116, 20);
            lbl_NumberOfRows.TabIndex = 7;
            lbl_NumberOfRows.Text = "Number of rows";
            // 
            // lbl_NumberOfRowsValue
            // 
            lbl_NumberOfRowsValue.AutoSize = true;
            lbl_NumberOfRowsValue.Location = new Point(134, 715);
            lbl_NumberOfRowsValue.Name = "lbl_NumberOfRowsValue";
            lbl_NumberOfRowsValue.Size = new Size(25, 20);
            lbl_NumberOfRowsValue.TabIndex = 8;
            lbl_NumberOfRowsValue.Text = "00";
            // 
            // TestAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 746);
            Controls.Add(lbl_NumberOfRowsValue);
            Controls.Add(lbl_NumberOfRows);
            Controls.Add(btn_Close);
            Controls.Add(btn_Schedule);
            Controls.Add(lbl_Appointment);
            Controls.Add(dgv_Appointments);
            Controls.Add(lbl_Title);
            Name = "TestAppointmentForm";
            Text = "Test Appointment";
            ((System.ComponentModel.ISupportInitialize)dgv_Appointments).EndInit();
            cms_AppointementOperations.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title;
        private Common_Forms.UserForms.uc_DrivingLicenseApplicationInfo uc_DrivingLicenseApplicationInfo1;
        private Common_Forms.UserForms.uc_ApplicationBasicInfo uc_ApplicationBasicInfo1;
        private DataGridView dgv_Appointments;
        private Label lbl_Appointment;
        private Button btn_Schedule;
        private Button btn_Close;
        private Label lbl_NumberOfRows;
        private Label lbl_NumberOfRowsValue;
        private ContextMenuStrip cms_AppointementOperations;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem takeTestToolStripMenuItem;
    }
}