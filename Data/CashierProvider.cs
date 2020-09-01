using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class CashierProvider
    {
        public List<CashierTable> Get_SelectedCashierForEndWork(int c_id )
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.CashierTables.Where(t => t.CashierId == c_id && t.EndTime == null).ToList();
            }
        }
        public List<UserTable> Get_SelectedCashiername(String s)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.UserTables.Where(t => t.UserName == s ).ToList();
            }
        }
        public List<UserTable> Get_SelectedCashiername1(int s)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.UserTables.Where(t => t.UserId == s).ToList();
            }
        }
        public bool Save_DayStartTime(CashierTable model)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                if (model.id == 0)
                {
                    db.CashierTables.Add(model);
                    db.SaveChanges();
                    return true;
                }
                else if (model.id > 0)
                {
                    CashierTable RowinDb = db.CashierTables.Where(d => d.CashierId == model.CashierId && d.id == model.id).SingleOrDefault();
                   RowinDb.EndTime = model.EndTime;
                    RowinDb.TotalHour = model.TotalHour;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
