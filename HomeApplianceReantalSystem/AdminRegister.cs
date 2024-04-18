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
    public partial class AdminRegister : Form
    {
        public AdminRegister()
        {
            InitializeComponent();
            AutoID();
            AdminDataView();
        }
        RentalSystemDataSetTableAdapters.AdministratorTableAdapter adminobj = new RentalSystemDataSetTableAdapters.AdministratorTableAdapter();
        DataTable admindt = new DataTable();

        public void ClearAdminText() // Clear all data from text box
        {
            txtAdminID.Clear();
            txtEmail.Clear();
            txtName.Clear();
            rdoFemale.Checked = false;
            rdoMale.Checked = false;
            adminPhoto.Image = null;
            txtPassword.Clear();
        }
        public void AdminDataView() // to view the admin data and refresh the data grid view
        {
            admindt = adminobj.GetAdminData();
            dgvAdmin.DataSource = admindt;
            dgvAdmin.Refresh();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAdminText();
            AutoID();
        }
        public void AutoID()  // Admin Auto ID
        {
            DataTable dt = new DataTable();
            dt = adminobj.GetAdminData();
            if (dt.Rows.Count == 0)
            {
                txtAdminID.Text = "A-001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                string oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(2, 3)) + 1;
                if (newid >= 1 && newid <= 9)
                {
                    txtAdminID.Text = "A-00" + newid;
                }
                else if (newid >= 10 && newid <= 99)
                {
                    txtAdminID.Text = "A-0" + newid;
                }
                else if (newid >= 100 && newid <= 999)
                {
                    txtAdminID.Text = "A-" + newid;
                }
            }
        }
        public string ValidationCheck() // Check the important fields have filled and return OK if all field are fill or
                                        // return error message if there have blank field 
        {
            if (txtAdminID.Text == "")
            {
                return "Admin ID is required!";
            }
            else if (txtEmail.Text == "")
            {
                return "Email is required!";
            }
            else if (txtName.Text == "")
            {
                return "Name is required!";
            }
            else if (txtPassword.Text == "")
            {
                return "Password is requried!";
            }
            else
            {
                return "OK";
            }
        }
        private void btnSave_Click(object sender, EventArgs e) // to save all of the admin data to database
        {
            string message = ValidationCheck();
            if (message == "OK")
            {
                AdministratorMordel adminmodel = new AdministratorMordel();
                string pwd = txtPassword.Text;
                string pwdmessage = adminmodel.PasswordValidationCheck(pwd);
                if (pwdmessage == pwd)
                {
                    adminmodel.ID = txtAdminID.Text;
                    adminmodel.Name = txtName.Text;
                    adminmodel.Eamil = txtEmail.Text;
                    if (rdoMale.Checked)
                    {
                        adminmodel.Gender = "Male";
                    }
                    else if (rdoFemale.Checked)
                    {
                        adminmodel.Gender = "Female";
                    }
                    adminmodel.Password = pwd;

                    string path;
                    if (adminPhoto.Image != null)
                    {
                        Random rdm = new Random();
                        int num = rdm.Next();
                        string location = "D:\\NCC\\DesigningAndDevelopingObject-OrientedComputerPrograms\\HomeApplianceReantalSystem\\HomeApplianceReantalSystem\\bin\\Debug\\Admin";
                        path = Path.Combine(location, txtName.Text + num + ".jpg");
                        Image a = adminPhoto.Image;
                        a.Save(path);
                    }
                    else
                    {
                        path = adminPhoto.Name;
                    }
                    adminobj.Insert(adminmodel.ID, adminmodel.Name, adminmodel.Eamil, adminmodel.Gender, adminmodel.Password, path);
                    MessageBox.Show("Register Successfully!");
                    ClearAdminText();
                    AutoID();
                    AdminDataView();
                }
                else
                {
                    MessageBox.Show(pwdmessage);
                }
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void adminPhoto_Click(object sender, EventArgs e) // to choose picuture and show selected picture on picture box
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;

            if (p != null)
            {
                open.Filter = "(*.jpg; *.jpeg; *.png;) | *.jpg; *.jpeg; *.png;";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }

        //Link to admin home page
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome adminhome = new AdminHome();
            this.Hide();
            adminhome.Show();
        }
        public void getAdmindataToUpdate(string id)
        {
            DataTable dt = new DataTable();
            dt = adminobj.GetDataByAdminID(id);
            txtAdminID.Text = dt.Rows[0][0].ToString();
            txtName.Text = dt.Rows[0][1].ToString();
            txtEmail.Text = dt.Rows[0][2].ToString();
            if (dt.Rows[0][3].ToString() == "Female")
            {
                rdoFemale.Checked = true;
            }
            else
            {
                rdoMale.Checked = true;
            }
            txtPassword.Text = dt.Rows[0][4].ToString();
            try
            {
                adminPhoto.Image = Image.FromFile(dt.Rows[0][5].ToString());
            }
            catch (Exception)
            {
                adminPhoto.Image = null;
            }
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }


        private void btnUpdate_Click(object sender, EventArgs e) // to update the admin data
        {
            string message = ValidationCheck();
            if (message == "OK")
            {
                string path;
                string gender;
                if (adminPhoto.Image != null)
                {
                    Random rdm = new Random();
                    int num = rdm.Next();
                    string location = "D:\\NCC\\DesigningAndDevelopingObject-OrientedComputerPrograms\\HomeApplianceReantalSystem\\RentalSystem\\HomeApplianceReantalSystem\\bin\\Debug\\Admin";
                    path = Path.Combine(location, txtName.Text + num + ".png");
                    Image a = adminPhoto.Image;
                    a.Save(path);
                }
                else
                {
                    path = adminPhoto.Name;
                }
                if (rdoFemale.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Male";
                }
                adminobj.UpdateAdminData(txtName.Text, txtEmail.Text, gender, txtPassword.Text, path, txtAdminID.Text);
                MessageBox.Show("Update Successful!");
                ClearAdminText();
                AutoID();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnClear.Enabled = true;
                AdminDataView();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAdmin.SelectedRows.Count > 0)
            {
                int rowindex = dgvAdmin.SelectedRows[0].Index;
                string adminid = dgvAdmin.Rows[rowindex].Cells[0].Value.ToString();

                adminobj.DeleteAdmin(adminid);
                dgvAdmin.Rows.RemoveAt(rowindex);
                MessageBox.Show("Remove admin successfully!");
            }
            else
            {
                MessageBox.Show("Please select a row to delete!");
            }
        }

    }
}
