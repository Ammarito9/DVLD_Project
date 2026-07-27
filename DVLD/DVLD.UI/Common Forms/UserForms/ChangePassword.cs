using DVLD.BLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Common_Forms.UserForms
{
    public partial class ChangePassword : Form
    {
        private int Id;
        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(int ID) : this()
        {
            Id = ID;

            InitializeUserInfo();
        }

        private void InitializeUserInfo()
        {
            SuspendLayout();

            ucUserInfo1 = new uc.ucUserInfo(Id);
            ucUserInfo1.Location = new Point(12, 12);
            ucUserInfo1.Name = "ucUserInfo1";
            ucUserInfo1.Size = new Size(1134, 585);
            this.Controls.Add(ucUserInfo1);

            ResumeLayout(false);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_CurrentPasswordValue_Leave(object sender, EventArgs e)
        {
            HandleEmptyTextBox((TextBox)sender);
        }

        private bool HandleEmptyTextBox(TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
            {
                ep_HandleEmptyTestBox.SetError(textBox, "This filed can't be empty");
                return true;
            }
            else
            {
                ep_HandleEmptyTestBox.SetError(textBox, "");
                return false;
            }
        }

        private bool IsChangingPasswordValid()
        {
            if (txt_CurrentPasswordValue.Text != CurrentUser.LoggedInUser.Password)
            {
                ep_PasswordDoesNotMatch.SetError(txt_CurrentPasswordValue, "Password is Wrong!");
                return false;
            }

            ep_PasswordDoesNotMatch.SetError(txt_CurrentPasswordValue, "");

            if (HandleEmptyTextBox(txt_NewPasswordValue) || HandleEmptyTextBox(txt_ConfirmPasswordValue))
                return false;

            if (txt_ConfirmPasswordValue.Text != txt_NewPasswordValue.Text)
            {
                ep_PasswordDoesNotMatch.SetError(txt_ConfirmPasswordValue, "Passwords does NOT match!");
                return false;
            }

            // the New and Confirm matched and filed
            return true;
        }

        private void txt_ConfirmPasswordValue_Leave(object sender, EventArgs e)
        {
             HandleEmptyTextBox(txt_ConfirmPasswordValue);
        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            if (!IsChangingPasswordValid())
                return;

            
            CurrentUser.LoggedInUser.Password = txt_ConfirmPasswordValue.Text;

            if (CurrentUser.LoggedInUser.Save())
            {
                MessageBox.Show("Password updated successfully!");
            }
            else
            {
                MessageBox.Show("Error! Password did NOT update.");
            }
            
        }
    }
}
