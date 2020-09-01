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

namespace WindowsFormsApp2
{
    public partial class Add_Category : Form
    {
        private Form Admin;
        MenuCatogeryService objMenuCatogeryServicel;
        MenuItemsService objMenuItemService;
        public static int MenuCatogeryIdforUpdate = 0;
        public String colorHexVal;
        public Add_Category(Form Admin)
        {
            try 
            { 
                InitializeComponent();
                this.Admin = Admin;
                Admin.Hide();
                objMenuCatogeryServicel = new MenuCatogeryService();
                objMenuItemService = new MenuItemsService();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

      

        private void Add_Category_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllTables();
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
                dataGridView1.DataSource = objMenuCatogeryServicel.GetAllMenuCatogery();
                dataGridView1.Columns[2].Visible = false;
          

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[4].Style.BackColor = System.Drawing.ColorTranslator.FromHtml(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    dataGridView1.Rows[i].Cells[4].Style.ForeColor = System.Drawing.ColorTranslator.FromHtml(dataGridView1.Rows[i].Cells[4].Value.ToString());
                
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        public void ClearAll()
        {
            DeleteDialogBox.delete = 0;
            txtCategory.Text = "";
            txtColor.BackColor = Color.White;
            btnLblSave.Text = "Save";
            MenuCatogeryIdforUpdate = 0;
            colorHexVal = null;
        }

        private void btnLblSave_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (txtCategory.Text.Trim() != "" && colorHexVal!=null)
                {
                    int TempId = 0;
                    try
                    {
                        Int32.TryParse(MenuCatogeryIdforUpdate.ToString(), out TempId);
                    }
                    catch (Exception) { }
                    if (objMenuCatogeryServicel.IsCatogeryNameExist(txtCategory.Text.Trim(), TempId).Count < 1)
                    {
                        if (btnLblSave.Text == "Save")
                        {
                            menuCategory obj = new menuCategory();
                            obj.name = txtCategory.Text.Trim();
                            obj.color = colorHexVal;
                            obj.id = 0;


                            if (objMenuCatogeryServicel.Save_MenuCatogery_tables(obj))
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
                        else if (btnLblSave.Text == "Update")
                        {
                            menuCategory obj = new menuCategory();
                            obj.name = txtCategory.Text.Trim();

                            colorHexVal = HexConverter(txtColor.BackColor);

                            obj.color = colorHexVal;

                            obj.id = MenuCatogeryIdforUpdate;


                            if (objMenuCatogeryServicel.Save_MenuCatogery_tables(obj))
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
                        else
                        {
                            MessageBox.Show("No Action Found", "Action Discart.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Category Already Exist!");
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

        private void btnSaveImg_MouseClick(object sender, MouseEventArgs e)
        {
            btnLblSave_MouseClick(sender, e);
        }

        private void btnpanelSave_MouseClick(object sender, MouseEventArgs e)
        {
            btnLblSave_MouseClick(sender, e);
        }

        private void btnRefreshImg_MouseClick(object sender, MouseEventArgs e)
        {
            ClearAll();
        }

        private void btnRefreshLbl_MouseClick(object sender, MouseEventArgs e)
        {
            btnRefreshImg_MouseClick( sender, e);
        }

        private void BtnRefreshPanel_MouseClick(object sender, MouseEventArgs e)
        {
            btnRefreshImg_MouseClick(sender, e);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    MenuCatogeryIdforUpdate = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    txtCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    colorHexVal = HexConverter(colorDialog1.Color);
                    txtColor.BackColor = System.Drawing.ColorTranslator.FromHtml(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                    btnLblSave.Text = "Update";
                }
                else if (e.ColumnIndex == 1)
                {
                    List<menuItem> p = new List<menuItem>();
                    int count = objMenuCatogeryServicel.CheckEmptyItem(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value)).Count;
                    if(count==0)
                    {
                        DeleteDialogBox obj = new DeleteDialogBox();
                        obj.ShowDialog();
                        if (DeleteDialogBox.delete == 1)
                        {
                            if (objMenuCatogeryServicel.Delete_MenuCatogery_tables(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value)))
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
                    else
                    {
                        MessageBox.Show("This Catogery contain items which must be deleted first to perform this action.");
                    }
                   
                    
                    
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

       
       
        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

    
        private void Back_MouseClick(object sender, MouseEventArgs e)
        {
            Admin.Show();
            this.Close();
        }

        private void btnColorPicker_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                {

                    txtColor.BackColor = colorDialog1.Color;
                    colorHexVal = HexConverter(colorDialog1.Color);

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

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            Admin.Show();
            this.Close();
        }
    }
}
