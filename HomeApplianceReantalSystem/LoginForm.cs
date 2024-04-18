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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private int login_count = 0;
        public static string CustomerName, CustomerID;
        RentalSystemDataSetTableAdapters.CustomerTableAdapter customerobj = new RentalSystemDataSetTableAdapters.CustomerTableAdapter();

        private void ClearText()
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CustomerRegister cusregister = new CustomerRegister();
            cusregister.Show();
        }

        // login process
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(login_count == 5)
            {
                MessageBox.Show("You reach your limit.Try again later!");
            }else if(txtEmail.Text == "")
            {
                MessageBox.Show("Please fill your email!");
            }else if(txtPassword.Text == "")
            {
                MessageBox.Show("Please fill your password!"); // check for validation
            }
            else
            {
                // login check
                DataTable dt = new DataTable();
                dt = customerobj.CustomerLogin(txtEmail.Text, txtPassword.Text);
                if(dt.Rows.Count == 1)
                {
                    dgvCustomer.DataSource = dt;
                    CustomerID = dgvCustomer[0,0].Value.ToString();
                    CustomerName = dgvCustomer[1,0].Value.ToString();

                    CustomerHome cushome = new CustomerHome();  // go to customer home
                    this.Hide();
                    cushome.Show();
                    
                }
                else
                {
                    ClearText();
                    login_count += 1;
                    MessageBox.Show("Invalid log in! Login attempts " + login_count);
                }
            }
        }
    }
}
