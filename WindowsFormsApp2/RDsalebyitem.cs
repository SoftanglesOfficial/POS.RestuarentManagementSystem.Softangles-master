using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Data;
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
    public partial class RDsalebyitem : Form
    {
        public RDsalebyitem()
        {
            InitializeComponent();
        }
        public List<menuItem> GetAllMenuItems()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuItems.ToList();
            }
        }
        private void RDsalebyitem_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxItemList.DataSource = GetAllMenuItems();
                comboBoxItemList.ValueMember = "id";
                comboBoxItemList.DisplayMember = "itemName";
                comboBoxItemList.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboBoxItemList.AutoCompleteSource = AutoCompleteSource.ListItems;
 
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        private void buttonSearch_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (comboBoxItemList.Text != "")
                {
                    CrystalReportSaleByItem ob = new CrystalReportSaleByItem();
                    ByPass(ob);
                    ob.SetParameterValue("startd", dateTimePicker1.Value);
                    ob.SetParameterValue("endd", dateTimePicker2.Value);
                    ob.SetParameterValue("name", comboBoxItemList.Text);

                    crystalReportViewer1.ReportSource = ob;
                    crystalReportViewer1.Refresh();
                    crystalReportViewer1.Show();

                }
                else
                {
                    MessageBox.Show("Please select Item First");
                }
               
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
                CrystalReportSaleByItemAll ob = new CrystalReportSaleByItemAll();

                ByPass2(ob);
                ob.SetParameterValue("startd", dateTimePicker1.Value);
                ob.SetParameterValue("endd", dateTimePicker2.Value);
                

                crystalReportViewer1.ReportSource = ob;
                crystalReportViewer1.Refresh();
                crystalReportViewer1.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }
        private static void ByPass(CrystalReportSaleByItem ob)
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

        private static void ByPass2(CrystalReportSaleByItemAll ob)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
