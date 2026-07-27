using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.BLL.Entities;
namespace DVLD.UI.Common_Forms.UserForms
{
    public partial class AddUpdateUser : Form
    {
        private int Id = 0;
        private enum Mode
        {
            Update,
            Add
        }
        private Mode _mode = Mode.Add;
        private User user = null;

        public AddUpdateUser()
        {
            InitializeComponent();
            cb_FilterBy.SelectedIndex = 0;


            if (_mode == Mode.Add)
            {
                lbl_Title.Text = "Add New User";
            }

        }

        public AddUpdateUser(int Id) : this()
        {
            _mode = Mode.Update;
            this.Id = Id;
            lbl_Title.Text = "Update User";
            gb_Filter.Enabled = false;
            user = User.Find(Id);
            LoadUserData();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadUserData()
        {
            lbl_UserIdValue.Text = user.ID.ToString();
            txt_UsernameValue.Text = user.UserName;
            txt_PasswordValue.Text = user.Password;
            txt_ConfirmPasswordValue.Text = user.Password;

            if(user.IsActive)
                cb_IsActiveValue.Checked = true;
            else
                cb_IsActiveValue.Checked = false;

            ucPersonDetails1.LoadPersonDetails(user.Person.ID);
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            addPerson.ShowDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_FilterByValue.Text))
            {
                MessageBox.Show("The search box can't be empty!");
                return;
            }

            // Filter by National number
            if (cb_FilterBy.SelectedIndex == 0)
            {
                ucPersonDetails1.LoadPersonDetails(txt_FilterByValue.Text);

                return;
            }
            // Filter by Person Id
            else if (cb_FilterBy.SelectedIndex == 1)
            {
                ucPersonDetails1.LoadPersonDetails(Convert.ToInt16(txt_FilterByValue.Text));
                return;
            }

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (ucPersonDetails1.person.ID == 0)
            {
                MessageBox.Show("There is no person to connect with!");
                return;
            }
            if (User.DoesPersonIdConnectedToUser(ucPersonDetails1.Id))
            {
                MessageBox.Show("This person already connected to user!");
                return;
            }

            tabControl1.SelectedIndex = 1;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                btn_Save.Enabled = false;
            else
                btn_Save.Enabled = true;
        }

        private bool CheckIfUsernameValid()
        {
            if (User.IsExist(txt_UsernameValue.Text))
                return false;
            return true;
        }
        private void txt_UsernameValue_Leave(object sender, EventArgs e)
        {
            if (CheckIfUsernameValid())
                ep_UsernameNotAvailable.SetError(txt_UsernameValue, "Username is NOT available!");
            else
                ep_UsernameNotAvailable.SetError(txt_UsernameValue, "");
        }

        private void txt_ConfirmPasswordValue_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_ConfirmPasswordValue.Text))
                ep_CantBeEmpty.SetError(txt_ConfirmPasswordValue, "This filed Can't be empty!");
            else
                ep_CantBeEmpty.SetError(txt_ConfirmPasswordValue, "");

            if (!CheckIfPasswordMatch())
                ep_PasswordDoesNotMatch.SetError(txt_ConfirmPasswordValue, "Passwords does not match!");
            else
                ep_PasswordDoesNotMatch.SetError(txt_ConfirmPasswordValue, "");
        }

        private bool CheckIfPasswordMatch()
        {
            if (txt_PasswordValue.Text.Equals(txt_ConfirmPasswordValue.Text))
                return true;
            return false;
        }

        private void txt_PasswordValue_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_PasswordValue.Text))
                ep_CantBeEmpty.SetError(txt_PasswordValue, "This filed Can't be empty!");
            else
                ep_CantBeEmpty.SetError(txt_PasswordValue, "");
        }

        private bool ArePasswordsValid()
        {
            if((!CheckIfPasswordMatch()) || 
                (String.IsNullOrEmpty(txt_PasswordValue.Text)) ||
                (String.IsNullOrEmpty(txt_ConfirmPasswordValue.Text)))
                return false;
            return true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ArePasswordsValid() && (CheckIfUsernameValid() || _mode == Mode.Update))
            {
                if (user == null)
                    user = new User();
                
                user.UserName = txt_UsernameValue.Text;
                user.Password = txt_ConfirmPasswordValue.Text;
                user.IsActive = cb_IsActiveValue.Checked;
                user.Person = ucPersonDetails1.person;
                
                if (!user.Save())
                {
                    MessageBox.Show("Error! User is not added.");
                    return;
                }

                lbl_UserIdValue.Text = user.ID.ToString();
                btn_Save.Enabled = false;
                MessageBox.Show("User added successfully!");
            }
            else
            {
                MessageBox.Show("All fields must be valid");
            }
        }
    }
}
