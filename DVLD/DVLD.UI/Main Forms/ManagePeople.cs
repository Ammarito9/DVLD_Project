using DVLD.BLL.Entities;
using DVLD.UI.Common_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Main_Forms
{
    public partial class ManagePeople : Form
    {
        public ManagePeople()
        {
            InitializeComponent();
            dgvPeople.AllowUserToAddRows = false;
            FillPeopleToDataView(Person.GetAll());
            cbFilterByCountry.SelectedIndexChanged -= cbFilterByCountry_SelectedIndexChanged;
            cbFilterByCountry.DataSource = Country.GetAllCountryNames();
            cbFilterByCountry.SelectedIndexChanged += cbFilterByCountry_SelectedIndexChanged;

            cbWhatToFilterBy.DataSource = Enum.GetNames(typeof(Person.FilterBy)).ToList();
        }

        private void FillPeopleToDataView(DataTable dt)
        {
            dgvPeople.DataSource = dt;
            lblNumberOfRecords.Text = Convert.ToString(dt.Rows.Count);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPerson AddUpdatePersonForm = new AddPerson();
            AddUpdatePersonForm.ShowDialog();
            FillPeopleToDataView(Person.GetAll());
        }

        private Person.FilterBy filterBy;
        private bool FilterDataViewBy()
        {
            txtOnlyDigitFilterBy.Visible = false;
            txtFilterBy.Visible = false;
            cbFilterByCountry.Visible = false;
            rbFilterByFemale.Visible = false;
            rbFilterByMale.Visible = false;

            switch (cbWhatToFilterBy.SelectedItem?.ToString())
            {
                case "ID":
                    {
                        txtOnlyDigitFilterBy.Visible = true;
                        filterBy = Person.FilterBy.ID;
                        return true;
                    }
                case "NationalNumber":
                    {
                        txtFilterBy.Visible = true;
                        filterBy = Person.FilterBy.NationalNumber;
                        return true;
                    }
                case "Country":
                    {
                        cbFilterByCountry.Visible = true;
                        filterBy = Person.FilterBy.Country;
                        return true;
                    }
                case "FirstName":
                    {
                        txtFilterBy.Visible = true;
                        filterBy = Person.FilterBy.FirstName;
                        return true;
                    }
                case "SecondName":
                    {
                        txtFilterBy.Visible = true;
                        filterBy = Person.FilterBy.SecondName;
                        return true;
                    }
                case "ThirdName":
                    {
                        txtFilterBy.Visible = true;
                        filterBy = Person.FilterBy.ThirdName;
                        return true;
                    }
                case "LastName":
                    {
                        txtFilterBy.Visible = true;
                        filterBy = Person.FilterBy.LastName;
                        return true;
                    }
                case "Gender":
                    {
                        rbFilterByFemale.Visible = true;
                        rbFilterByMale.Visible = true;
                        filterBy = Person.FilterBy.Gender;
                        return true;
                    }
                case "Email":
                    {
                        txtFilterBy.Visible = true;
                        filterBy = Person.FilterBy.Email;
                        return true;
                    }

                case "PhoneNumber":
                    {
                        txtOnlyDigitFilterBy.Visible = true;
                        filterBy = Person.FilterBy.PhoneNumber;
                        return true;
                    }
                case "None":
                    {
                        return false;
                    }
                default:
                    {
                        filterBy = Person.FilterBy.None;
                        return false;
                    }
            }
        }
        private void cbWhatToFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FilterDataViewBy()) FillPeopleToDataView(Person.GetAll());
        }

        private void OnlyDigitFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (txtOnlyDigitFilterBy.Text == string.Empty) FillPeopleToDataView(Person.GetAll());

            FillPeopleToDataView(Person.GetAllFilterBy(filterBy, txtOnlyDigitFilterBy.Text));
        }

        private void txtOnlyDigitFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterBy.Text == string.Empty) FillPeopleToDataView(Person.GetAll());

            FillPeopleToDataView(Person.GetAllFilterBy(filterBy, txtFilterBy.Text, true));
        }

        private void HandleGenderFilter()
        {
            if (rbFilterByFemale.Checked) FillPeopleToDataView(Person.GetAllFilterBy(filterBy, "F"));
            if (rbFilterByMale.Checked) FillPeopleToDataView(Person.GetAllFilterBy(filterBy, "M"));

        }

        private void rbFilterByMale_CheckedChanged(object sender, EventArgs e)
        {
            HandleGenderFilter();
        }

        private void rbFilterByFemale_CheckedChanged(object sender, EventArgs e)
        {
            HandleGenderFilter();
        }

        private void cbFilterByCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPeopleToDataView(Person.GetAllFilterBy(filterBy, cbFilterByCountry.SelectedItem?.ToString()));
        }

        private void miAddNewPerson_Click(object sender, EventArgs e)
        {
            AddPerson AddUpdatePersonForm = new AddPerson();
            AddUpdatePersonForm.ShowDialog();
            FillPeopleToDataView(Person.GetAll());
        }

        private void miShowDetails_Click(object sender, EventArgs e)
        {
            if (dgvPeople.CurrentRow == null)
            {
                MessageBox.Show("Person is not found!", "Error");
                return;
            }

            int id = Convert.ToInt32(dgvPeople.CurrentRow.Cells["ID"].Value);
            var personDetails = new PersonDetails(id);
            personDetails.ShowDialog();

        }
    }
}
