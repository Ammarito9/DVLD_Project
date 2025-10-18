namespace DVLD.UI.Common_Forms
{
    partial class AddPerson
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
            ucAddUpdatePerson1 = new ucAddUpdatePerson();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ucAddUpdatePerson1
            // 
            ucAddUpdatePerson1.Dock = DockStyle.Fill;
            ucAddUpdatePerson1.Location = new Point(0, 0);
            ucAddUpdatePerson1.Name = "ucAddUpdatePerson1";
            ucAddUpdatePerson1.Size = new Size(937, 505);
            ucAddUpdatePerson1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(803, 443);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AddPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 505);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(ucAddUpdatePerson1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "AddPerson";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Add Person";
            ResumeLayout(false);
        }

        #endregion

        private ucAddUpdatePerson ucAddUpdatePerson1;
        private Button btnClose;
    }
}