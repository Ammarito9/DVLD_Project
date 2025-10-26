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
    public partial class ucPersonDetails : UserControl
    {
        private Person temp_person;
        public ucPersonDetails(int ID)
        {
            InitializeComponent();
            temp_person = Person.Find(ID);
            LoadPersonDetails();
        }

        public string HandleNullableOrEmptyFiled(string filed)
        {
            if (string.IsNullOrEmpty(filed))
                return "N/A";
            return filed;
        }
        private void LoadPersonDetails()
        {
            if (temp_person != null)
            {
                lblPersonIdValue.Text = Convert.ToString(temp_person.ID);
                lblNameValue.Text = temp_person.GetFullName();
                lblNationalnumberValue.Text = temp_person.NationalNumber;
                lblGenderValue.Text = temp_person.Gender == "M" ? "Male" : "Female";
                lblEmailValue.Text = HandleNullableOrEmptyFiled(temp_person.Email);
                lblAddressValue.Text = temp_person.Address;
                lblDateOfBirthValue.Text = temp_person.DateOfBirth.ToShortDateString();
                lblPhoneValue.Text = temp_person.PhoneNumber;
                lblCountryValue.Text = temp_person.GetPersonNationalityNameByID(temp_person.ID);
                pbPersonImage.ImageLocation = temp_person.PersonalPhotoPath;
            }
        }
    }
}
