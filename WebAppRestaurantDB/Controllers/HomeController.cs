using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDB.Repositories;

namespace WebAppRestaurantDB.Controllers
{
    public class HomeController : Controller
    {
        ItemRepository _itemRepository;
        CustomerRepository _customerReposistory;
        PaymentTypeRepository _paymentTypeRepository;

        // GET: Home
        public ActionResult Index()
        {
            _customerReposistory = new CustomerRepository();
            _itemRepository = new ItemRepository();
            _paymentTypeRepository = new PaymentTypeRepository();

            var allMultipleObject = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                                    (_customerReposistory.GetAllCustomers(), _itemRepository.GetAllItems(), _paymentTypeRepository.GetAllPaymentTypes());
            return View(allMultipleObject);
        }
    }
}