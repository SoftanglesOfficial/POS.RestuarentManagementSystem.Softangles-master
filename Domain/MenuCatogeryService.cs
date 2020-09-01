using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;


namespace Domain
{
        
   public class MenuCatogeryService
    {
        MenuCatogeryProvider objMenyProvider;

        public MenuCatogeryService()
        {
            objMenyProvider = new MenuCatogeryProvider();
        }
        public List<menuCategory> GetAllMenuCatogery()
        {
            return objMenyProvider.GetAllMenuCatogery();
        }
        public List<menuItem> GetoneMenuCatogery(int k)
        {

            return objMenyProvider.GetoneMenuCatogery(k); ;
           
        }
        public List<menuItem> CheckEmptyItem(int k)
        {

            return objMenyProvider.CheckEmptyItem(k);

        }
        public bool Delete_MenuCatogery_tables(int id)
        {
            return objMenyProvider.Delete_MenuCatogery_tables(id);
        }
        public bool Save_MenuCatogery_tables(menuCategory model)
        {
            return objMenyProvider.Save_MenuCatogery_tables(model);
        }
        public List<menuCategory> IsCatogeryNameExist(string catname, int id)
        {
            return objMenyProvider.IsCatogeryNameExist(catname, id);
        }
    }
}
