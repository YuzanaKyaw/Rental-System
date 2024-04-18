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
    public partial class RentalReport : Form
    {
        public RentalReport()
        {
            InitializeComponent();
            
        }

        RentalSystemDataSetTableAdapters.RentalOrderTableAdapter rentalorder = new RentalSystemDataSetTableAdapters.RentalOrderTableAdapter();
        RentalSystemDataSetTableAdapters.RentalDetailTableAdapter rentaldetail = new RentalSystemDataSetTableAdapters.RentalDetailTableAdapter();


        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtReport = new DataTable();
            DataRow dr;
            dtReport.Columns.Add("RentalID", typeof(string));
            dtReport.Columns.Add("CustomerName", typeof(string));
            dtReport.Columns.Add("StartDate", typeof(string));
            dtReport.Columns.Add("DueDate", typeof(string));
            dtReport.Columns.Add("ApplianceQuantity", typeof(int));
            dtReport.Columns.Add("RentalFee", typeof(int));   // main rental report datatable and its columns
            DataTable dttemp = new DataTable(); // temporary data table for rental data
            if (rdoAllData.Checked) // search all rental data
            {
                dttemp = rentalorder.GetRentalDataBySearchAll();
            }else if (rdoDate.Checked) // dearch rental data by date
            {
                string startdate = StartDate.Value.ToString(); 
                string enddate = endDate.Value.ToString();
                dttemp = rentalorder.GetDataBySearchDate(startdate, enddate);
            }
            for (int i = 0; i < dttemp.Rows.Count; i++)  // format data to dtReport data table
            {
                dr = dtReport.NewRow();
                dr["RentalID"] = dttemp.Rows[i][0];
                dr["CustomerName"] = dttemp.Rows[i][7];
                dr["StartDate"] = dttemp.Rows[i][2];
                dr["DueDate"] = dttemp.Rows[i][3];
                dr["ApplianceQuantity"] = dttemp.Rows[i][5];
                dr["RentalFee"] = dttemp.Rows[i][4];
                dtReport.Rows.Add(dr);
            }
            dgvRentalReport.DataSource = dtReport;
            
        }

        private void dgvRentalReport_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) //view rental detail data 
        {
            DataTable dtdetail = new DataTable(); // rental appliances detail datatable
            DataRow dr;
            dtdetail.Columns.Add("ApplianceID", typeof(string));
            dtdetail.Columns.Add("ApplianceName", typeof(string));
            dtdetail.Columns.Add("UnitFee", typeof(int));
            dtdetail.Columns.Add("RentalMonth", typeof(int));
            DataGridViewRow row = this.dgvRentalReport.Rows[e.RowIndex];
            string rentalid = row.Cells[0].Value.ToString();
            
            lbRentalId.Text = rentalid;
            lbCustomerName.Text = row.Cells[1].Value.ToString();
            lbStartDate.Text = row.Cells[2].Value.ToString();
            lbDueDate.Text = row.Cells[3].Value.ToString();
            lbTotalFee.Text = row.Cells[5].Value.ToString();
            DataTable dttemp = rentaldetail.GetDataByRentalID(rentalid);  // search rental appliances by rentalid
            
            for(int i =0; i<dttemp.Rows.Count; i++)  // set appliance genral data to dtdetail
            {
                dr = dtdetail.NewRow();
                dr["ApplianceID"] = dttemp.Rows[i][1];
                dr["ApplianceName"] = dttemp.Rows[i][8];
                dr["UnitFee"] = dttemp.Rows[i][6];
                dr["RentalMonth"] = dttemp.Rows[i][7];
                dtdetail.Rows.Add(dr);
            }
            dgvRentalApplianceDetail.DataSource = dtdetail;
            dgvRentalApplianceDetail.Refresh();

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            AdminHome home = new AdminHome();
            this.Hide();
            home.Show();
        }
    }
}
