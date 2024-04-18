using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeApplianceReantalSystem
{
    public partial class CustomerRegister : Form
    {
        public CustomerRegister()
        {
            InitializeComponent();
            CustomerAutoID();

        }

        RentalSystemDataSetTableAdapters.CustomerTableAdapter objCustomer = new RentalSystemDataSetTableAdapters.CustomerTableAdapter();
        DataTable customerTable = new DataTable();
        private void CustomerRegister_Load(object sender, EventArgs e)
        {
            
        }
        public void CustomerTextClear()  // clear all text
        {
            txtCustomerID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPhoneNo.Clear();
            txtPassword.Clear();
            customerPhoto.Image = null;

        }
        public void CustomerAutoID()   // generate auto id
        {
            DataTable dt = new DataTable();
            dt = objCustomer.GetCustomerData();
            if(dt.Rows.Count == 0)
            {
                txtCustomerID.Text = "C-0001";
            }
            else
            {
                int size = dt.Rows.Count -1  ;
                string oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(2, 4)) + 1;
                if(newid>= 1 && newid < 10)
                {
                    txtCustomerID.Text = "C-000" + newid;
                }else if(newid>=10 && newid < 100)
                {
                    txtCustomerID.Text = "C-00" + newid;
                }else if(newid>=100 && newid < 1000)
                {
                    txtCustomerID.Text = "C-0" + newid;
                }else if(newid >=1000 && newid < 10000)
                {
                    txtCustomerID.Text = "C-" + newid;
                }
            }
        }

        public void getCustomerDataToUpdate(string customerid)    // get customer form profile page using customer id
        {
            DataTable dt = new DataTable();
            dt = objCustomer.GetDataByCustomerID(customerid);   // select customer data from customer id

            // customer data showing to text box and picture box
            txtCustomerID.Text = customerid;
            txtName.Text = dt.Rows[0][1].ToString();
            txtEmail.Text = dt.Rows[0][2].ToString();
            if(dt.Rows[0][3].ToString() == "Male")
            {
                rdoMale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = true;
            }
            txtPhoneNo.Text = dt.Rows[0][4].ToString();
            txtAddress.Text = dt.Rows[0][5].ToString();
            txtPassword.Text = dt.Rows[0][6].ToString();
            try
            {
                customerPhoto.Image = Image.FromFile(dt.Rows[0][7].ToString());
            }
            catch (Exception)
            {
                customerPhoto.Image = null;
            }
            btnSave.Visible = false;
            btnClear.Visible = false;
            btnUpdate.Visible = true;
        }
        public string ValidationCheck()   // check all requirement field are filled
                                          // if not show error message
                                          // customer picuture is optional 
        {
            if (txtCustomerID.Text == "")
            {
                return "You need to fill Customer ID!";
            }
            else if (txtName.Text == "")
            {
                return "Please fill your Name!";
            }
            else if (txtEmail.Text == "")
            {
                return "Please fill your email!";
            }
            else if (txtPhoneNo.Text == "")
            {
                return "Please fill your Phone Number!";
            }
            else if (txtAddress.Text == "")
            {
                return "Please fill your address!";
            }
            else if (txtPassword.Text == "")
            {
                return "Please fill your Password!";
            }
            else
            {
                return "OK";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CustomerTextClear();
            CustomerAutoID();
        }

        private void btnSave_Click(object sender, EventArgs e)    // save customer data
        {
            string password = txtPassword.Text;
            string message = ValidationCheck();
            if(message != "OK")
            {
                MessageBox.Show(message);
            }
            else
            {
                string pwd = txtPassword.Text;
                CustomerModel customer = new CustomerModel();    // using customer model
                string errorMessage = customer.PasswordValidationCheck(pwd);   // password vaildation 
                if(errorMessage == pwd)     // get customer data
                {
                    customer.ID = txtCustomerID.Text;
                    customer.Name = txtName.Text;
                    customer.Eamil = txtEmail.Text;
                    if (rdoMale.Checked)
                    {
                        customer.Gender = "Male";
                    }else if (rdoFemale.Checked)
                    {
                        customer.Gender = "Female";
                    }
                    customer.Password = pwd;
                    customer.PhoneNo = txtPhoneNo.Text;
                    customer.Address = txtAddress.Text;
                    customer.Photo = customerPhoto.Name;

                    string path;
                    if(customerPhoto.Image != null)    // save image path
                    {
                        Random rdm = new Random();
                        int num = rdm.Next();
                        string location = "D:\\NCC\\DesigningAndDevelopingObject-OrientedComputerPrograms\\HomeApplianceReantalSystem\\RentalSystem\\HomeApplianceReantalSystem\\bin\\Debug\\Customer";
                        path = Path.Combine(location, txtName.Text+ num + ".jpg");
                        Image a = customerPhoto.Image;
                        a.Save(path);
                    }
                    else
                    {
                        path = customerPhoto.Name;
                    }
                    

                    objCustomer.Insert(customer.ID, customer.Name, customer.Eamil, customer.Gender, customer.PhoneNo, customer.Address, customer.Password,path);
                    MessageBox.Show("Register Successfully!");
                    CustomerTextClear();
                    CustomerAutoID();
                    this.Hide();
                    LoginForm cuslogin = new LoginForm();
                    cuslogin.Show();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
        }

        private void customerPhoto_Click(object sender, EventArgs e)   // choosing photo and show it on picture box
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;

            if(p != null)
            {
                open.Filter = "(*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png ";
                if(open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)   // update customer data
        {
            string message = ValidationCheck();
            if (message != "OK")
            {
                MessageBox.Show(message);
            }
            else
            {
                string pwd = txtPassword.Text;
                CustomerModel customer = new CustomerModel();
                string errorMessage = customer.PasswordValidationCheck(pwd);
                if (errorMessage == pwd)
                {
                    customer.ID = txtCustomerID.Text;
                    customer.Name = txtName.Text;
                    customer.Eamil = txtEmail.Text;
                    if (rdoMale.Checked)
                    {
                        customer.Gender = "Male";
                    }
                    else if (rdoFemale.Checked)
                    {
                        customer.Gender = "Female";
                    }
                    customer.Password = pwd;
                    customer.PhoneNo = txtPhoneNo.Text;
                    customer.Address = txtAddress.Text;
                    customer.Photo = customerPhoto.Name;

                    string path;
                    if (customerPhoto.Image != null)
                    {
                        Random rdm = new Random();
                        int num = rdm.Next();
                        string location = "D:\\NCC\\DesigningAndDevelopingObject-OrientedComputerPrograms\\HomeApplianceReantalSystem\\RentalSystem\\HomeApplianceReantalSystem\\bin\\Debug\\Customer";
                        path = Path.Combine(location, txtName.Text + num + ".jpg");
                        Image a = customerPhoto.Image;
                        a.Save(path);
                    }
                    else
                    {
                        path = customerPhoto.Name;
                    }


                    objCustomer.UpdateCustomerData(customer.Name, customer.Eamil, customer.Gender, customer.PhoneNo, customer.Address, customer.Password, path, customer.ID);
                    MessageBox.Show("Update Successfully!");
                    CustomerTextClear();
                    CustomerAutoID();
                    this.Hide();
                    CustomerHome cushome = new CustomerHome();
                    cushome.Show();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
        }
    }
}
