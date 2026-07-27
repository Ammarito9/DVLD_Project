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

namespace DVLD.UI.Main_Forms
{
    public partial class ManageDrivers : Form
    {
        Driver.Filters filter;
        public ManageDrivers()
        {
            InitializeComponent();
            cbFilter.SelectedIndex = 0;
        }
        private void LoadDriversToView(DataTable source)
        {
            dgvDrivers.DataSource = source;
            lblNumberOfRecordsValue.Text = dgvDrivers.Rows.Count.ToString();
        }
        private void Filter()
        {
            switch (cbFilter.SelectedIndex)
            {
                case (int)Driver.Filters.DRIVER_ID:
                    filter = Driver.Filters.DRIVER_ID;
                    return;
                case (int)Driver.Filters.PERSON_ID:
                    filter = Driver.Filters.PERSON_ID;
                    return;
                case (int)Driver.Filters.NATIONAL_NUMBER:
                    filter = Driver.Filters.NATIONAL_NUMBER;
                    return;
                case (int)Driver.Filters.FULL_NAME:
                    filter = Driver.Filters.FULL_NAME;
                    return;
                default:
                    LoadDriversToView(Driver.GetDriverFiltered(Driver.Filters.NONE));
                    return;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDriversToView(Driver.GetDriverFiltered(filter, txtSearch.Text));
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex != ((int)Driver.Filters.NONE))
                txtSearch.Visible = true;
            else
                txtSearch.Visible = false;

            Filter();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
