using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppRestaurantDB.ViewModels
{
    public class ItemViewModel
    {
        public int ItemId { set; get; }
        public string ItemCode { set; get; }
        public string ItemName { set; get; }
        public decimal ItemPrice { set; get; }
        public decimal OnHand { set; get; }
        public decimal IsCommited { set; get; }
        public decimal OnOrder { set; get; }
        public string UoM { set; get; }
        public string FrgnName { set; get; }
        public string BuyUnitMsr { set; get; }
        public string NumInBuy { set; get; }
    }
}