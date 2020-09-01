using Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DevelopersControl : Form
    {
        private Form Admin;
        string LogoFileName = "";
        public DevelopersControl(Form Admin)
        {
            InitializeComponent();
            this.Admin = Admin;
            Admin.Hide();
        }

        byte[] ConvertImageToBinery(Image img)
        {
            using (var ms = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(img);
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        Image ConvertBinaryToImage(Byte[] obj)
        {
            using (MemoryStream ms = new MemoryStream(obj))
            {
                return Image.FromStream(ms);
            }
        }
        public void clearConfiguration()
        {
            RName.Clear();
            RAddress.Clear();
            RPhoneNumber.Clear();
            pictureBox1.Image = null;
            buttonSave.Text = "Update";
        }
        private void buttonSave_MouseClick(object sender, MouseEventArgs e)
        {
            if (RName.Text.Trim() != "" && RAddress.Text.Trim() != "" && RAddress.Text.Trim() != "" && pictureBox1.Image != null)
            {
                if (buttonSave.Text == "SAVE")
                {
                    using (RMSDBEntities db = new RMSDBEntities())
                    {
                        POS_Tbl obj = new POS_Tbl();
                        obj.Name = RName.Text;
                        obj.PhoneNumber = RPhoneNumber.Text;
                        obj.Address = RAddress.Text;
                        obj.Pic = ConvertImageToBinery(pictureBox1.Image);


                        db.POS_Tbl.Add(obj);
                        db.SaveChanges();
                        MessageBox.Show("POS Data Added Successfully");
                        clearConfiguration();

                    }
                }
                else if (buttonSave.Text == "Update")
                {
                    using (RMSDBEntities db = new RMSDBEntities())
                    {

                        POS_Tbl RowinDb = db.POS_Tbl.Where(d => d.Id == 1).SingleOrDefault();
                        if (RowinDb != null)
                        {
                            RowinDb.Name = RName.Text;

                            RowinDb.PhoneNumber = RPhoneNumber.Text;
                            RowinDb.Address = RAddress.Text;

                            RowinDb.Pic = ConvertImageToBinery(pictureBox1.Image);

                            db.SaveChanges();
                            MessageBox.Show("Data Updated Successfully");
                            clearConfiguration();

                        }
                    }
                }
            }

        }
        private void buttonUploadPicture_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                using (OpenFileDialog obj = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (obj.ShowDialog() == DialogResult.OK)
                    {
                        LogoFileName = obj.FileName;
                        pictureBox1.Image = Image.FromFile(LogoFileName);
                    }
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message, "Exception Error");
            }
        
        }

        private void DevelopersControl_Load(object sender, EventArgs e)
        {
            try
            {
                using (RMSDBEntities db = new RMSDBEntities())
                {
                    var TempObj = db.POS_Tbl.Where(d => d.Id == 1).SingleOrDefault();
                    if (TempObj != null)
                    {
                       
                        RName.Text = TempObj.Name;
                        RPhoneNumber.Text = TempObj.PhoneNumber;
                        RAddress.Text = TempObj.Address;
                        pictureBox1.Image = ConvertBinaryToImage(TempObj.Pic);
                        buttonSave.Text = "Update";

                    }
                    else
                    {
                        MessageBox.Show("Bad Request Try Again latter");


                    }

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error In Loading Data for updation");
            }
        }

        private void Back_MouseClick(object sender, MouseEventArgs e)
        {
            Admin.Show();
            this.Close();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonGenerate_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (textBoxKey.Text.Trim()!="" && textBoxMonth.Text.Trim()!="" )
                {
                    for (int w = 0; w < Convert.ToInt32(textBoxKey.Text); w++)
                    {
                        Random ran = new Random();
                        String random = "";
                        String b = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                int a = ran.Next(b.Length); //string.Lenght gets the size of string
                                random = random + b.ElementAt(a);
                                if (j == 4 && i < 4)
                                {
                                    random = random + "-";
                                }
                            }
                        }
                        if (IsKeyExist(random).Count < 1)
                        {
                            Encryption.Class1 obj = new Encryption.Class1();

                            using (RMSDBEntities db = new RMSDBEntities())
                            {


                                Subcription_Tbl obj1 = new Subcription_Tbl();
                                obj1.SubcriptionKey = Encryption.Class1.Encrypt(random, "Softangle@2999");
                                obj1.UserTyoe = Encryption.Class1.Encrypt("keynotused", "Softangle@2999");
                                obj1.ForeignId = Encryption.Class1.Encrypt(textBoxMonth.Text.Trim(), "Softangle@2999");
                                db.Subcription_Tbl.Add(obj1);
                                db.SaveChanges();
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("key Already Exist.");
                            
                        }
                    }
                    MessageBox.Show("Data saved!");
                    ClearFeilds();


                }
                else
                {
                    MessageBox.Show("Fields are empty.");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message,"Error Message");
            }
        }

        private void ClearFeilds()
        {
            textBoxMonth.Clear();
            textBoxKey.Clear();
        }

        public List<Subcription_Tbl> IsKeyExist(string key)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                string asd = Encryption.Class1.Encrypt(key, "Softangle@2999");
                return db.Subcription_Tbl.Where(t => t.SubcriptionKey == asd ).ToList();
            }
        }

        private void buttonExcel_MouseClick(object sender, MouseEventArgs e)
        {
           
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string path = fd.SelectedPath + "Key.xlsx";
                File.Delete(path);
                FileInfo spreedsheetInfo = new FileInfo(path);
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelPackage pck = new ExcelPackage(spreedsheetInfo);
                var worksheet = pck.Workbook.Worksheets.Add("Serial Keys");
                worksheet.Cells["A1"].Value = "Key";
                worksheet.Cells["B1"].Value = "Duration in Months";
                worksheet.Cells["C1"].Value = "Used";
                worksheet.Cells["A1:C1"].Style.Font.Bold = true;

                //load data to save in excel fields
                List<Subcription_Tbl> keys = new List<Subcription_Tbl>();
                keys = getallkeys();
                foreach (var item in keys)
                {
                    item.SubcriptionKey = Encryption.Class1.Decrypt(item.SubcriptionKey, "Softangle@2999");
                    item.ForeignId = Encryption.Class1.Decrypt(item.ForeignId, "Softangle@2999");
                    item.UserTyoe = Encryption.Class1.Decrypt(item.UserTyoe, "Softangle@2999");
                }

                // populate data

                int currentRow = 2;

                foreach (var item in keys)
                {
                    worksheet.Cells["A" + currentRow.ToString()].Value = item.SubcriptionKey;

                    if (item.UserTyoe=="keynotused")
                    {
                        worksheet.Cells["C" + currentRow.ToString()].Value = 0;
                    }
                    else
                    {
                        worksheet.Cells["C" + currentRow.ToString()].Value = 1;
                    }

                    worksheet.Cells["B" + currentRow.ToString()].Value = item.ForeignId;
                   

                    currentRow++;
                }

                worksheet.View.FreezePanes(2, 1);
                pck.Save();
                MessageBox.Show("Data saved!");


            }
        }
        public List<Subcription_Tbl> getallkeys()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.Subcription_Tbl.ToList();
            }
        }

        private void textBoxKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {
            textBoxKey.Text = textBoxKey.Text.TrimStart('0');
        }

        private void textBoxMonth_TextChanged(object sender, EventArgs e)
        {
            textBoxMonth.Text = textBoxMonth.Text.TrimStart('0');
        }

        private void textBoxMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
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

