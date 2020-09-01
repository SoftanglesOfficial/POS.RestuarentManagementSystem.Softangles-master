using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
  public  class UserProviders
    {

        public List<UserTable> GetAllUsers()
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.UserTables.ToList();
            }
        }
        public List<UserTable> GetSpecificUsers(String Username)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.UserTables.Where(d => d.UserName == Username).ToList();
            }
        }
        public List<UserTable> GetAunthenticatedUsers(String Username,string password)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.UserTables.Where(d => d.UserName == Username && d.Password== password).ToList();
            }
        }
        public bool SaveUser(UserTable model, int checkupdate)
        {

            using (RMSDBEntities db = new RMSDBEntities())
            {


                if (checkupdate == 0)

                {
                    db.UserTables.Add(model);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    UserTable RowinDb = db.UserTables.Where(d => d.UserName == model.UserName).SingleOrDefault();

                   

                    RowinDb.FullName = model.FullName;
                    RowinDb.Password = model.Password;
                    RowinDb.ConfirmPassword = model.ConfirmPassword;
                    RowinDb.IsAdmin = model.IsAdmin;
                  
                    db.SaveChanges();
                    return true;
                }




            }

        }
        public List<UserTable> IsUsernameExist(string username, int id)
        {
            using (RMSDBEntities db = new RMSDBEntities())
            {
                return db.UserTables.Where(t => t.UserId != id && t.UserName == username).ToList();
            }
        }
    }
}
