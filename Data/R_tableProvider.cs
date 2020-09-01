
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class R_tableProvider
    {
        public List<R_Tables> Get_R_tables()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.R_Tables.ToList();
            }
        }

        public List<R_Tables> Get_R_tables_Active()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.R_Tables.Where(t=>t.status == true).ToList();
            }
        }


        public bool Save_filled(string rid , int filled)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                
                R_Tables RowinDb = db.R_Tables.Where(d => d.Name == rid).SingleOrDefault();

                {
                    
                    RowinDb.filled = Convert.ToInt32(RowinDb.filled) + (filled);
                    db.SaveChanges();
                    return true;
                }
              
                  
            }
        }
        public bool remove_filled(string rid, int filled)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                R_Tables RowinDb = db.R_Tables.Where(d => d.Name == rid).SingleOrDefault();

                {
                    RowinDb.filled = Convert.ToInt32(RowinDb.filled) - (filled);
                    db.SaveChanges();
                    return true;
                }


            }
        }
        public List<R_Tables> Get_filled(int rid)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.R_Tables.Where(t => t.id == rid).ToList();

            }
        }
        public bool Save_R_tables(R_Tables model)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                if (model.id == 0)
                {
                    db.R_Tables.Add(model);
                    db.SaveChanges();
                    return true;
                }
                else if(model.id > 0)
                {
                    R_Tables RowinDb = db.R_Tables.Where(d=>d.id == model.id).SingleOrDefault();
                    RowinDb.Name = model.Name;
                    RowinDb.capacity = model.capacity;
                    RowinDb.status = model.status;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public bool Delete_R_tables(int id)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                if (id > 0)
                {
                    R_Tables RowinDb = db.R_Tables.Where(d => d.id == id).SingleOrDefault();
                    if (RowinDb != null)
                    {
                        db.R_Tables.Remove(RowinDb);
                        db.SaveChanges();
                        return true;
                    }
                    return false;
                }
                return false;
            }
        }
        public List<R_Tables> IsTableNameExist(string tablename, int id)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.R_Tables.Where(t => t.id != id && t.Name == tablename).ToList();
            }
        }
    }
}
