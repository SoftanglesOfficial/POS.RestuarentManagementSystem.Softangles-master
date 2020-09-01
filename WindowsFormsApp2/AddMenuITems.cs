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


namespace WindowsFormsApp2
{
    public partial class AddMenuItems : Form
    {
        private Form Admin;
       

        MenuItemsService objMenuItemsService;
        counterService objCounterServicel;
        MenuCatogeryService objMenuCatogeryServicel;

        public static int MenuItemsIdforUpdate = 0;
        public static int ComboBoxSectionIndex = 0;
        public static int ComboBoxCategoryIndex = 0;

        public static string catogeryName = "";
        public static string sectionName ="";
        public String colorHexValMenuItem;

        public string bc="";

        public AddMenuItems(Form Admin)
        {
            try
            {
                InitializeComponent();
                this.Admin = Admin;
                Admin.Hide();
                objMenuCatogeryServicel = new MenuCatogeryService();
                objMenuItemsService = new MenuItemsService();
                objCounterServicel = new counterService();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
           
        }

        private void AddMenuItems_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllTables();
                
               
                ComboBoxCategory.DataSource = objMenuCatogeryServicel.GetAllMenuCatogery();
                ComboBoxCategory.ValueMember = "id";
                ComboBoxCategory.DisplayMember = "name";
                catogeryName = ComboBoxCategory.SelectedText;

                ComboBoxSection.DataSource = objCounterServicel.GetAllCounters();
                ComboBoxSection.ValueMember = "id";
                ComboBoxSection.DisplayMember = "sectionname";
                sectionName = ComboBoxSection.SelectedText;
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error In Loading Form");
            }
        }
        public void LoadAllTables()
        {
            try
            {
                DgvMenuItems.DataSource = null;
                if (objMenuItemsService.GetAllMenuItems().Count>0)
                {
                    DgvMenuItems.DataSource = objMenuItemsService.GetAllMenuItems();
                    DgvMenuItems.Columns[2].Visible = false;
                    DgvMenuItems.Columns[3].Visible = false;
                    DgvMenuItems.Columns[4].ReadOnly = true;
                    DgvMenuItems.Columns[5].ReadOnly = true;
                    DgvMenuItems.Columns[6].Visible = false;
                    DgvMenuItems.Columns[7].ReadOnly = true;
                    DgvMenuItems.Columns[8].ReadOnly = true;
                    DgvMenuItems.Columns[9].ReadOnly = true;

                    for (int j = 0; j < DgvMenuItems.Rows.Count; j++)
                    {
                        DgvMenuItems.Rows[j].Cells[4].Style.BackColor = System.Drawing.ColorTranslator.FromHtml(DgvMenuItems.Rows[j].Cells[4].Value.ToString());
                        DgvMenuItems.Rows[j].Cells[4].Style.ForeColor = System.Drawing.ColorTranslator.FromHtml(DgvMenuItems.Rows[j].Cells[4].Value.ToString());

                    }
                }
               
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

       
        public void ClearAll()
        {
            bc = "";
            DeleteDialogBox.delete = 0;
            TxtItemName.Text = "";
            TxtBarCode.Text = "";
            TxtDiscount.Text = "";
            TxtRate.Text = "";
            TxtColorPickerMenuItem.BackColor = Color.Empty;
            CheckBoxStatus.Checked = false;
            BtnSaveLbl.Text = "Save";
            MenuItemsIdforUpdate = 0;
            colorHexValMenuItem = null;
   
        }
        private void BtnSaveLbl_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (TxtItemName.Text.Trim() != "" && TxtRate.Text.Trim() != "" && ComboBoxCategory.SelectedIndex >= 0 && ComboBoxSection.SelectedIndex >= 0 && colorHexValMenuItem != null)
                {
                    int TempId = 0;
                    try
                    {
                        Int32.TryParse(MenuItemsIdforUpdate.ToString(), out TempId);
                    }
                    catch (Exception) { }
                    if (objMenuItemsService.IsItemNameExist(TxtItemName.Text.Trim(), TempId).Count < 1)
                    {
                        if (BtnSaveLbl.Text == "Save")
                        {


                            if (TxtBarCode.Text.Length != 8)
                            {
                                MessageBox.Show("Please Enter 8 Digit Unique Barcode");
                            }
                            else if (TxtBarCode.Text.Length == 8 && objMenuItemsService.Get_SelectedBarcode(TxtBarCode.Text).Count > 0)
                            {
                                MessageBox.Show("Barcode Already Exist in DataBase");
                            }
                            else if (TxtBarCode.Text.Length == 8 && objMenuItemsService.Get_SelectedBarcode(TxtBarCode.Text).Count == 0)

                            {
                                menuItem obj = new menuItem();
                                obj.itemName = TxtItemName.Text.Trim();
                                obj.Price = Convert.ToDouble(TxtRate.Text.Trim());

                                double a = 0;
                                Double.TryParse(TxtDiscount.Text, out a);
                                obj.discountpercnt = a;
                                if (CheckBoxStatus.Checked == true) obj.status = true; else obj.status = false;
                                obj.cat_id = Convert.ToInt32(ComboBoxCategory.SelectedValue.ToString());
                                obj.section_id = Convert.ToInt32(ComboBoxSection.SelectedValue.ToString());
                                obj.color = colorHexValMenuItem;
                                obj.quantity = Convert.ToDouble(txtQnty.Text);
                                obj.id = 0;
                                obj.barcode = TxtBarCode.Text;
                                obj.Aed_Vat = Convert.ToDouble(textboxAedVat.Text);


                                if (objMenuItemsService.Save_MenuItems_tables(obj))
                                {
                                    MessageBox.Show("Table Added Seccessfully.");
                                    ClearAll();
                                    LoadAllTables();
                                }
                                else
                                {
                                    MessageBox.Show("Table Insertion Filed");
                                }
                            }
                        }



                        else if (BtnSaveLbl.Text == "Update")
                        {

                            menuItem obj = new menuItem();
                            obj.itemName = TxtItemName.Text.Trim();
                            obj.Price = Convert.ToDouble(TxtRate.Text.Trim());
                            double a = 0;
                            Double.TryParse(TxtDiscount.Text, out a);
                            obj.discountpercnt = a;

                            if (CheckBoxStatus.Checked == true) obj.status = true; else obj.status = false;
                            obj.cat_id = Convert.ToInt32(ComboBoxCategory.SelectedValue.ToString());
                            obj.section_id = Convert.ToInt32(ComboBoxSection.SelectedValue.ToString());

                            colorHexValMenuItem = HexConverter(TxtColorPickerMenuItem.BackColor);
                            obj.color = colorHexValMenuItem;
                            obj.id = MenuItemsIdforUpdate;
                            if (objMenuItemsService.Save_MenuItems_tables(obj))
                            {
                                MessageBox.Show("Updated Seccessfully.");
                                ClearAll();
                                LoadAllTables();

                            }
                            else
                            {
                                MessageBox.Show("Table Insertion Filed");
                            }
                        }


                    }
                    else
                    {
                        MessageBox.Show("Item ALready Exist!");
                    }
                }


                else
                {
                    MessageBox.Show("Incomplete Form", "Please Fill Complete Form.!");
                }
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error Message");
            }
        }

