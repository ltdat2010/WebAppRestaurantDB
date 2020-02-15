using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppRestaurantDB.ViewModels
{
    public class UsersViewModel
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string RePassWord { get; set; }
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