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

namespace DVLD.UI.Common_Forms
{
    public partial class ucAddUpdatePerson : UserControl
    {
        public ucAddUpdatePerson()
        {
            InitializeComponent();

            cbCountry.DataSource = Country.GetAllCountryNames();
            cbCountry.SelectedIndex = 100;
        }
        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            CheckIsAllFieldsValid();
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            CheckIsAllFieldsValid();
        }

        private void txtPhoneNumber_Validated(object sender, EventArgs e)
        {
            CheckIsAllFieldsValid();
        }
        private void HandleIsNationalNumberAvailable(TextBox txtNationalNumber)
        {
            CheckIsAllFieldsValid();
        }
        private void txtNationalNumber_Validated(object sender, EventArgs e)
        {
            CheckIsAllFieldsValid();
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            CheckIsAllFieldsValid();
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            CheckIsAllFieldsValid();
        }

        private void llblSelectImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                pbPersonImage.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void llblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.Image = null;
        }

        private bool CheckIsAllFieldsValid()
        {

            if (txtFirstName.Text == string.Empty)
            {
                epNonNullFields.SetError(txtFirstName, "This Filed Can't be empty!");
                return false;
            }
            else
            {
                epNonNullFields.SetError(txtFirstName, "");
            }

            if (txtLastName.Text == string.Empty)
            {
                epNonNullFields.SetError(txtLastName, "This Filed Can't be empty!");
                return false;
            }
            else
            {
                epNonNullFields.SetError(txtLastName, "");
            }

            if (txtNationalNumber.Text == string.Empty)
            {
                epNonNullFields.SetError(txtNationalNumber, "This Filed Can't be empty!");
                return false;
            }
            else
            {
                epNonNullFields.SetError(txtNationalNumber, "");
            }

            if (Person.IsExists(txtNationalNumber.Text))
            {
                epNationalNumberAvailable.SetError(txtNationalNumber, "The national number is used. Please use another one!");
            }
            else
            {
                epNationalNumberAvailable.SetError(txtNationalNumber, "");
            }

            if (!(rbMale.Checked || rbFemale.Checked))
            {
                epGender.SetError(lblGender, "You must choose the gender!");
                return false;
            }
            else
            {
                epGender.SetError(lblGender, "");
            }

            if (txtEmail.Text == string.Empty)
            {
                epNonNullFields.SetError(txtEmail, "This Filed Can't be empty!");
                return false;
            }
            else
            {
                epNonNullFields.SetError(txtEmail, "");
            }

            if (!(txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".")))
            {
                epHandleEmailFormatting.SetError(txtEmail, "Please write a valid email formatting (ex: example@example.example)");
                return false;
            }
            else
            {
                epNonNullFields.SetError(txtEmail, "");
            }

            if (txtAddress.Text == string.Empty)
            {
                epNonNullFields.SetError(txtAddress, "This Filed Can't be empty!");
                return false;
            }
            else
            {
                epNonNullFields.SetError(txtAddress, "");
            }

            if (txtPhoneNumber.Text == string.Empty)
            {
                epNonNullFields.SetError(txtPhoneNumber, "This Filed Can't be empty!");
                return false;
            }
            else
            {
                epNonNullFields.SetError(txtPhoneNumber, "");
            }

            return true;
        }

        private void LoadAndSavePersonData()
        {
            Person person = new Person();
            person.FirstName = txtFirstName.Text;
            person.SecondName = txtSecondName.Text;
            person.ThirdName = txtThirdName.Text;
            person.LastName = txtLastName.Text;
            person.NationalNumber = txtNationalNumber.Text;
            person.Gender = rbFemale.Checked ? "F" : "M";
            person.Email = txtEmail.Text;
            person.DateOfBirth = dtpDateOfBirth.Value;
            person.Address = txtAddress.Text;
            person.PhoneNumber = txtPhoneNumber.Text;
            person.NationalityCountryID = Country.Find(cbCountry.SelectedItem?.ToString()).ID;
            person.PersonalPhotoPath = pbPersonImage.ImageLocation;

            if (person.Save())
            {
                btnSave.Enabled = false;
                lblID.Text = person.ID.ToString();
                MessageBox.Show($"The person added successfully with id {person.ID}", "Added successfully");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckIsAllFieldsValid())
                return;

            LoadAndSavePersonData();
        }

        private void rbMale_Validated(object sender, EventArgs e)
        {
            CheckIsAllFieldsValid();
        }

        private void rbFemale_Validated(object sender, EventArgs e)
        {
            CheckIsAllFieldsValid();
        }
    }
}
