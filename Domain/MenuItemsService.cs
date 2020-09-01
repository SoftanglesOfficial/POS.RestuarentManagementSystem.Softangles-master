using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Domain

{
    public class MenuItemsService
    {
        MenuItemsProviders objMenuItemsProviders;

        public MenuItemsService()
        {
            objMenuItemsProviders = new MenuItemsProviders();
        }
        public List<menuItem> Get_barcodeOrItemName(String borname)
        {

            return objMenuItemsProviders.Get_barcodeOrItemName(borname);


        }
        public List<menuItem> Get_SelectedBarcode(String barcode)
        {

            return objMenuItemsProviders.Get_SelectedBarcode(barcode);
            
        }
        public List<menuCategory> Get_CategoryName(int catname)
        {
           
                return objMenuItemsProviders.Get_CategoryName(catname);
           
        }
        public List<section> Get_SectionyName(int Secname)
        {

            return objMenuItemsProviders.Get_SectionyName(Secname);


        }
        public List<menuCategory> Get_CategoryID(string catname)
        {
           
                return objMenuItemsProviders.Get_CategoryID(catname);
           
        }
        public List<section> Get_SectionID(string Secname)
        {
           
                return objMenuItemsProviders.Get_SectionID(Secname);
           
        }
        public List<menuItem> Get_SelectedMenuItem(int id)
        {
            return objMenuItemsProviders.Get_SelectedMenuItem(id);
        }
        public List<menuItem> Get_AllCatIdForGstUpdateFromADdCatogery(int catid)
        {
           
                return objMenuItemsProviders.Get_AllCatIdForGstUpdateFromADdCatogery(catid);
            
        }
        public List<menuItem> Get_SelectedMenuItemONDVG(int id)
        {
            return objMenuItemsProviders.Get_SelectedMenuItemONDVG(id);
        }
        public List<menuItem> GetAllMenuItems()
        {
            return objMenuItemsProviders.GetAllMenuItems();
        }
        public bool Save_MenuItems_tables(menuItem model)
        {
            return objMenuItemsProviders.Save_MenuItems_tables(model);
        }
        public bool Delete_MenuItems_tables(int id)
        {
            return objMenuItemsProviders.Delete_MenuItems_tables(id);
        }
        public List<menuItem> IsItemNameExist(string itemname, int id)
        {
            return objMenuItemsProviders.IsItemNameExist(itemname, id);
        }
    }
}
