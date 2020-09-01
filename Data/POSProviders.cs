using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class POSProviders
    {
        public List<Sale> GetAllSalesItems()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.Sales.ToList();
            }
        }
        public List<Sale> Getpendingsale()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.Sales.Where(a => a.IsBillPending == 1 && a.OrderType== "Dine_In").GroupBy(z => z.TableName).Select(g => g.FirstOrDefault()).ToList();

            }
        }
        public List<Sale> GetpendingsaleofSelectedTable(string name)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.Sales.Where(a => a.IsBillPending == 1 && a.OrderType == "Dine_In" && a.TableName==name).ToList();

            }
        }
        public bool SaveSaleDetailItems(SaleDetail model ,int checkupdate )
        {
            
                using (RMSDBEntities db = new RMSDBEntities())
                {
               
                
                 if (checkupdate ==0 )
                
                {
                    db.SaleDetails.Add(model);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    SaleDetail RowinDb = db.SaleDetails.Where(d => d.TicketNo == model.TicketNo && d.ItemId == model.ItemId).SingleOrDefault();
                  
                    

                    RowinDb.ItemId = model.ItemId;
                    RowinDb.itemName = model.itemName;
                    RowinDb.Price = model.Price;
                    RowinDb.Discount = model.Discount;
                    RowinDb.Quantity = model.Quantity;
                    RowinDb.Total = model.Total;
                    RowinDb.TicketNo = model.TicketNo;
                    RowinDb.RecordID = model.RecordID;
                    RowinDb.Aed_Vat = model.Aed_Vat;
                    RowinDb.Aed_Vat_Amount = model.Aed_Vat_Amount;
                    RowinDb.Date = model.Date;

                    db.SaveChanges();
                    return true;
                }
               
              


                }
            
         }
        public bool SaveSale(Sale model,int checkupdate)
        {

            using (RMSDBEntities db = new RMSDBEntities())
            {
              //  Sale RowinDb = db.Sales.Where(d => d.TicketNo == model.TicketNo).SingleOrDefault();
                if (checkupdate==0)

                {
                    db.Sales.Add(model);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    Sale RowinDb = db.Sales.Where(d => d.TicketNo == model.TicketNo ).SingleOrDefault();
                    RowinDb.TicketNo = model.TicketNo;

                    RowinDb.TableName = model.TableName;
                    RowinDb.CustomerName = model.CustomerName;
                    RowinDb.OrderType = model.OrderType;
                    RowinDb.Balance = model.Balance;
                    RowinDb.TicketNote = model.TicketNote;
                    RowinDb.IsDeleted = model.IsDeleted;
                    RowinDb.PhoneNumber = model.PhoneNumber;
                    RowinDb.DeliveryAddress = model.DeliveryAddress;
                    RowinDb.IsBillPending = model.IsBillPending;
                    RowinDb.NumberOfPerson = model.NumberOfPerson;
                    RowinDb.ReceivedAmount = model.ReceivedAmount;
                    RowinDb.RemainingBalance = model.RemainingBalance;
                    RowinDb.cashier_id = model.cashier_id;
                    RowinDb.Cahier_Name = model.Cahier_Name;
                    RowinDb.IsRefund = model.IsRefund;
                    db.SaveChanges();
                    return true;
                }
                



            }

        }
        public bool SaveSaleReceivedBalance(string tn, double Received , double balance,int person,string tablename)
        {

            using (RMSDBEntities db = new RMSDBEntities())
            {
                
                {
                    Sale RowinDb = db.Sales.Where(d => d.TicketNo == tn).SingleOrDefault();

                    RowinDb.IsBillPending = 0;
                    RowinDb.ReceivedAmount = Received;
                    RowinDb.RemainingBalance = balance;

                    R_Tables RowinDb1 = db.R_Tables.Where(d => d.Name == tablename).SingleOrDefault();
                    RowinDb1.filled = Convert.ToInt32( RowinDb1.filled) - person;

                    db.SaveChanges();
                    return true;
                }

            }

        }
        public bool SaveSaleReceivedBalanceGen(string tn, double Received, double balance)
        {

            using (RMSDBEntities db = new RMSDBEntities())
            {

                {
                    Sale RowinDb = db.Sales.Where(d => d.TicketNo == tn).SingleOrDefault();

                    RowinDb.ReceivedAmount = Received;
                    RowinDb.RemainingBalance = balance;

                    db.SaveChanges();
                    return true;
                }

            }

        }
        public List<Sale> Get_SelectedSale(String s , string orderType)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.Sales.Where(t => t.TicketNo == s && t.OrderType == orderType).ToList();
            }
        }
        public List<Sale> Get_PendingOrderList(int i, string orderType)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.Sales.Where(t => t.IsBillPending == i && t.OrderType == orderType).ToList();
            }
        }
        public List<Sale> Get_PendingOrderListDineIn(int i, string orderType)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.Sales.Where(t => t.IsBillPending == i && t.OrderType == orderType).ToList();
            }
        }
        public List<Sale> Get_PendingOrderSingle( string ticketno)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.Sales.Where(t => t.TicketNo == ticketno && t.OrderType =="Home_Delivery" && t.IsRefund==0  && t.IsBillPending==1).ToList();
            }
        }
        public List<SaleDetail> Get_SelectedSaledetailItemup(int id,String s)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.SaleDetails.Where(t => t.TicketNo == s  && t.ItemId==id).ToList();
            }
        }
        public List<SaleDetail> Get_SelectedSaleDetail(String s )
       {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.SaleDetails.Where(t => t.TicketNo ==s).ToList();
            }
        }
        public bool Delete_SaleItemFromSaleDetail(int id)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {

                if (id != 0)
                {
                    SaleDetail RowinDb = db.SaleDetails.Where(d => d.RecordID == id).SingleOrDefault();

                    {
                        db.SaleDetails.Remove(RowinDb);
                        db.SaveChanges();
                        return true;
                    }
                }
                else
                    return false;
                   
                  
                
               
            }
        }
       
        public bool Delete_SaleRowFromSale(string s)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {


                Sale RowinDb = db.Sales.Where(d => d.TicketNo == s).SingleOrDefault();

                {
                    RowinDb.IsDeleted = 1;
                    RowinDb.IsBillPending = 0;
                    db.SaveChanges();
                    return true;
                }



            }
        }


    }
    
}


    

