//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppRestaurantDB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public byte[] UserImage { get; set; }
        public Nullable<bool> Locked { get; set; }
        public string Note { get; set; }
        public string SocialAccount1 { get; set; }
        public string SocialAccount2 { get; set; }
        public string SocialAccount3 { get; set; }
        public string SocialAccount4 { get; set; }
    }
}
