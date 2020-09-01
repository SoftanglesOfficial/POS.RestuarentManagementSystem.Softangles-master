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
using Business;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApp2
{
    public partial class RDCashierhour : Form
    {
        CashierService obj;
        public RDCashierhour()
        {
            InitializeComponent();
            obj = new CashierService();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (comboBox1.Text.Trim() != "")
                {

                    List<UserTable> asd = new List<UserTable>();
                    asd = obj.Get_SelectedCashiername((comboBox1.Text));
                    if (asd.Count > 0 && asd[0].IsAdmin == 0)
                    {
                        CrystalReportCashier ob = new CrystalReportCashier();

                        ByPass(ob);

                        ob.SetParameterValue("start", dateTimePicker1.Value);
                        ob.SetParameterValue("end", dateTimePicker2.Value);
                        ob.SetParameterValue("CID", asd[0].UserId);
                        ob.SetParameterValue("CNAME", asd[0].FullName);
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
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            
        }
        private static void ByPass(CrystalReportCashier ob)
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

        private void RDCashierhour_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = GetAllCahier();
            comboBox1.ValueMember = "UserId";
            comboBox1.DisplayMember = "UserName";
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        public List<UserTable> GetAllCahier()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.UserTables.Where(a => a.IsAdmin == 0).ToList();
            }
        }
    }
}
