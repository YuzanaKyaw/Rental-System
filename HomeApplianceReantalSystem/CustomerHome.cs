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
    public partial class CustomerHome : Form
    {
        public CustomerHome()
        {
            InitializeComponent();
        }

        private void CustomerHome_Load(object sender, EventArgs e)  // display user name
        {
            lbName.Text = LoginForm.CustomerName;
        }

        private void applianceViewToolStripMenuItem_Click(object sender, EventArgs e)  // direct to appliance view page
        {
            this.Hide();
            CustomerApplianceView cusView = new CustomerApplianceView();
            cusView.Show();
        }

        private void rentAppliancesToolStripMenuItem_Click(object sender, EventArgs e) // direct to rental form 
        {
            this.Hide();
            RentalForm rentform = new RentalForm();
            rentform.Show();
        }
        

        private void rentalHistoryToolStripMenuItem_Click(object sender, EventArgs e) // rental history page
        {
            this.Hide();
            RentalHistory history = new RentalHistory();
            history.Show();
        }
            
        private void ProfilePageToolStripMenuItem_Click(object sender, EventArgs e)  // user profile page
        {
            this.Hide();
            CustomerProfile cusprofile = new CustomerProfile();
            cusprofile.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)  // log out process
        {
            lbName.Text = null;
            LoginForm.CustomerID = null;
            LoginForm.CustomerName = null;
            this.Hide();
            FirstPageForm firstpage = new FirstPageForm();
            firstpage.Show();
        }
    }
}
