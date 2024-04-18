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
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
        }
        RentalSystemDataSetTableAdapters.AdministratorTableAdapter adminobj = new RentalSystemDataSetTableAdapters.AdministratorTableAdapter();

        private string userid = AdminLogin.AdminID;
        private void AdminProfile_Load(object sender, EventArgs e)
        {
            getAdminInfo(userid);
        }

        public void getAdminInfo(string id)
        {
            DataTable dt = new DataTable();
            dt = adminobj.GetDataByAdminID(id);
            lbAdminName.Text = dt.Rows[0][1].ToString();
            lbAdminEmail.Text = dt.Rows[0][2].ToString();
            lbAdminGender.Text = dt.Rows[0][3].ToString();
            lbAdminPassword.Text = dt.Rows[0][4].ToString();
            try
            {
                AdminPhoto.Image = Image.FromFile(dt.Rows[0][5].ToString());
            }
            catch (Exception)
            {
                AdminPhoto.Image = Image.FromFile("D:\\NCC\\DesigningAndDevelopingObject-OrientedComputerPrograms\\HomeApplianceReantalSystem\\RentalSystem\\Images\\24-248325_profile-picture-circle-png-transparent-png.png");
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRegister register = new AdminRegister();
            register.Show();
            register.getAdmindataToUpdate(userid);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHome home = new AdminHome();
            this.Hide();
            home.Show();
        }
    }
}
