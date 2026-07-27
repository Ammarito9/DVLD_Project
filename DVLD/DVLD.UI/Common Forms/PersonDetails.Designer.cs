namespace DVLD.UI.Common_Forms
{
    partial class PersonDetails
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
            btnClose = new Button();
            lblCardTitle = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(776, 431);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 92;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblCardTitle
            // 
            lblCardTitle.AutoSize = true;
            lblCardTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardTitle.Location = new Point(325, 9);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(203, 38);
            lblCardTitle.TabIndex = 93;
            lblCardTitle.Text = "Person Details";
            // 
            // PersonDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 472);
            ControlBox = false;
            Controls.Add(lblCardTitle);
            Controls.Add(btnClose);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PersonDetails";
            Text = "PersonDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ucPersonDetails ucPersonDetails1;
        private Button btnClose;
        private Label lblCardTitle;
    }
}