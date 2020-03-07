using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDB.Models;
using WebAppRestaurantDB.Repositories;
using WebAppRestaurantDB.ViewModels;

namespace WebAppRestaurantDB.Controllers
{
    public class HomeController : Controller
    {
        RestaurantDBEntities _restaurantDBEntities;
        ItemRepository _itemRepository;
        CustomerRepository _customerReposistory;
        PaymentTypeRepository _paymentTypeRepository;

        public HomeController()
        {
            _restaurantDBEntities = new RestaurantDBEntities();
            _customerReposistory = new CustomerRepository();
            _itemRepository = new ItemRepository();
            _paymentTypeRepository = new PaymentTypeRepository();
        }

        // GET: Home
        public ActionResult Index()
        {

            var allMultipleObject = new Tuple<IEnumerable<SelectListItem>, IEnumerable<ItemViewModel>, IEnumerable<SelectListItem>>
            //var allMultipleObject = new Tuple<IEnumerable<CustomerViewModel>, IEnumerable<ItemViewModel>, IEnumerable<PaymentTypeViewModel>>
                                    (_customerReposistory.GetAll(), _itemRepository.GetAll(), _paymentTypeRepository.GetAll());
            return View(allMultipleObject);
        }

        [HttpGet]
        public JsonResult getItemUnitPrice(int itemId)
        {
            decimal _unitPrice = _restaurantDBEntities.Items.Single(model => model.ItemId == itemId).ItemPrice;
            return Json(_unitPrice, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            var _listItems =_itemRepository.GetAll();
            return Json(new { data = _listItems }, JsonRequestBehavior.AllowGet);
        }



    }
}