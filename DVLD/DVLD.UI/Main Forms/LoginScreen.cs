using DVLD.BLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD.UI.Main_Forms
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            FillDataFromRememberMeFile();
        }
        private void FillDataFromRememberMeFile()
        {
            User user = User.GetStoredUserCredentials();

            if (user is null)
                return;

            txtUsername.Text = user.UserName;
            txtPassword.Text = user.Password;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;

            User user = User.CheckCredentials(txtUsername.Text, txtPassword.Text);

            if (user is null)
            {
                MessageBox.Show("Invalid username or password", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // (CheckCredentials) func returns password empty if the user not found.
            // and it returns IsActive false if it's found but not active.
            if (user.Password == String.Empty)
            {
                MessageBox.Show("Invalid username or password", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (user.IsActive == false)
            {
                MessageBox.Show("The user is deactivated", "Please contact your admin!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chkRememberMe.Checked)
            {
                User.StoreUserCredentials(txtUsername.Text, txtPassword.Text);
            }
            else
            {
                User.StoreUserCredentials(string.Empty, string.Empty);
            }

            CurrentUser.LoggedInUser = user;
            MainForm mf = new MainForm();
            txtUsername.Clear();
            txtPassword.Clear();
            mf.ShowDialog();
            this.Close();
        }

        private bool ValidateCredentialsTextBoxes(object textBox)
        {
            if (string.IsNullOrEmpty(((System.Windows.Forms.TextBox)textBox).Text))
            {
                errorProvider1.SetError((System.Windows.Forms.TextBox)textBox, "This filed cant be empty");
                return false;
            }
            else
            {
                errorProvider1.SetError((System.Windows.Forms.TextBox)textBox, "");
                return true;
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            ValidateCredentialsTextBoxes(sender);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateCredentialsTextBoxes(sender);
        }
    }
}
