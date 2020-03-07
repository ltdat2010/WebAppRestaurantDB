using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDB.Repositories;

namespace WebAppRestaurantDB.Controllers
{
    public class PRLineController : Controller
    {
        PRLineRepository _pRLineRepository;
        // GET: PRLine
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int pRLineId)
        {
            _pRLineRepository = new PRLineRepository();
            _pRLineRepository.Delete(pRLineId);
            return Json(true);
        }
    }
}