        private void BtnColorPickerMenuItem_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (ColorDialogMenuItem.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                {

                    TxtColorPickerMenuItem.BackColor = ColorDialogMenuItem.Color;
                    colorHexValMenuItem = HexConverter(ColorDialogMenuItem.Color);

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error Message");
            }


        }
        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

    
        private void BtnReferedLbl_MouseClick(object sender, MouseEventArgs e)
        {
            ClearAll();
        }

        private void BtnRefereshImg_MouseClick(object sender, MouseEventArgs e)
        {
            BtnReferedLbl_MouseClick(sender, e);
        }

        private void BtnRefereshPanel_MouseClick(object sender, MouseEventArgs e)
        {
            BtnReferedLbl_MouseClick(sender, e);
        }

        private void BtnSaveImg_MouseClick(object sender, MouseEventArgs e)
        {
            BtnSaveLbl_MouseClick(sender,  e);
        }

        private void BtnSavePanel_MouseClick(object sender, MouseEventArgs e)
        {
            BtnSaveLbl_MouseClick(sender, e);
        }

        private void DgvMenuItems_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    
                    MenuItemsIdforUpdate = Convert.ToInt32(DgvMenuItems.Rows[e.RowIndex].Cells[2].Value);
                    TxtItemName.Text = DgvMenuItems.Rows[e.RowIndex].Cells[5].Value.ToString();
                    TxtRate.Text= (DgvMenuItems.Rows[e.RowIndex].Cells[7].Value.ToString());
                    TxtDiscount.Text= (DgvMenuItems.Rows[e.RowIndex].Cells[8].Value.ToString());
                    TxtBarCode.Text= (DgvMenuItems.Rows[e.RowIndex].Cells[11].Value.ToString());
                    if (Convert.ToInt32(DgvMenuItems.Rows[e.RowIndex].Cells[9].Value)==1)
                    {
                        CheckBoxStatus.Checked = true;
                    }
                    else
                    {
                        CheckBoxStatus.Checked = false;
                    }

