using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class counterProvider
    {
        public List<section> GetAllCounters()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.sections.ToList();
            }
        }

        public bool SaveCounter(section model)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                if (model.id == 0)
                {
                    db.sections.Add(model);
                    db.SaveChanges();
                    return true;
                }
                else if (model.id > 0)
                {
                    section RowinDb = db.sections.Where(d => d.id == model.id).SingleOrDefault();
                    RowinDb.sectionname = model.sectionname;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public List<section> IsSectionNameExist(string sectionname, int id)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.sections.Where(t => t.id != id && t.sectionname == sectionname).ToList();
            }
        }
        public bool DeleteCounter(int id)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                if (id > 0)
                {
                    section RowinDb = db.sections.Where(d => d.id == id).SingleOrDefault();
                    if (RowinDb != null)
                    {
                        db.sections.Remove(RowinDb);
                        db.SaveChanges();
                        return true;
                    }
                    return false;
                }
                return false;
            }
        }
    }
}
