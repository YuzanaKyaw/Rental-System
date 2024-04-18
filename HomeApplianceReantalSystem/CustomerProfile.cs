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
    public partial class CustomerProfile : Form
    {
        public CustomerProfile()
        {
            InitializeComponent();
        }
        RentalSystemDataSetTableAdapters.CustomerTableAdapter customer = new RentalSystemDataSetTableAdapters.CustomerTableAdapter();
        string customerid = LoginForm.CustomerID;

        public void getCustomerData(string customerid)  // get customer data and show them
        {
            DataTable dt = new DataTable();
            dt = customer.GetDataByCustomerID(customerid);
            lbName.Text = dt.Rows[0][1].ToString();
            lbEmail.Text = dt.Rows[0][2].ToString();
            lbGender.Text = dt.Rows[0][3].ToString();
            lbPhone.Text = dt.Rows[0][4].ToString();
            lbAddress.Text = dt.Rows[0][5].ToString();
            lbPassword.Text = dt.Rows[0][6].ToString();
            try
            {
                CustomerPhoto.Image = Image.FromFile(dt.Rows[0][7].ToString());
            }
            catch (Exception)
            {
                CustomerPhoto.Image = Image.FromFile("D:\\NCC\\DesigningAndDevelopingObject-OrientedComputerPrograms\\HomeApplianceReantalSystem\\RentalSystem\\Images\\24-248325_profile-picture-circle-png-transparent-png.png");
            }
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            getCustomerData(customerid);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerHome cushome = new CustomerHome();
            cushome.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRegister cusregister = new CustomerRegister();
            cusregister.getCustomerDataToUpdate(customerid);
            cusregister.Show();
        }
    }
}
