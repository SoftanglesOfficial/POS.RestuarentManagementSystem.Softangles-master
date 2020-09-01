using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.CommonClasses
{
    public  class SaleCart
    {
        public int ItemId { get; set; }
        public string  ItemName { get; set; }
        public double price { get; set; }
        public double discount { get; set; }
        public double quantity { get; set; }

        
        public double Total { get; set; }
        public string TicketNo { get; set; }
        public int RecordID { get; set; }

        public double Aed_Vat { get; set; }

        
        public string PhoneNumber { get; set; }
        public string DeliveryAddress { get; set; }
        public int IsBillPending { get; set; }

        public double Available_quantity { get; set; }

    }
}
