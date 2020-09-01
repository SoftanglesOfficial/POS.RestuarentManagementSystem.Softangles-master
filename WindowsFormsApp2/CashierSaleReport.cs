using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Data;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApp2
{
    public partial class CashierSaleReport : Form
    {
        CashierService obj;
        public CashierSaleReport()
        {
            InitializeComponent();
            obj = new CashierService();
        }
        public List<UserTable> GetAllCahier()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.UserTables.Where(a=>a.IsAdmin==0).ToList();
            }
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (WorkStatus.Endworkcheck == 1 || WorkStatus.startworkcheck == 0)
            {
                if (comboBox1.Text.Trim() != "")
                {

                    List<UserTable> asd = new List<UserTable>();
                    asd = obj.Get_SelectedCashiername((comboBox1.Text));
                    if (asd.Count > 0 && asd[0].IsAdmin == 0)
                    {
                        CrystalReportSelectiveCashierSale ob = new CrystalReportSelectiveCashierSale();


                        ByPass(ob);

                        ob.SetParameterValue("start", dateTimePicker1.Value);
                        ob.SetParameterValue("end", dateTimePicker2.Value);
                        ob.SetParameterValue("CID", asd[0].UserId);
                        ob.SetParameterValue("CNAME",(asd[0].UserName.ToString()));
                        ob.SetParameterValue("name", (asd[0].FullName.ToString()));
                        crystalReportViewer1.ReportSource = ob;
                        crystalReportViewer1.Refresh();
                        crystalReportViewer1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Cashier ID Incorect");
                    }
                       
                }
                else
                {
                    MessageBox.Show("Text Field Empty!");
                }
                    
            }
            else
            {
                MessageBox.Show("First End the Work To Logout");
            }
     
        }

        private static void ByPass(CrystalReportSelectiveCashierSale ob)
        {
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;


            crConnectionInfo.ServerName = ".";
            crConnectionInfo.DatabaseName = "RMSDB";
            crConnectionInfo.UserID = "sa";
            crConnectionInfo.Password = Variable.Class1.a;

            CrTables = ob.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }
        }

        private void CashierSaleReport_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = GetAllCahier();
            comboBox1.ValueMember = "UserId";
            comboBox1.DisplayMember = "UserName";
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}
