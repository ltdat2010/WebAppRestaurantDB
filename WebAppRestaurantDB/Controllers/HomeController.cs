using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDB.Models;
using WebAppRestaurantDB.Repositories;

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
            

            var allMultipleObject = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                                    (_customerReposistory.GetAllCustomers(), _itemRepository.GetAllItems(), _paymentTypeRepository.GetAllPaymentTypes());
            return View(allMultipleObject);
        }

        [HttpGet]
        public JsonResult getItemUnitPrice(int itemId)
        {
            decimal _unitPrice = _restaurantDBEntities.Items.Single(model => model.ItemId == itemId).ItemPrice;
            return Json(_unitPrice, JsonRequestBehavior.AllowGet);
        }

    }
}