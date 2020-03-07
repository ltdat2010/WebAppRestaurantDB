using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDB.Repositories;

namespace WebAppRestaurantDB.Controllers
{
    public class ItemController : Controller
    {
        
        // GET: Item
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            var _itemRepository = new ItemRepository();
            var _listItem = _itemRepository.GetAll();

            return Json(new { data = _listItem }, JsonRequestBehavior.AllowGet);
        }
    }
}