using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//-------------------------------
using WebAppRestaurantDB.Models;
using System.Web.Mvc;


namespace WebAppRestaurantDB.Repositories
{
    public class ItemRepository
    {
        RestaurantDBEntities _restaurantDBEntities;

        public ItemRepository()
        {
            _restaurantDBEntities = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllItems()
        {
            var _objGetAllItems = new List<SelectListItem>();
            _objGetAllItems = (from obj in _restaurantDBEntities.Items
                               select new SelectListItem()
                               {
                                Text  = obj.ItemName,
                                Value = obj.ItemId.ToString(),
                                Selected = true
            }).ToList();

            return _objGetAllItems;
        }
    }
}