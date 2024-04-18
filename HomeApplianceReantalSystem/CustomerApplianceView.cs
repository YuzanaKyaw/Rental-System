using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeApplianceReantalSystem
{
    // customers view the general data of appliance data
    public partial class CustomerApplianceView : Form
    {
        public CustomerApplianceView()
        {
            InitializeComponent();
            getCategory();
            showAllApplianceData(); // showing all data as soon as the form was run
        }

        RentalSystemDataSetTableAdapters.ApplianceDetailTableAdapter appliance = new RentalSystemDataSetTableAdapters.ApplianceDetailTableAdapter();
        RentalSystemDataSetTableAdapters.ApplianceCategoryTableAdapter category = new RentalSystemDataSetTableAdapters.ApplianceCategoryTableAdapter();

        public void getCategory() // add category data to combobox
        {
            DataTable dt = category.GetApplianceCategoryData();
            if (dt.Rows.Count > 0)
            {
                cboCategory.DataSource = dt;
                cboCategory.DisplayMember = "ApplianceCategoryName";
                cboCategory.ValueMember = "ApplianceCategoryID";
            }
        }

        public void showAllApplianceData() // show all appliance data 
        {
            DataTable dt = new DataTable();
            DataTable dttemp = new DataTable();
            dt.Columns.Add("ApplianceName", typeof(string));  // dt datatable formating
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Columns.Add("BrandName", typeof(string));
            dt.Columns.Add("MonthlyFee", typeof(int));
            dt.Columns.Add("MinRentalMonth", typeof(int));
            dt.Columns.Add("ApplianceImage", Type.GetType("System.Byte[]"));

            dttemp = appliance.CustomerShowAllData();
            showNotFoundLabel(dttemp);
            for (int i = 0; i < dttemp.Rows.Count; i++)  // set data to dt datatable
            {
                DataRow dr = dt.NewRow();
                dr["ApplianceName"] = dttemp.Rows[i][2].ToString();
                dr["CategoryName"] = dttemp.Rows[i][13].ToString();
                dr["BrandName"] = dttemp.Rows[i][3].ToString();
                dr["MonthlyFee"] = dttemp.Rows[i][5];
                dr["MinRentalMonth"] = dttemp.Rows[i][6];
                dr["ApplianceImage"] = File.ReadAllBytes(dttemp.Rows[i][11].ToString());
                dt.Rows.Add(dr);
            }
            dgvAppliances.DataSource = dt;
        }
        public void showNotFoundLabel(DataTable dttemp)  // show not found data label
                                                         // if the searching data wasn't found
        {
            if (dttemp.Rows.Count == 0)
            {
                lbNotFound.Visible = true;
                dgvAppliances.Visible = false;
            }
            else
            {
                lbNotFound.Visible = false;
                dgvAppliances.Visible = true;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)  // for data searching
        {
            DataTable dt = new DataTable();  // set datatable format
            dt.Columns.Add("ApplianceName", typeof(string));  
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Columns.Add("BrandName", typeof(string));
            dt.Columns.Add("MonthlyFee", typeof(int));
            dt.Columns.Add("MinRentalMonth", typeof(int));
            dt.Columns.Add("ApplianceImage", Type.GetType("System.Byte[]"));

            string searchvalue;
            DataTable dttemp = new DataTable();
            if (rdoNameSearch.Checked)   // searching with the applinace name
            {
                searchvalue = txtApplianceSearch.Text;
                dttemp = appliance.CustomerSearchApplianceName(searchvalue);
                showNotFoundLabel(dttemp);
                
            }else if (rdoCategorySearch.Checked)  // searching category 
            {
                searchvalue = cboCategory.SelectedValue.ToString();
                dttemp = appliance.CustomerSearchByCategory(searchvalue); // add data to temporary datatable
                showNotFoundLabel(dttemp);
            }
            for (int i = 0; i < dttemp.Rows.Count; i++)  // seting data to format data table
            {
                DataRow dr = dt.NewRow();
                dr["ApplianceName"] = dttemp.Rows[i][2].ToString();
                dr["CategoryName"] = dttemp.Rows[i][13].ToString();
                dr["BrandName"] = dttemp.Rows[i][3].ToString();
                dr["MonthlyFee"] = dttemp.Rows[i][5];
                dr["MinRentalMonth"] = dttemp.Rows[i][6];
                dr["ApplianceImage"] = File.ReadAllBytes(dttemp.Rows[i][11].ToString());
                dt.Rows.Add(dr);
            }
            dgvAppliances.DataSource = dt;
        }

        private void btnShowAll_Click(object sender, EventArgs e)  // show all data of appliances
        {
            showAllApplianceData();
        }

        private void btnRentalForm_Click(object sender, EventArgs e)   // go to rental form
        {
            RentalForm rentform = new RentalForm();
            this.Hide();
            rentform.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CustomerHome cushome = new CustomerHome();
            this.Hide();
            cushome.Show();
        }
    }
}
