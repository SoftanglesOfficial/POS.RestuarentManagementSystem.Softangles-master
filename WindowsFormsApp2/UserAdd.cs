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
    public partial class UserAdd : Form
    {
        private Form User;

        UserService objUserService;
        List<UserTable> u = new List<UserTable>();
        public UserAdd(int i,Form User)
        {
            objUserService = new UserService();
            InitializeComponent();
            this.User = User;
            User.Hide();
            if (i == 1)
            {
                UBtnSave.Text = "Update";
                UBtnSave.Enabled = false;
            }
            else
            {
                btnFetchReocrd.Visible = false;
            }
           
        }

        private void UBtnSave_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (UTextBoxFullName.Text.Trim() != "" && UTextBoxUserName.Text.Trim() != "" && UTextBoxPassword.Text.Trim() != "" && UTextBoxConfirmPassword.Text.Trim() != "")
                {
                    int TempId = 0;
                    try
                    {
                        Int32.TryParse(u[0].UserId.ToString(), out TempId);
                    }
                    catch (Exception) { }
                    if (objUserService.IsUsernameExist(UTextBoxUserName.Text, TempId).Count < 1)
                    {
                        if (UBtnSave.Text == "Save")
                        {
                            UserTable obj = new UserTable();
                            obj.FullName = UTextBoxFullName.Text;
                            obj.UserName = UTextBoxUserName.Text;
                            obj.Password = UTextBoxPassword.Text;
                            obj.ConfirmPassword = UTextBoxConfirmPassword.Text;
                            if (UCheckBoxIsAdmin.Checked == true)
                            {
                                obj.IsAdmin = 1;

                            }
                            else
                            {
                                obj.IsAdmin = 0;
                            }


                            if (objUserService.SaveUser(obj, 0))
                            {
                                MessageBox.Show("User Added Seccessfully.");
                                User.Show();
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("User Insertion Failed");
                            }
                        }
                        else if (UBtnSave.Text == "Update")
                        {
                            UserTable obj = new UserTable();

                            obj.FullName = UTextBoxFullName.Text;
                            obj.UserName = UTextBoxUserName.Text;
                            obj.Password = UTextBoxPassword.Text;
                            obj.ConfirmPassword = UTextBoxConfirmPassword.Text;
                            if (UCheckBoxIsAdmin.Checked == true)
                            {
                                obj.IsAdmin = 1;

                            }
                            else
                            {
                                obj.IsAdmin = 0;
                            }

                            if (objUserService.SaveUser(obj, 1))
                            {
                                MessageBox.Show("User Updated Seccessfully");
                                User.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("User Updation Failed");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username Already Exist in DataBase");
                    }
                       


                }
                else
                {
                    MessageBox.Show("Incomplete Form", "Please Fill Complete Form.!");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = GetAllUser();
            comboBox1.ValueMember = "UserId";
            comboBox1.DisplayMember = "UserName";
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

       

        public List<UserTable> GetAllUser()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.UserTables.ToList();
            }
        }
      
        private void BackBtn_MouseClick(object sender, MouseEventArgs e)
        {
            User.Show();
            this.Close();
        }

        private void btnFetchReocrd_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (comboBox1.Text!="")
                {
                    if (objUserService.GetSpecificUsers(comboBox1.Text).Count > 0)
                    {
                        UBtnSave.Enabled = true;
                        List<UserTable> List1 = new List<UserTable>();
                        List1 = objUserService.GetSpecificUsers(comboBox1.Text);
                        u = List1;

                        UTextBoxFullName.Text = List1[0].FullName;
                        UTextBoxUserName.Text = List1[0].UserName;
                        UTextBoxPassword.Text = List1[0].Password;
                        UTextBoxConfirmPassword.Text = List1[0].ConfirmPassword;
                        if (List1[0].IsAdmin == 1)
                        {
                            UCheckBoxIsAdmin.Checked = true;
                        }
                        else
                        {
                            UCheckBoxIsAdmin.Checked = false;
                        }
                        UTextBoxUserName.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Email Id Does not Exist");
                        ClearUser();
                    }
                }
                else
                {
                    MessageBox.Show("Email Id Empty");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error In Updating User");
            }
        }
        public void ClearUser()
        {
            UTextBoxFullName.Clear();
            UTextBoxUserName.Clear();
            UTextBoxPassword.Clear();
            UTextBoxConfirmPassword.Clear();
            UCheckBoxIsAdmin.Checked = false;

        }
    }
}
