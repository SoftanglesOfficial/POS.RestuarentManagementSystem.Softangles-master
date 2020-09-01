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
using WindowsFormsApp2.CommonClasses;
namespace WindowsFormsApp2
{
    public partial class User : Form
    {
        private Form Admin;

        UserService objUserService;
        public User(Form Admin)
        {
            objUserService = new UserService();
            InitializeComponent();
            this.Admin = Admin;
            Admin.Hide();
        }

        

        private void UBtnUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                UserAdd objUserAdd = new UserAdd(1, this);
                objUserAdd.Show();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
        
        }

        private void UBtnAddNewUser_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                // simply go to useradd form
                UserAdd objUserAdd = new UserAdd(0, this);
                objUserAdd.Show();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
           
        }
       

        private void UBackBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Admin.Show();
            this.Close();
        }
    }
}
