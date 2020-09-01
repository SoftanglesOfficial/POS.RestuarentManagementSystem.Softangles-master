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
using WindowsFormsApp2.CommonClasses;
using System.Drawing.Printing;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApp2
{
    public partial class POS : Form
    {
        private Form Cashier;

        MenuCatogeryService objMMenuCatogeryService;  // for catogery load method access
        MenuItemsService objMenuItemsService;
        POSService objPOSService;
        CashierService objCashierService;
        R_tableService objTable;

        List<Data.menuItem> Listdvgmain = new List<Data.menuItem>();
        List<Data.Sale> ListSale = new List<Data.Sale>();
        List<Data.menuCategory> ListCatogery = new List<Data.menuCategory>(); // for saving the category in list
        List<Data.menuItem> ListMenuItem = new List<Data.menuItem>();


        public static int CatogerySelectIndex = 0;
        public static int checkupdate = 0;
        public static int MenuIemSelectIndex = 0;
        public static string ticket = "";
        public static int persons = 0;
        public static int NoPrint = 0;
        public static int personupdatecheck=0;
        public static string ticketNumerForChangePlace = "";
      

        public POS(Form Cashier)
        {

            InitializeComponent();

            this.Cashier = Cashier;
            Cashier.Hide();

            objPOSService = new POSService();
            objMMenuCatogeryService = new MenuCatogeryService(); // for catogery load
            objMenuItemsService = new MenuItemsService();
            objCashierService = new CashierService();
            objTable = new R_tableService();
        }

        public void POS_Load(object sender, EventArgs e)
        {
            try
            {
                List<UserTable> asd = new List<UserTable>();
                asd = objCashierService.Get_SelectedCashiername1(Login.CashierId);
                labelCashierName.Text = asd[0].FullName;
                timer1.Start();
                if (tabControl1.SelectedTab.Name == "tabPage1")
                {
                    ticket =  (objPOSService.GetAllSalesItems().Count + 1).ToString();
                    lblTicketNo.Text = ticket;
                }

                BtnUpdatePrint.Enabled = false;
                TABtnUpdatePrint.Enabled = false;
                HDBtnUpdatePrint.Enabled = false;
                TxtFeildChangeRate.Visible = false;
            
                TextBoxUpdateTicketNo.Visible = false;

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
           

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if(TextBoxTotalPersons.Text != "")
                {
                    persons = Convert.ToInt32(TextBoxTotalPersons.Text);
                    POSTableShow obj1 = new POSTableShow(); // calling the form to show the tables availabe to select
                    obj1.ShowDialog();
                    lblTableNoHide.Visible = false;
                    LblTableName.Text = POSTableShow.PassingTableName;
                    showCatogeryFlowLayout();  // show main Catogery in long FLuid container
                }
                else
                {
                    MessageBox.Show("First Enter total number of persons");
                }
                

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
           

        }
        public void showCatogeryFlowLayout()
        {
            try
            {
                if (FlowLayoutPanelCatogery.Controls.Count == 0 && tabControl1.SelectedTab.Name == "tabPage1" || TAFlowLayoutPanelCatogery.Controls.Count == 0 && tabControl1.SelectedTab.Name == "tabPage2" || HDFlowLayoutPanelCatogery.Controls.Count == 0 && tabControl1.SelectedTab.Name == "tabPage3")
                {
                    int CatogeryCount = objMMenuCatogeryService.GetAllMenuCatogery().Count;
                    ListCatogery = objMMenuCatogeryService.GetAllMenuCatogery().ToList(); // saving cattegory to list

                    for (int i = 0; i < CatogeryCount; i++)
                    {
                        Button b = new Button();

                        b.Name = ListCatogery[i].name;
                        b.Text = ListCatogery[i].name;
                        b.BackColor = System.Drawing.ColorTranslator.FromHtml(ListCatogery[i].color);
                        b.Size = new Size(230, 42);
                        b.Font = new Font("Minion Pro", 20);
                        b.Padding = new Padding(0);
                        b.AutoSize = true;
                        b.MouseClick += new MouseEventHandler(Mouse_Click);
                        b.Tag = new Indeces { IndexI = i };

                        if (tabControl1.SelectedTab.Name == "tabPage1")
                        {
                            FlowLayoutPanelCatogery.Controls.Add(b);
                        }
                        else if (tabControl1.SelectedTab.Name == "tabPage2")
                        {
                            TAFlowLayoutPanelCatogery.Controls.Add(b);
                        }
                        else if (tabControl1.SelectedTab.Name == "tabPage3")
                        {
                            HDFlowLayoutPanelCatogery.Controls.Add(b);
                        }
                       

                    }
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            

        }
        protected void Mouse_Click(object sender, EventArgs e)
        {
            try
            {
                var button = sender as Button;
                var indeces = (Indeces)button.Tag;
                CatogerySelectIndex = ListCatogery[indeces.IndexI].id;  // get selected catogery index
                ShowMenuItem();   // display menu item of particular catoegory

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            


        }
        public void MenuItem()   // show menu item button
        {
            try
            {
                if (objMenuItemsService.Get_SelectedMenuItem(CatogerySelectIndex).Count > 0)
                {
                    int MenuItemCount = objMenuItemsService.Get_SelectedMenuItem(CatogerySelectIndex).Count;
                    ListMenuItem = objMenuItemsService.Get_SelectedMenuItem(CatogerySelectIndex).ToList();

                    for (int i = 0; i < MenuItemCount; i++)
                    {


                        Button b = new Button();

                        b.Name = ListMenuItem[i].itemName;
                        b.Text = ListMenuItem[i].itemName;
                        b.BackColor = System.Drawing.ColorTranslator.FromHtml(ListMenuItem[i].color);
                        b.Size = new Size(222, 42);
                        b.Font = new Font("Minion Pro", 20);
                        b.Padding = new Padding(0);
                        b.AutoSize = true;
                        b.MouseClick += new MouseEventHandler(Mouse_Clickitem);
                        b.Tag = new Indeces1 { IndexItem = i };

                        if (tabControl1.SelectedTab.Name == "tabPage1")
                        {
                            FlowLayoutMenuItem.Controls.Add(b);
                        }
                        else if (tabControl1.SelectedTab.Name == "tabPage2")
                        {
                            TAFlowLayoutMenuItem.Controls.Add(b);
                        }
                        else if (tabControl1.SelectedTab.Name == "tabPage3")
                        {
                            HDFlowLayoutMenuItem.Controls.Add(b);
                        }
                        else
                        {

                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Item In Specefic Catogery");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
      
        }
        public List<Stock_Tbl> GetSelectedMenuItemCount(string s)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.Stock_Tbl.Where(a => a.ItemName == s).ToList();
            }
        }
        public List<SaleDetail> GetSelectedMenuItemSale(string s)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.SaleDetails.Where(a => a.itemName == s).ToList();
            }
        }
        protected void Mouse_Clickitem(object sender, EventArgs e)
        {
            try
            {
                
                var button = sender as Button;
                var indeces1 = (Indeces1)button.Tag;
                MenuIemSelectIndex = ListMenuItem[indeces1.IndexItem].id;
                
                ShowMenuItemOnDGV(MenuIemSelectIndex);   // display the menu item on grid view on single click

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }
            
        public void ShowMenuItemOnDGV(int k )
        {
             try
            {
                double availablestock = 0;
                double Salestock = 0;
                double dvgquantity = 0;


                List<menuItem> mi = new List<menuItem>();
                List<Stock_Tbl> AllMenuItemOfCurrentType = new List<Stock_Tbl>();
                List<SaleDetail> AllSaleOfCurrentType = new List<SaleDetail>();

                mi = objMenuItemsService.Get_SelectedMenuItemONDVG(k);
                AllMenuItemOfCurrentType = GetSelectedMenuItemCount(mi[0].itemName);
                AllSaleOfCurrentType = GetSelectedMenuItemSale(mi[0].itemName);


                for (int i = 0; i < AllMenuItemOfCurrentType.Count; i++)
                {
                    availablestock += AllMenuItemOfCurrentType[i].Quantity;
                }
                for (int t = 0; t < AllSaleOfCurrentType.Count; t++)
                {
                    Salestock += AllSaleOfCurrentType[t].Quantity;
                }
                if (tabControl1.SelectedTab.Name == "tabPage1" && dgvMenu.Rows.Count > 0)
                {
                    foreach (DataGridViewRow Row in dgvMenu.Rows)
                    {
                        
                        if (Convert.ToInt32(Row.Cells[0].Value) == k)
                        {
                            dvgquantity = Convert.ToDouble(Row.Cells[4].Value) ;
                        }
                       
                       
                    }
                }
                else if (tabControl1.SelectedTab.Name == "tabPage2" && TAdgvMenu.Rows.Count > 0)
                {
                    foreach (DataGridViewRow Row in TAdgvMenu.Rows)
                    {

                        if (Convert.ToInt32(Row.Cells[0].Value) == k)
                        {
                            dvgquantity = Convert.ToDouble(Row.Cells[4].Value);
                        }


                    }
                }
                else if (tabControl1.SelectedTab.Name == "tabPage3" && HDdgvMenu.Rows.Count > 0)
                {
                    foreach (DataGridViewRow Row in HDdgvMenu.Rows)
                    {

                        if (Convert.ToInt32(Row.Cells[0].Value) == k)
                        {
                            dvgquantity = Convert.ToDouble(Row.Cells[4].Value);
                        }


                    }
                }
                double fianlAvailableAmount = availablestock - Salestock - dvgquantity;
                if (fianlAvailableAmount > 0)
                {
                    Listdvgmain = objMenuItemsService.Get_SelectedMenuItemONDVG(k); // get the slected item on list 
                    bool IsExists = false;
                    if (tabControl1.SelectedTab.Name == "tabPage1" && dgvMenu.Rows.Count > 0)   //here dgvmeanu check that weather it is n
                    {
                        foreach (DataGridViewRow Row in dgvMenu.Rows)
                        {
                            if (Convert.ToInt32(Row.Cells[0].Value) == k)
                                IsExists = true;
                        }
                    }
                    else if (tabControl1.SelectedTab.Name == "tabPage2" && TAdgvMenu.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow Row in TAdgvMenu.Rows)
                        {
                            if (Convert.ToInt32(Row.Cells[0].Value) == k)
                                IsExists = true;
                        }
                    }
                    else if (tabControl1.SelectedTab.Name == "tabPage3" && HDdgvMenu.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow Row in HDdgvMenu.Rows)
                        {
                            if (Convert.ToInt32(Row.Cells[0].Value) == k)
                                IsExists = true;
                        }
                    }

                    List<SaleCart> ListCart = new List<SaleCart>();
                    if (tabControl1.SelectedTab.Name == "tabPage1")
                    {
                        if (dgvMenu.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow Row in dgvMenu.Rows)
                            {
                                SaleCart obj = new SaleCart();
                                obj.ItemId = Convert.ToInt32(Row.Cells[0].Value);
                                obj.ItemName = Row.Cells[1].Value.ToString();
                                obj.price = Convert.ToDouble(Row.Cells[2].Value);
                                obj.discount = Convert.ToDouble(Row.Cells[3].Value);
                                //  obj.Total= Convert.ToDouble(Row.Cells[5].Value);
                                if (Convert.ToInt32(Row.Cells[0].Value) == k)
                                {
                                    obj.quantity = Convert.ToDouble(Row.Cells[4].Value) + 1;
                                    obj.Available_quantity = fianlAvailableAmount - 1;
                                }
                                else
                                {
                                    obj.quantity = Convert.ToDouble(Row.Cells[4].Value);
                                    obj.Available_quantity= Convert.ToDouble(Row.Cells[12].Value) ;
                                }
                                obj.TicketNo = Row.Cells[6].Value.ToString();
                                obj.RecordID = Convert.ToInt32(Row.Cells[7].Value);

                                obj.Aed_Vat = Convert.ToDouble(Row.Cells[8].Value);
                                


                                ListCart.Add(obj);
                            }
                        }
                    }
                    else if (tabControl1.SelectedTab.Name == "tabPage2")
                    {
                        if (TAdgvMenu.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow Row in TAdgvMenu.Rows)
                            {
                                SaleCart obj = new SaleCart();
                                obj.ItemId = Convert.ToInt32(Row.Cells[0].Value);
                                obj.ItemName = Row.Cells[1].Value.ToString();
                                obj.price = Convert.ToDouble(Row.Cells[2].Value);
                                obj.discount = Convert.ToDouble(Row.Cells[3].Value);
                                if (Convert.ToInt32(Row.Cells[0].Value) == k)
                                {
                                    obj.quantity = Convert.ToDouble(Row.Cells[4].Value) + 1;
                                    obj.Available_quantity = fianlAvailableAmount - 1;
                                }
                                else
                                {
                                    obj.quantity = Convert.ToDouble(Row.Cells[4].Value);
                                    obj.Available_quantity = Convert.ToDouble(Row.Cells[12].Value);
                                }
                                obj.TicketNo = Row.Cells[6].Value.ToString();
                                obj.RecordID = Convert.ToInt32(Row.Cells[7].Value);
                                obj.Aed_Vat = Convert.ToDouble(Row.Cells[8].Value);
                                ListCart.Add(obj);
                            }
                        }
                    }
                    else if (tabControl1.SelectedTab.Name == "tabPage3")
                    {
                        if (HDdgvMenu.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow Row in HDdgvMenu.Rows)
                            {
                                SaleCart obj = new SaleCart();
                                obj.ItemId = Convert.ToInt32(Row.Cells[0].Value);
                                obj.ItemName = Row.Cells[1].Value.ToString();
                                obj.price = Convert.ToDouble(Row.Cells[2].Value);
                                obj.discount = Convert.ToDouble(Row.Cells[3].Value);
                                if (Convert.ToInt32(Row.Cells[0].Value) == k)
                                {
                                    obj.quantity = Convert.ToDouble(Row.Cells[4].Value) + 1;
                                    obj.Available_quantity = fianlAvailableAmount - 1;
                                }
                                else
                                {
                                    obj.quantity = Convert.ToDouble(Row.Cells[4].Value);
                                    obj.Available_quantity = Convert.ToDouble(Row.Cells[12].Value);
                                }
                                obj.TicketNo = Row.Cells[6].Value.ToString();
                                obj.RecordID = Convert.ToInt32(Row.Cells[7].Value);
                                obj.Aed_Vat = Convert.ToDouble(Row.Cells[8].Value);
                                ListCart.Add(obj);
                            }
                        }
                    }


                    if (!IsExists)
                    {
                        foreach (var item in Listdvgmain)
                        {
                            SaleCart obj = new SaleCart();
                            obj.ItemId = item.id;
                            obj.ItemName = item.itemName;
                            obj.price = Convert.ToDouble(item.Price);
                            obj.discount = Convert.ToDouble(item.discountpercnt);
                            obj.quantity = Convert.ToDouble(item.quantity);

                            List<menuItem> L12 = new List<menuItem>();
                            L12 = objMMenuCatogeryService.GetoneMenuCatogery(item.id);
                            obj.Aed_Vat = Convert.ToDouble(L12[0].Aed_Vat.ToString());
                            obj.Available_quantity = fianlAvailableAmount-1;

                            if (tabControl1.SelectedTab.Name == "tabPage1")
                            {
                                obj.TicketNo = lblTicketNo.Text;

                            }
                            else if (tabControl1.SelectedTab.Name == "tabPage2")
                            {
                                obj.TicketNo = TAlblTicketNo.Text;
                            }
                            else if (tabControl1.SelectedTab.Name == "tabPage3")
                            {
                                obj.TicketNo = HDlblTicketNo.Text;
                            }
                            else
                            {

                            }

                            //obj.RecordID=item.
                            ListCart.Add(obj);
                        }
                    }
                    if (tabControl1.SelectedTab.Name == "tabPage1")
                    {
                        dgvMenu.DataSource = ListCart;

                        dgvMenu.Columns[0].Visible = false;
                        dgvMenu.Columns[3].Visible = false;
                        dgvMenu.Columns[6].Visible = false;
                        dgvMenu.Columns[7].Visible = false;
                        dgvMenu.Columns[8].Visible = false;
                        dgvMenu.Columns[9].Visible = false;
                        dgvMenu.Columns[10].Visible = false;
                        dgvMenu.Columns[11].Visible = false;



                        CalculateTotalForItem();
                        CalculteTotal();
                    }
                    else if (tabControl1.SelectedTab.Name == "tabPage2")
                    {
                        TAdgvMenu.DataSource = ListCart;

                        TAdgvMenu.Columns[0].Visible = false;
                        TAdgvMenu.Columns[3].Visible = false;
                        TAdgvMenu.Columns[6].Visible = false;
                        TAdgvMenu.Columns[7].Visible = false;
                        TAdgvMenu.Columns[8].Visible = false;
                        TAdgvMenu.Columns[9].Visible = false;
                        TAdgvMenu.Columns[10].Visible = false;
                        TAdgvMenu.Columns[11].Visible = false;

                        CalculateTotalForItem();
                        CalculteTotal();
                    }
                    else if (tabControl1.SelectedTab.Name == "tabPage3")
                    {
                        HDdgvMenu.DataSource = ListCart;

                        HDdgvMenu.Columns[0].Visible = false;
                        HDdgvMenu.Columns[3].Visible = false;
                        HDdgvMenu.Columns[6].Visible = false;
                        HDdgvMenu.Columns[7].Visible = false;
                        HDdgvMenu.Columns[8].Visible = false;
                        HDdgvMenu.Columns[9].Visible = false;
                        HDdgvMenu.Columns[10].Visible = false;
                        HDdgvMenu.Columns[11].Visible = false;

                        CalculateTotalForItem();
                        CalculteTotal();
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Item Amount not Sufficent!");

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error In Adding Item");
            }
        }
        public void CalculateTotalForItem()
        {
            try
            {
                if (tabControl1.SelectedTab.Name == "tabPage1")
                {
                    foreach (DataGridViewRow Row in dgvMenu.Rows)
                    {

                        double amoutAfterDiscount = Convert.ToDouble(Row.Cells[2].Value) - Convert.ToDouble(Row.Cells[3].Value);

                        Row.Cells[5].Value = (amoutAfterDiscount)  * Convert.ToDouble(Row.Cells[4].Value);
                        Row.Cells[9].Value = (amoutAfterDiscount * (Convert.ToDouble(Row.Cells[8].Value) / 100))*Convert.ToDouble(Row.Cells[4].Value);
                       
                    }
                }
                else if (tabControl1.SelectedTab.Name == "tabPage2")
                {
                    foreach (DataGridViewRow Row in TAdgvMenu.Rows)
                    {
                        double amoutAfterDiscount = Convert.ToDouble(Row.Cells[2].Value) - Convert.ToDouble(Row.Cells[3].Value);

                        Row.Cells[5].Value = (amoutAfterDiscount) * Convert.ToDouble(Row.Cells[4].Value);
                        Row.Cells[9].Value = (amoutAfterDiscount * (Convert.ToDouble(Row.Cells[8].Value) / 100)) * Convert.ToDouble(Row.Cells[4].Value);
                    }
                }
                else if (tabControl1.SelectedTab.Name == "tabPage3")
                {
                    foreach (DataGridViewRow Row in HDdgvMenu.Rows)
                    {
                        double amoutAfterDiscount = Convert.ToDouble(Row.Cells[2].Value) - Convert.ToDouble(Row.Cells[3].Value);

                        Row.Cells[5].Value = (amoutAfterDiscount) * Convert.ToDouble(Row.Cells[4].Value);
                        Row.Cells[9].Value = (amoutAfterDiscount * (Convert.ToDouble(Row.Cells[8].Value) / 100)) * Convert.ToDouble(Row.Cells[4].Value);
                    }
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
       
        }

        public void CalculteTotal()
        {

            try
            {
                if (tabControl1.SelectedTab.Name == "tabPage1")
                {
                    double Amount = 0.0;
                    foreach (DataGridViewRow Row in dgvMenu.Rows)
                    {
                        
                        Amount = Amount +( Convert.ToDouble(Row.Cells[5].Value)+ Convert.ToDouble(Row.Cells[9].Value) );
                    }
                    lblBalance.Text = Amount.ToString();
                }
                else if (tabControl1.SelectedTab.Name == "tabPage2")
                {
                    double Amount = 0.0;
                    foreach (DataGridViewRow Row in TAdgvMenu.Rows)
                    {

                        Amount = Amount + (Convert.ToDouble(Row.Cells[5].Value) + Convert.ToDouble(Row.Cells[9].Value));
                    }
                    TAlblBalance.Text = Amount.ToString();
                }
                else if (tabControl1.SelectedTab.Name == "tabPage3")
                {
                    double Amount = 0.0;
                    foreach (DataGridViewRow Row in HDdgvMenu.Rows)
                    {

                        Amount = Amount + (Convert.ToDouble(Row.Cells[5].Value) + Convert.ToDouble(Row.Cells[9].Value));
                    }
                    HDlblBalance.Text = Amount.ToString();
                }
               

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error In Calculating Total Amount");
            }
        }

        public void ShowMenuItem()
        {
            try
            {
                if (FlowLayoutMenuItem.Controls.Count == 0 && tabControl1.SelectedTab.Name == "tabPage1" || TAFlowLayoutMenuItem.Controls.Count == 0 && tabControl1.SelectedTab.Name == "tabPage2" || HDFlowLayoutMenuItem.Controls.Count == 0 && tabControl1.SelectedTab.Name == "tabPage3")
                {
                    MenuItem();  // dispaly menu item on fluid container
                }
                else
                {
                    FlowLayoutMenuItem.Controls.Clear();
                    TAFlowLayoutMenuItem.Controls.Clear();
                    HDFlowLayoutMenuItem.Controls.Clear();
                    MenuItem();
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            


        }
        public class Indeces1
        {
            public int IndexItem { get; set; }

        }
        public class Indeces
        {
            public int IndexI { get; set; }

        }
     
        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (LblTableName.Text != "")
                {
                    button2_MouseClick(sender, e);
                }
                else
                {
                    MessageBox.Show("First select table from table button");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            

        }

        private void BtnIncreaseQuantity_MouseClick(object sender, MouseEventArgs e)  // INcrement btn
        {
             try
            {
                if (tabControl1.SelectedTab.Name == "tabPage1")
                {
                    
                    if (dgvMenu.Rows.Count > 0)
                    {
                        if (dgvMenu.SelectedRows.Count == 1)
                        {
                            int rowIndex = dgvMenu.SelectedRows[0].Index;
                            double AvailabeAmount =Convert.ToDouble(dgvMenu.Rows[rowIndex].Cells[12].Value);
                            if (AvailabeAmount>0)
                            {
                                dgvMenu.Rows[rowIndex].Cells[4].Value = (Convert.ToDouble(dgvMenu.Rows[rowIndex].Cells[4].Value) + 1).ToString();
                                dgvMenu.Rows[rowIndex].Cells[12].Value = (Convert.ToDouble(dgvMenu.Rows[rowIndex].Cells[12].Value) - 1).ToString();
                                CalculateTotalForItem();
                                CalculteTotal();
                            }
                            else
                            {
                                MessageBox.Show("Item Amount not Sufficent!");
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("please Select Only One Row To Perform Any Operation ");
                        }

                    }
                    else
                    {
                        MessageBox.Show("First Add Menu Item on List to Perform This operation");
                    }
                    
                }
                else if (tabControl1.SelectedTab.Name == "tabPage2")
                {
                    if (TAdgvMenu.Rows.Count > 0)
                    {
                        if (TAdgvMenu.SelectedRows.Count == 1)
                        {
                            int rowIndex = TAdgvMenu.SelectedRows[0].Index;
                            double AvailabeAmount = Convert.ToDouble(TAdgvMenu.Rows[rowIndex].Cells[12].Value);
                            if (AvailabeAmount > 0)
                            {
                                TAdgvMenu.Rows[rowIndex].Cells[4].Value = (Convert.ToDouble(TAdgvMenu.Rows[rowIndex].Cells[4].Value) + 1).ToString();
                                TAdgvMenu.Rows[rowIndex].Cells[12].Value = (Convert.ToDouble(TAdgvMenu.Rows[rowIndex].Cells[12].Value) - 1).ToString();
                                CalculateTotalForItem();
                                CalculteTotal();
                            }
                            else
                            {
                                MessageBox.Show("Item Amount not Sufficent!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("please Select Only One Row To Perform Any Operation ");
                        }

                    }
                    else
                    {
                        MessageBox.Show("First Add Menu Item on List to Perform This operation");
                    }
                    
                }
                else if (tabControl1.SelectedTab.Name == "tabPage3")
                {
                    if (HDdgvMenu.Rows.Count > 0)
                    {
                        if (HDdgvMenu.SelectedRows.Count == 1)
                        {
                            int rowIndex = HDdgvMenu.SelectedRows[0].Index;
                            double AvailabeAmount = Convert.ToDouble(HDdgvMenu.Rows[rowIndex].Cells[12].Value);
                            if (AvailabeAmount > 0)
                            {
                                HDdgvMenu.Rows[rowIndex].Cells[4].Value = (Convert.ToDouble(HDdgvMenu.Rows[rowIndex].Cells[4].Value) + 1).ToString();
                                HDdgvMenu.Rows[rowIndex].Cells[12].Value = (Convert.ToDouble(HDdgvMenu.Rows[rowIndex].Cells[12].Value) - 1).ToString();
                                CalculateTotalForItem();
                                CalculteTotal();
                            }
                            else
                            {
                                MessageBox.Show("Item Amount not Sufficent!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("please Select Only One Row To Perform Any Operation ");
                        }

                    }
                    else
                    {
                        MessageBox.Show("First Add Menu Item on List to Perform This operation");
                    }
                    
                }
                else
                {

                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error In Incriment Quantity");
            }
        }


        private void TxtFeildChangeRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (dgvMenu.Rows.Count > 0) 
                    {
                        if (dgvMenu.SelectedRows.Count == 1 && TxtFeildChangeRate.Text.Trim() != "")
                        {
                            int rowIndex = dgvMenu.SelectedRows[0].Index;
                            dgvMenu.Rows[rowIndex].Cells[2].Value = Convert.ToDouble(TxtFeildChangeRate.Text);
                            CalculateTotalForItem();
                            CalculteTotal();
                            TxtFeildChangeRate.Text = "";
                        }
                        else if (TxtFeildChangeRate.Text.Trim() == "" )
                        {
                            MessageBox.Show( "Enter Price is Zero");
                        }
                        else
                        {
                            MessageBox.Show("please Select Complete One Row To Perform Any Operation ");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("First Add Menu Item on List to Perform This operation");
                    }
                    
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Error In Changing Price");
                }
                TxtFeildChangeRate.Visible = false;
            }
        }

        private void BtnChangeRate_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dgvMenu.Rows.Count > 0)
                {
                    TxtFeildChangeRate.Visible = true;
                }
                else
                    MessageBox.Show("Frist Add MenuItems");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void BtnTicketNote_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dgvMenu.Rows.Count > 0)
                {
                    TicketNote obj = new TicketNote();
                    obj.ShowDialog();
                }
                else
                    MessageBox.Show("Frist Add MenuItems");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

       

        private void BtnSavePrint_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab.Name == "tabPage1")
                {
                    if (LblTableName.Text != "No Table Selected" && LblTableName.Text != "" && TxtBoxCustomerName.Text != "" &&  TextBoxTotalPersons.Text != "" && dgvMenu.Rows.Count > 0)
                    {
                        double tx=0;
                        foreach (DataGridViewRow Row in dgvMenu.Rows)
                        {

                            SaleDetail objSaleDetail = new SaleDetail();

                            objSaleDetail.ItemId = Convert.ToInt32(Row.Cells[0].Value);
                            objSaleDetail.itemName = Row.Cells[1].Value.ToString();
                            objSaleDetail.Price = Convert.ToDouble(Row.Cells[2].Value);
                            objSaleDetail.Discount = Convert.ToDouble(Row.Cells[3].Value);
                            objSaleDetail.Quantity = Convert.ToDouble(Row.Cells[4].Value);
                            objSaleDetail.Total = Convert.ToDouble(Row.Cells[5].Value);
                            objSaleDetail.TicketNo = Row.Cells[6].Value.ToString();
                            objSaleDetail.Aed_Vat = Convert.ToDouble(Row.Cells[8].Value);
                            objSaleDetail.Aed_Vat_Amount = Convert.ToDouble(Row.Cells[9].Value);
                            objSaleDetail.Date = Convert.ToDateTime(DateTime.Now.Date);

                            tx = tx + (Convert.ToDouble(Row.Cells[9].Value));
                            
                            objPOSService.SaveSaleDetailItems(objSaleDetail, checkupdate);
                        }

                        
                        Sale objSale = new Sale();
                        objSale.TicketNo = ticket;
                        objSale.CustomerName = TxtBoxCustomerName.Text;
                        objSale.OrderType = "Dine_In";
                        objSale.TableName = LblTableName.Text;
                        objSale.TAX = tx;
                        objSale.Balance = Convert.ToDouble(lblBalance.Text);
                        objSale.TicketNote = TicketNote.tnote;
                        objSale.IsDeleted = 0;
                        
                        objSale.IsBillPending = 1;
                        objSale.PhoneNumber = "";
                        objSale.DeliveryAddress = "";
                        objSale.cashier_id = Login.CashierId;
                        objSale.IsRefund = 0;
                        List<UserTable> asd = new List<UserTable>();
                        asd = objCashierService.Get_SelectedCashiername1(Login.CashierId);
                        objSale.Cahier_Name = asd[0].FullName;
                        objSale.day = Convert.ToDateTime(DateTime.Now.Date);


                        objSale.NumberOfPerson = Convert.ToInt32(TextBoxTotalPersons.Text);
                        objTable.Save_filled(LblTableName.Text,Convert.ToInt32(TextBoxTotalPersons.Text));



                        if (objPOSService.SaveSale(objSale, checkupdate))
                        {

                            
                            MessageBox.Show("Table Added Seccessfully.");
                            printKitchenTicket(ticket);

                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("DATABASE INSERTION FAILED");
                        }
                        

                        
                    }

                    else
                    {
                        MessageBox.Show("Please Complete the Sale to Save the Data");
                    }
                }
                else if (tabControl1.SelectedTab.Name == "tabPage2")
                {
                    if (TATxtBoxCustomerName.Text != "" && TATextBoxReceivedAmount.Text!="" && TAdgvMenu.Rows.Count > 0)
                    {
                        if (Convert.ToDouble(TATextBoxBalance.Text) >= 0)
                        {
                            double tx = 0;

                            foreach (DataGridViewRow Row in TAdgvMenu.Rows)
                            {

                                SaleDetail objSaleDetail = new SaleDetail();

                                objSaleDetail.ItemId = Convert.ToInt32(Row.Cells[0].Value);
                                objSaleDetail.itemName = Row.Cells[1].Value.ToString();
                                objSaleDetail.Price = Convert.ToDouble(Row.Cells[2].Value);
                                objSaleDetail.Discount = Convert.ToDouble(Row.Cells[3].Value);
                                objSaleDetail.Quantity = Convert.ToDouble(Row.Cells[4].Value);
                                objSaleDetail.Total = Convert.ToDouble(Row.Cells[5].Value);
                                objSaleDetail.TicketNo = Row.Cells[6].Value.ToString();
                                objSaleDetail.Aed_Vat = Convert.ToDouble(Row.Cells[8].Value);
                                objSaleDetail.Aed_Vat_Amount = Convert.ToDouble(Row.Cells[9].Value);
                                objSaleDetail.Date = Convert.ToDateTime(DateTime.Now.Date);

                                tx = tx + (Convert.ToDouble(Row.Cells[9].Value));

                                objPOSService.SaveSaleDetailItems(objSaleDetail, checkupdate);

                            }
                            Sale objSale = new Sale();

                            objSale.TAX = tx;
                            objSale.TicketNo = ticket;
                            objSale.CustomerName = TATxtBoxCustomerName.Text;
                            objSale.OrderType = "Take_Away";
                            objSale.TableName = "";
                            objSale.Balance = Convert.ToDouble(TAlblBalance.Text);
                            objSale.TicketNote = TicketNote.tnote;
                            objSale.IsDeleted = 0;
                            objSale.IsBillPending = 0;
                            objSale.PhoneNumber = "";
                            objSale.DeliveryAddress = "";
                            objSale.cashier_id = Login.CashierId;
                            objSale.day = Convert.ToDateTime(DateTime.Now.Date);
                            objSale.ReceivedAmount = Convert.ToDouble(TATextBoxReceivedAmount.Text);
                            objSale.RemainingBalance = Convert.ToDouble(TATextBoxBalance.Text);

                            objSale.IsRefund = 0;
                            List<UserTable> asd = new List<UserTable>();
                            asd = objCashierService.Get_SelectedCashiername1(Login.CashierId);
                            objSale.Cahier_Name = asd[0].FullName;

                            if (objPOSService.SaveSale(objSale, checkupdate))
                            {
                                MessageBox.Show("Table Added Seccessfully.");
                                if (NoPrint != 1)
                                {
                                    printKitchenTicket(ticket);
                                    printDineTicket(ticket);
                                }
                                else
                                {
                                    printKitchenTicket(ticket);
                                }

                                ClearAll();
                            }
                            else
                            {
                                MessageBox.Show("DATABASE INSERTION FAILED");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Received Amount is Less the Totoal Bill");
                        }


                    }

                    else
                    {
                        MessageBox.Show("Please Complete the Sale to Save the Data");
                    }
                }
                else if (tabControl1.SelectedTab.Name == "tabPage3")
                {
                    if (HDTxtBoxCustomerName.Text != "" && HomeDeliveryTextBocPhoneNumber.Text != "" && HomeDeliveryTextBocDeliveryAddress.Text != "" && HDdgvMenu.Rows.Count > 0)
                    {

                            double tx = 0;

                            foreach (DataGridViewRow Row in HDdgvMenu.Rows)
                            {

                                SaleDetail objSaleDetail = new SaleDetail();

                                objSaleDetail.ItemId = Convert.ToInt32(Row.Cells[0].Value);
                                objSaleDetail.itemName = Row.Cells[1].Value.ToString();
                                objSaleDetail.Price = Convert.ToDouble(Row.Cells[2].Value);
                                objSaleDetail.Discount = Convert.ToDouble(Row.Cells[3].Value);
                                objSaleDetail.Quantity = Convert.ToDouble(Row.Cells[4].Value);
                                objSaleDetail.Total = Convert.ToDouble(Row.Cells[5].Value);
                                objSaleDetail.TicketNo = Row.Cells[6].Value.ToString();
                                objSaleDetail.Aed_Vat = Convert.ToDouble(Row.Cells[8].Value);
                                objSaleDetail.Aed_Vat_Amount = Convert.ToDouble(Row.Cells[9].Value);
                                objSaleDetail.Date = Convert.ToDateTime(DateTime.Now.Date);

                            tx = tx + (Convert.ToDouble(Row.Cells[9].Value));

                            objPOSService.SaveSaleDetailItems(objSaleDetail, checkupdate);
                            }

                            Sale objSale = new Sale();

                            objSale.TAX = tx;
                            objSale.TicketNo = ticket;
                            objSale.CustomerName = HDTxtBoxCustomerName.Text;
                            objSale.OrderType = "Home_Delivery";
                            objSale.TableName = "";
                            objSale.Balance = Convert.ToDouble(HDlblBalance.Text);
                            objSale.TicketNote = TicketNote.tnote;
                            objSale.IsDeleted = 0;
                            objSale.IsBillPending = 1;
                            objSale.PhoneNumber = HomeDeliveryTextBocPhoneNumber.Text;
                            objSale.DeliveryAddress = HomeDeliveryTextBocDeliveryAddress.Text;

                            objSale.day = Convert.ToDateTime(DateTime.Now.Date);
                            objSale.IsRefund = 0;
                            objSale.cashier_id = Login.CashierId;
                            List<UserTable> asd = new List<UserTable>();
                            asd = objCashierService.Get_SelectedCashiername1(Login.CashierId);
                            objSale.Cahier_Name = asd[0].FullName;

                            if (objPOSService.SaveSale(objSale, checkupdate))
                            {
                                MessageBox.Show("Table Added Seccessfully.");
                                if (NoPrint != 1)
                                {
                                    printKitchenTicket(ticket);
                                    printDineTicket(ticket);
                                }
                                else
                                {
                                    printKitchenTicket(ticket);
                                }
                                ClearAll();
                            }
                            else
                            {
                                MessageBox.Show("DATABASE INSERTION FAILED");
                            }
                      



                    }

                    else
                    {
                        MessageBox.Show("Please Complete the Sale to Save the Data");
                    }
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
  

        }

        private void BtnUpdatePrint_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab.Name == "tabPage1")
                {
                    if(LblTableName.Text.Trim() != "")
                    {
                        if (dgvMenu.Rows.Count > 0 && TextBoxUpdateTicketNo.Text != "")
                        {
                            checkupdate = 1;
                            double tx = 0;
                            foreach (DataGridViewRow Row in dgvMenu.Rows)
                            {
                                List<Data.SaleDetail> ListS = new List<Data.SaleDetail>();
                                ListS = objPOSService.Get_SelectedSaledetailItemup(Convert.ToInt32(Row.Cells[0].Value), Row.Cells[6].Value.ToString());


                                SaleDetail objSaleDetail = new SaleDetail();

                                objSaleDetail.ItemId = Convert.ToInt32(Row.Cells[0].Value);
                                objSaleDetail.itemName = Row.Cells[1].Value.ToString();
                                objSaleDetail.Price = Convert.ToDouble(Row.Cells[2].Value);
                                objSaleDetail.Discount = Convert.ToDouble(Row.Cells[3].Value);
                                objSaleDetail.Quantity = Convert.ToDouble(Row.Cells[4].Value);
                                objSaleDetail.Total = Convert.ToDouble(Row.Cells[5].Value);
                                objSaleDetail.TicketNo = Row.Cells[6].Value.ToString();
                                objSaleDetail.Aed_Vat = Convert.ToDouble(Row.Cells[8].Value);
                                objSaleDetail.Aed_Vat_Amount = Convert.ToDouble(Row.Cells[9].Value);
                                objSaleDetail.Date = Convert.ToDateTime(DateTime.Now.Date);

                                tx = tx + (Convert.ToDouble(Row.Cells[9].Value));
                                if (ListS.Count == 0)
                                {
                                    checkupdate = 0;
                                    objPOSService.SaveSaleDetailItems(objSaleDetail, checkupdate);
                                }
                                else
                                {
                                    checkupdate = 1;
                                    objSaleDetail.RecordID = Convert.ToInt32(Row.Cells[7].Value);
                                    objPOSService.SaveSaleDetailItems(objSaleDetail, checkupdate);
                                }
                            }
                            checkupdate = 1;
                            Sale objSale = new Sale();
                            objSale.TAX = tx;
                            objSale.TicketNo = dgvMenu.Rows[0].Cells[6].Value.ToString();
                            objSale.TableName = LblTableName.Text;
                            objSale.CustomerName = TxtBoxCustomerName.Text;
                            objSale.OrderType = "Dine_In";
                            objSale.Balance = Convert.ToDouble(lblBalance.Text);
                            objSale.TicketNote = TicketNote.tnote;
                            objSale.IsDeleted = 0;

                            objSale.PhoneNumber = "";
                            objSale.DeliveryAddress = "";
                            objSale.IsBillPending = 1;
                            objSale.day = Convert.ToDateTime(DateTime.Now.Date);



                            String pre_table = ListSale[0].TableName;
                            int pre_person = ListSale[0].NumberOfPerson;
                            String neew_table = LblTableName.Text;
                            int new_person = Convert.ToInt32(TextBoxTotalPersons.Text);

                            int Final_person = 0;

                            if (new_person > pre_person)
                            {
                                Final_person = (new_person - pre_person) + pre_person;
                            }
                            else if (new_person < pre_person)
                            {
                                Final_person = pre_person - (pre_person - new_person);
                            }
                            else if (new_person == pre_person)
                            {
                                Final_person = new_person;
                            }

                            if (String.Equals(pre_table, neew_table))
                            {
                                objTable.remove_filled(pre_table, pre_person);
                                objTable.Save_filled(neew_table, Final_person);
                            }
                            else
                            {
                                objTable.remove_filled(pre_table, pre_person);
                                objTable.Save_filled(neew_table, Final_person);

                            }

                            objSale.NumberOfPerson = Final_person;


                            objSale.IsRefund = 0;
                            objSale.cashier_id = Login.CashierId;

                            List<UserTable> asd = new List<UserTable>();
                            asd = objCashierService.Get_SelectedCashiername1(Login.CashierId);
                            objSale.Cahier_Name = asd[0].FullName;
                            if (objPOSService.SaveSale(objSale, checkupdate))
                            {
                                MessageBox.Show("Table Added Seccessfully.");
                                printKitchenTicket(ticket);
                                ClearAll();
                            }
                            else
                            {
                                MessageBox.Show("DATABASE INSERTION FAILED");
                            }


                        }


                        else if (dgvMenu.Rows.Count == 0 && TextBoxUpdateTicketNo.Text != "")
                        {
                            string pret = ListSale[0].TableName;
                            int preno = (ListSale[0].NumberOfPerson);
                            objTable.remove_filled(pret, preno);
                             
                            objPOSService.Delete_SaleRowFromSale(lblTicketNo.Text);
                            MessageBox.Show("Data Deleted ");
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("First Fetch date From Get data botton ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select Table ");
                    }
                    
                }
                else if (tabControl1.SelectedTab.Name == "tabPage2")
                {
                    if (TAdgvMenu.Rows.Count > 0 && TATextBoxUpdateTicketNo.Text != "")
                    {
                        if (Convert.ToDouble(TATextBoxBalance.Text) >= 0)
                        {
                            double tx = 0;

                            checkupdate = 1;
                            foreach (DataGridViewRow Row in TAdgvMenu.Rows)
                            {
                                List<Data.SaleDetail> ListS = new List<Data.SaleDetail>();
                                ListS = objPOSService.Get_SelectedSaledetailItemup(Convert.ToInt32(Row.Cells[0].Value), Row.Cells[6].Value.ToString());


                                SaleDetail objSaleDetail = new SaleDetail();

                                objSaleDetail.ItemId = Convert.ToInt32(Row.Cells[0].Value);
                                objSaleDetail.itemName = Row.Cells[1].Value.ToString();
                                objSaleDetail.Price = Convert.ToDouble(Row.Cells[2].Value);
                                objSaleDetail.Discount = Convert.ToDouble(Row.Cells[3].Value);
                                objSaleDetail.Quantity = Convert.ToDouble(Row.Cells[4].Value);
                                objSaleDetail.Total = Convert.ToDouble(Row.Cells[5].Value);
                                objSaleDetail.TicketNo = Row.Cells[6].Value.ToString();
                                objSaleDetail.Aed_Vat = Convert.ToDouble(Row.Cells[8].Value);
                                objSaleDetail.Aed_Vat_Amount = Convert.ToDouble(Row.Cells[9].Value);
                                objSaleDetail.Date = Convert.ToDateTime(DateTime.Now.Date);

                                tx = tx + (Convert.ToDouble(Row.Cells[9].Value));


                                if (ListS.Count == 0)
                                {
                                    checkupdate = 0;
                                    objPOSService.SaveSaleDetailItems(objSaleDetail, checkupdate);
                                }
                                else
                                {
                                    checkupdate = 1;
                                    objSaleDetail.RecordID = Convert.ToInt32(Row.Cells[7].Value);
                                    objPOSService.SaveSaleDetailItems(objSaleDetail, checkupdate);
                                }

                            }
                            checkupdate = 1;
                            Sale objSale = new Sale();
                            objSale.TicketNo = TAdgvMenu.Rows[0].Cells[6].Value.ToString();

                            objSale.TAX = tx;
                            objSale.CustomerName = TATxtBoxCustomerName.Text;
                            objSale.OrderType = "Take_Away";
                            objSale.Balance = Convert.ToDouble(TAlblBalance.Text);
                            objSale.TicketNote = TicketNote.tnote;
                            objSale.IsDeleted = 0;
                            objSale.IsBillPending = 0;
                            objSale.PhoneNumber = "";
                            objSale.DeliveryAddress = "";
                            objSale.TableName = "";
                            objSale.ReceivedAmount = Convert.ToDouble(TATextBoxReceivedAmount.Text);
                            objSale.RemainingBalance = Convert.ToDouble(TATextBoxBalance.Text);
                            objSale.day = Convert.ToDateTime(DateTime.Now.Date);
                            objSale.IsRefund = 0;
                            objSale.cashier_id = Login.CashierId;

                            List<UserTable> asd = new List<UserTable>();
                            asd = objCashierService.Get_SelectedCashiername1(Login.CashierId);
                            objSale.Cahier_Name = asd[0].FullName;

                            if (objPOSService.SaveSale(objSale, checkupdate))
                            {
                                MessageBox.Show("Table Added Seccessfully.");
                                if (NoPrint != 1)
                                {
                                    printKitchenTicket(ticket);
                                    printDineTicket(objSale.TicketNo);
                                    
                                }
                                else
                                {
                                    printKitchenTicket(ticket);
                                }
                                ClearAll();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Received Amount is less then Total Bill.");
                        }
                           

                        
                    }


                    else if (TAdgvMenu.Rows.Count == 0 && TATextBoxUpdateTicketNo.Text != "")
                    {
                        objPOSService.Delete_SaleRowFromSale(TAlblTicketNo.Text);
                        MessageBox.Show("Data Deleted ");
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("First Fetch date From Get data button ");
                    }

                }
                else if (tabControl1.SelectedTab.Name == "tabPage3")
                {
                    if (HDdgvMenu.Rows.Count > 0 && HDTextBoxUpdateTicketNo.Text != "")
                    {
                        double tx = 0;
                    
                        checkupdate = 1;
                        foreach (DataGridViewRow Row in HDdgvMenu.Rows)
                        {
                            List<Data.SaleDetail> ListS = new List<Data.SaleDetail>();
                            ListS = objPOSService.Get_SelectedSaledetailItemup(Convert.ToInt32(Row.Cells[0].Value), Row.Cells[6].Value.ToString());


                            SaleDetail objSaleDetail = new SaleDetail();

                            objSaleDetail.ItemId = Convert.ToInt32(Row.Cells[0].Value);
                            objSaleDetail.itemName = Row.Cells[1].Value.ToString();
                            objSaleDetail.Price = Convert.ToDouble(Row.Cells[2].Value);
                            objSaleDetail.Discount = Convert.ToDouble(Row.Cells[3].Value);
                            objSaleDetail.Quantity = Convert.ToDouble(Row.Cells[4].Value);
                            objSaleDetail.Total = Convert.ToDouble(Row.Cells[5].Value);
                            objSaleDetail.TicketNo = Row.Cells[6].Value.ToString();
                            objSaleDetail.Aed_Vat = Convert.ToDouble(Row.Cells[8].Value);
                            objSaleDetail.Aed_Vat_Amount = Convert.ToDouble(Row.Cells[9].Value);
                            objSaleDetail.Date = Convert.ToDateTime(DateTime.Now.Date);

                            tx = tx + (Convert.ToDouble(Row.Cells[9].Value));

                            if (ListS.Count == 0)
                            {
                                checkupdate = 0;
                                objPOSService.SaveSaleDetailItems(objSaleDetail, checkupdate);
                            }
                            else
                            {
                                checkupdate = 1;
                                objSaleDetail.RecordID = Convert.ToInt32(Row.Cells[7].Value);
                                objPOSService.SaveSaleDetailItems(objSaleDetail, checkupdate);
                            }

                        }
                        checkupdate = 1;
                        Sale objSale = new Sale();
                        objSale.TicketNo = HDdgvMenu.Rows[0].Cells[6].Value.ToString();
                      
                        objSale.TAX = tx;
                        objSale.CustomerName = HDTxtBoxCustomerName.Text;
                        objSale.PhoneNumber = HomeDeliveryTextBocPhoneNumber.Text;
                        objSale.DeliveryAddress = HomeDeliveryTextBocDeliveryAddress.Text;
                        objSale.OrderType = "Home_Delivery";
                        objSale.Balance = Convert.ToDouble(HDlblBalance.Text);
                        objSale.TicketNote = TicketNote.tnote;
                        objSale.IsBillPending = 1;
                        objSale.IsDeleted = 0;
                        objSale.TableName = "";
                       
                        objSale.day = Convert.ToDateTime(DateTime.Now.Date);
                        objSale.IsRefund = 0;
                        objSale.cashier_id = Login.CashierId;
                      
                        List<UserTable> asd = new List<UserTable>();
                        asd = objCashierService.Get_SelectedCashiername1(Login.CashierId);
                        objSale.Cahier_Name = asd[0].FullName;

                        if (objPOSService.SaveSale(objSale, checkupdate))
                        {
                            MessageBox.Show("Table Added Seccessfully.");
                            if (NoPrint != 1)
                            {
                                printKitchenTicket(ticket);
                                printDineTicket(objSale.TicketNo);
                               
                            }
                            else
                            {
                                printKitchenTicket(ticket);
                            }
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("DATABASE INSERTION FAILED");
                        }
                       
                    }


                    else if (HDdgvMenu.Rows.Count == 0 && HDTextBoxUpdateTicketNo.Text != "")
                    {
                        objPOSService.Delete_SaleRowFromSale(HDlblTicketNo.Text);
                        MessageBox.Show("Data Deleted ");
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("First Fetch date From Get data button ");
                    }
                }
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error Updating Form");
            }
            


        }
        public void ClearAll()
        {
            
                NoPrint = 0;
                if (tabControl1.SelectedTab.Name == "tabPage1")
            {
                personupdatecheck = 0;
                PendingBills.CheckOndine = 0;
                TextBoxTotalPersons.Enabled = true;
                TicketNote.tnote = "";
                TextBoxTotalPersons.Text = "";
                LblTableName.Text = "No Table Selected";
                lblTableNoHide.Visible = false;
                TxtBoxCustomerName.Text = "";
                TxtFeildChangeRate.Text = "";
                FlowLayoutMenuItem.Controls.Clear();
                TextBoxUpdateTicketNo.Text = "";
                lblTicketNo.Text = (objPOSService.GetAllSalesItems().Count + 1).ToString();
                ticket = lblTicketNo.Text;
                dgvMenu.DataSource = null;
                dgvMenu.Rows.Clear();
                BtnSavePrint.Enabled = true;
               
                TextBoxUpdateTicketNo.Visible = false;
                checkupdate = 0;
                lblBalance.Text = "";
                BtnUpdatePrint.Enabled = false;
                
            }
            else if (tabControl1.SelectedTab.Name == "tabPage2")
            {
                buttonTASave.Enabled = true;
                TAlblBalance.Text = "";
                TicketNote.tnote = "";
                TATxtFeildChangeRate.Text = "";
                TAFlowLayoutMenuItem.Controls.Clear();
                TATextBoxUpdateTicketNo.Text = "";
                TATxtBoxCustomerName.Text = "";

                TAlblTicketNo.Text = (objPOSService.GetAllSalesItems().Count + 1).ToString();
                ticket = TAlblTicketNo.Text;
                TAdgvMenu.DataSource = null;
                TAdgvMenu.Rows.Clear();
                TABtnSavePrint.Enabled = true;
                TATextBoxBalance.Text = "";
                TATextBoxUpdateTicketNo.Visible = false;
               
                checkupdate = 0;
                TATextBoxReceivedAmount.Text = "";
                TABtnUpdatePrint.Enabled = false;
                
            }
            else if (tabControl1.SelectedTab.Name == "tabPage3")
            {
                buttonHDSave.Enabled = true;
                TicketNote.tnote = "";
                HDTextBoxUpdateTicketNo.Visible = false;
                HDTxtBoxCustomerName.Text = "";
                HDTxtFeildChangeRate.Text = "";
                HDFlowLayoutMenuItem.Controls.Clear();
                HDTextBoxUpdateTicketNo.Text = "";
                HomeDeliveryTextBocDeliveryAddress.Text = "";
                HomeDeliveryTextBocPhoneNumber.Text = "";
                HDlblTicketNo.Text =(objPOSService.GetAllSalesItems().Count + 1).ToString();
                ticket = HDlblTicketNo.Text;
                HDdgvMenu.DataSource = null;
                HDdgvMenu.Rows.Clear();
                HDBtnSavePrint.Enabled = true;
             
                HDTextBoxUpdateTicketNo.Visible = false;
                checkupdate = 0;
                HDlblBalance.Text = "";
               
                HDBtnUpdatePrint.Enabled = false;
            }
           
        }
        private void TextBoxUpdateTicketNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    BtnUpdatePrint.Enabled = true;
                    TextBoxUpdateTicketNo.Visible = false;
                    personupdatecheck = 1;
                    //store ticket number
                    buttonTASave.Enabled = false;
                    TextBoxTotalPersons.Enabled = true;
                    LoadDataForUpdatation();
                    showCatogeryFlowLayout();

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Cannot Find the entered Ticket in records");
                    ClearAll();
                }

            }

        }
        public void LoadDataForUpdatation()
        {
            try
            {
                if (tabControl1.SelectedTab.Name == "tabPage1")
                {
                    int count = objPOSService.Get_SelectedSale(TextBoxUpdateTicketNo.Text, "Dine_In").Count;

                    if (count > 0)
                    {
                        dgvMenu.DataSource = null;

                        dgvMenu.DataSource = objPOSService.Get_SelectedSaleDetail(TextBoxUpdateTicketNo.Text);
                        dgvMenu.AutoResizeColumns(); 
                        lblTicketNo.Text = TextBoxUpdateTicketNo.Text;
                        lblTableNoHide.Text = "";


                        dgvMenu.Columns[0].Visible = false;
                        dgvMenu.Columns[3].Visible = false;
                        dgvMenu.Columns[6].Visible = false;
                        dgvMenu.Columns[7].Visible = false;
                        dgvMenu.Columns[8].Visible = false;
                        dgvMenu.Columns[9].Visible = false;
                        
                        


                        ListSale = objPOSService.Get_SelectedSale(TextBoxUpdateTicketNo.Text, "Dine_In");
                        LblTableName.Text = ListSale[0].TableName;
                        TxtBoxCustomerName.Text = ListSale[0].CustomerName;
                        lblBalance.Text = (ListSale[0].Balance).ToString();
                        TextBoxTotalPersons.Text= (ListSale[0].NumberOfPerson).ToString();
                        ticketNumerForChangePlace = ListSale[0].TicketNo;
                        TicketNote.tnote = (ListSale[0].TicketNote);
                        BtnSavePrint.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("This Record not Exist in DataBase!");
                        TextBoxUpdateTicketNo.Text = "";
                    }
                }
                else if (tabControl1.SelectedTab.Name == "tabPage2")
                {
                    int count = objPOSService.Get_SelectedSale(TATextBoxUpdateTicketNo.Text, "Take_Away").Count;

                    if (count > 0)
                    {
                        TAdgvMenu.DataSource = objPOSService.Get_SelectedSaleDetail(TATextBoxUpdateTicketNo.Text);
                        TAlblTicketNo.Text = TATextBoxUpdateTicketNo.Text;


                        TAdgvMenu.Columns[0].Visible = false;
                        TAdgvMenu.Columns[3].Visible = false;
                        TAdgvMenu.Columns[6].Visible = false;
                        TAdgvMenu.Columns[7].Visible = false;
                        TAdgvMenu.Columns[8].Visible = false;
                        TAdgvMenu.Columns[9].Visible = false;
                        


                        ListSale = objPOSService.Get_SelectedSale(TATextBoxUpdateTicketNo.Text, "Take_Away");

                        TATxtBoxCustomerName.Text = ListSale[0].CustomerName;
                        TAlblBalance.Text = (ListSale[0].Balance).ToString();
                        TicketNote.tnote = (ListSale[0].TicketNote);
                       TATextBoxBalance.Text = (ListSale[0].RemainingBalance).ToString();
                        TATextBoxReceivedAmount.Text= (ListSale[0].ReceivedAmount).ToString();
                        TABtnSavePrint.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("This Record not Exist in DataBase!");
                        TextBoxUpdateTicketNo.Text = "";
                    }

                }
                else if (tabControl1.SelectedTab.Name == "tabPage3")
                {
                    int count = objPOSService.Get_SelectedSale(HDTextBoxUpdateTicketNo.Text, "Home_Delivery").Count;

                    if (count > 0)
                    {
                        HDdgvMenu.DataSource = objPOSService.Get_SelectedSaleDetail(HDTextBoxUpdateTicketNo.Text);
                        HDlblTicketNo.Text = HDTextBoxUpdateTicketNo.Text;

                        HDdgvMenu.Columns[0].Visible = false;
                        HDdgvMenu.Columns[3].Visible = false;
                        HDdgvMenu.Columns[6].Visible = false;
                        HDdgvMenu.Columns[7].Visible = false;
                        HDdgvMenu.Columns[8].Visible = false;
                        HDdgvMenu.Columns[9].Visible = false;
                       
                        ListSale = objPOSService.Get_SelectedSale(HDTextBoxUpdateTicketNo.Text, "Home_Delivery");
                        HomeDeliveryTextBocPhoneNumber.Text = (ListSale[0].PhoneNumber);
                        HomeDeliveryTextBocDeliveryAddress.Text = (ListSale[0].DeliveryAddress);
                        HDTxtBoxCustomerName.Text = ListSale[0].CustomerName;
                        HDlblBalance.Text = (ListSale[0].Balance).ToString();
                       
                        TicketNote.tnote = (ListSale[0].TicketNote);
                        HDBtnSavePrint.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("This Record not Exist in DataBase!");
                        TextBoxUpdateTicketNo.Text = "";
                    }
                }
               

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error In Loading Form");
            }
        
        }

        private void BtnGetDataForUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            ClearAll();
            TextBoxUpdateTicketNo.Visible = true;
        }

        private void BtnDecreaseQuantity_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                if (tabControl1.SelectedTab.Name == "tabPage1")
                {
                    if (dgvMenu.SelectedRows.Count == 1)
                    {
                        int rowIndex = dgvMenu.SelectedRows[0].Index;
                        if (Convert.ToDouble(dgvMenu.Rows[rowIndex].Cells[4].Value) == 1)
                        {
                            List<SaleCart> ListCart = new List<SaleCart>();
                            foreach (DataGridViewRow Row in dgvMenu.Rows)
                            {
                                if (!(Row.Index == rowIndex))
                                {
                                    SaleCart obj = new SaleCart();
                                    obj.ItemId = Convert.ToInt32(Row.Cells[0].Value);
                                    obj.ItemName = Row.Cells[1].Value.ToString();
                                    obj.price = Convert.ToDouble(Row.Cells[2].Value);
                                    obj.discount = Convert.ToDouble(Row.Cells[3].Value);
                                    obj.quantity = Convert.ToDouble(Row.Cells[4].Value);
                                    obj.Total = Convert.ToDouble(Row.Cells[5].Value);
                                    obj.TicketNo = Row.Cells[6].Value.ToString();
                                    obj.RecordID = Convert.ToInt32(Row.Cells[7].Value);
                                    obj.Aed_Vat= Convert.ToDouble(Row.Cells[8].Value);
                                    obj.Available_quantity= Convert.ToDouble(Row.Cells[12].Value);
                                    ListCart.Add(obj);

                                }
                                else
                                {
                                    objPOSService.Delete_SaleItemFromSaleDetail(Convert.ToInt32(Row.Cells[7].Value));
                                }
                            }


                            dgvMenu.DataSource = ListCart;

                        }
                        else
                        {
                            dgvMenu.Rows[rowIndex].Cells[4].Value = (Convert.ToDouble(dgvMenu.Rows[rowIndex].Cells[4].Value) - 1).ToString();
                            dgvMenu.Rows[rowIndex].Cells[12].Value = (Convert.ToDouble(dgvMenu.Rows[rowIndex].Cells[12].Value) + 1).ToString();
                        }
                        CalculateTotalForItem();
                        CalculteTotal();
                    }
                    else
                    {
                        MessageBox.Show("please Select Only One Row To Perform Any Operation ");
                    }
                }
                else if (tabControl1.SelectedTab.Name == "tabPage2")
                {
                    if (TAdgvMenu.SelectedRows.Count == 1)
                    {
                        int rowIndex = TAdgvMenu.SelectedRows[0].Index;
                        if (Convert.ToDouble(TAdgvMenu.Rows[rowIndex].Cells[4].Value) == 1)
                        {
                            List<SaleCart> ListCart = new List<SaleCart>();
                            foreach (DataGridViewRow Row in TAdgvMenu.Rows)
                            {
                                if (!(Row.Index == rowIndex))
                                {
                                    SaleCart obj = new SaleCart();
                                    obj.ItemId = Convert.ToInt32(Row.Cells[0].Value);
                                    obj.ItemName = Row.Cells[1].Value.ToString();
                                    obj.price = Convert.ToDouble(Row.Cells[2].Value);
                                    obj.discount = Convert.ToDouble(Row.Cells[3].Value);
                                    obj.quantity = Convert.ToDouble(Row.Cells[4].Value);
                                    obj.Total = Convert.ToDouble(Row.Cells[5].Value);
                                    obj.TicketNo = Row.Cells[6].Value.ToString();
                                    obj.RecordID = Convert.ToInt32(Row.Cells[7].Value);
                                    obj.Aed_Vat = Convert.ToDouble(Row.Cells[8].Value);
                                    obj.Available_quantity = Convert.ToDouble(Row.Cells[12].Value);
                                    ListCart.Add(obj);

                                }
                                else
                                {
                                    objPOSService.Delete_SaleItemFromSaleDetail(Convert.ToInt32(Row.Cells[7].Value));

                                }
                            }


                            TAdgvMenu.DataSource = ListCart;


                        }
                        else
                        {
                            TAdgvMenu.Rows[rowIndex].Cells[4].Value = (Convert.ToDouble(TAdgvMenu.Rows[rowIndex].Cells[4].Value) - 1).ToString();
                            TAdgvMenu.Rows[rowIndex].Cells[12].Value = (Convert.ToDouble(TAdgvMenu.Rows[rowIndex].Cells[12].Value) + 1).ToString();
                        }
                        CalculateTotalForItem();
                        CalculteTotal();
                    }
                    else
                    {
                        MessageBox.Show("please Select Only One Row To Perform Any Operation ");
                    }
                }
                else if (tabControl1.SelectedTab.Name == "tabPage3")
                {
                    if (HDdgvMenu.SelectedRows.Count == 1)
                    {
                        int rowIndex = HDdgvMenu.SelectedRows[0].Index;
                        if (Convert.ToDouble(HDdgvMenu.Rows[rowIndex].Cells[4].Value) == 1)
                        {
                            List<SaleCart> ListCart = new List<SaleCart>();
                            foreach (DataGridViewRow Row in HDdgvMenu.Rows)
                            {
                                if (!(Row.Index == rowIndex))
                                {
                                    SaleCart obj = new SaleCart();
                                    obj.ItemId = Convert.ToInt32(Row.Cells[0].Value);
                                    obj.ItemName = Row.Cells[1].Value.ToString();
                                    obj.price = Convert.ToDouble(Row.Cells[2].Value);
                                    obj.discount = Convert.ToDouble(Row.Cells[3].Value);
                                    obj.quantity = Convert.ToDouble(Row.Cells[4].Value);
                                    obj.Total = Convert.ToDouble(Row.Cells[5].Value);
                                    obj.TicketNo = Row.Cells[6].Value.ToString();
                                    obj.RecordID = Convert.ToInt32(Row.Cells[7].Value);
                                    obj.Aed_Vat = Convert.ToDouble(Row.Cells[8].Value);
                                    obj.Available_quantity = Convert.ToDouble(Row.Cells[12].Value);
                                    ListCart.Add(obj);

                                }
                                else
                                {
                                    objPOSService.Delete_SaleItemFromSaleDetail(Convert.ToInt32(Row.Cells[7].Value));
                                }
                            }


                            HDdgvMenu.DataSource = ListCart;


                        }
                        else
                        {
                            HDdgvMenu.Rows[rowIndex].Cells[4].Value = (Convert.ToDouble(HDdgvMenu.Rows[rowIndex].Cells[4].Value) - 1).ToString();
                            HDdgvMenu.Rows[rowIndex].Cells[12].Value = (Convert.ToDouble(HDdgvMenu.Rows[rowIndex].Cells[12].Value) + 1).ToString();
                        }
                        CalculateTotalForItem();
                        CalculteTotal();
                    }
                    else
                    {
                        MessageBox.Show("please Select Only One Row To Perform Any Operation ");
                    }
                }
                else
                {

                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error In Decriment Quantity");
            }
        }

        private void TakeAwayBtnUpdatePrint_MouseClick(object sender, MouseEventArgs e)
        {
            BtnUpdatePrint_MouseClick(sender, e);
        }

        private void TakeAwayBtnIncreaseQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            BtnIncreaseQuantity_MouseClick(sender, e);
        }

        private void TakeAwayBtnDecreaseQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            BtnDecreaseQuantity_MouseClick(sender, e);
        }

        private void TakeAwayBtnChangeRate_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (TAdgvMenu.Rows.Count > 0)
                {
                    TATxtFeildChangeRate.Visible = true;
                }
                else
                    MessageBox.Show("Frist Add MenuItems");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void TakeAwayBtnIGetDataForUpdate_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void TakeAwayTextBoxChangeRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (TAdgvMenu.SelectedRows.Count == 1 && TATxtFeildChangeRate.Text.Trim() != "")
                    {
                        int rowIndex = TAdgvMenu.SelectedRows[0].Index;
                        TAdgvMenu.Rows[rowIndex].Cells[2].Value = Convert.ToDouble(TATxtFeildChangeRate.Text);
                        CalculateTotalForItem();
                        CalculteTotal();
                        TATxtFeildChangeRate.Text = "";
                    }
                    else if (TATxtFeildChangeRate.Text.Trim() == "")
                    {
                        MessageBox.Show("Enter Price is Zero");
                    }
                    else
                    {
                        MessageBox.Show("please Select Complete oOne Row To Perform Any Operation ");
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Error In Changing Price");
                }
                TxtFeildChangeRate.Visible = false;
            }
        }

       

        private void tabControl1_Selected(object sender, TabControlEventArgs e)  // Allocate ticket no on changing the tab
        {
            if (tabControl1.SelectedTab.Name == "tabPage1")
            {
                ClearAll();
                ticket =  (objPOSService.GetAllSalesItems().Count + 1).ToString();
                lblTicketNo.Text = ticket;
             
            }
            else if (tabControl1.SelectedTab.Name == "tabPage2")
            {
                ClearAll();
                ticket = (objPOSService.GetAllSalesItems().Count + 1).ToString();
                TAlblTicketNo.Text = ticket;
                TATxtFeildChangeRate.Visible = false;
                TATextBoxUpdateTicketNo.Visible = false;
                showCatogeryFlowLayout();

            }
            else if (tabControl1.SelectedTab.Name == "tabPage3")
            {
                ClearAll();
                ticket =  (objPOSService.GetAllSalesItems().Count + 1).ToString();
                HDlblTicketNo.Text = ticket;
                HDTxtFeildChangeRate.Visible = false;
              
              
                showCatogeryFlowLayout();
            }
            else
            {
                dgvExpressBilling.DataSource = objPOSService.Get_PendingOrderList(1, "Home_Delivery").ToList();
                dgvExpressBilling.Columns[0].Visible = false;
                dgvExpressBilling.Columns[2].Visible = false;
                dgvExpressBilling.Columns[4].Visible = false;
                dgvExpressBilling.Columns[6].Visible = false;
                dgvExpressBilling.Columns[7].Visible = false;
                dgvExpressBilling.Columns[10].Visible = false;
                dgvExpressBilling.Columns[11].Visible = false;
                dgvExpressBilling.Columns[13].Visible = false;
                dgvExpressBilling.Columns[14].Visible = false;
                dgvExpressBilling.Columns[15].Visible = false;
                dgvExpressBilling.Columns[16].Visible = false;
                dgvExpressBilling.Columns[17].Visible = false;

            }
        }

       
        private void TABtnSavePrint_MouseClick(object sender, MouseEventArgs e)
        {
            BtnSavePrint_MouseClick(sender, e);
        }

        private void HDBtnSavePrint_MouseClick(object sender, MouseEventArgs e)
        {
            BtnSavePrint_MouseClick(sender, e);
        }

        private void HDBtnIncreaseQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            BtnIncreaseQuantity_MouseClick(sender, e);
        }

        private void HDBtnDecreaseQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            BtnDecreaseQuantity_MouseClick(sender, e);
        }

        private void HDBtnChangeRate_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (HDdgvMenu.Rows.Count > 0)
                {
                    HDTxtFeildChangeRate.Visible = true;
                }
                else
                    MessageBox.Show("Frist Add MenuItems");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void HDTxtFeildChangeRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (HDdgvMenu.SelectedRows.Count == 1 && HDTxtFeildChangeRate.Text.Trim() != "")
                    {
                        int rowIndex = HDdgvMenu.SelectedRows[0].Index;
                        HDdgvMenu.Rows[rowIndex].Cells[2].Value = Convert.ToDouble( HDTxtFeildChangeRate.Text);
                        CalculateTotalForItem();
                        CalculteTotal();
                        HDTxtFeildChangeRate.Text = "";
                    }
                    else if (HDTxtFeildChangeRate.Text.Trim() == "")
                    {
                        MessageBox.Show("Enter Price is Zero");
                    }
                    else
                    {
                        MessageBox.Show("please Select Complete oOne Row To Perform Any Operation ");
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Error In Changing Price");
                }
                HDTxtFeildChangeRate.Visible = false;
            }
        }

        private void HDBtnGetDataForUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void HDTextBoxUpdateTicketNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    HDTextBoxUpdateTicketNo.Visible = false;
                    buttonHDSave.Enabled = false;
                    HDBtnUpdatePrint.Enabled = true;
                    LoadDataForUpdatation();

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Cannot Find the entered Ticket in records");
                    ClearAll();
                }

            }
        }

        private void HDBtnUpdatePrint_MouseClick(object sender, MouseEventArgs e)
        {
            BtnUpdatePrint_MouseClick(sender, e);
        }

        private void EPTextBox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void EBBtnReceiveClear_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dgvExpressBilling.SelectedRows.Count == 1)
                {
                    // int rowIndex = dgvMenu.SelectedRows[0].Index;
                    //  dgvMenu.Rows[rowIndex].Cells[4].Value = (Convert.ToInt32(dgvMenu.Rows[rowIndex].Cells[4].Value) + 1).ToString();
                    int rowIndex = dgvExpressBilling.SelectedRows[0].Index;
                    if (MessageBox.Show("Are you sure to clear the selected pending bill?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow Row in dgvExpressBilling.Rows)
                        {
                            if ((Row.Index == rowIndex))
                            {
                                Sale objSale = new Sale();
                                objSale.Sale_Id = Convert.ToInt32(Row.Cells[0].Value);
                                objSale.TicketNo = Row.Cells[1].Value.ToString();
                                objSale.TableName = "";
                                objSale.CustomerName = Row.Cells[3].Value.ToString();
                                objSale.OrderType = "Home_Delivery";
                                objSale.Balance = Convert.ToDouble(Row.Cells[5].Value);
                                objSale.TicketNote = Row.Cells[6].Value.ToString();
                                objSale.IsDeleted = 0;
                                objSale.PhoneNumber = Row.Cells[8].Value.ToString();
                                objSale.DeliveryAddress = Row.Cells[9].Value.ToString();
                                objSale.IsBillPending = 0;
                                objSale.ReceivedAmount = Convert.ToDouble(Row.Cells[5].Value);
                                objSale.RemainingBalance = 0;
                                objSale.cashier_id = Login.CashierId;
                                List<UserTable> asd = new List<UserTable>();
                                asd = objCashierService.Get_SelectedCashiername1(Login.CashierId);
                                objSale.Cahier_Name = asd[0].FullName;
                                objSale.IsRefund = 0;
                                objPOSService.SaveSale(objSale, 1);
                                dgvExpressBilling.DataSource = objPOSService.Get_PendingOrderList(1, "Home_Delivery").ToList();
                                dgvExpressBilling.Columns[0].Visible = false;
                                dgvExpressBilling.Columns[2].Visible = false;
                                dgvExpressBilling.Columns[4].Visible = false;
                                dgvExpressBilling.Columns[7].Visible = false;
                                dgvExpressBilling.Columns[10].Visible = false;
                            }


                        }


                    }
                    
                }
                else
                {
                    MessageBox.Show("please Select Only One Row To Perform Any Operation ");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error In Loading Form");
            }
           
        }

        private void Back_MouseClick(object sender, MouseEventArgs e)
        {
            Cashier.Show();
            this.Close();
        }

    

        private void refundlbl_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dgvExpressBilling.SelectedRows.Count == 1)
                {
                    
                    int rowIndex = dgvExpressBilling.SelectedRows[0].Index;
                    if (MessageBox.Show("Are you sure to Refund the selected pending bill?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow Row in dgvExpressBilling.Rows)
                        {
                            if ((Row.Index == rowIndex))
                            {
                                Sale objSale = new Sale();
                                objSale.Sale_Id = Convert.ToInt32(Row.Cells[0].Value);
                                objSale.TicketNo = Row.Cells[1].Value.ToString();
                                objSale.TableName = null;
                                objSale.CustomerName = Row.Cells[3].Value.ToString();
                                objSale.OrderType = "Home_Delivery";
                                objSale.Balance = Convert.ToDouble(Row.Cells[5].Value);
                                objSale.TicketNote = Row.Cells[6].Value.ToString();
                                objSale.IsDeleted = 1;
                                objSale.PhoneNumber = Row.Cells[8].Value.ToString();
                                objSale.DeliveryAddress = Row.Cells[9].Value.ToString();
                                objSale.IsBillPending = 0;
                                objSale.IsRefund = 1;
                                objSale.cashier_id = Login.CashierId;
                                List<UserTable> asd = new List<UserTable>();
                                asd = objCashierService.Get_SelectedCashiername1(Login.CashierId);
                                objSale.Cahier_Name = asd[0].FullName;
                                objPOSService.SaveSale(objSale, 1);
                                dgvExpressBilling.DataSource = objPOSService.Get_PendingOrderList(1, "Home_Delivery").ToList();
                                //dgvExpressBilling.Columns[0].Visible = false;
                                //dgvExpressBilling.Columns[2].Visible = false;
                                //dgvExpressBilling.Columns[4].Visible = false;
                                //dgvExpressBilling.Columns[7].Visible = false;
                                //dgvExpressBilling.Columns[10].Visible = false;
                            }

                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("please Select Only One Row To Perform Any Operation ");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error In Loading Form");
            }
            
            
        }

        private void refundimg_MouseClick(object sender, MouseEventArgs e)
        {
            refundlbl_MouseClick(sender, e);

        }

        private void refundPanel_MouseClick(object sender, MouseEventArgs e)
        {
            refundlbl_MouseClick(sender, e);
        }

        private void EBBtnReceiveClearImg_MouseClick(object sender, MouseEventArgs e)
        {
            EBBtnReceiveClear_MouseClick(sender, e);
        }

        private void EBBtnReceiveClearPanel_MouseClick(object sender, MouseEventArgs e)
        {
            EBBtnReceiveClear_MouseClick(sender, e);
        }


        private void DIbarocdeitemname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (objMenuItemsService.Get_barcodeOrItemName(DIbarocdeitemname.Text).Count > 0)
                    {
                        List<menuItem> l2 = new List<menuItem>();
                        l2 = objMenuItemsService.Get_barcodeOrItemName(DIbarocdeitemname.Text.Trim());
                        ShowMenuItemOnDGV(l2[0].id);
                        DIbarocdeitemname.Text = "";
                        
                    }
                    else
                    {
                        MessageBox.Show("No Barcode or Item Name Match!");
                        DIbarocdeitemname.Text = "";
                       
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Error In Loading item");
                }

            }
        }

        private void TABarcodeItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (objMenuItemsService.Get_barcodeOrItemName(TABarcodeItemName.Text).Count > 0)
                    {
                        List<menuItem> l2 = new List<menuItem>();
                        l2 = objMenuItemsService.Get_barcodeOrItemName(TABarcodeItemName.Text);
                        ShowMenuItemOnDGV(l2[0].id);
                        TABarcodeItemName.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("No Barcode or Item Name Match!");
                        TABarcodeItemName.Text = "";

                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Error In Loading item");
                }

            }
        }


        private void HDBarcodeItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (objMenuItemsService.Get_barcodeOrItemName(HDBarcodeItemName.Text).Count > 0)
                    {
                        List<menuItem> l2 = new List<menuItem>();
                        l2 = objMenuItemsService.Get_barcodeOrItemName(HDBarcodeItemName.Text);
                        ShowMenuItemOnDGV(l2[0].id);
                        HDBarcodeItemName.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("No Barcode or Item Name Match!");
                        HDBarcodeItemName.Text = "";

                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Error In Loading item");
                }

            }
        }

        private void HDBtnTicketNote_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (HDdgvMenu.Rows.Count > 0)
                {
                    TicketNote obj = new TicketNote();
                    obj.ShowDialog();
                }
                else
                    MessageBox.Show("Frist Add MenuItems");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

       

        private void TABtnTicketNote_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (TAdgvMenu.Rows.Count > 0)
                {
                    TicketNote obj = new TicketNote();
                    obj.ShowDialog();
                }
                else
                    MessageBox.Show("Frist Add MenuItems");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

       

        private void DIOpenTicketBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ClearAll();
            TextBoxUpdateTicketNo.Visible = true;
        }

        private void TAOpenTicket_MouseClick(object sender, MouseEventArgs e)
        {
            ClearAll();
            TATextBoxUpdateTicketNo.Visible = true;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            ClearAll();
        }

        private void TANewTicketBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ClearAll();
        }

        private void HDNewTicketBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ClearAll();
        }

        private void HDOpenTicket_MouseClick(object sender, MouseEventArgs e)
        {
            ClearAll();
            HDTextBoxUpdateTicketNo.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnPendingBills_MouseClick(object sender, MouseEventArgs e)
        {
            PendingBills obj = new PendingBills();
            obj.ShowDialog();
            TextBoxUpdateTicketNo.Text = PendingBills.tn;
            if(PendingBills.CheckOndine==1)
            {
                TextBoxTotalPersons.Enabled = true;
                BtnUpdatePrint.Enabled = true;
                LoadDataForUpdatation();
            }
            
            showCatogeryFlowLayout();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       

        private void TATextBoxReceivedAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TATextBoxReceivedAmount.Text = TATextBoxReceivedAmount.Text.TrimStart('0');
                if (TATextBoxReceivedAmount.Text != "")
                {
                    double a = 0;
                    double b = 0;
                    double.TryParse(TATextBoxReceivedAmount.Text, out a);
                    double.TryParse(TAlblBalance.Text, out b);
                  


                    double bal = (a-b);
                    TATextBoxBalance.Text = (bal).ToString();
                }
                else
                {
                    TATextBoxBalance.Clear();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = Convert.ToString(DateTime.Now);
        }

        private void buttonTASave_MouseClick(object sender, MouseEventArgs e)
        {
            NoPrint = 1;
            BtnSavePrint_MouseClick( sender,  e);
        }

        private void buttonTAUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            NoPrint = 1;
            BtnUpdatePrint_MouseClick(sender, e);
        }

        private void buttonTAPrint_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int count = objPOSService.Get_SelectedSale(TATextBoxUpdateTicketNo.Text, "Take_Away").Count;
                if (TATextBoxUpdateTicketNo.Text.Trim() !=""  )
                {
                    if(count > 0)
                    {
                        List<Sale> objSale = new List<Sale>();
                        objSale = objPOSService.Get_SelectedSale(TATextBoxUpdateTicketNo.Text, "Take_Away");
                        printKitchenTicket(objSale[0].TicketNo);
                        printDineTicket(objSale[0].TicketNo);
                       
                    }
                    else
                    {
                        MessageBox.Show("This Bill doesnot Exist in Database");
                        ClearAll();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Please first Fetch Data to Print Specific Bill.");
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            
            
            
        }

        private void buttonHDSave_MouseClick(object sender, MouseEventArgs e)
        {
            NoPrint = 1;
            BtnSavePrint_MouseClick(sender, e);
        }

        private void buttonHDUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            NoPrint = 1;
            BtnUpdatePrint_MouseClick(sender, e);
        }

        private void buttonHDPrint_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int count = objPOSService.Get_SelectedSale(HDTextBoxUpdateTicketNo.Text, "Home_Delivery").Count;
                if (HDTextBoxUpdateTicketNo.Text.Trim() != "")
                {
                    if (count > 0)
                    {
                        List<Sale> objSale = new List<Sale>();
                        objSale = objPOSService.Get_SelectedSale(HDTextBoxUpdateTicketNo.Text, "Home_Delivery");
                        printKitchenTicket(ticket);
                        printDineTicket(objSale[0].TicketNo);

      

                    }
                    else
                    {
                        MessageBox.Show("This Bill doesnot Exist in Database");
                        ClearAll();
                    }

                }
                else
                {
                    MessageBox.Show("Please first Fetch Data to Print Specific Bill.");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        private void labelEBPRint_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dgvExpressBilling.SelectedRows.Count == 1)
                {

                    int rowIndex = dgvExpressBilling.SelectedRows[0].Index;
                   
                        foreach (DataGridViewRow Row in dgvExpressBilling.Rows)
                        {
                            if ((Row.Index == rowIndex))
                            {
                            
                                     printDineTicket(Row.Cells[1].Value.ToString());
                             }

                        }
                    

               }
                else
                {
                    MessageBox.Show("please Select Only One Row To Perform Any Operation ");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error In Loading Form");
            }
        }

        private void TAlblBalance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TATextBoxReceivedAmount.Text != "")
                {
                    double a = 0;
                    double.TryParse(TAlblBalance.Text, out a);
                    double bal = (Convert.ToDouble(TATextBoxReceivedAmount.Text) - a);
                    TATextBoxBalance.Text = (bal).ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        private void TATextBoxUpdateTicketNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    TABtnUpdatePrint.Enabled = true;
                    TABtnSavePrint.Enabled = false;
                    TATextBoxUpdateTicketNo.Visible = false; ;
                    buttonTASave.Enabled = false;
                    
                    LoadDataForUpdatation();
                    showCatogeryFlowLayout();

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Cannot Find the entered Ticket in records");
                    ClearAll();
                }

            }
        }

        private void pictureBoxEBPRint_MouseClick(object sender, MouseEventArgs e)
        {
            labelEBPRint_MouseClick(sender, e);
        }

        private void PanelEBPRint_MouseClick(object sender, MouseEventArgs e)
        {
            labelEBPRint_MouseClick(sender, e);
        }

        private void FlowLayoutMenuItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBoxTotalPersons_KeyPress(object sender, KeyPressEventArgs e)
        {
            LblTableName.Text = "";

            if (  (!char.IsNumber(e.KeyChar) ) && (!char.IsControl(e.KeyChar)) )
            {
                e.Handled = true;
            }
        }

        private void TextBoxTotalPersons_TextChanged(object sender, EventArgs e)
        {
            
            TextBoxTotalPersons.Text = TextBoxTotalPersons.Text.TrimStart('0');
        }

        private void TATextBoxReceivedAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TATxtFeildChangeRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxtFeildChangeRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void HDTxtFeildChangeRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void HDTxtFeildChangeRate_TextChanged(object sender, EventArgs e)
        {
            HDTxtFeildChangeRate.Text = HDTxtFeildChangeRate.Text.TrimStart('0');
        }

        private void HDTextBoxUpdateTicketNo_TextChanged(object sender, EventArgs e)
        {
            HDTextBoxUpdateTicketNo.Text = HDTextBoxUpdateTicketNo.Text.TrimStart('0');
        }

        private void TATxtFeildChangeRate_TextChanged(object sender, EventArgs e)
        {
            TATxtFeildChangeRate.Text = TATxtFeildChangeRate.Text.TrimStart('0');
        }

        private void TATextBoxUpdateTicketNo_TextChanged(object sender, EventArgs e)
        {
            TATextBoxUpdateTicketNo.Text = TATextBoxUpdateTicketNo.Text.TrimStart('0');
        }

        private void TxtFeildChangeRate_TextChanged(object sender, EventArgs e)
        {
            TxtFeildChangeRate.Text = TxtFeildChangeRate.Text.TrimStart('0');
        }

        private void TextBoxUpdateTicketNo_TextChanged(object sender, EventArgs e)
        {
            TextBoxUpdateTicketNo.Text = TextBoxUpdateTicketNo.Text.TrimStart('0');
        }

        private void TextBoxUpdateTicketNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TATextBoxUpdateTicketNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void HDTextBoxUpdateTicketNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void EPTextBox_TextChanged(object sender, EventArgs e)
        {
           
            {
                if(EPTextBox.Text.Trim()!="")
                {
                    try
                    {
                        dgvExpressBilling.DataSource = null;
                        dgvExpressBilling.Rows.Clear();
                        dgvExpressBilling.DataSource = objPOSService.Get_PendingOrderSingle(EPTextBox.Text);
                        dgvExpressBilling.Columns[0].Visible = false;
                        dgvExpressBilling.Columns[2].Visible = false;
                        dgvExpressBilling.Columns[4].Visible = false;
                        dgvExpressBilling.Columns[6].Visible = false;
                        dgvExpressBilling.Columns[7].Visible = false;
                        dgvExpressBilling.Columns[10].Visible = false;
                        dgvExpressBilling.Columns[11].Visible = false;
                        dgvExpressBilling.Columns[13].Visible = false;
                        dgvExpressBilling.Columns[14].Visible = false;
                        dgvExpressBilling.Columns[15].Visible = false;
                        dgvExpressBilling.Columns[16].Visible = false;
                        dgvExpressBilling.Columns[17].Visible = false;
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message, "Error In Changing Price");
                    }
                }
                else
                {
                    dgvExpressBilling.DataSource = objPOSService.Get_PendingOrderList(1, "Home_Delivery").ToList();
                    dgvExpressBilling.Columns[0].Visible = false;
                    dgvExpressBilling.Columns[2].Visible = false;
                    dgvExpressBilling.Columns[4].Visible = false;
                    dgvExpressBilling.Columns[6].Visible = false;
                    dgvExpressBilling.Columns[7].Visible = false;
                    dgvExpressBilling.Columns[10].Visible = false;
                    dgvExpressBilling.Columns[11].Visible = false;
                    dgvExpressBilling.Columns[13].Visible = false;
                    dgvExpressBilling.Columns[14].Visible = false;
                    dgvExpressBilling.Columns[15].Visible = false;
                    dgvExpressBilling.Columns[16].Visible = false;
                    dgvExpressBilling.Columns[17].Visible = false;
                }
                

            }
        }
        public void printKitchenTicket(string name)
        {

            CrystalReportKitchenReceipt ob = new CrystalReportKitchenReceipt();
            ByPass(ob);
            PrinterSettings printerName = new PrinterSettings();
            string defaultPrinter;
            defaultPrinter = printerName.PrinterName;
            ob.PrintOptions.PrinterName = defaultPrinter;


            ob.SetParameterValue("ticketno", name);
            ob.SetParameterValue("billno", name);

            ob.PrintToPrinter(1, false, 0, 0);
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


        private static void ByPass(CrystalReportKitchenReceipt ob)
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

        private void TAFlowLayoutPanelCatogery_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            Cashier.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
} 
    