                    List<menuCategory> L1 = new List<menuCategory>();
                    L1 = objMenuItemsService.Get_CategoryName(Convert.ToInt32(DgvMenuItems.Rows[e.RowIndex].Cells[3].Value));
                    ComboBoxCategory.SelectedIndex = ComboBoxCategory.FindString(L1[0].name);

                    List<section> L2 = new List<section>();
                    L2 = objMenuItemsService.Get_SectionyName(Convert.ToInt32(DgvMenuItems.Rows[e.RowIndex].Cells[6].Value));
                    ComboBoxSection.SelectedIndex = ComboBoxSection.FindString(L2[0].sectionname);

                    TxtColorPickerMenuItem.BackColor = System.Drawing.ColorTranslator.FromHtml(DgvMenuItems.Rows[e.RowIndex].Cells[4].Value.ToString());
                    colorHexValMenuItem = HexConverter(ColorDialogMenuItem.Color);
                    BtnSaveLbl.Text = "Update";
                    brcode.Text= DgvMenuItems.Rows[e.RowIndex].Cells[11].Value.ToString();
                    bc = DgvMenuItems.Rows[e.RowIndex].Cells[11].Value.ToString();
                }
                else if (e.ColumnIndex == 1)
                {
                    DeleteDialogBox obj = new DeleteDialogBox();
                    obj.ShowDialog();
                    if (DeleteDialogBox.delete == 1)
                    {
                        if (objMenuItemsService.Delete_MenuItems_tables(Convert.ToInt32(DgvMenuItems.Rows[e.RowIndex].Cells[2].Value)))
                        {
                            MessageBox.Show("Deleted Successfully.!");
                            LoadAllTables();
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Deleted failed");
                        }
                    }
                        
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        private void Back_MouseClick(object sender, MouseEventArgs e)
        {
            Admin.Show();
            this.Close();
        }
 
        private void TextBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                

            }
        }

        private void PrintBarcode_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                if (objMenuItemsService.Get_SelectedBarcode(bc).Count > 0)
                {
                    List<menuItem> List1 = new List<menuItem>();
                    List1 = objMenuItemsService.Get_SelectedBarcode(bc);

                   
                    Barcodewebform obj = new Barcodewebform(List1[0].itemName, bc);
                    ClearAll();
                    obj.ShowDialog();
                }
                else
                {
                    
                    MessageBox.Show("Click on Edit button from  menu item First");
                }




            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error In printing Barcode");
            }
        }

        private void BtnBarcodeimg_MouseClick(object sender, MouseEventArgs e)
        {
            PrintBarcode_MouseClick_1(sender, e);
        }

        private void PanelBarcodeBTn_MouseClick(object sender, MouseEventArgs e)
        {
            PrintBarcode_MouseClick_1(sender, e);
        }

        private void TxtBarCode_TextChanged(object sender, EventArgs e)
        {
            brcode.Text = TxtBarCode.Text;
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void TxtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.' || TxtRate.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void TxtRate_TextChanged(object sender, EventArgs e)
        {
            TxtRate.Text = TxtRate.Text.TrimStart('0');
        }

        private void TxtDiscount_TextChanged(object sender, EventArgs e)
        {
            TxtDiscount.Text = TxtDiscount.Text.TrimStart('0');
        }

        private void TxtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.' || TxtDiscount.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void TxtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
          

            if ((!char.IsNumber(e.KeyChar) || Convert.ToInt32(TxtBarCode.Text.Length) > 7) && !char.IsControl(e.KeyChar) && (e.KeyChar != 8 || Convert.ToInt32(TxtBarCode.Text.Length)>7))
            {
                e.Handled = true;
            }
           
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            Admin.Show();
            this.Close();
        }
    }
}
