using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Admin : Form
    {
       // this is login
        private Form Login;
        public Admin(Form Login)
        {
            
            InitializeComponent();
            
            this.Login = Login;
            Login.Hide();
        }

        private void AdminMangeUserLbl_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                User objUser = new User(this);
                objUser.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }

        }

        private void AdminMangeUserImg_MouseClick(object sender, MouseEventArgs e)
        {
            
            AdminMangeUserLbl_MouseClick (sender,  e);
        }

        private void AdminMangeUserPanel_MouseClick(object sender, MouseEventArgs e)
        {
            AdminMangeUserLbl_MouseClick(sender, e);
        }

        private void AdminMangeTablesLbl_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                
                Form1 objUser = new Form1(this);
                objUser.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
           
        }

        private void AdminAddCatogeryLbl_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Add_Category objUser = new Add_Category(this);
                objUser.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            
        }

        private void AdminMenuItemsLbl_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                AddMenuItems objUser = new AddMenuItems(this);
                objUser.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            
        }

        private void AdminLogoutLbl_MouseClick(object sender, MouseEventArgs e)
        {
            
           
            {
                Login.Show();
                this.Close();
            }
           
        }

        private void AdminMangeTablesImg_MouseClick(object sender, MouseEventArgs e)
        {
            AdminMangeTablesLbl_MouseClick(sender, e);
        }

        private void AdminMangeTablesPanel_MouseClick(object sender, MouseEventArgs e)
        {
            AdminMangeTablesLbl_MouseClick(sender, e);
        }

        private void AdminAddCatogeryImg_MouseClick(object sender, MouseEventArgs e)
        {
            AdminAddCatogeryLbl_MouseClick(sender, e);
        }

        private void AdminAddCatogeryPanel_MouseClick(object sender, MouseEventArgs e)
        {
            AdminAddCatogeryLbl_MouseClick(sender, e);
        }

        private void AdminMenuItemsImg_MouseClick(object sender, MouseEventArgs e)
        {
            AdminMenuItemsLbl_MouseClick(sender, e);
        }

        private void AdminMenuItemsPanel_MouseClick(object sender, MouseEventArgs e)
        {
            AdminMenuItemsLbl_MouseClick(sender, e);
        }

        private void AdminLogoutPanel_MouseClick(object sender, MouseEventArgs e)
        {
            AdminLogoutLbl_MouseClick( sender,  e);
        }

        private void AdminReportsDataLbl_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ReportDashboard objUser = new ReportDashboard(this);
                objUser.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
           
        }

        private void AdminReportsDataImg_MouseClick(object sender, MouseEventArgs e)
        {
            AdminReportsDataLbl_MouseClick( sender,  e);
        }

        private void AdminReportsDataPanel_MouseClick(object sender, MouseEventArgs e)
        {
            AdminReportsDataLbl_MouseClick(sender, e);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void LblMangeSection_MouseClick(object sender, MouseEventArgs e)
        {
           AddCounter obj = new AddCounter(this);
            obj.ShowDialog();
        }

        private void ImgMangeSection_MouseClick(object sender, MouseEventArgs e)
        {
            LblMangeSection_MouseClick( sender,  e);
        }

        private void PanelMangeSection_MouseClick(object sender, MouseEventArgs e)
        {
            LblMangeSection_MouseClick(sender, e);
        }

     

        // Stock WinForm
        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Stock objUser = new Stock(this);
                objUser.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            label2_MouseClick( sender,  e);
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            label2_MouseClick(sender, e);
        }

        private void labelContactDeveloper_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                About_Developers objUser = new About_Developers();
                objUser.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            labelContactDeveloper_MouseClick(sender, e);
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            labelContactDeveloper_MouseClick(sender, e);
        }

        private void AdminLogoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            Login.Show();
            this.Close();
        }
    }
}
