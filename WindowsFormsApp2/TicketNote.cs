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
    public partial class TicketNote : Form
    {
        public static string tnote = "";
        public TicketNote()
        {
            InitializeComponent();
        }

        private void OkayLbl_MouseClick(object sender, MouseEventArgs e)
        {
            tnote =  TicketNoteRichTextBox.Text;
            this.Close();
        }

        private void TicketNote_Load(object sender, EventArgs e)
        {
            TicketNoteRichTextBox.Text = tnote;
        }

        private void OkayImg_MouseClick(object sender, MouseEventArgs e)
        {
            OkayLbl_MouseClick( sender,  e);
        }

        private void OkayPanel_MouseClick(object sender, MouseEventArgs e)
        {
            OkayLbl_MouseClick(sender, e);
        }

        private void ClearLbl_MouseClick(object sender, MouseEventArgs e)
        {
            TicketNoteRichTextBox.Text = "";
            tnote = TicketNoteRichTextBox.Text;
        }

        private void ClearImg_MouseClick(object sender, MouseEventArgs e)
        {
            ClearLbl_MouseClick( sender,  e);
        }

        private void ClearPanel_MouseClick(object sender, MouseEventArgs e)
        {
            ClearLbl_MouseClick(sender, e);
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
