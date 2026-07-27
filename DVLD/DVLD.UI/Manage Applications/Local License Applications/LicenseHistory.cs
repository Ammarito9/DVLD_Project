using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Manage_Applications
{
    public partial class LicenseHistory : Form
    {
        int driverID, personID;
        public LicenseHistory()
        {
            InitializeComponent();
        }
        public LicenseHistory(int driverID, int personID) : this()
        {
            this.driverID = driverID;
            this.personID = personID;

            InitializePersonDetailsController();
            InitializeDriverLicensesController();
        }
        private void InitializePersonDetailsController()
        {
            ucPersonDetails1 = new DVLD.UI.Common_Forms.ucPersonDetails(personID);
            // 
            // ucPersonDetails1
            // 
            ucPersonDetails1.Location = new Point(115, -2);
            ucPersonDetails1.Name = "ucPersonDetails1";
            ucPersonDetails1.Size = new Size(904, 438);
            ucPersonDetails1.TabIndex = 1;
            Controls.Add(ucPersonDetails1);
        }
        private void InitializeDriverLicensesController()
        {
            driverLicenses1 = new DVLD.UI.User_Controls.Driver.DriverLicenses(driverID);
            // 
            // driverLicenses1
            // 
            driverLicenses1.Location = new Point(12, 442);
            driverLicenses1.Name = "driverLicenses1";
            driverLicenses1.Size = new Size(1000, 350);
            driverLicenses1.TabIndex = 0;
            Controls.Add(driverLicenses1);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
