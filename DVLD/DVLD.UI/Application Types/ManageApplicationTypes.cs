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

namespace DVLD.UI.Application_Types
{
    public partial class ManageApplicationTypes : Form
    {
        public ManageApplicationTypes()
        {
            InitializeComponent();
            LoadApplicationsToDataView(Service.GetAll());
        }

        private void LoadApplicationsToDataView(DataTable ApplicationsDataTable)
        {
            dgv_ApplicationTypes.DataSource = ApplicationsDataTable;
            lbl_NumberOfRecordsValue.Text = dgv_ApplicationTypes.Rows.Count.ToString();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dgv_ApplicationTypes.CurrentRow.Cells["Id"].Value);

            UpdateApplicationType update = new UpdateApplicationType(id);
            update.ShowDialog();

            LoadApplicationsToDataView(Service.GetAll());
        }
    }
}
