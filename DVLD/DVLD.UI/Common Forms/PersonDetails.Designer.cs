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
        private void InitializeComponent(int ID)
        {
            ucPersonDetails1 = new ucPersonDetails(ID);
            SuspendLayout();
            // 
            // ucPersonDetails1
            // 
            ucPersonDetails1.Location = new Point(-12, -29);
            ucPersonDetails1.Name = "ucPersonDetails1";
            ucPersonDetails1.Size = new Size(906, 449);
            ucPersonDetails1.TabIndex = 0;
            // 
            // PersonDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 419);
            Controls.Add(ucPersonDetails1);
            Name = "PersonDetails";
            Text = "PersonDetails";
            ResumeLayout(false);
        }

        #endregion

        private ucPersonDetails ucPersonDetails1;
    }
}