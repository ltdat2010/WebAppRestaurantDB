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
    public class PRController : Controller
    {
        PRRepository _pRRepository;
        //IPRRepository _ipRRepository;
        PRLineRepository _pRLineRepository;

        public PRController()
        {
            _pRRepository = new PRRepository();
            //_ipRRepository = new PRRepository(new RestaurantDBEntities());
        }

        // GET: PR
        public ActionResult PRIdx()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            var _pRs = _pRRepository.GetAll();

            var _listPRViewModel = new List<PRViewModel>();

            foreach (var _pR in _pRs)
            {
                var _pRViewModel = new PRViewModel();
                var _departmentRepository = new DepartmentRepository();
                //Mapping
                _pRViewModel.PRNo = _pR.PRNo;
                _pRViewModel.SelectedDeptCode = _pR.DeptCode;
                //_pRViewModel.Departments = _departmentRepository.GetById(_pRViewModel.DeptCodeRequested);
                _pRViewModel.Reason = _pR.Reason;
                _pRViewModel.PRDate = _pR.PRDate;
                _pRViewModel.RequestedBy = _pR.RequestedBy;
                _pRViewModel.RequestedDate = _pR.RequestedDate;
                _pRViewModel.ApprovedStatus = _pR.ApprovedStatus;
                _pRViewModel.SelectedDepartment = _departmentRepository.GetById(_pRViewModel.SelectedDeptCode);

                _listPRViewModel.Add(_pRViewModel);
            }
            return Json(new { data = _listPRViewModel }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {


            //var _pRViewModel = new PRViewModel();
            //var _departmentRepository = new DepartmentRepository();
            //_pRViewModel.Departments = _departmentRepository.GetAll();

            //var _itemRepository = new ItemRepository();
            //return View(_pRViewModel);

            //Thay the bang code sau
            var _departmentRepository = new DepartmentRepository();
            var _itemRepository = new ItemRepository();
            var _pRViewModel = new PRViewModel();
            var _pRLineViewModel = new PRLineViewModel();

            var MultiObj = new Tuple<PRViewModel, PRLineViewModel, IEnumerable<SelectListItem>, IEnumerable<ItemViewModel>>
                                    (_pRViewModel, _pRLineViewModel, _departmentRepository.GetAll(), _itemRepository.GetAll());
            return View(MultiObj);
        }


        public ActionResult Edit(string pRNo)
        {
            var _pRViewModel = new PRViewModel();

            var _pRLineRepository = new PRLineRepository();
            var _departmentRepository = new DepartmentRepository();
            _pRViewModel.Departments = _departmentRepository.GetAll();

            var _pR = _pRRepository.GetById(pRNo);

            ////Mapping
            _pRViewModel.Id = _pR.Id;
            _pRViewModel.PRNo = _pR.PRNo;
            _pRViewModel.SelectedDeptCode = _pR.DeptCode;
            _pRViewModel.RequestedDate = _pR.RequestedDate;
            _pRViewModel.Reason = _pR.Reason;
            var _listPRLines = _pRLineRepository.GetById(pRNo);

            var _listPRLineViewModel = new List<PRLineViewModel>();

            foreach (var _pRLine in _listPRLines)
            {
                var _pRLineViewModel = new PRLineViewModel();
                //Bu sung Id de xoa PRLine
                _pRLineViewModel.Id = _pRLine.Id;

                _pRLineViewModel.SelectedItemCode = _pRLine.ItemCode;
                _pRLineViewModel.SelectedItemName = _pRLine.ItemName;
                _pRLineViewModel.UoM = _pRLine.UoM;
                _pRLineViewModel.InStock = _pRLine.InStock;
                _pRLineViewModel.QtyRequest = _pRLine.QtyRequest;
                _pRLineViewModel.NeededDate = _pRLine.NeededDate;
                _pRLineViewModel.PRLinesStatus = _pRLine.PRLinesStatus;
                _pRLineViewModel.Price = _pRLine.Price;

                _listPRLineViewModel.Add(_pRLineViewModel);
            }
            _pRViewModel.PRLines = _listPRLineViewModel;

            return View(_pRViewModel);
        }

        //CRUD-C
        [HttpPost]
        public ActionResult CreateNew(PR pR)
        {
            pR.PRNo = _pRRepository.GetMaxPRNo();

            _pRRepository.Create(pR);

            //foreach (var _pRLine in pR.PRLines)
            //{
            //    _pRLineRepository.Create(_pRLine);
            //}

            //return Json(Url.Action("PRIdx", "PR"));
            return Json(true);
        }
    }
}