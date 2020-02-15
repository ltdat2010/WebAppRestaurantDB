using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDB.Models;
//---
using WebAppRestaurantDB.Repositories;
using WebAppRestaurantDB.ViewModels;

namespace WebAppRestaurantDB.Controllers
{
    public class EmployeeController : Controller
    {      

        EmployeeRepository _employeeRepository = new EmployeeRepository();
        

        // GET: Employee
        public ActionResult Index()
        {
            //var MultiObj = Turple<IEnumerable<SelectListItem>, IEnumerable< SelectListItem > 
            //                ( ); 
            return View();
        }
        
        [HttpGet]
        public JsonResult GetAll()
        {            
            var AllObj = _employeeRepository.GetAll();
            return Json(new { data = AllObj }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetByCode(string employeeCode)
        {
            var AllObj = _employeeRepository.GetByCode(employeeCode);
            return Json(new { data = AllObj }, JsonRequestBehavior.AllowGet);
        }

        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeViewModel employeeViewModel)
        {
            Employee employee = new Employee();
            if (ModelState.IsValid)
            {
                //Mapper
                employee.EmployeeCode = employeeViewModel.EmployeeCode;
                employee.FirstName = employeeViewModel.FirstName;
                employee.LastName = employeeViewModel.LastName;
                employee.EmailID = employeeViewModel.EmailID;

                _employeeRepository.Create(employee);

                //return RedirectToAction("Index");
                //Ko the redirect tu ajax post
                return Json(Url.Action("Index", "Employee"));
            }
            else
            {
                return View("Index");
            }            
        }

        public ActionResult Update(string employeeCode)
        {
            if (employeeCode == null)
                return new HttpNotFoundResult("Employee Code not found");

            //EmployeeRepository _employeeRepository = _employeeRepository.GetByCode(employeeCode);
            return View(_employeeRepository);
        }

        [HttpPost]
        public ActionResult Update(string employeeCode,Employee employee)
        {
            if (employeeCode == null)
                return new HttpNotFoundResult("Employee Code not found");
            if (ModelState.IsValid)
            {
                _employeeRepository.Update(employee);
                return Json(Url.Action("Index", "Employee"));

            }
            return View(employee);

        }

        [HttpPost]
        public ActionResult Delete(string employeeCode)
        {
            _employeeRepository.Delete(employeeCode);
            return Json(Url.Action("Index", "Employee"));
        }

        //[HttpPost]
        //public ActionResult Save()
        //{

        //    return View("Index");
        //}
        //[HttpGet]
        //public ActionResult Details(string employeeCode)
        //{
        //    if (employeeCode == null)
        //        return new HttpNotFoundResult("Employee Code not found");

        //    //EmployeeViewModel _employeeViewModel = _employeeRepository.GetByCode(employeeCode);
        //    return View(_employeeViewModel);
        //}
    }
}