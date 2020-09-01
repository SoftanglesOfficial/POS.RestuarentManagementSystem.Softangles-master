using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data;

namespace Domain
{
   public class UserService
    {
        UserProviders objUserProviders;

        public UserService()
        {
            objUserProviders = new UserProviders();
        }
        public List<UserTable> GetSpecificUsers(String un)
        {
           return objUserProviders.GetSpecificUsers(un); 
        }
        public List<UserTable> IsUsernameExist(string username, int id)
        {
            return objUserProviders.IsUsernameExist(username,id);
        }

        public List<UserTable> GetAunthenticatedUsers(String un,string s)
        {
            return objUserProviders.GetAunthenticatedUsers(un,s);
        }
        public bool SaveUser(UserTable model, int checkupdate)
        {

            return objUserProviders.SaveUser(model,checkupdate);

        }
    }
}
