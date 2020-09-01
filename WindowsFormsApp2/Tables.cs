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
    public partial class Form1 : Form
    {
        private Form Admin;

        R_tableService objTblServicel;

        public static int tableIdforUpdate = 0;
        public Form1(Form Admin)
        {
            try
            {
                InitializeComponent();
                this.Admin = Admin;
                Admin.Hide();
                objTblServicel = new R_tableService();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (txttableNumber.Text.Trim() != "" && txttableCapacity.Text.Trim() != "")
                {
                    int TempId = 0;
                    try
                    {
                        Int32.TryParse(tableIdforUpdate.ToString(), out TempId);
                    }
                    catch (Exception) { }
                    if (objTblServicel.IsTableNameExist(txttableNumber.Text.Trim(), TempId).Count < 1)
                    {
                        if (btnSavelbl.Text == "Add")
                        {
                            R_Tables obj = new R_Tables();
                            obj.Name = txttableNumber.Text.Trim();
                            obj.capacity = Convert.ToInt32(txttableCapacity.Text);
                            obj.filled = 0;
                            obj.id = 0;
                            obj.status = chbxTableStatus.Checked ? true : false;

                            if (objTblServicel.Save_R_tables(obj))
                            {
                                MessageBox.Show("Table Added Seccessfully.");
                                LoadAllTables();
                            }
                            else
                            {
                                MessageBox.Show("Table Insertion Filed");
                            }
                        }
                        else if (btnSavelbl.Text == "Update")
                        {
                            R_Tables obj = new R_Tables();
                            obj.Name = txttableNumber.Text.Trim();
                            obj.capacity = Convert.ToInt32(txttableCapacity.Text);
                            obj.id = tableIdforUpdate;
                            obj.status = chbxTableStatus.Checked ? true : false;

                            if (objTblServicel.Save_R_tables(obj))
                            {
                                MessageBox.Show("Updated Seccessfully.");
                                LoadAllTables();
                                ClearAll();
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
                        MessageBox.Show("Table already Exist!");
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
        private void btnSavelbl_MouseClick(object sender, MouseEventArgs e)
        {
            btnSave_MouseClick(sender, e);
        }

        private void btnSaveimg_MouseClick(object sender, MouseEventArgs e)
        {
            btnSave_MouseClick(sender, e);
        }

        public void LoadAllTables()
        {
            try
            {
                DGVtable.DataSource = objTblServicel.Gettables();
                DGVtable.Columns[2].Visible = false;
               
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        public void ClearAll()
        {
            DeleteDialogBox.delete = 0;
            txttableCapacity.Text = "";
            txttableNumber.Text = "";
            btnSavelbl.Text = "Add";
            tableIdforUpdate = 0;
            chbxTableStatus.Checked = false;
        }

        private void DGVtable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    
                    if (Convert.ToInt32(DGVtable.Rows[e.RowIndex].Cells[6].Value) !=0)
                    {
                        MessageBox.Show("Table Currently in Use!");
                    }
                    else
                    {
                        tableIdforUpdate = Convert.ToInt32(DGVtable.Rows[e.RowIndex].Cells[2].Value);
                        txttableNumber.Text = DGVtable.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txttableCapacity.Text = DGVtable.Rows[e.RowIndex].Cells[4].Value.ToString();
                        if (DGVtable.Rows[e.RowIndex].Cells[5].Value.ToString() == "True") chbxTableStatus.Checked = true; else chbxTableStatus.Checked = false;
                        btnSavelbl.Text = "Update";
                    }
                    
                }
                else if (e.ColumnIndex == 1)
                {
                    if (Convert.ToInt32(DGVtable.Rows[e.RowIndex].Cells[6].Value) != 0)
                    {
                        MessageBox.Show("Table Currently in Use!");
                    }
                    else
                    {
                        DeleteDialogBox obj = new DeleteDialogBox();
                        obj.ShowDialog();
                        if (DeleteDialogBox.delete == 1)
                        {
                            if (objTblServicel.Delete_R_tables(Convert.ToInt32(DGVtable.Rows[e.RowIndex].Cells[2].Value)))
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
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        private void btnrefresh_MouseClick(object sender, MouseEventArgs e)
        {
            ClearAll();
        }

        private void ptRefreshImg_MouseClick(object sender, MouseEventArgs e)
        {
            btnrefresh_MouseClick(sender, e);
        }

        private void btnrefreshlbl_MouseClick(object sender, MouseEventArgs e)
        {
            btnrefresh_MouseClick(sender, e);
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

        private void txttableCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttableCapacity_TextChanged(object sender, EventArgs e)
        {
            txttableCapacity.Text = txttableCapacity.Text.TrimStart('0');
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            Admin.Show();
            this.Close();
        }
    }
}
