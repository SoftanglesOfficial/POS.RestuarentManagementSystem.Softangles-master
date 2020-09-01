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
using Encryption;

namespace WindowsFormsApp2
{
    public partial class SubcriptionForm : Form
    {
        public SubcriptionForm()
        {
            InitializeComponent();
        }
        public List<Subcription_Tbl> Key()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.Subcription_Tbl.ToList();
            }
        }

        public List<Subcription_Tbl> KeyMatch(string n)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.Subcription_Tbl.Where(a=>a.SubcriptionKey==n).ToList();
            }
        }
        public List<Login_Tbl> record( )
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.Login_Tbl.ToList();
            }
        }

        private void buttonActivate_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int match = 0;
                if (textBox1.Text !="")
                {
                    List<Subcription_Tbl> sk = new List<Subcription_Tbl>();
                    sk = Key();
                    for (int i = 0; i < sk.Count; i++)
                    {
                        Encryption.Class1 obj = new Encryption.Class1();
                  
                     
                        if (textBox1.Text.Equals(Encryption.Class1.Decrypt(sk[i].SubcriptionKey, "Softangle@2999")) )
                        {
                            if (Encryption.Class1.Decrypt(sk[i].UserTyoe, "Softangle@2999").Equals("keynotused"))
                            {
                                using (RMSDBEntities db = new RMSDBEntities())
                                {

                                    Login_Tbl obj1 = new Login_Tbl();
                                    obj1.First_Login_Date = DateTime.Now;
                                    obj1.Expiration_Date = DateTime.Now.AddMonths(Convert.ToInt32(Encryption.Class1.Decrypt(sk[i].ForeignId, "Softangle@2999")));
                                    obj1.Last_Login_Date = DateTime.Now;
                                    obj1.IsAuthenticated = 1;

                                    List<Login_Tbl> lt = new List<Login_Tbl>();
                                    lt = record();
                                    if (lt.Count==0)
                                    {
                                        db.Login_Tbl.Add(obj1);
                                        db.SaveChanges();
                                    }
                                    else
                                    {
                                        Login_Tbl RowinDb1 = db.Login_Tbl.SingleOrDefault();
                                        RowinDb1.First_Login_Date = obj1.First_Login_Date;
                                        RowinDb1.Expiration_Date = obj1.Expiration_Date;
                                        RowinDb1.Last_Login_Date = obj1.Last_Login_Date;
                                        RowinDb1.IsAuthenticated = 1;
                                        db.SaveChanges();
                                    }
                                    
                                    // updating key used to change value
                                    Subcription_Tbl ok = new Subcription_Tbl();
                                    ok.SubcriptionKey = Encryption.Class1.Encrypt(textBox1.Text, "Softangle@2999");
                                    

                                    Subcription_Tbl RowinDb = db.Subcription_Tbl.Where(d => d.SubcriptionKey == ok.SubcriptionKey ).SingleOrDefault();
                                    RowinDb.UserTyoe = Encryption.Class1.Encrypt("keyalreadyused", "Softangle@2999");
                                   
                                    db.SaveChanges();
                                    MessageBox.Show("Software Registered Successfully");
                                    match = 1;
                                    textBox1.Clear();
                                   
                                }
                            }
                            else
                            {
                                MessageBox.Show("Subcription Key Already Used.");
                                textBox1.Clear();
                               

                            }
                            
                           
                        }
                        else
                        {
                            if (i==sk.Count-1 && match==0)
                            {
                                MessageBox.Show("Invalid Subcription Key.");
                                textBox1.Clear();
                               
                            }

                        }
                    } // foreloop end
                    
                }
                else
                {
                    MessageBox.Show("Enter Subcription Key.");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message,"Error Message");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
