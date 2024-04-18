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
    public partial class ApplianceCategory : Form
    {
        public ApplianceCategory()
        {
            InitializeComponent();
            CategoryAutoID();
            CategoryDataView();
        }
        RentalSystemDataSetTableAdapters.ApplianceCategoryTableAdapter categoryobj = new RentalSystemDataSetTableAdapters.ApplianceCategoryTableAdapter();
        DataTable categorydt = new DataTable();

        // Auto ID for category data generate unique ID for each category 
        public void CategoryAutoID()
        {
            DataTable dt =  categoryobj.GetApplianceCategoryData();
            if(dt.Rows.Count == 0)
            {
                txtCategoryID.Text = "AC-001";
            }
            else
            {
                int size = dt.Rows.Count-1;
                string oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(3, 3)) + 1;
                if(newid>= 1 && newid <= 9)
                {
                    txtCategoryID.Text = "AC-00" + newid;
                }else if(newid>= 10 && newid <= 99)
                {
                    txtCategoryID.Text = "AC-0" + newid;
                }else if(newid>= 100 && newid<= 999)
                {
                    txtCategoryID.Text = "AC-" + newid;
                }
            }
        }

        // to show category data in data grid view
        public void CategoryDataView()
        {
            categorydt = categoryobj.GetApplianceCategoryData();
            dgvCategory.DataSource = categorydt;
            dgvCategory.Refresh();
        }

        // check category validation 
        private string CategoryValidation()
        {
            if(txtCategoryID.Text == "")
            {
                return "Category ID is required!";
            }else if(txtCategoryName.Text == "")
            {
                return "Category Name is required!";
            }
            else
            {
                return "OK";
            }
        }

        //refresh and update data grid view
        public void RefreshPage()
        {
            ClearCategoryText();
            CategoryAutoID();
            CategoryDataView();
        }

        // clear category text
        public void ClearCategoryText()
        {
            txtCategoryID.Clear();
            txtCategoryName.Clear();
        }
        
        // register and add category data to databse
        private void btnSave_Click(object sender, EventArgs e)
        {
            string message = CategoryValidation();
            if(message == "OK")
            {
                ApplianceCategoryModel acobj = new ApplianceCategoryModel();
                acobj.CategoryID = txtCategoryID.Text;
                acobj.CategoryName = txtCategoryName.Text;
                categoryobj.Insert(acobj.CategoryID, acobj.CategoryName);
                MessageBox.Show("Register Successfully!");

                RefreshPage();

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        // clear category text
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCategoryText();
        }


        // update category data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string message = CategoryValidation();
            if (message == "OK")
            {
                categoryobj.UpdateApplianceCategory(txtCategoryName.Text, txtCategoryID.Text);
                MessageBox.Show("Update Successfully!");
                RefreshPage();

                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        // delete Category data
        private void btnDelete_Click(object sender, EventArgs e)
        {
            categoryobj.DeleteApplianceCategory(txtCategoryID.Text);
            MessageBox.Show("Delete Successfully!");

            RefreshPage();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        
        // go back to home
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome admhome = new AdminHome();
            this.Hide();
            admhome.Show();
        }


        //get category data to update 
        private void dgvCategory_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dgvCategory.Rows[e.RowIndex];
            txtCategoryID.Text = row.Cells[0].Value.ToString();
            txtCategoryName.Text = row.Cells[1].Value.ToString();

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void ApplianceCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
