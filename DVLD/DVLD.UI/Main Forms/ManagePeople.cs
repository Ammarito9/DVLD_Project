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
using DVLD.UI.Common_Forms;

namespace DVLD.UI.Main_Forms
{
    public partial class ManagePeople : Form
    {
        public ManagePeople()
        {
            InitializeComponent();
            FillPeopleToDataView(Person.GetAll());
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

        private void cbWhatToFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
