using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.CommonClasses
{
   public class updateuser
    {
        public  int UserId  { get; set; }
        public string  FullName { get; set; }
        public string UsernName { get; set; }
        public string Passwod { get; set; }
        public string ConfirmPassword { get; set; }
        public int IsAdmin { get; set; }
    }
}
