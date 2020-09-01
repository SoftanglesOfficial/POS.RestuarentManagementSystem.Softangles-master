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
using System.Drawing.Printing;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApp2
{
    public partial class PendingBills : Form
    {
        POSService objPOSService;
        CashierService objCashierService;
        List<Data.Sale> L1 = new List<Data.Sale>();
        public static string tn = "";
        public string tablename = "";
        public static int CheckOndine = 0;
        public int person;
        public PendingBills()
        {
            InitializeComponent();
            objPOSService = new POSService();
            objCashierService = new CashierService();
        }

        private void PendingBills_Load(object sender, EventArgs e)
        {

            try
            {
                MainPanel.Visible = false;
                PanelSettlePayments.Visible = false;
                int TableShowCount = objPOSService.Getpendingsale().Count;
                L1 = objPOSService.Getpendingsale().ToList();
                int x = 50;
                int y = 50;
                for (int i = 0; i < TableShowCount; i++)
                {

                    Button b = new Button();
                    b.Location = new Point(x, y);
                    b.Name = L1[i].TableName;
                    b.Text = L1[i].TableName;
                    b.Size = new Size(180, 42);
                    b.Font = new Font("Minion Pro", 20);
                    b.Padding = new Padding(0);
                    b.Tag = new Indeces { IndexI = b.Name };
                    b.MouseClick += new MouseEventHandler(Mouse_Click);
                    flowLayoutPanel1.Controls.Add(b);




                }



            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }

        }
        public class Indeces
        {
            public String IndexI { get; set; }

        }
        public class Indeces1
        {
            public String ticketno { get; set; }

        }
        protected void Mouse_Click(object sender, EventArgs e)
        {
            try
            {
                PanelSettlePayments.Visible = false;
                Clear();
                    MainPanel.Visible = false;
                if (flowLayoutPanel2.Controls.Count == 0)
                {
                    ShowPendingBillOfSelectedTable(sender);  // dispaly menu item on fluid container
                }
                else
                {
                    flowLayoutPanel2.Controls.Clear();

                    ShowPendingBillOfSelectedTable(sender);
                }




            }



            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }



        }
        public void ShowPendingBillOfSelectedTable(object s)
        {
            var button = s as Button;
            var indeces = (Indeces)button.Tag;
            List<Data.Sale> L2 = new List<Data.Sale>();
            L2 = objPOSService.GetpendingsaleofSelectedTable(indeces.IndexI);
            tablename = indeces.IndexI;
            int Count = objPOSService.GetpendingsaleofSelectedTable(indeces.IndexI).Count;

            int x = 50;
            int y = 50;
            for (int i = 0; i < Count; i++)
            {

                Button b = new Button();
                b.Location = new Point(x, y);
                b.Name = L2[i].TicketNo;
                b.Text = L2[i].CustomerName;
                b.Size = new Size(110, 42);
                b.Font = new Font("Minion Pro", 20);
                b.Padding = new Padding(0);
                b.Tag = new Indeces1 { ticketno = b.Name };
                b.MouseClick += new MouseEventHandler(Mouse_Clickitem);
                flowLayoutPanel2.Controls.Add(b);


            }

        }
        protected void Mouse_Clickitem(object sender, EventArgs e)
        {
            try
            {
                Clear();
                PanelSettlePayments.Visible = false;
                MainPanel.Visible = true;
                var button = sender as Button;
                var indeces1 = (Indeces1)button.Tag;
                tn = indeces1.ticketno;
                //MenuIemSelectIndex = ListMenuItem[indeces1.IndexItem].id;
                //ShowMenuItemOnDGV(MenuIemSelectIndex);   // display the menu item on grid view on single click

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

       void Clear()
        {
            TextBoxCashReceived.Text = "";
            TextBoxTotalAmount.Text = "";
            TextBoxBalance.Text = "";
        }

        private void BtnSettlePayments_MouseClick(object sender, MouseEventArgs e)
        {
            PanelSettlePayments.Visible = true;
            List<Data.Sale> L1 = new List<Sale>();
            L1 = objPOSService.Get_SelectedSale(tn,"Dine_In");
            TextBoxTotalAmount.Text= L1[0].Balance.ToString();
            TextBoxTotalAmount.Enabled = false;
            person =Convert.ToInt32( L1[0].NumberOfPerson.ToString());
        }

       

        private void PendingBillsBtnPrintBill_MouseClick(object sender, MouseEventArgs e)
        {
            
            printDineTicket(tn);
            
        }
      
        public void printDineTicket(string name)
        {
            CrystalReportDineTiket ob = new CrystalReportDineTiket();
            ByPass2(ob);
           
            PrinterSettings printerName = new PrinterSettings();
            string defaultPrinter;
            defaultPrinter = printerName.PrinterName;
            ob.PrintOptions.PrinterName = defaultPrinter;


            ob.SetParameterValue("ticketno", name);
            ob.SetParameterValue("billno", name);

            ob.PrintToPrinter(1, false, 0, 0);
        }

        private static void ByPass2(CrystalReportDineTiket ob)
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
        private void BtnFinish_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (TextBoxCashReceived.Text.Trim() != "")
                {
                    if (Convert.ToDouble(TextBoxBalance.Text) >= 0)
                    {
                        if (objPOSService.SaveSaleReceivedBalance(tn, Convert.ToDouble(TextBoxCashReceived.Text), Convert.ToDouble(TextBoxBalance.Text), person, tablename))
                        {
                            MessageBox.Show("Bill Setteled");
                            printDineTicket( tn);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cash Received is less then Total bill.");
                    }
                }
                else
                {
                    MessageBox.Show("Received Amount Not Entered");
                }
               
              
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        private void TextBoxCashReceived_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxCashReceived.Text != "")
                {
                    double bal = (Convert.ToDouble(TextBoxCashReceived.Text) - Convert.ToDouble(TextBoxTotalAmount.Text));
                    TextBoxBalance.Text = (bal).ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }

        }

        private void BtnSettlePayments_Click(object sender, EventArgs e)
        {

        }

        private void BtnPendingBillUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            CheckOndine = 1;
            this.Close();
        }

        private void TextBoxCashReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
