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
    public partial class Cashier : Form
    {
        private Form Login;
        public Cashier(Form Login)
        {
            InitializeComponent();
            this.Login = Login;
            Login.Hide();
        }

        private void PosLbl_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (WorkStatus.startworkcheck == 1)
                {

                    POS objpos = new POS(this);
                    objpos.Show();
                }
                else
                {
                    MessageBox.Show("Start The work To perfrom Sale");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            
            
        }

        private void PosImg_MouseClick(object sender, MouseEventArgs e)
        {
            PosLbl_MouseClick(sender, e);
        }

        private void PosPanel_MouseClick(object sender, MouseEventArgs e)
        {
            PosLbl_MouseClick(sender, e);
        }

        private void StrtEndLbl_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                WorkStatus a = new WorkStatus(this);
                a.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
      
        }

        private void CashierLogoutLbl_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (WorkStatus.Endworkcheck == 1 || WorkStatus.startworkcheck == 0)
                {
                    
                    Login.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("First End the Work To Logout");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            
           
        }

        private void StrtEndImg_MouseClick(object sender, MouseEventArgs e)
        {
            StrtEndLbl_MouseClick(sender, e);
        }

        private void StrtEndPanel_MouseClick(object sender, MouseEventArgs e)
        {
            StrtEndLbl_MouseClick(sender, e);
        }

        private void CashierLogoutPanel_MouseClick(object sender, MouseEventArgs e)
        {
            CashierLogoutLbl_MouseClick(sender, e);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            CashierLogoutLbl_MouseClick(sender, e);
        }
    }
}
