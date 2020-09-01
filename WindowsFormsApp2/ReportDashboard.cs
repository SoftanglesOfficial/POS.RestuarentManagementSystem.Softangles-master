
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ReportDashboard : Form
    {
        private Form Admin;
        public ReportDashboard(Form Admin)
        {
            try
            {
                InitializeComponent();
                this.Admin = Admin;
                Admin.Hide();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }

        }

        private void RDgettotalsalerange_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                RDgettotalsale obj = new RDgettotalsale();
                obj.ShowDialog();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                RDCashierhour obj = new RDCashierhour();
                obj.ShowDialog();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }

        }

        private void BackBtnRD_MouseClick(object sender, MouseEventArgs e)
        {
            Admin.Show();
            this.Close();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                CashierSaleReport obj = new CashierSaleReport();
                obj.ShowDialog();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }

        }

        private void BtnUser_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                RDUsers obj = new RDUsers();
                obj.ShowDialog();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        private void buttonRefund_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                RDRefund obj = new RDRefund();
                obj.ShowDialog();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        private void buttonSaleByItem_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                RDsalebyitem obj = new RDsalebyitem();
                obj.ShowDialog();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }
    }
}
