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
    public partial class UpdateApplicationType : Form
    {
        private int Id = 0;
        private Service service;
        public UpdateApplicationType()
        {
            InitializeComponent();
        }

        public UpdateApplicationType(int id) : this()
        {
            Id = id;
            service = Service.Find(id);
            LoadApplicationTypeData();
        }

        private void LoadApplicationTypeData()
        {
            lbl_IdValue.Text = service.ID.ToString();
            txt_ApplicationTitleValue.Text = service.ServiceName;
            txt_FeeValue.Text = service.ServiceFee.ToString();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            service.ServiceName = txt_ApplicationTitleValue.Text;
            service.ServiceFee = Convert.ToDecimal(txt_FeeValue.Text);

            if (service.Save())
            {
                btn_Save.Enabled = false;
                MessageBox.Show("The application updated successfully!");
            }
            else
                MessageBox.Show("Error! The application isn't updated.");
        }
    }
}
