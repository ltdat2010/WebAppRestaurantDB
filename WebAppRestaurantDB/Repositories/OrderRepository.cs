using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using WebAppRestaurantDB.Models;
using WebAppRestaurantDB.ViewModels;

namespace WebAppRestaurantDB.Repositories
{
    public class OrderRepository
    {
        SqlConnection _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RestaurantDBSQL"].ConnectionString);
        RestaurantDBEntities _restaurantDBEntities;

        //OrderRepository _orderRepository ;
        //OrderDetailRepository _orderDetailRepository;
        //CustomerRepository _customerRepository ;
        PaymentTypeRepository _paymentTypeRepository;

        //OrderViewModel _orderViewModel;
        //CustomerViewModel _customerViewModel;
        //PaymentTypeViewModel _paymentTypeViewModel;

        public OrderRepository()
        {
             _restaurantDBEntities = new RestaurantDBEntities();
        }
        
        public IEnumerable<OrderViewModel> GetAll()
        {
            //_orderRepository = new OrderRepository();
            //_orderDetailRepository = new OrderDetailRepository();
            //_customerRepository = new CustomerRepository();
            _paymentTypeRepository = new PaymentTypeRepository();

            //var _selectListPaymentType = _paymentTypeRepository.GetAll();
            //var _selectListCustomer = _customerRepository.GetAll();           

            List<OrderViewModel> _listorders = new List<OrderViewModel>();

            SqlCommand _sqlCommand = new SqlCommand("GetAllOrder", _sqlConnection);
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            _sqlConnection.Open();
            SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();

            while (_sqlDataReader.Read())
            {
                var _order = new Order();
                var _orderViewModel = new OrderViewModel();

                _order.OrderId = int.Parse(_sqlDataReader["OrderId"].ToString());
                _order.PaymentTypeId = int.Parse(_sqlDataReader["PaymentTypeId"].ToString());
                _order.CustomerId = int.Parse(_sqlDataReader["CustomerId"].ToString());
                _order.OrderNumber = _sqlDataReader["OrderNumber"].ToString();
                _order.FinalTotal = decimal.Parse(_sqlDataReader["FinalTotal"].ToString());
                //MapsterMapper
                _orderViewModel.OrderId = _order.OrderId;
                //_orderViewModel.PaymentTypes = _paymentTypeRepository.GetAll();
                _orderViewModel.SelectedPaymentTypeId = _order.PaymentTypeId;
                _orderViewModel.SelectedPaymentTypeName = _paymentTypeRepository.GetById(_orderViewModel.SelectedPaymentTypeId).PaymentTypeName;
                _orderViewModel.SelectedCustomerId = _order.CustomerId;
                _orderViewModel.OrderNumber = _order.OrderNumber;
                _orderViewModel.FinalTotal = _order.FinalTotal;
                _listorders.Add(_orderViewModel);
            }
            _sqlConnection.Close();

            //var _listorders = _restaurantDBEntities.Orders.ToList(); 




            return _listorders;
        }
    }
}