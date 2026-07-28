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
        private int Id = 0;
        public ucAddUpdatePerson(bool IsUpdateMode = false, int ID = 0)
        {
            InitializeComponent();

            cbCountry.DataSource = Country.GetAllCountryNames();
            
            if (IsUpdateMode)
            {
                Id = ID;
                InitializeAsUpdateMode(ID);
            }
            else
                cbCountry.SelectedIndex = 100;
        }

        private void InitializeAsUpdateMode(int ID)
        {
            lblCardTitle.Text = "Update Person";
            LoadPersonDataToUpdate(ID);
        }
        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            CheckIsAllFieldsValid();
        }

        private void LoadGender(string gender)
        {
            if (gender == "M")
            {
                rbMale.Checked = true;
                rbFemale.Checked = false;

                return;
            }
            rbMale.Checked = false;
            rbFemale.Checked = true;
        }
        private void LoadPersonDataToUpdate(int ID)
        {
            Person person = Person.Find(ID);

            if (person != null)
            {
                lblID.Text = Convert.ToString(person.ID);
                txtFirstName.Text = person.FirstName;
                txtSecondName.Text = person.SecondName;
                txtThirdName.Text = person.ThirdName;
                txtLastName.Text = person.LastName;
                txtNationalNumber.Text = person.NationalNumber;
                LoadGender(person.Gender);
                txtEmail.Text = person.Email;
                txtAddress.Text = person.Address;
                dtpDateOfBirth.Value = person.DateOfBirth;
                txtPhoneNumber.Text = person.PhoneNumber;
                // It's 0 based index and the IDs are 1 based so -1 to make the IDs 0 based.
                cbCountry.SelectedIndex = person.NationalityCountryID - 1;
                pbPersonImage.ImageLocation = person.PersonalPhotoPath; 
            }
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
            {
                var path = openFileDialog.FileName;
                pbPersonImage.Image = Image.FromFile(path);
                pbPersonImage.ImageLocation = path;
            }
        }

        private void llblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;
        }

        // TODO: Validation fires at wrong timing in some cases — revisit after project completion
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

            if (Person.IsExists(txtNationalNumber.Text, Id))
            {
                epNationalNumberAvailable.SetError(txtNationalNumber, "The national number is used. Please use another one!");
                return false;
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

            if (!(txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".")) && !string.IsNullOrEmpty(txtEmail.Text))
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
        
        private bool HandlePersonImage(ref Person person)
        {
            if (person.PersonalPhotoPath != pbPersonImage.ImageLocation)
            {
                if (!string.IsNullOrEmpty(person.PersonalPhotoPath))
                {
                    try
                    {
                        File.Delete(person.PersonalPhotoPath);
                    }
                    catch (IOException ex)
                    {
                    }
                }

                if (!string.IsNullOrEmpty(pbPersonImage.ImageLocation))
                {
                    string sourceImagePath = pbPersonImage.ImageLocation;
                    if (DVLD.BLL.Util.CopyImageToProjectImageFolder(ref sourceImagePath))
                    {
                        pbPersonImage.ImageLocation = sourceImagePath;
                        return true;
                    }
                    
                    MessageBox.Show("Failed to copy the image file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void LoadAndSavePersonData()
        {
            Person person = Person.Find(Id);

            if (person == null) person = new Person();

            if (!HandlePersonImage(ref person))
                return;

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
