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
    public partial class ApplianceViewInfo : Form
    {
        public ApplianceViewInfo()
        {
            InitializeComponent();
            getCategoryData();
            cboAvailable.SelectedIndex = 0;
            appliancedt.Columns.Add("ApplianceID", typeof(string));
            appliancedt.Columns.Add("CategoryName", typeof(string));
            appliancedt.Columns.Add("ApplianceName", typeof(string));
            appliancedt.Columns.Add("BrandName", typeof(string));
            appliancedt.Columns.Add("MonthlyFee", typeof(int));
            appliancedt.Columns.Add("MinRentalMonth", typeof(int));
            appliancedt.Columns.Add("ApplianceImage", Type.GetType("System.Byte[]"));
            appliancedt.Columns.Add("ApplianceLength", typeof(int));
            appliancedt.Columns.Add("ApplianceWidth", typeof(int));
            appliancedt.Columns.Add("ApplianceHeight", typeof(int));
            appliancedt.Columns.Add("TypicalUsage", typeof(string));
            appliancedt.Columns.Add("ApplianceStatus", typeof(string));
            appliancedt.Columns.Add("AppliancePower", typeof(int));
        }
        RentalSystemDataSetTableAdapters.ApplianceDetailTableAdapter applianceobj = new RentalSystemDataSetTableAdapters.ApplianceDetailTableAdapter();
        RentalSystemDataSetTableAdapters.ApplianceCategoryTableAdapter category = new RentalSystemDataSetTableAdapters.ApplianceCategoryTableAdapter();
        DataTable appliancedt = new DataTable();

        public void getCategoryData() // get category data for category search
        {
            DataTable dt = category.GetApplianceCategoryData();
            if (dt.Rows.Count > 0)
            {
                cboCategorySearch.DataSource = dt;
                cboCategorySearch.DisplayMember = "ApplianceCategoryName";
                cboCategorySearch.ValueMember = "ApplianceCategoryID";
            }
        }

        private void ApplianceViewInfo_Load(object sender, EventArgs e)
        {
            getAllAppliacneData();
        }

        private void dgvApplianceInfo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) // give applianceid to update data and
                                                                                                      // sent it to update page this page is register page
        {
            DataGridViewRow row = this.dgvApplianceInfo.Rows[e.RowIndex];
            string applianceid = row.Cells[0].Value.ToString();
            

            ApplianceRegister registerobj = new ApplianceRegister();
            this.Hide();
            registerobj.Show();
            registerobj.ClearApplianceText();
            registerobj.getDataFromView(applianceid); // carry appliance data and then display them to register page
        }

        public void getAllAppliacneData()  // show all applaicne data
        {
            DataTable dt = applianceobj.AdminShowAllData();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = appliancedt.NewRow();
                dr["ApplianceID"] = dt.Rows[i][0].ToString();
                dr["CategoryName"] = dt.Rows[i][13].ToString();
                dr["ApplianceName"] = dt.Rows[i][2].ToString();
                dr["BrandName"] = dt.Rows[i][3].ToString();
                dr["MonthlyFee"] = dt.Rows[i][5].ToString();
                dr["MinRentalMonth"] = dt.Rows[i][6].ToString();
                dr["ApplianceLength"] = dt.Rows[i][7].ToString();
                dr["ApplianceWidth"] = dt.Rows[i][8].ToString();
                dr["ApplianceHeight"] = dt.Rows[i][9].ToString();
                dr["TypicalUsage"] = dt.Rows[i][4].ToString();
                dr["AppliancePower"] = dt.Rows[i][10].ToString();
                dr["ApplianceStatus"] = dt.Rows[i][12].ToString();
                dr["ApplianceImage"] = File.ReadAllBytes(dt.Rows[i][11].ToString());
                appliancedt.Rows.Add(dr);
            }
            dgvApplianceInfo.DataSource = appliancedt;
            dgvApplianceInfo.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome admhome = new AdminHome();
            this.Hide();
            admhome.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ApplianceRegister register = new ApplianceRegister();
            this.Hide();
            register.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e) // for data searching 
        {
            DataTable dt = new DataTable();
            if (rdoAvailable.Checked) // search data by appliance status
            {                
                string searchvalue = cboAvailable.SelectedItem.ToString(); // availabe search
                if (searchvalue == "Available")
                {
                    appliancedt.Clear();
                    dt = applianceobj.GetDataByApplianceStatus();                    
                    
                }
                else
                {
                    appliancedt.Clear();
                    dt = applianceobj.GetDataByUnavailable(); // unavailable search
                    
                }
                
            }else if (rdoCategorySearch.Checked)
            {
                string searchvalue = cboCategorySearch.SelectedValue.ToString(); //search by category 

                appliancedt.Clear();
                dt = applianceobj.AdminSearchCategory(searchvalue);                
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = appliancedt.NewRow();
                dr["ApplianceID"] = dt.Rows[i][0].ToString();
                dr["CategoryName"] = dt.Rows[i][13].ToString();
                dr["ApplianceName"] = dt.Rows[i][2].ToString();
                dr["BrandName"] = dt.Rows[i][3].ToString();
                dr["MonthlyFee"] = dt.Rows[i][5].ToString();
                dr["MinRentalMonth"] = dt.Rows[i][6].ToString();
                dr["ApplianceLength"] = dt.Rows[i][7].ToString();
                dr["ApplianceWidth"] = dt.Rows[i][8].ToString();
                dr["ApplianceHeight"] = dt.Rows[i][9].ToString();
                dr["TypicalUsage"] = dt.Rows[i][4].ToString();
                dr["AppliancePower"] = dt.Rows[i][10].ToString();
                dr["ApplianceStatus"] = dt.Rows[i][12].ToString();
                dr["ApplianceImage"] = File.ReadAllBytes(dt.Rows[i][11].ToString());
                appliancedt.Rows.Add(dr);
            }
            dgvApplianceInfo.DataSource = appliancedt;
            dgvApplianceInfo.Refresh();
        }

        private void btnShowAll_Click(object sender, EventArgs e) // show all data
        {
            getAllAppliacneData();
            
        }
    }
}
