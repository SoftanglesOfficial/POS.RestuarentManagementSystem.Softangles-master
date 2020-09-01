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
    public partial class Stock : Form
    {
        private Form Admin;
        int Cat_Id;  
        int IdforUpdate;
        public Stock(Form Admin)
        {
            InitializeComponent();
            this.Admin = Admin;
            Admin.Hide();
        }

        // load at form load
        private void Stock_Load(object sender, EventArgs e)
        {
            comboBoxCategory.DataSource = GetAllMenuCatogery();
            comboBoxCategory.ValueMember = "id";
            comboBoxCategory.DisplayMember = "name";
            comboBoxCategory.SelectedIndex = 0;


            LoadAllTables();  // load datagridview data in tables

        }

        public List<menuCategory> GetAllMenuCatogery()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuCategories.ToList();
            }
        }
        public List<menuCategory> GetSelectedMenuCatogery(string s)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuCategories.Where(a=>a.name==s).ToList();
            }
        }
        public List<menuItem> GetAllMenuItems()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuItems.ToList();
            }
        }

        public List<menuItem> SearchSelectedMenuItems(int s)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuItems.Where(t => t.cat_id == s ).ToList();
            }
        }
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.Text != null)
            {
                comboBoxMenuItems.DataSource = null;
                List<menuCategory> L1 = new List<menuCategory>();
                L1 = GetSelectedMenuCatogery(comboBoxCategory.Text);
                if (L1.Count>0)
                {
                    Cat_Id = L1[0].id;
                    // Cat_Id = Convert.ToInt32(comboBoxCategory.SelectedValue.ToString());
                    comboBoxMenuItems.DataSource = SearchSelectedMenuItems(Cat_Id);
                    comboBoxMenuItems.ValueMember = "id";
                    comboBoxMenuItems.DisplayMember = "itemName";
                }
               
            }
            
        }

        private void buttonSave_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (comboBoxMenuItems.Text.Trim() != "" && textBoxAvailableStock.Text.Trim() != "")
                {
                      if (buttonSave.Text == "Save")
                      {
                        Stock_Tbl obj = new Stock_Tbl();
                        obj.CategoryName = comboBoxCategory.Text;
                        obj.ItemName = comboBoxMenuItems.Text;
                        obj.Date = dateTimePickerStock.Value;
                        obj.Quantity = Convert.ToInt32(textBoxAvailableStock.Text);

                        using (RMSDBEntities db = new RMSDBEntities())
                        {
                            db.Stock_Tbl.Add(obj);
                            db.SaveChanges();
                            MessageBox.Show("Data Added Seccessfully.");
                            clearStock();
                            LoadAllTables();
                        }

                      }
                      else if (buttonSave.Text == "Update")
                      {
                        using (RMSDBEntities db = new RMSDBEntities())
                        {
                            Stock_Tbl RowinDb = db.Stock_Tbl.Where(d => d.Id == IdforUpdate).SingleOrDefault();

                            RowinDb.CategoryName = comboBoxCategory.Text;
                            RowinDb.ItemName = comboBoxMenuItems.Text;
                            RowinDb.Date = dateTimePickerStock.Value;
                            RowinDb.Quantity = Convert.ToInt32(textBoxAvailableStock.Text);
                            db.SaveChanges();
                            MessageBox.Show("Data Updated Seccessfully.");
                            clearStock();
                            LoadAllTables();
                        }
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

        private void clearStock()
        {
            textBoxAvailableStock.Clear();
            dateTimePickerStock.Value = DateTime.Now;
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    IdforUpdate = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[2].Value);
                    
                    comboBoxCategory.SelectedIndex = comboBoxCategory.FindString(dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());
                    comboBoxMenuItems.SelectedIndex = comboBoxMenuItems.FindString(dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString());
                    dateTimePickerStock.Value= DateTime.Parse(dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString());
                    textBoxAvailableStock.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();

                    buttonSave.Text = "Update";
                }
                else if (e.ColumnIndex == 1)
                {
                    DeleteDialogBox obj = new DeleteDialogBox();
                    obj.ShowDialog();
                    if (DeleteDialogBox.delete == 1)
                    {
                        using (RMSDBEntities db = new RMSDBEntities())
                        {
                            IdforUpdate = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());
                            Stock_Tbl RowinDb = db.Stock_Tbl.Where(d => d.Id == IdforUpdate).SingleOrDefault();
                            if (RowinDb != null)
                            {
                                db.Stock_Tbl.Remove(RowinDb);
                                db.SaveChanges();
                                MessageBox.Show("Deleted Successfully!");
                                LoadAllTables();
                            }
                            
                        }
                        
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }
        public List<Stock_Tbl> GetAllStock( )
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.Stock_Tbl.ToList();
            }
        }
        public void LoadAllTables()
        {
            try
            {
                dataGridView2.DataSource = null;
                if (GetAllStock().Count > 0)
                {
                    dataGridView2.DataSource = GetAllStock();
                    dataGridView2.Columns[2].Visible = false;
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

