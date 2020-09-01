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
    public partial class POSTableShow : Form
    {
       
        R_tableService objTblServicel;

        public static  string  PassingTableName="" ;
        public static int TableShowCount=0;

        List<Data.R_Tables> L1 = new List<Data.R_Tables>();
        public POSTableShow()
        {
            objTblServicel = new R_tableService();
            InitializeComponent();

            
        }

        private void POSTableShow_Load(object sender, EventArgs e)
        {
            try
            {
                if (POS.personupdatecheck == 1)
                {
                    using (RMSDBEntities db = new RMSDBEntities())
                    {
                        List<GetTablesOnChangeing_Result> b1 = new List<GetTablesOnChangeing_Result>();
                         b1= db.GetTablesOnChangeing(POS.ticketNumerForChangePlace).ToList();
                       int  TableShowCount1 = b1.Count;
                        int x = 50;
                        int y = 50;

                        for (int i = 0; i < TableShowCount1; i++)
                        {
                            if (b1[i].capacity - b1[i].filled >= POS.persons)
                            {
                                Button b = new Button();
                                b.Location = new Point(x, y);
                                b.Name = b1[i].Name;
                                b.Text = b1[i].Name;
                                b.Size = new Size(180, 42);
                                b.Font = new Font("Minion Pro", 20);
                                b.Padding = new Padding(0);
                                b.MouseClick += new MouseEventHandler(Mouse_Click);
                                flowLayoutPanel1.Controls.Add(b);

                            }


                        }
                        for (int i = 0; i < TableShowCount1; i++)
                        {
                            if (b1[i].capacity - b1[i].filled < POS.persons)
                            {
                                Button b = new Button();
                                b.Location = new Point(x, y);
                                b.Name = b1[i].Name;
                                b.Text = b1[i].Name;
                                b.Size = new Size(180, 42);
                                b.Font = new Font("Minion Pro", 20);
                                b.Padding = new Padding(0);
                                b.Enabled = false;
                                b.MouseClick += new MouseEventHandler(Mouse_Click);
                                flowLayoutPanel1.Controls.Add(b);
                            }



                        }
                    }

                }
                else
                {

                    TableShowCount = objTblServicel.Get_R_tables_Active().Count;
                    L1 = objTblServicel.Get_R_tables_Active().ToList();
                    int x = 50;
                    int y = 50;

                    for (int i = 0; i < TableShowCount; i++)
                    {
                        if (L1[i].capacity - L1[i].filled >= POS.persons)
                        {
                            Button b = new Button();
                            b.Location = new Point(x, y);
                            b.Name = L1[i].Name;
                            b.Text = L1[i].Name;
                            b.Size = new Size(180, 42);
                            b.Font = new Font("Minion Pro", 20);
                            b.Padding = new Padding(0);
                            b.MouseClick += new MouseEventHandler(Mouse_Click);
                            flowLayoutPanel1.Controls.Add(b);

                        }


                    }
                    for (int i = 0; i < TableShowCount; i++)
                    {
                        if (L1[i].capacity - L1[i].filled < POS.persons)
                        {
                            Button b = new Button();
                            b.Location = new Point(x, y);
                            b.Name = L1[i].Name;
                            b.Text = L1[i].Name;
                            b.Size = new Size(180, 42);
                            b.Font = new Font("Minion Pro", 20);
                            b.Padding = new Padding(0);
                            b.Enabled = false;
                            b.MouseClick += new MouseEventHandler(Mouse_Click);
                            flowLayoutPanel1.Controls.Add(b);
                        }



                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            

        }
        protected void Mouse_Click(object sender , EventArgs e )
        {
            try
            {
                PassingTableName = (sender as Button).Text;
                this.Close();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            PassingTableName = (sender as Button).Text;
            this.Close();
           
        }
    }
}
