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
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
            getApplianceData();
            dtCart.Columns.Add("ApplianceID",typeof(string));  // declare data tabel columns
            dtCart.Columns.Add("ApplianceName",typeof(string));
            dtCart.Columns.Add("UnitPrice", typeof(int));
            dtCart.Columns.Add("Duration", typeof(string));
            dtCart.Columns.Add("RentalFee",typeof(int));
            dtCart.Columns.Add("Cancel", Type.GetType("System.Byte[]"));
            cboRentalMonth.SelectedIndex = 0;
            AutoRentalID();
            
        }
        RentalSystemDataSetTableAdapters.ApplianceDetailTableAdapter appliances = new RentalSystemDataSetTableAdapters.ApplianceDetailTableAdapter();
        RentalSystemDataSetTableAdapters.RentalOrderTableAdapter rentalorder = new RentalSystemDataSetTableAdapters.RentalOrderTableAdapter();
        RentalSystemDataSetTableAdapters.RentalDetailTableAdapter rentaldetail = new RentalSystemDataSetTableAdapters.RentalDetailTableAdapter();
        DataTable dtCart = new DataTable();
        DataRow dr;
        int totalFee,applianceQty;
       

        public void getApplianceData()   // get appliance data to search appliance  and
                                         // set data to cbobox
        {
            DataTable dt = new DataTable();  
            dt = appliances.GetDataByApplianceStatus();
            cboAppliance.Items.Add("Choose appliance you want to rent");
            for (int i = 0; i < dt.Rows.Count; i++)  // the name of the appliance will be shown 
                                                     // same name will not be include
            {
                int index = cboAppliance.FindString(dt.Rows[i][2].ToString()); // find the same string 

                if (index != -1) // skip the same string name
                {
                    continue;
                }
                else
                {
                    cboAppliance.Items.Add(dt.Rows[i][2]);
                }
                
            }
            cboAppliance.SelectedIndex = 0;
        }
        public void AutoRentalID()   // auto generate rental id
        {
            DataTable dt = new DataTable();
            dt = rentalorder.GetRentalOrderData();
            if(dt.Rows.Count == 0)
            {
                txtRentalID.Text = "RO-00001";
            }
            else
            {
                string oldid = dt.Rows[dt.Rows.Count - 1][0].ToString();
                int oldnum = Convert.ToInt32(oldid.Substring(3));
                oldnum+=1;
                string newid = oldnum.ToString("RO-00000");
                txtRentalID.Text = newid;
            }
        }
        public void DateCalculation(int duration)  // date calculation for rented appliances
        {
            DateTime currentDate = StartDate.Value;
            DateTime duedate = currentDate.AddMonths(duration);
            DueDate.Value = duedate;
        }
        private void cboAppliance_SelectedIndexChanged(object sender, EventArgs e)   // show appliance data in appliance gird view
                                                                                     // to show raw data to customer
        {
            DataTable dt = new DataTable();
            DataTable dttemp = new DataTable();
            DataRow dr;
            dttemp.Columns.Add("ApplianceID", typeof(string));
            dttemp.Columns.Add("ApplianceName", typeof(string));
            dttemp.Columns.Add("BrandName", typeof(string));
            dttemp.Columns.Add("RentalFee", typeof(string));
            dt = appliances.GetDataByApplianceName(cboAppliance.SelectedItem.ToString());
            for(int i=0; i<dt.Rows.Count; i++)  // set appliances general data to data table
            {
                dr = dttemp.NewRow();
                dr["ApplianceID"] = dt.Rows[i][0];
                dr["ApplianceName"] = dt.Rows[i][2];
                dr["BrandName"] = dt.Rows[i][3];
                dr["RentalFee"] = dt.Rows[i][5];
                dttemp.Rows.Add(dr);

            }
            
            dgvApplianceSearch.DataSource = dttemp;  // set these data to datagridview
            dgvApplianceSearch.Refresh();

            lbApplianceCategory.Text = null;
            lbApplianceID.Text = null;
            lbApplianceName.Text = null;
            lbBrandName.Text = null;
            lbDimension.Text = null;
            lbRentalFee.Text = null;
            lbTypicalUse.Text = null;
            ApplianceImage.Image = null;
        }

        private void btnAddCart_Click(object sender, EventArgs e)  // add appliances to rental cart
        {
            try
            {
                if(cboAppliance.SelectedIndex == 0)  // check if the rent appliance is selected
                {
                    MessageBox.Show("Please select the appliance you want to rent", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else if (cboRentalMonth.SelectedIndex == 0)  // check whether the rental month is selected
                {
                    MessageBox.Show("Please select the month you rented!", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    cboRentalMonth.Enabled = false;
                    int rentalMonth = Convert.ToInt32(cboRentalMonth.SelectedItem.ToString());
                    DateCalculation(rentalMonth);
                    string appliance = lbApplianceID.Text;  // check if the appliance is already exits in rental cart
                                                            // because customer can't rent the same id appliances
                    bool isApplianceExist = false;
                    foreach(DataGridViewRow row in dgvRentalCart.Rows)
                    {
                        if(row.Cells[0].Value !=null && row.Cells[0].Value.ToString().Equals(appliance))
                        {
                            isApplianceExist = true;
                            break;
                        }
                    }

                    
                    if (isApplianceExist)
                    {
                        MessageBox.Show("Appliance already exit in rental cart!"); // show error message for same appliances
                    }
                    else
                    {
                        // get rented appliance data
                        string deleteImgPath = "D:\\NCC\\DesigningAndDevelopingObject-OrientedComputerPrograms\\HomeApplianceReantalSystem\\RentalSystem\\Images\\deleteicon.jfif";
                        DataTable dttemp = appliances.GetDataByApplianceID(lbApplianceID.Text);
                        int index = lbRentalFee.Text.IndexOf('$');
                        int rentalfeeForOne = Convert.ToInt32(lbRentalFee.Text.Substring(0, index));
                        int rentalfee = rentalfeeForOne * Convert.ToInt32(cboRentalMonth.SelectedItem.ToString());
                        dr = dtCart.NewRow();
                        dr["Cancel"] = File.ReadAllBytes(deleteImgPath);
                        dr["ApplianceID"] = lbApplianceID.Text.ToString();
                        dr["ApplianceName"] = lbApplianceName.Text.ToString();
                        dr["UnitPrice"] = rentalfeeForOne;
                        dr["Duration"] = cboRentalMonth.SelectedItem.ToString();
                        dr["RentalFee"] = rentalfee;
                        
                        totalFee += rentalfee;  // total fee calculation
                        dtCart.Rows.Add(dr);

                        applianceQty = dtCart.Rows.Count;
                        txtApplianceQuantity.Text = applianceQty.ToString();
                        dgvRentalCart.DataSource = dtCart;
                        txtTotal.Text = totalFee.ToString();
            
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }
        }


        // show appliance detail data if the datagridview cell mouse click
        private void dgvApplianceSearch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dgvApplianceSearch.Rows[e.RowIndex];
            string applianceid = row.Cells[0].Value.ToString();
            DataTable dt = appliances.GetDataByApplianceID(applianceid);   // show data to detail view
            lbApplianceID.Text = dt.Rows[0][0].ToString();
            lbApplianceName.Text = dt.Rows[0][2].ToString();
            lbApplianceCategory.Text = dt.Rows[0][13].ToString();
            lbBrandName.Text = dt.Rows[0][3].ToString();
            lbRentalFee.Text = dt.Rows[0][5].ToString() + "$ per month";
            lbTypicalUse.Text = dt.Rows[0][4].ToString();
            lbDimension.Text = "L =" + dt.Rows[0][7].ToString() + "cm W=" + dt.Rows[0][8].ToString() + "cm H=" + dt.Rows[0][9].ToString() + "cm";
            ApplianceImage.Image = Image.FromFile(dt.Rows[0][11].ToString());
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerHome cushome = new CustomerHome();
            cushome.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)  // rental appliances process
        {
            string rentid = txtRentalID.Text;
            string customerid = LoginForm.CustomerID;
            DateTime startdate = StartDate.Value;
            DateTime duedate = DueDate.Value;
            int rentalfee = Convert.ToInt32(txtTotal.Text.ToString());
            int applianceqty = Convert.ToInt32(txtApplianceQuantity.Text.ToString());
            string rentalstatus = "Rented";
            string applianceStatus = "Unavailable";
            rentalorder.Insert(rentid, customerid, startdate, duedate,   
                rentalfee, applianceqty, rentalstatus);  // save data to rental table

            for (int i=0; i<dgvRentalCart.Rows.Count-1; i++)   // save data to rental detail table
            {
                string applianceid = dgvRentalCart.Rows[i].Cells[0].Value.ToString();
                int unitfee = Convert.ToInt32(dgvRentalCart.Rows[i].Cells[3].Value.ToString());
                int rentalmonth = Convert.ToInt32(cboRentalMonth.SelectedItem.ToString());
                rentaldetail.Insert(rentid, applianceid, customerid, startdate, duedate, rentalstatus, unitfee,rentalmonth);
                appliances.UpdateApplianceStatus(applianceStatus, applianceid);
            }

            MessageBox.Show("Successfully rented!");
            getApplianceData();

            this.Hide();
            CustomerHome cushome = new CustomerHome();
            cushome.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)  // cancel the rental data before customer rented
                                                                  // this buton clear all the data in rental cart
        {
            foreach(DataGridViewRow row in this.dgvRentalCart.SelectedRows)
            {
                dgvRentalCart.Rows.RemoveAt(row.Index);
            }
            AutoRentalID();
            txtTotal.Text = null;
            StartDate.Value = DateTime.Now;
            DueDate.Value = DateTime.Now;
            txtApplianceQuantity.Text = null;
            totalFee = 0;
            applianceQty = 0;
            cboRentalMonth.Enabled = true;
            cboRentalMonth.SelectedIndex = 0;
            dtCart.Clear();
            
        }

        
        private void dgvRentalCart_CellContentClick(object sender, DataGridViewCellEventArgs e)  // cancel unit data in rental cart
        {
            if (e.ColumnIndex == this.dgvRentalCart.Columns["Cancel"].Index)
            {
                DataGridViewRow row = this.dgvRentalCart.Rows[e.RowIndex];
                int deletedRentalFee = Convert.ToInt32(row.Cells[4].Value.ToString());
                int rowindex = e.RowIndex;
                dgvRentalCart.Rows.RemoveAt(rowindex);
                totalFee = totalFee - deletedRentalFee;
                applianceQty = dgvRentalCart.RowCount;
                txtApplianceQuantity.Text = applianceQty.ToString();
                txtTotal.Text = totalFee.ToString();

            }
        }

        
    }
}
