using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class MenuItemsProviders
    {
        public List<menuItem> GetAllMenuItems()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuItems.ToList();
            }
        }
        public List<menuItem> Get_SelectedBarcode(String barcode)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuItems.Where(t => t.barcode == barcode ).ToList();
            }
        }

        public List<menuItem> Get_barcodeOrItemName(String borname)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuItems.Where(t => t.barcode == borname || t.itemName== borname ).ToList();
            }
        }
        public List<menuItem> Get_AllCatIdForGstUpdateFromADdCatogery(int catid)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuItems.Where(t => t.cat_id == catid).ToList();
            }
        }

        public List<menuCategory> Get_CategoryName(int catname)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuCategories.Where(t => t.id == catname).ToList();
            }
        }
        public List<section> Get_SectionyName(int Secname)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.sections.Where(t => t.id == Secname).ToList();
            }
        }
        public List<menuCategory> Get_CategoryID(string catname)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuCategories.Where(t => t.name == catname).ToList();
            }
        }
        public List<section> Get_SectionID(string Secname)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.sections.Where(t => t.sectionname == Secname).ToList();
            }
        }
        public List<menuItem> Get_SelectedMenuItem(int id)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuItems.Where(t => t.cat_id == id && t.status==true).ToList();
            }
        }
       
        public List<menuItem> Get_SelectedMenuItemONDVG(int id)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuItems.Where(t => t.id == id).ToList();
            }
        }
        public bool Save_MenuItems_tables(menuItem model)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                if (model.id == 0)
                {
                    db.menuItems.Add(model);
                    db.SaveChanges();
                    return true;
                }
                else if (model.id > 0)
                {
                    menuItem RowinDb = db.menuItems.Where(d => d.id == model.id).SingleOrDefault();
                    RowinDb.itemName = model.itemName;

                    RowinDb.color = model.color;
                    RowinDb.Price = model.Price;
                    RowinDb.discountpercnt = model.discountpercnt;
                    RowinDb.status = model.status;
                    RowinDb.cat_id = model.cat_id;
                    RowinDb.section_id = model.section_id;

                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
       
        
        public bool Delete_MenuItems_tables(int id)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                if (id > 0)
                {
                    menuItem RowinDb = db.menuItems.Where(d => d.id == id).SingleOrDefault();
                    if (RowinDb != null)
                    {
                        db.menuItems.Remove(RowinDb);
                        db.SaveChanges();
                        return true;
                    }
                    return false;
                }
                return false;
            }
        }
        public List<menuItem> IsItemNameExist(string itemname, int id)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.menuItems.Where(t => t.id != id && t.itemName == itemname).ToList();
            }
        }
    }
    
}
