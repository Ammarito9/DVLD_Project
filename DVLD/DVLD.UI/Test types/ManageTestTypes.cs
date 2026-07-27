using DVLD.BLL.Entities;
using DVLD.UI.Application_Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Test_types
{
    public partial class ManageTestTypes : Form
    {
        public ManageTestTypes()
        {
            InitializeComponent();
            LoadApplicationsToDataView(TestType.GetAll());
        }
        private void LoadApplicationsToDataView(DataTable TestsDataTable)
        {
            dgv_TestTypes.DataSource = TestsDataTable;
            lbl_NumberOfRecordsValue.Text = dgv_TestTypes.Rows.Count.ToString();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dgv_TestTypes.CurrentRow.Cells["Id"].Value);

            UpdateTestTypes update = new UpdateTestTypes(id);
            update.ShowDialog();

            LoadApplicationsToDataView(TestType.GetAll());
        }
    }
}
