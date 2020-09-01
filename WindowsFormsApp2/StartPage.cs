using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Encryption;

namespace WindowsFormsApp2
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void SPPictureFrontOffice_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
               
                Login objLogin = new Login();
                objLogin.Show();
                this.Hide();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            
        }

        private void SPPictureBackOffice_MouseClick(object sender, MouseEventArgs e)
        {
            SPPictureFrontOffice_MouseClick(sender, e);
        }

        private void lblContactDevelopers_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Developed By Softangles\nEmail:- shahzadwaheed0@gmail.com \nWebsite:- www.softangles.com \nContact:- +92-311-6068410","ABout Developes");
        }

        private void ImgContactDevelopers_MouseClick(object sender, MouseEventArgs e)
        {
            lblContactDevelopers_MouseClick( sender,  e);
        }

        private void panelContactDevelopers_MouseClick(object sender, MouseEventArgs e)
        {
            lblContactDevelopers_MouseClick(sender, e);
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
