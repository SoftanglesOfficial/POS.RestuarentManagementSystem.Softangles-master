using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Domain
{
    public class CashierService
    {
        CashierProvider objCashierProvide;
        public CashierService()
        {
            objCashierProvide = new CashierProvider();
        }
        public List<UserTable> Get_SelectedCashiername(string s)
        {
            
                return objCashierProvide.Get_SelectedCashiername(s);
           
        }
        public List<UserTable> Get_SelectedCashiername1(int s)
        {

            return objCashierProvide.Get_SelectedCashiername1(s);

        }
        public bool Save_DayStartTime(CashierTable model)
        {
            return objCashierProvide.Save_DayStartTime(model);
        }
        public List<CashierTable> Get_SelectedCashierForEndWork(int c_id)
        {
            
                return objCashierProvide.Get_SelectedCashierForEndWork(c_id);
            
        }
    }
}
