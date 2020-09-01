using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MenuCatogeryProvider
    {
        public List<menuCategory> GetAllMenuCatogery()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuCategories.ToList();
            }
        }
        public List<menuItem> GetoneMenuCatogery(int k)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuItems.Where(d => d.id == k).ToList();
            }
        }
        public bool Save_MenuCatogery_tables(menuCategory model)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                if (model.id == 0)
                {
                    db.menuCategories.Add(model);
                    db.SaveChanges();
                    return true;
                }
                else if (model.id > 0)
                {
                    menuCategory RowinDb = db.menuCategories.Where(d => d.id == model.id).SingleOrDefault();
                    RowinDb.name = model.name;
                    RowinDb.color = model.color;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public bool Delete_MenuCatogery_tables(int id)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                if (id > 0)
                {
                    menuCategory RowinDb = db.menuCategories.Where(d => d.id == id).SingleOrDefault();
                 
                        if (RowinDb != null)
                        {
                            db.menuCategories.Remove(RowinDb);
                            db.SaveChanges();
                           
                        }
                       
                    }
                   
                }
                return true;
         }
        public List<menuItem> CheckEmptyItem(int cat)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuItems.Where(d => d.cat_id == cat).ToList();
            }
        }
        public List<menuCategory> IsCatogeryNameExist(string catogeryname, int id)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuCategories.Where(t => t.id != id && t.name== catogeryname).ToList();
            }
        }
    }
        

}

