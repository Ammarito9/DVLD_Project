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
    public partial class ManageUsers : Form
    {


        private User.Filters Filter = User.Filters.None;
        public ManageUsers()
        {
            InitializeComponent();
            FillUsersToDateView(User.GetAll());
            cb_FilterByValue.SelectedIndex = ((int)Filter);
        }

        private void FillUsersToDateView(DataTable UserDataTable)
        {
            dgvUsers.DataSource = UserDataTable;
            lbl_NumberOfRecordsValue.Text = UserDataTable.Rows.Count.ToString();
        }

        private void ManageFilters(string filterValue = "")
        {
            switch (Filter)
            {
                case User.Filters.None:

                    FillUsersToDateView(User.GetAll());
                    break;

                case User.Filters.UserId:
                    FillUsersToDateView(User.GetFilterBy(User.Filters.UserId, filterValue));
                    break;

                case User.Filters.PersonId:
                    FillUsersToDateView(User.GetFilterBy(User.Filters.PersonId, filterValue));
                    break;

                case User.Filters.FullName:
                    FillUsersToDateView(User.GetFilterBy(User.Filters.FullName, filterValue));
                    break;

                case User.Filters.Username:
                    FillUsersToDateView(User.GetFilterBy(User.Filters.Username, filterValue));
                    break;

                case User.Filters.IsActive:
                    FillUsersToDateView(User.GetFilterBy(User.Filters.IsActive, filterValue));
                    break;

                default:
                    break;
            }
        }

        private void cb_FilterByValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillUsersToDateView(User.GetAll());

            Filter = (User.Filters)cb_FilterByValue.SelectedIndex;

            cb_FilterByIsActiveValue.Visible = false;
            cb_FilterByIsActiveValue.SelectedIndex = 0;

            txt_FilterByValue.Visible = false;
            txt_FilterByValue.Clear();

            txt_FilterByValueNumeric.Visible = false;
            txt_FilterByValueNumeric.Clear();

            switch (Filter)
            {
                case User.Filters.UserId:
                case User.Filters.PersonId:
                    txt_FilterByValueNumeric.Visible = true;
                    break;

                case User.Filters.FullName:
                case User.Filters.Username:
                    txt_FilterByValue.Visible = true;
                    break;

                case User.Filters.IsActive:
                    cb_FilterByIsActiveValue.Visible = true;
                    break;

                default:
                    break;
            }
        }

        private void txt_FilterByValueNumeric_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_FilterByValueNumeric.Text))
            {
                FillUsersToDateView(User.GetAll());
                return;
            }

            ManageFilters(txt_FilterByValueNumeric.Text);
        }

        private void txt_FilterByValueNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }

        private void txt_FilterByValue_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_FilterByValue.Text))
            {
                FillUsersToDateView(User.GetAll());
                return;
            }

            ManageFilters(txt_FilterByValue.Text);
        }
        enum IsActiveFilter
        {
            All,
            Yes,
            No,
        }

        private void cb_FilterByIsActiveValue_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_FilterByIsActiveValue.SelectedIndex == ((int)IsActiveFilter.All))
            {
                FillUsersToDateView(User.GetAll());
                return;
            }

            String FilterByValue = "1";

            if (cb_FilterByIsActiveValue.SelectedIndex == ((int)IsActiveFilter.No)) FilterByValue = "0";

            ManageFilters(FilterByValue);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("User not found!");
                return;
            }

            int Id = (int)(dgvUsers.CurrentRow.Cells["Id"].Value);
            UserInformation userInfo = new UserInformation(Id);
            userInfo.ShowDialog();
        }

        private void UpdateDataGridViewAfterEdit()
        {
            if (!String.IsNullOrEmpty(txt_FilterByValue.Text))
                ManageFilters(txt_FilterByValue.Text);
            else if (!String.IsNullOrEmpty(txt_FilterByValueNumeric.Text))
                ManageFilters(txt_FilterByValueNumeric.Text);
            else if (cb_FilterByIsActiveValue.SelectedIndex == ((int)IsActiveFilter.No))
                ManageFilters("0");
            else if (cb_FilterByIsActiveValue.SelectedIndex == ((int)IsActiveFilter.Yes))
                ManageFilters("1");
            else
                FillUsersToDateView(User.GetAll());
        }
        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateUser addUser = new AddUpdateUser();
            addUser.ShowDialog();

            UpdateDataGridViewAfterEdit();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("User not found!");
                return;
            }

            int Id = Convert.ToInt16(dgvUsers.CurrentRow.Cells["ID"].Value);
            if (User.Delete(Id))
            {
                MessageBox.Show($"User with id {Id} deleted successfully!");

                UpdateDataGridViewAfterEdit();
            }
            else
            {
                MessageBox.Show("Error! User isn't deleted.");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddUpdateUser addUser = new AddUpdateUser();
            addUser.ShowDialog();

            UpdateDataGridViewAfterEdit();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("User not found!");
                return;
            }

            int Id = (int)(dgvUsers.CurrentRow.Cells["Id"].Value);
            AddUpdateUser userInfo = new AddUpdateUser(Id);
            userInfo.ShowDialog();

            UpdateDataGridViewAfterEdit();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will be implemented later!");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will be implemented later!");
        }
    }
}
