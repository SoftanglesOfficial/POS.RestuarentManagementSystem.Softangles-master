
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    
    public partial class RDgettotalsale : Form
    {
        public RDgettotalsale()
        {
            InitializeComponent();
          
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                CrystalReportGetTotalSale ob = new CrystalReportGetTotalSale();

                ByPass(ob);

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
        private static void ByPass(CrystalReportGetTotalSale ob)
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

    }
}
