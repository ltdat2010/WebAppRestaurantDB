using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDB.Repositories;
using WebAppRestaurantDB.ViewModels;

namespace WebAppRestaurantDB.Controllers
{
    public class OrderController : Controller
    {
        OrderRepository _orderRepository = new OrderRepository();
        PaymentTypeRepository _paymentTypeRepository = new PaymentTypeRepository();
        //OrderViewModel _orderViewModel;
        // GET: Order
        public ActionResult Index()
        {
            var _orderViewModel = new OrderViewModel();
            _orderViewModel.PaymentTypes = _paymentTypeRepository.GetAll();
            return View(_orderViewModel);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var _listOrderViewModel = _orderRepository.GetAll();            
            return Json(new { data = _listOrderViewModel }, JsonRequestBehavior.AllowGet);
        }


    }
}