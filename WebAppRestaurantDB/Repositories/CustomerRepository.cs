using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//-------------------------------
using WebAppRestaurantDB.Models;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;

namespace WebAppRestaurantDB.Repositories
{
    public class CustomerRepository
    {
        SqlConnection _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RestaurantDBSQL"].ConnectionString);
        CustomerViewModel _customerViewModel;
        //RestaurantDBEntities _restaurantDBEntities;

        public CustomerRepository()
        {
            _customerViewModel = new CustomerViewModel();
            //_restaurantDBEntities = new RestaurantDBEntities();
        }
        public IEnumerable<SelectListItem> GetAll()
        {
            var _objGetAllItems = new List<SelectListItem>();
            //_objGetAllItems = (from obj in _restaurantDBEntities.Customers
            //                   select new SelectListItem()
            //                   {
            //                       Text = obj.CustomerName,
            //                       Value = obj.CustomerId.ToString(),
            //                       Selected = true
            //                   }).ToList();
            SqlCommand _sqlCommand = new SqlCommand("GetAllCustomer", _sqlConnection);
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlConnection.Open();
            SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                var customer = new Customer();
                var _selectListItem = new SelectListItem();

                customer.CustomerId = int.Parse(_sqlDataReader["CustomerId"].ToString());
                customer.CustomerName = _sqlDataReader["CustomerName"].ToString();
                //MapsterMapper
                _selectListItem.Value = customer.CustomerId.ToString();
                _selectListItem.Text = customer.CustomerName;

                _objGetAllItems.Add(_selectListItem);
            }
            return _objGetAllItems;
        }
        //public IEnumerable<SelectListItem> GetAllCustomers()
        //{
        //    var _objGetAllItems = new List<SelectListItem>();
        //    _objGetAllItems = (from obj in _restaurantDBEntities.Customers
        //                       select new SelectListItem()
        //                       {
        //                           Text = obj.CustomerName,
        //                           Value = obj.CustomerId.ToString(),
        //                           Selected = true
        //                       }).ToList();

        //    return _objGetAllItems;
        //}
    }
}