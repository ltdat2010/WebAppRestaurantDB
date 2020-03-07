using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//-------------------------------
using WebAppRestaurantDB.Models;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebAppRestaurantDB.Repositories
{
    public class PaymentTypeRepository
    {
        RestaurantDBEntities _restaurantDBEntities;
        SqlConnection _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RestaurantDBSQL"].ConnectionString);
        PaymentTypeViewModel _paymentTypeViewModel ;

        public PaymentTypeRepository()
        {
            _paymentTypeViewModel = new PaymentTypeViewModel();
            _restaurantDBEntities = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAll()
        {
            var _objGetAllItems = new List<SelectListItem>();
            _objGetAllItems = (from obj in _restaurantDBEntities.PaymentTypes
                               select new SelectListItem()
                               {
                                   Text = obj.PaymentTypeName,
                                   Value = obj.PaymentTypeId.ToString(),
                                   Selected = true
                               }).ToList();
            //SqlCommand _sqlCommand = new SqlCommand("GetAllPaymentType", _sqlConnection);
            //_sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //_sqlConnection.Open();
            //SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
            //while (_sqlDataReader.Read())
            //{
            //    var paymentType = new PaymentType();
            //    var _paymentTypeViewModel = new PaymentTypeViewModel();

            //    paymentType.PaymentTypeId = int.Parse(_sqlDataReader["PaymentTypeId"].ToString());
            //    paymentType.PaymentTypeName = _sqlDataReader["PaymentTypeName"].ToString();
            //    //SelectListItem
            //    _paymentTypeViewModel.PaymentTypeId = paymentType.PaymentTypeId;
            //    _paymentTypeViewModel.PaymentTypeName = paymentType.PaymentTypeName;

            //    _objGetAllItems.Add(_paymentTypeViewModel);
            //}            

            //return new SelectList(_objGetAllItems, "PaymentTypeId", "PaymentTypeName");

            return _objGetAllItems;
        }

        public PaymentTypeViewModel GetById(int PaymentTypeId)
        {
            var paymentType = new PaymentType();
            var _paymentTypeViewModel = new PaymentTypeViewModel();

            var _objPaymentType = _restaurantDBEntities.PaymentTypes
                                    .Where(o => o.PaymentTypeId == PaymentTypeId)
                                    .FirstOrDefault();
            paymentType.PaymentTypeId = _objPaymentType.PaymentTypeId;
            paymentType.PaymentTypeName = _objPaymentType.PaymentTypeName;
            //MapsterMapper
            _paymentTypeViewModel.PaymentTypeId = paymentType.PaymentTypeId;
            _paymentTypeViewModel.PaymentTypeName = paymentType.PaymentTypeName;            

            return _paymentTypeViewModel;
        }


    }
}