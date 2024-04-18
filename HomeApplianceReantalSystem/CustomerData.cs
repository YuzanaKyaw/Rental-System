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
    public partial class CustomerData : Form
    {
        public CustomerData()
        {
            InitializeComponent();
        }
        RentalSystemDataSetTableAdapters.CustomerTableAdapter customerobj = new RentalSystemDataSetTableAdapters.CustomerTableAdapter();
        DataTable dtcustomer = new DataTable();

        private void CustomerData_Load(object sender, EventArgs e)
        {
            dtcustomer = customerobj.GetCustomerData();
            dgvCustomer.DataSource = dtcustomer;
            dgvCustomer.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome admhome = new AdminHome();
            admhome.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvCustomer.SelectedRows.Count > 0)
            {
                int rowindex = dgvCustomer.SelectedRows[0].Index;
                string customerid = dgvCustomer.Rows[rowindex].Cells[0].Value.ToString();

                customerobj.DeleteCustomer(customerid);
                dgvCustomer.Rows.RemoveAt(rowindex);
                MessageBox.Show("Customer remove successfully!");
            }
            else
            {
                MessageBox.Show("Please Select a customer to delete");
            }
        }
    }
}
