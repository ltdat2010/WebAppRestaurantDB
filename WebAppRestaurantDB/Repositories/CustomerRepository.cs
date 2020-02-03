using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//-------------------------------
using WebAppRestaurantDB.Models;
using System.Web.Mvc;

namespace WebAppRestaurantDB.Repositories
{
    public class CustomerRepository
    {

        RestaurantDBEntities _restaurantDBEntities;

        public CustomerRepository()
        {
            _restaurantDBEntities = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            var _objGetAllItems = new List<SelectListItem>();
            _objGetAllItems = (from obj in _restaurantDBEntities.Customers
                               select new SelectListItem()
                               {
                                   Text = obj.CustomerName,
                                   Value = obj.CustomerId.ToString(),
                                   Selected = true
                               }).ToList();

            return _objGetAllItems;
        }
    }
}