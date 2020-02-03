using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//-------------------------------
using WebAppRestaurantDB.Models;
using System.Web.Mvc;

namespace WebAppRestaurantDB.Repositories
{
    public class PaymentTypeRepository
    {
        RestaurantDBEntities _restaurantDBEntities;

        public PaymentTypeRepository()
        {
            _restaurantDBEntities = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllPaymentTypes()
        {
            var _objGetAllItems = new List<SelectListItem>();
            _objGetAllItems = (from obj in _restaurantDBEntities.PaymentTypes
                               select new SelectListItem()
                               {
                                   Text = obj.PaymentTypeName,
                                   Value = obj.PaymentTypeId.ToString(),
                                   Selected = true
                               }).ToList();

            return _objGetAllItems;
        }
    }
}