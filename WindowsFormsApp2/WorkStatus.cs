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
using Domain;
namespace WindowsFormsApp2
{
    public partial class WorkStatus : Form
    {
        CashierService objCashierService;
        POSService objPOSService;
        public static int startworkcheck = 0;
        public static int Endworkcheck = 0;

        private Form Cashier;
        public WorkStatus(Form Cashier)
        {
            InitializeComponent();
            objPOSService = new POSService();
            objCashierService = new CashierService();
            this.Cashier = Cashier;
            Cashier.Hide();
        }

        private void StrtLbl_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (startworkcheck == 0 && Endworkcheck == 0)

                {
                    CashierTable obj = new CashierTable();
                    obj.CashierId = Login.CashierId;
                    obj.CurrentDay = DateTime.Now.Date;
                    obj.StartTime = DateTime.Now;
                    obj.EndTime = null;
                    obj.TotalHour = 0;
                    startworkcheck = 1;
                    if (objCashierService.Save_DayStartTime(obj))
                    {
                        MessageBox.Show("Work Started");
                        this.Close();
                        Cashier.Show();
                    }
                    else
                    {
                        MessageBox.Show("Work Started Failed");
                        this.Close();
                        Cashier.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Work Already Started");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            
        }

        private void EndWorkLbl_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                List<Sale> L1 = new List<Sale>();
                L1 = objPOSService.Getpendingsale().ToList();
                if (startworkcheck == 1 && Endworkcheck == 0 && L1.Count<1)
                {
                    CashierTable obj = new CashierTable();
                    List<CashierTable> LWS = new List<CashierTable>();
                    LWS = objCashierService.Get_SelectedCashierForEndWork(Login.CashierId);
                    for (int i = LWS.Count-1; i < LWS.Count; i++)
                    {
                        
                       
                        obj.CashierId = Login.CashierId;
                        obj.CurrentDay = LWS[i].CurrentDay;
                        obj.StartTime = LWS[i].StartTime;
                        obj.id = LWS[i].id;
                    }
                   


                    obj.EndTime = DateTime.Now;
                    Double HourDiff = DateTime.Now.Hour - obj.StartTime.Hour;

                    Double MinDiff = DateTime.Now.Minute - obj.StartTime.Minute;

                    if (DateTime.Now.Minute < obj.StartTime.Minute)
                    {
                        HourDiff = HourDiff - 1;
                        MinDiff = (60 - obj.StartTime.Minute) + DateTime.Now.Minute;
                    }


                    obj.TotalHour = HourDiff + (MinDiff / 60);
                    //   string hours = obj.EndTime.Subtract(LWS[0].StartTime).TotalMinutes.ToString();

                    if (objCashierService.Save_DayStartTime(obj))
                    {
                        MessageBox.Show("Work End Successfully");
                        Endworkcheck = 0;
                        startworkcheck = 0;
                        this.Close();
                        Cashier.Show();
                    }
                    else
                    {
                        MessageBox.Show("Work End Failed");
                        this.Close();
                        Cashier.Show();
                    }

                }
                else if(L1.Count>0)
                {
                    MessageBox.Show("First Clear Pending Bills");
                }
                else
                {
                    MessageBox.Show("First Start the work");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Exception Error");
            }
            
        }

        private void Back_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            Cashier.Show();
        }

        private void StrtLblImg_MouseClick(object sender, MouseEventArgs e)
        {
            StrtLbl_MouseClick( sender,  e);
        }

        private void StrtPanel_MouseClick(object sender, MouseEventArgs e)
        {
            StrtLbl_MouseClick(sender, e);
        }

        private void EndWorkImg_MouseClick(object sender, MouseEventArgs e)
        {
            EndWorkLbl_MouseClick(sender, e);
        }

        private void EndWorkPanel_MouseClick(object sender, MouseEventArgs e)
        {
            EndWorkLbl_MouseClick(sender, e);
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            Cashier.Show();
        }
    }
}
