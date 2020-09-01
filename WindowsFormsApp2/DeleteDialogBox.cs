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
    public partial class DeleteDialogBox : Form
    {
        public static int delete = 0;
        public DeleteDialogBox()
        {
            InitializeComponent();
        }

        private void DeleteDialogBox_Load(object sender, EventArgs e)
        {

        }

        private void DeleteBtnYes_MouseClick(object sender, MouseEventArgs e)
        {
            delete = 1;
            this.Close();
        }

        private void DeleteBtnNo_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
