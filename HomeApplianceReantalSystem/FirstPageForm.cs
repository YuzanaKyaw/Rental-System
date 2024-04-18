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
    public partial class FirstPageForm : Form
    {
        public FirstPageForm()
        {
            InitializeComponent();
        }

        // login page for customer
        private void btnLoginPage_Click(object sender, EventArgs e) 
        {
            this.Hide();
            LoginForm loginpage = new LoginForm();
            loginpage.Show();
        }

        // register page for customer
        private void btnRegisterPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRegister cusregister = new CustomerRegister();
            cusregister.Show();
        }

        // login page for admin
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin admlogin = new AdminLogin();
            admlogin.Show();
        }
    }
}
