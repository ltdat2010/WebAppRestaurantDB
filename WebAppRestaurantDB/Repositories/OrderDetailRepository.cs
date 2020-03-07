using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDB.Models;
using WebAppRestaurantDB.ViewModels;

namespace WebAppRestaurantDB.Repositories
{
    public class OrderDetailRepository
    {
        SqlConnection _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RestaurantDBSQL"].ConnectionString);
        OrderdetailViewModel _orderdetailViewModel;

        public OrderDetailRepository()
        {
            _orderdetailViewModel = new OrderdetailViewModel();
        }

        [HttpGet]
        public IEnumerable<OrderdetailViewModel> GetAll()
        {
            List<OrderdetailViewModel> _listorderDetails = new List<OrderdetailViewModel>();
            SqlCommand _sqlCommand = new SqlCommand("GetAllOrderDetail", _sqlConnection);
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlConnection.Open();
            SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
            while(_sqlDataReader.Read())
            {
                var orderDetail = new OrderDetail();
                orderDetail.OrderDetailId = int.Parse(_sqlDataReader["OrderDetailId"].ToString());
                orderDetail.OrderId = int.Parse(_sqlDataReader["OrderId"].ToString());
                orderDetail.ItemId = int.Parse(_sqlDataReader["ItemId"].ToString());
                orderDetail.Quantity = int.Parse(_sqlDataReader["Quantity"].ToString());
                orderDetail.UnitPrice = int.Parse(_sqlDataReader["UnitPrice"].ToString());
                orderDetail.Discount = int.Parse(_sqlDataReader["Discount"].ToString());
                orderDetail.Total = int.Parse(_sqlDataReader["Total"].ToString());
                //MapsterMapper
                _orderdetailViewModel.OrderDetailId = orderDetail.OrderDetailId;
                _orderdetailViewModel.OrderId = orderDetail.OrderId;
                _orderdetailViewModel.ItemId = orderDetail.ItemId;
                _orderdetailViewModel.Quantity = orderDetail.Quantity;
                _orderdetailViewModel.UnitPrice = orderDetail.UnitPrice;
                _orderdetailViewModel.Discount = orderDetail.Discount;
                _orderdetailViewModel.Total = orderDetail.Total;

                _listorderDetails.Add(_orderdetailViewModel);
            }
            return _listorderDetails;
        }

        [HttpGet]
        public IEnumerable<OrderdetailViewModel> GetAllById(int OrderDetailId)
        {
            List<OrderdetailViewModel> _listorderDetails = new List<OrderdetailViewModel>();
            SqlCommand _sqlCommand = new SqlCommand("GetByIdOrderDetail", _sqlConnection);
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlConnection.Open();
            SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                var orderDetail = new OrderDetail();
                orderDetail.OrderDetailId = int.Parse(_sqlDataReader["OrderDetailId"].ToString());
                orderDetail.OrderId = int.Parse(_sqlDataReader["OrderId"].ToString());
                orderDetail.ItemId = int.Parse(_sqlDataReader["ItemId"].ToString());
                orderDetail.Quantity = int.Parse(_sqlDataReader["Quantity"].ToString());
                orderDetail.UnitPrice = int.Parse(_sqlDataReader["UnitPrice"].ToString());
                orderDetail.Discount = int.Parse(_sqlDataReader["Discount"].ToString());
                orderDetail.Total = int.Parse(_sqlDataReader["Total"].ToString());
                //MapsterMapper
                _orderdetailViewModel.OrderDetailId = orderDetail.OrderDetailId;
                _orderdetailViewModel.OrderId = orderDetail.OrderId;
                _orderdetailViewModel.ItemId = orderDetail.ItemId;
                _orderdetailViewModel.Quantity = orderDetail.Quantity;
                _orderdetailViewModel.UnitPrice = orderDetail.UnitPrice;
                _orderdetailViewModel.Discount = orderDetail.Discount;
                _orderdetailViewModel.Total = orderDetail.Total;

                _listorderDetails.Add(_orderdetailViewModel);
            }
            return _listorderDetails;
        }
        [HttpGet]
        public IEnumerable<OrderdetailViewModel> GetAllByParentId(int OrderId)
        {
            List<OrderdetailViewModel> _listorderDetails = new List<OrderdetailViewModel>();
            SqlCommand _sqlCommand = new SqlCommand("GetByOrderIdOrderDetail", _sqlConnection);
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlConnection.Open();
            SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                var orderDetail = new OrderDetail();
                orderDetail.OrderDetailId = int.Parse(_sqlDataReader["OrderDetailId"].ToString());
                orderDetail.OrderId = int.Parse(_sqlDataReader["OrderId"].ToString());
                orderDetail.ItemId = int.Parse(_sqlDataReader["ItemId"].ToString());
                orderDetail.Quantity = int.Parse(_sqlDataReader["Quantity"].ToString());
                orderDetail.UnitPrice = int.Parse(_sqlDataReader["UnitPrice"].ToString());
                orderDetail.Discount = int.Parse(_sqlDataReader["Discount"].ToString());
                orderDetail.Total = int.Parse(_sqlDataReader["Total"].ToString());
                //MapsterMapper
                _orderdetailViewModel.OrderDetailId = orderDetail.OrderDetailId;
                _orderdetailViewModel.OrderId = orderDetail.OrderId;
                _orderdetailViewModel.ItemId = orderDetail.ItemId;
                _orderdetailViewModel.Quantity = orderDetail.Quantity;
                _orderdetailViewModel.UnitPrice = orderDetail.UnitPrice;
                _orderdetailViewModel.Discount = orderDetail.Discount;
                _orderdetailViewModel.Total = orderDetail.Total;


                _listorderDetails.Add(_orderdetailViewModel);
            }
            return _listorderDetails;
        }
    }
}