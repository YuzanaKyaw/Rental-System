using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeApplianceReantalSystem
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            lbName.Text = AdminLogin.AdminName;
            ApplianceNav.Visible = false;
            CustomerNav.Visible = false;
        }

        //appliance menu strip show
        private void aPPLIANCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplianceNav.Show();
            CustomerNav.Visible = false;
        }

        // go to create category form 
        private void Category_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplianceCategory category = new ApplianceCategory();
            category.Show();
        }

        // to go appliance detail info view form
        private void applianceDetailViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplianceViewInfo appview = new ApplianceViewInfo();
            appview.Show();
        }

        // to create new appliance 
        private void Create_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplianceRegister appregister = new ApplianceRegister();
            appregister.Show();
        }

        // to register new admin and admin regsiter form
        private void administratorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRegister admin = new AdminRegister();
            admin.Show();
        }

        
        // to open customer nav and close appliance nave if open
        private void cUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerNav.Show();
            ApplianceNav.Visible = false;
        }

        // close customer nav panel 
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerNav.Visible = false;
        }

        // close appliance nav panel
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ApplianceNav.Visible = false;
        }

        // to view customer data
        private void cUSTOMERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerData cusdata = new CustomerData();
            this.Hide();
            cusdata.Show();
        }

        private void RentalReport_Click(object sender, EventArgs e)
        {
            RentalReport report = new RentalReport();
            this.Hide();
            report.Show();
        }


        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbName.Text = null;
            LoginForm.CustomerID = null;
            LoginForm.CustomerName = null;
            this.Hide();
            FirstPageForm firstpage = new FirstPageForm();
            firstpage.Show();
        }

        private void ProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminProfile profile = new AdminProfile();
            this.Hide();
            profile.Show();
        }
    }
}
