using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppRestaurantDB.Models
{
    public class ItemViewModel
    {
        public int ItemId { set; get; }
        public string ItemName { set; get; }
        public decimal ItemPrice { set; get; }
    }
}