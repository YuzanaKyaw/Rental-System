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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        
        RentalSystemDataSetTableAdapters.AdministratorTableAdapter adminobj = new RentalSystemDataSetTableAdapters.AdministratorTableAdapter();
        public static string AdminID, AdminName;
        private int logincount = 0;

        private void ClearText()
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        // login process
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(logincount > 5)
            {
                MessageBox.Show("You reach your limit!");
            }
            else if(txtEmail.Text == "")
            {
                MessageBox.Show("Email is required to login");
            }else if(txtPassword.Text == "")
            {
                MessageBox.Show("Password is required to login"); // validation check
            }
            else
            {
                // check user data for login
                DataTable dt = new DataTable();
                dt = adminobj.AdminLogin(txtEmail.Text, txtPassword.Text);
                if(dt.Rows.Count == 1)
                {
                    dgvAdmin.DataSource = dt;  // save admin data
                    AdminID = dgvAdmin[0, 0].Value.ToString();
                    AdminName = dgvAdmin[1, 0].Value.ToString();

                    AdminHome adminhome = new AdminHome(); // go to admin home
                    this.Hide();
                    adminhome.Show();
                }
                else
                {
                    ClearText();
                    logincount += 1;
                    MessageBox.Show("Invalid login! Login attempt " + logincount);
                }
            }
        }
    }
}
