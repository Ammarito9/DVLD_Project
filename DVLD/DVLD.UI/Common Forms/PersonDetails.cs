using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Common_Forms
{
    public partial class PersonDetails : Form
    {

        public PersonDetails()
        {
            InitializeComponent();
        }

        public PersonDetails(int ID) : this()
        {
            InitializeComponent();

            ucPersonDetails1 = new ucPersonDetails(ID);
            SuspendLayout();
            // 
            // ucPersonDetails1
            // 
            ucPersonDetails1.Location = new Point(-12, -32);
            ucPersonDetails1.Name = "ucPersonDetails1";
            ucPersonDetails1.Size = new Size(906, 449);
            ucPersonDetails1.TabIndex = 0;
            this.Controls.Add(ucPersonDetails1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
