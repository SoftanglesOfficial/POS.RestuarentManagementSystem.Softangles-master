﻿using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Barcodewebform : Form
    {
        

        public Barcodewebform(string bname,string text)
        {
            InitializeComponent();
            this.Text = text;
            this.name1 = bname;
            Text = "*" + text + "*";
        }
        public string name1 { get; set; }
        private void Barcodewebform_Load(object sender, EventArgs e)
        {
            try
            {
                CrystalReportbarcode ob = new CrystalReportbarcode();
                ByPass(ob);
                ob.SetParameterValue("Name", Text);
                ob.SetParameterValue("BName", name1);
                crystalReportViewer1.ReportSource = ob;
                crystalReportViewer1.Refresh();
                crystalReportViewer1.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            
        }

        private static void ByPass(CrystalReportbarcode ob)
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
