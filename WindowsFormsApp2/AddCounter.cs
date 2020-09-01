using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Data;

namespace WindowsFormsApp2
{
    public partial class AddCounter : Form
    {
        private Form Admin;
        counterService objCounterServicel;
        public static int counterIdforUpdate = 0;
        List<section> section = new List<section>();
        public AddCounter(Form Admin)
        {
            try
            {
                InitializeComponent();
                objCounterServicel = new counterService();
                this.Admin = Admin;
                Admin.Hide();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        private void btnSavelbl_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (txtSection.Text.Trim() != "")
                {

                    int TempId = 0;
                    try
                    {
                        Int32.TryParse(counterIdforUpdate.ToString(), out TempId);
                    }
                    catch (Exception) { }
                    if (objCounterServicel.IsSectionNameExist(txtSection.Text.Trim(), TempId).Count < 1)
                    {
                        if (btnSavelbl.Text == "Save")
                        {
                            section obj = new section();
                            obj.sectionname = txtSection.Text.Trim();
                            obj.id = 0;
                            if (objCounterServicel.SaveCounter(obj))
                            {
                                MessageBox.Show("Added Seccessfully.");
                                LoadAllCounter();
                            }
                            else
                            {
                                MessageBox.Show("Insertion Filed");
                            }
                        }
                        else if (btnSavelbl.Text == "Update")
                        {
                            section obj = new section();
                            obj.sectionname = txtSection.Text.Trim();

                            obj.id = counterIdforUpdate;
                            if (objCounterServicel.SaveCounter(obj))
                            {
                                MessageBox.Show("Updated Seccessfully.");
                                LoadAllCounter();
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
                        MessageBox.Show("Section already Exist");
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

        private void btnSaveimg_MouseClick(object sender, MouseEventArgs e)
        {
            btnSavelbl_MouseClick(sender, e);
        }

        private void btnsave_MouseClick(object sender, MouseEventArgs e)
        {
            btnSavelbl_MouseClick(sender, e);
        }


        private void btnefresh_MouseClick(object sender, MouseEventArgs e)
        {
            ClearAll();
        }

        private void btnRefreshimg_MouseClick(object sender, MouseEventArgs e)
        {
            btnefresh_MouseClick(sender, e);
        }

        private void btnRefreshlbl_MouseClick(object sender, MouseEventArgs e)
        {
            btnefresh_MouseClick(sender, e);
        }

        public void ClearAll()
        {
            DeleteDialogBox.delete = 0;
            btnSavelbl.Text = "Save";
            txtSection.Text = "";
            counterIdforUpdate = 0;
        }
        public void LoadAllCounter()
        {
            try
            {
                DGVCounter.DataSource = objCounterServicel.GetAllCounters();

                DGVCounter.Columns[2].Visible = false;
                DGVCounter.Columns[3].ReadOnly = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        private void AddCounter_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllCounter();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error In Loading Form");
            }
        }

        private void DGVCounter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    counterIdforUpdate = Convert.ToInt32(DGVCounter.Rows[e.RowIndex].Cells[2].Value);
                    txtSection.Text = DGVCounter.Rows[e.RowIndex].Cells[3].Value.ToString();


                    btnSavelbl.Text = "Update";
                }
                else if (e.ColumnIndex == 1)
                {
                    DeleteDialogBox obj = new DeleteDialogBox();
                    obj.ShowDialog();
                    if (DeleteDialogBox.delete == 1)
                    {
                        if (objCounterServicel.DeleteCounter(Convert.ToInt32(DGVCounter.Rows[e.RowIndex].Cells[2].Value)))
                        {
                            MessageBox.Show("Deleted Successfully.!");
                            LoadAllCounter();
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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Back_MouseClick(object sender, MouseEventArgs e)
        {
            Admin.Show();
            this.Close();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            Admin.Show();
            this.Close();
        }
    }
}
