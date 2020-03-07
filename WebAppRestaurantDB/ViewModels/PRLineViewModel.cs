using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDB.Models;

namespace WebAppRestaurantDB.ViewModels
{
    public class PRLineViewModel
    {
        public PRLineViewModel()
        {

        }
        public int Id { get; set; }
        public string PRNo { get; set; }
        public string SelectedItemCode { get; set; }
        public string SelectedItemName { get; set; }
        public IEnumerable<SelectListItem> Items { get; set; }
        public string UoM { get; set; }
        public Nullable<decimal> InStock { get; set; }
        public Nullable<decimal> QtyRequest { get; set; }
        public Nullable<System.DateTime> NeededDate { get; set; }
        public Nullable<bool> PRLinesStatus { get; set; }
        //Update de theo doi tinh trang cua PRLine
        //New hay Update tren DataTable only (Database no needed)
        public string CRUDStatus { get; set; }
        public Nullable<decimal> Price { get; set; }
        public virtual PR PR { get; set; }
        public IEnumerable<PRLine> PRLines { get; set; }
    }
}