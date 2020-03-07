using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDB.Models;
using WebAppRestaurantDB.ViewModels;

namespace WebAppRestaurantDB.Controllers
{
    public class VehicleController : Controller
    {
        // GET: Vehicle
        public ActionResult Index()
        {
            var model = new VehicleViewModel();
            model.MakeModelsList = new SelectList(GetMakes(), "Id", "MakeName");
            model.VehicleModelsList = new SelectList(GetModels(), "Id", "VehicleName");
            return View(model);
        }

        [HttpPost]
        public ActionResult GetSelectedModels(int makeId)
        {
            if (makeId > 0)
            {
                var list = from p in GetModels()
                           where p.MakeId == makeId
                           select p;

                return Json(list.ToList());
            }
            return Json("");
        }

        public IEnumerable<VehicleModel> GetModels()
        {
            return new List<VehicleModel>()
                {
                    new VehicleModel(){ Id=1, MakeId =1, VehicleName = "VW"},
                    new VehicleModel(){ Id=2, MakeId =1, VehicleName = "BMW"},
                    new VehicleModel(){ Id=3, MakeId =2, VehicleName = "Honda"},
                    new VehicleModel(){ Id=4, MakeId =3, VehicleName = "Toyoto"},
                };
        }

        /// <summary>
        /// Gets the makes.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<VehicleMakeModel> GetMakes()
        {
            return new List<VehicleMakeModel>()
                {
                    new VehicleMakeModel(){ Id=1,  MakeName = "2000"},
                    new VehicleMakeModel(){ Id=2,  MakeName = "2001"},
                    new VehicleMakeModel(){ Id=3,  MakeName = "2002"},
                };

        }
    }
}