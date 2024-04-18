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
    public partial class RentalHistory : Form
    {
        public RentalHistory()
        {
            InitializeComponent();
            dtHistory.Columns.Add("RentalID", typeof(string));
            dtHistory.Columns.Add("StartDate", typeof(string));
            dtHistory.Columns.Add("DueDate", typeof(string));
            dtHistory.Columns.Add("TotalRentalFee", typeof(string));
            CustomerRentalHistory();
        }
        RentalSystemDataSetTableAdapters.RentalOrderTableAdapter rentalobj = new RentalSystemDataSetTableAdapters.RentalOrderTableAdapter();
        DataTable dtHistory = new DataTable();

        public void CustomerRentalHistory() // get customer's rental history
        {
            string customerid = LoginForm.CustomerID;
            DataTable dt = rentalobj.GetDataByCustomerID(customerid);   // select data by customerid
            for(int i=0; i<dt.Rows.Count; i++)
            {
                DataRow dr = dtHistory.NewRow();
                dr["RentalID"] = dt.Rows[i][0];
                dr["StartDate"] = dt.Rows[i][2].ToString();
                dr["DueDate"] = dt.Rows[i][3].ToString();
                dr["TotalRentalFee"] = dt.Rows[i][4].ToString();
                dtHistory.Rows.Add(dr);

            }
            dgvRentalHistory.DataSource = dtHistory;
        }

        private void btnHome_Click(object sender, EventArgs e)  // go back to home page
        {
            this.Hide();
            CustomerHome cushome = new CustomerHome();
            cushome.Show();
        }
    }
}
