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
            CurrentUser.LoggedInUser = User.GetCredentialsFromRememberMe();

            if (CurrentUser.LoggedInUser != null)
            {
                txtUsername.Text = CurrentUser.LoggedInUser.UserName;
                txtPassword.Text = CurrentUser.LoggedInUser.Password;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateCredentialsTextBoxes(txtUsername) || !ValidateCredentialsTextBoxes(txtPassword)) 
            {
                return;
            }
            CurrentUser.LoggedInUser = User.CheckCredentials(txtUsername.Text, txtPassword.Text);

            if (CurrentUser.LoggedInUser == null)
            {
                MessageBox.Show("Invalid username or password", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (chkRememberMe.Checked)
                {
                    User.AddCredentialsToRememberMe(txtUsername.Text);
                }
                else
                {
                    User.AddCredentialsToRememberMe(string.Empty);
                }
            }
            MainForm mf = new MainForm();
            this.Hide();
            txtUsername.Clear();
            txtPassword.Clear();
            mf.ShowDialog();
        }


        private void txtUsername_MouseLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty)
            {
                txtUsername.Focus();
            }
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

    }
}
