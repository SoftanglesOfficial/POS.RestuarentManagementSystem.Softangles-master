//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Login_Tbl
    {
        public int id { get; set; }
        public System.DateTime First_Login_Date { get; set; }
        public System.DateTime Last_Login_Date { get; set; }
        public System.DateTime Expiration_Date { get; set; }
        public int IsAuthenticated { get; set; }
    }
}
