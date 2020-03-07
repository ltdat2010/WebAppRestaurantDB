using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDB.Repositories;

namespace WebAppRestaurantDB.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentRepository _departmentRepository;
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            _departmentRepository = new DepartmentRepository();
            var _listDept = _departmentRepository.GetAll();
            return Json(new {data = _listDept },JsonRequestBehavior.AllowGet );
        }
    }
}