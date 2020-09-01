using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Domain
{
    public class R_tableService
    {

        R_tableProvider Objr_TableProvider;
        // constructor
        public R_tableService()
        {
            Objr_TableProvider = new R_tableProvider();
        }

        public  List<R_Tables> Gettables()
        {
            return Objr_TableProvider.Get_R_tables();
        }
        public List<R_Tables> Get_filled(int id)
        {
            return Objr_TableProvider.Get_filled( id);
        }
        public bool Save_filled(string rid, int filled)
        {
            return Objr_TableProvider.Save_filled(rid,filled);
        }

        public bool remove_filled(string rid, int filled)
        {
            return Objr_TableProvider.remove_filled(rid, filled);
        }
        public List<R_Tables> Get_R_tables_Active()
        {
            return Objr_TableProvider.Get_R_tables_Active();
        }

        public  bool Save_R_tables(R_Tables model)
        {
            return Objr_TableProvider.Save_R_tables(model);
        }

        public bool Delete_R_tables(int id)
        {
            return Objr_TableProvider.Delete_R_tables(id);
        }
        public List<R_Tables> IsTableNameExist(string tablename, int id)
        {
            return Objr_TableProvider.IsTableNameExist(tablename, id);
        }
    }
}
