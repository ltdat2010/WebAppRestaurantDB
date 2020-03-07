using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDB.Models;

namespace WebAppRestaurantDB.ViewModels
{
    public class OrderViewModel
    {
        public OrderViewModel()
        {

        }

        public int OrderId { get; set; }
        public int SelectedPaymentTypeId { get; set; }
        public string SelectedPaymentTypeName { get; set; }
        public IEnumerable<SelectListItem> PaymentTypes { get; set; }
        public int SelectedCustomerId { get; set; }
        public string SelectedCustomerName { get; set; }
        public IEnumerable<SelectListItem> Customers { set; get; }
        public string OrderNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public decimal FinalTotal { get; set; }
        public virtual IEnumerable<OrderdetailViewModel> OrderDetails { get; set; }
    }
}