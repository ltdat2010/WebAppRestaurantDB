using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDB.Models;

namespace WebAppRestaurantDB.Repositories
{
    public class DepartmentRepository
    {
        RestaurantDBEntities _restaurantDBEntities;

        public DepartmentRepository()
        {
            _restaurantDBEntities = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAll()
        {
            var _listDepartment = (from obj in _restaurantDBEntities.Departments
                                     select new SelectListItem()
                                     {
                                         Text = obj.DeptName,
                                         Value = obj.DeptCode.ToString(),
                                         Selected = true

                                     }).ToList();
            return _listDepartment;
        }


        public Department  GetById(string DepartmentCode)
        {
            var _department = (from obj in _restaurantDBEntities.Departments
                               where obj.DeptCode == DepartmentCode
                               select obj).FirstOrDefault();
            return _department;
        }

    }
}