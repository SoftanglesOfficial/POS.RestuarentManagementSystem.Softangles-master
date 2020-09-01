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
    public partial class Login : Form
    {
        public static int CashierId = 0;
        UserService objUserService;
        public Login()
        {
            objUserService = new UserService();
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LTextBoxEmail.Focus();
        }

        public List<Login_Tbl> record()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.Login_Tbl.ToList();
            }
        }
        private void LLblLogin_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (LTextBoxEmail.Text.Trim() != "" && LTextBoxPassword.Text.Trim() != "")
                {
                    if (objUserService.GetAunthenticatedUsers(LTextBoxEmail.Text, LTextBoxPassword.Text).Count > 0)
                    {
                        List<Login_Tbl> loginDetail = new List<Login_Tbl>();
                        loginDetail = record();
                        if (loginDetail.Count>0)
                        {
                            if (loginDetail[0].Last_Login_Date < DateTime.Now && DateTime.Now < loginDetail[0].Expiration_Date && loginDetail[0].IsAuthenticated == 1)
                            {
                                using (RMSDBEntities db = new RMSDBEntities())
                                {
                                    Login_Tbl RowinDb = db.Login_Tbl.SingleOrDefault();
                                    RowinDb.Last_Login_Date = DateTime.Now;
                                    db.SaveChanges();
                                }

                               int asdf = Convert.ToInt32((loginDetail[0].Expiration_Date - DateTime.Now).TotalDays);
                                if (asdf < 11)
                                {
                                    MessageBox.Show("You Subcription will expire within "+asdf+ " Days.Please Contact Softangle for uninterrupted use of software");
                                }


                                List<UserTable> singleuserInList = new List<UserTable>();
                                singleuserInList = objUserService.GetSpecificUsers(LTextBoxEmail.Text);
                                if (singleuserInList[0].IsAdmin == 1)
                                {
                                    LTextBoxEmail.Text = "";
                                    LTextBoxPassword.Text = "";
                                    Admin objadmin = new Admin(this);
                                    LTextBoxEmail.Focus();
                                    objadmin.Show();


                                }
                                else
                                {
                                    LTextBoxEmail.Text = "";
                                    LTextBoxPassword.Text = "";
                                    CashierId = singleuserInList[0].UserId;
                                    Cashier objCashier = new Cashier(this);
                                    LTextBoxEmail.Focus();
                                    objCashier.Show();
                                }
                            }
                            else
                            {
                                using (RMSDBEntities db = new RMSDBEntities())
                                {
                                    Login_Tbl RowinDb = db.Login_Tbl.SingleOrDefault();
                                    RowinDb.IsAuthenticated = 0;
                                    db.SaveChanges();
                                }
                                MessageBox.Show("Subcription Expired.");
                                SubcriptionForm obk = new SubcriptionForm();
                                obk.Show();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Subcription Expired.");
                            SubcriptionForm obk = new SubcriptionForm();
                            obk.Show();
                        }
                        
                        
                    }
                    else if (LTextBoxEmail.Text == Variable.Class1.u && LTextBoxPassword.Text == Variable.Class1.p)
                    {
                        try
                        {
                            LTextBoxEmail.Clear();
                            LTextBoxPassword.Clear();
                            DevelopersControl obj = new DevelopersControl(this);
                            obj.Show();
                        }
                        catch (Exception exp)
                        {

                            MessageBox.Show(exp.Message, "Error!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("UserName or Password Incorrect!");
                        LTextBoxEmail.Focus();
                        LTextBoxEmail.Text = "";
                        LTextBoxPassword.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill both Feilds to Login");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error In Loging");
            }
        }

        private void LImgBtnLogin_MouseClick(object sender, MouseEventArgs e)
        {
            LLblLogin_MouseClick(sender, e);
        }

        private void LPanelBtnLogin_MouseClick(object sender, MouseEventArgs e)
        {
            LLblLogin_MouseClick(sender, e);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                About_Developers objUser = new About_Developers();
                objUser.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
