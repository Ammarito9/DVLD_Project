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
        public int Id { get; private set; }
        public Person person { get; private set; } = new Person();
        public ucPersonDetails()
        {
            InitializeComponent();
        }
        public ucPersonDetails(int ID)
        {
            Id = ID;
            InitializeComponent();
            person = Person.Find(ID);
            LoadPersonDetails();
        }

        public string HandleNullableOrEmptyFiled(string filed)
        {
            if (string.IsNullOrEmpty(filed))
                return "N/A";
            return filed;
        }
        public void LoadPersonDetails(int id = 0)
        {
            if (id != 0)
            {
                person = Person.Find(id);
            }
            
            if (person != null)
            {
                lblPersonIdValue.Text = Convert.ToString(person.ID);
                lblNameValue.Text = person.GetFullName();
                lblNationalnumberValue.Text = person.NationalNumber;
                lblGenderValue.Text = person.Gender == "M" ? "Male" : "Female";
                lblEmailValue.Text = HandleNullableOrEmptyFiled(person.Email);
                lblAddressValue.Text = person.Address;
                lblDateOfBirthValue.Text = person.DateOfBirth.ToShortDateString();
                lblPhoneValue.Text = person.PhoneNumber;
                lblCountryValue.Text = person.GetPersonNationalityNameByID(person.ID);
                pbPersonImage.ImageLocation = person.PersonalPhotoPath;
            }
        }

        public void LoadPersonDetails(String NationalID)
        {
            if (NationalID != String.Empty)
            {
                person = Person.Find(NationalID);
            }

            if (person != null)
            {
                lblPersonIdValue.Text = Convert.ToString(person.ID);
                lblNameValue.Text = person.GetFullName();
                lblNationalnumberValue.Text = person.NationalNumber;
                lblGenderValue.Text = person.Gender == "M" ? "Male" : "Female";
                lblEmailValue.Text = HandleNullableOrEmptyFiled(person.Email);
                lblAddressValue.Text = person.Address;
                lblDateOfBirthValue.Text = person.DateOfBirth.ToShortDateString();
                lblPhoneValue.Text = person.PhoneNumber;
                lblCountryValue.Text = person.GetPersonNationalityNameByID(person.ID);
                pbPersonImage.ImageLocation = person.PersonalPhotoPath;
            }
        }

        private void llblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdatePerson updatePerson = new UpdatePerson(Id);
            updatePerson.ShowDialog();


            person = Person.Find(Id);
            LoadPersonDetails();
        }
    }
}
