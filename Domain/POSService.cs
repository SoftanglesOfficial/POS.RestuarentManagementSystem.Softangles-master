using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Domain
{
    public class POSService
    {
        POSProviders objPOSProviders;
        public POSService()
        {
            objPOSProviders = new POSProviders();
        }
        public List<Sale> GetAllSalesItems()
        {
            return objPOSProviders.GetAllSalesItems();
        }
        public List<Sale> Getpendingsale()
        {
            return objPOSProviders.Getpendingsale();
        }
        public List<Sale> GetpendingsaleofSelectedTable(string name)
        {
            return objPOSProviders.GetpendingsaleofSelectedTable(name);
        }
        public bool SaveSaleDetailItems(SaleDetail model,int checkupdate )
        {
            return objPOSProviders.SaveSaleDetailItems(model,checkupdate);
        }
        public bool SaveSale(Sale model ,int checkupdate)
        {
            return objPOSProviders.SaveSale(model, checkupdate);
        }
        public bool SaveSaleReceivedBalance(string tn, double Received, double balance, int person,string tablename)
        {

            return objPOSProviders.SaveSaleReceivedBalance(tn, Received, balance, person, tablename);

        }
        public bool SaveSaleReceivedBalanceGen(string tn, double Received, double balance)
        {

            return objPOSProviders.SaveSaleReceivedBalanceGen(tn, Received, balance);

        }
        public List<Sale> Get_SelectedSale(String s, string orderType)
        {
            return objPOSProviders.Get_SelectedSale(s, orderType);
        }
        public List<Sale> Get_PendingOrderList(int i, string orderType)
        {
            return objPOSProviders.Get_PendingOrderList(i, orderType);
        }
        public List<Sale> Get_PendingOrderListDineIn(int i, string orderType)
        {
            return objPOSProviders.Get_PendingOrderListDineIn(i, orderType);
        }
       
        public List<Sale> Get_PendingOrderSingle( string TicketNo)
        {
            return objPOSProviders.Get_PendingOrderSingle(TicketNo);
        }
        public List<SaleDetail> Get_SelectedSaleDetail(String sd)
        {
            return objPOSProviders.Get_SelectedSaleDetail(sd);
        }
        
        public List<SaleDetail> Get_SelectedSaledetailItemup(int id,String sd)
        {
            return objPOSProviders.Get_SelectedSaledetailItemup(id,sd);
        }

        public bool Delete_SaleItemFromSaleDetail(int id)
        {
            return objPOSProviders.Delete_SaleItemFromSaleDetail(id);
        }
        public bool Delete_SaleRowFromSale(string s)
        {
            return objPOSProviders.Delete_SaleRowFromSale(s);
        }
    }
}
