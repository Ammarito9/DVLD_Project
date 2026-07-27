using DVLD.BLL.Entities;
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
    public partial class UpdateTestTypes : Form
    {
        private int id = 0;
        private TestType testType;
        public UpdateTestTypes()
        {
            InitializeComponent();
        }
        public UpdateTestTypes(int id) : this()
        {
            this.id = id;
            testType = TestType.Find(id);
            LoadTestTypeData();
        }

        private void LoadTestTypeData()
        {
            lbl_IdValue.Text = testType.ID.ToString();
            txt_TestTitleValue.Text = testType.TestTypeName;
            txt_Description.Text = testType.TestTypeDescription;
            txt_FeeValue.Text = testType.TestFee.ToString();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            testType.TestTypeName = txt_TestTitleValue.Text;
            testType.TestTypeDescription = txt_Description.Text;
            testType.TestFee = Convert.ToDecimal(txt_FeeValue.Text);

            if (testType.Save())
            {
                btn_Save.Enabled = false;
                MessageBox.Show("The test updated successfully!");
            }
            else
                MessageBox.Show("Error! The test isn't updated.");
        }
    }
}
