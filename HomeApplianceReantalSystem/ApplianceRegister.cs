using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeApplianceReantalSystem
{
    public partial class ApplianceRegister : Form
    {
        public ApplianceRegister()
        {
            InitializeComponent();
            txtApplianceID.Text = AutoID();
            getApplianceCategory();
        }
        RentalSystemDataSetTableAdapters.ApplianceDetailTableAdapter applianceobj = new RentalSystemDataSetTableAdapters.ApplianceDetailTableAdapter();
        DataTable dtappliance = new DataTable();
        RentalSystemDataSetTableAdapters.ApplianceCategoryTableAdapter apptypeobj = new RentalSystemDataSetTableAdapters.ApplianceCategoryTableAdapter();
        
        //get appliance categories from category database for appliance category 
        public void getApplianceCategory()
        {
            DataTable dtcategory = new DataTable();
            dtcategory = apptypeobj.GetApplianceCategoryData();

            cboCategory.Items.Add("Choose your Category");
            if (dtcategory.Rows.Count >0)
            {
                cboCategory.DataSource = dtcategory;

                cboCategory.DisplayMember = "ApplianceCategoryName"; // display member is for data display
                cboCategory.ValueMember = "ApplianceCategoryID"; // value member is for data save
            }
            cboCategory.SelectedIndex = 0;
        }

        //Auto ID for every appliance
        public string AutoID()
        {
            DataTable dt = new DataTable();
            dt = applianceobj.GetApplianceDetailData();
            if(dt.Rows.Count == 0)
            {
                return "A-0001";
            }
            else
            {
                string oldid = dt.Rows[dt.Rows.Count - 1][0].ToString();
                int oldnum = Convert.ToInt32(oldid.Substring(2));
                oldnum++;
                string newid = oldnum.ToString("A-0000");
                return newid;
            }

        }
        
        // to show data from the database to data grid view from for user view
        public void getDataFromView(string id)
        {
            DataTable dt = new DataTable();
            
            dt = applianceobj.GetDataByApplianceID(id);
            
            txtApplianceID.Text = dt.Rows[0][0].ToString();
            cboCategory.SelectedValue = dt.Rows[0][1].ToString();
            txtApplianceName.Text = dt.Rows[0][2].ToString();
            txtBrandName.Text = dt.Rows[0][3].ToString();
            txtTypicalUseage.Text = dt.Rows[0][4].ToString();
            txtMonthlyFee.Text = dt.Rows[0][5].ToString();
            txtMiniumRentalMonth.Text = dt.Rows[0][6].ToString();
            txtApplianceLenght.Text = dt.Rows[0][7].ToString();
            txtApplianceWidth.Text = dt.Rows[0][8].ToString();
            txtApplianceHeight.Text = dt.Rows[0][9].ToString();
            txtAppliancePower.Text = dt.Rows[0][10].ToString();
            try
            {
                txtApplianceImage.Image = Image.FromFile(dt.Rows[0][11].ToString());
            }
            catch (Exception)
            {
                txtApplianceImage.Image = null;
            }
            cboApplianceStatus.SelectedItem = dt.Rows[0][12].ToString();

            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Visible = false;
            btnSave.Enabled = false;
            btnClear.Visible = false;
            btnViewInfo.Visible = false;
            btnBack.Visible = true;
            btnBack.Enabled = true;
            btnHome.Visible = false;
        }

        // to clear data from the appliance register group box
        public void ClearApplianceText()
        {
            txtApplianceID.Clear();
            cboCategory.SelectedIndex = 0;
            txtApplianceName.Clear();
            txtAppliancePower.Clear();
            txtTypicalUseage.Clear();
            txtApplianceWidth.Clear();
            txtApplianceHeight.Clear();
            txtApplianceLenght.Clear();
            txtAppliancePower.Clear();
            txtBrandName.Clear();
            txtMiniumRentalMonth.Clear();
            txtApplianceImage.Image =null;
            txtMonthlyFee.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearApplianceText();
            AutoID();
        }

        //to save all data to the database
        private void btnSave_Click(object sender, EventArgs e)
        {
            string message;
            message = ValidationCheck();
            if(message == "OK")
            {
                Random rdm = new Random();
                int num = rdm.Next();
                string path;
                if(txtApplianceImage.Image != null)
                {
                    string location = "D:\\NCC\\DesigningAndDevelopingObject-OrientedComputerPrograms\\HomeApplianceReantalSystem\\RentalSystem\\HomeApplianceReantalSystem\\bin\\Debug\\Appliance";
                    path = Path.Combine(location, txtApplianceID.Text+ rdm + ".png");
                    
                    txtApplianceImage.Image.Save(path);
                }
                else
                {
                    path = txtApplianceImage.Name;
                }
                applianceobj.Insert(txtApplianceID.Text, cboCategory.SelectedValue.ToString(), txtApplianceName.Text, txtBrandName.Text,
                txtTypicalUseage.Text, Convert.ToInt32(txtMonthlyFee.Text), Convert.ToInt32(txtMiniumRentalMonth.Text), Convert.ToInt32(txtApplianceLenght.Text), Convert.ToInt32(txtApplianceWidth.Text),
                Convert.ToInt32(txtApplianceHeight.Text), Convert.ToInt32(txtAppliancePower.Text),path,cboApplianceStatus.SelectedItem.ToString());
                MessageBox.Show("Register Successful!");
                ClearApplianceText();
                txtApplianceID.Text = AutoID();
            }
            else
            {
                MessageBox.Show(message);
            }
            
        }
        public string ValidationCheck() //validation checke if all required field are filled
        {
            if(txtApplianceID.Text == "")
            {
                return "Appliance ID is required!";
            }else if(txtApplianceName.Text == "")
            {
                return "Appliance Appliance name is required!";
            }else if(txtBrandName.Text == "")
            {
                return "Brand Name is required!";
            }else if(txtTypicalUseage.Text == "")
            {
                return "Appliance Type is required!";
            }else if(txtMonthlyFee.Text == "")
            {
                return "Monthly Fee is required!";
            }else if(txtMiniumRentalMonth.Text == "")
            {
                return "Minum Rental Month is required!";
            }else if(txtApplianceWidth.Text == "")
            {
                return "Appliance Width is required!";
            }else if(txtApplianceHeight.Text == "")
            {
                return "Appliance Windth is required!";
            }else if(txtApplianceLenght.Text == "")
            {
                return "Appliance Length is required!";
            }else if(txtAppliancePower.Text == "")
            {
                return "Appliance Power is required!";
            }
            else
            {
                return "OK";
            }
        }

        private void btnViewInfo_Click(object sender, EventArgs e) //to go to appliances info page
        {
            ApplianceViewInfo viewobj = new ApplianceViewInfo();
            this.Hide();
            viewobj.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ApplianceViewInfo appview = new ApplianceViewInfo();
            this.Hide();
            appview.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e) // update the appliance information
        {
            string message = ValidationCheck();
            if(message == "OK")
            {
                string path;
                if (txtApplianceImage.Image != null)
                {
                    Random rdm = new Random();
                    int num = rdm.Next();
                    
                    string location = "D:\\NCC\\DesigningAndDevelopingObject-OrientedComputerPrograms\\HomeApplianceReantalSystem\\RentalSystem\\HomeApplianceReantalSystem\\bin\\Debug\\Appliance";
                    path = Path.Combine(location, txtApplianceID.Text+num + ".png");
                    
                    txtApplianceImage.Image.Save(path);
                }
                else
                {
                    path = txtApplianceImage.Name;
                }
                applianceobj.UpdateApplianceDetail(cboCategory.SelectedValue.ToString(), txtApplianceName.Text, txtBrandName.Text,
                    txtTypicalUseage.Text, Convert.ToInt32(txtMonthlyFee.Text), Convert.ToInt32(txtMiniumRentalMonth.Text), Convert.ToInt32(txtApplianceLenght.Text), Convert.ToInt32(txtApplianceWidth.Text),
                    Convert.ToInt32(txtApplianceHeight.Text), Convert.ToInt32(txtAppliancePower.Text), path, cboApplianceStatus.SelectedItem.ToString(), txtApplianceID.Text);
                MessageBox.Show("Update Successfully!");

                ClearApplianceText();
                ApplianceViewInfo viewinfo = new ApplianceViewInfo();
                this.Hide();
                viewinfo.Show();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void txtApplianceImage_Click(object sender, EventArgs e) //select image in picuture box and view selected image
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;

            if(p != null)
            {
                open.Filter = "(*.png; *.jpg; *.jpeg) | *.png; *.jpg; *.jpeg";
                if(open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e) //go back to admin home page
        {
            AdminHome admhome = new AdminHome();
            this.Hide();
            admhome.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            applianceobj.DeleteAppliance(txtApplianceID.Text);
            MessageBox.Show("Appliance delete successfully!");

            ClearApplianceText();
            AutoID();
        }

    }
}
