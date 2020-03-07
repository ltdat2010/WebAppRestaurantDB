using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//-------------------------------
using WebAppRestaurantDB.ViewModels;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using WebAppRestaurantDB.Models;

namespace WebAppRestaurantDB.Repositories
{
    public class ItemRepository
    {
        //RestaurantDBEntities _restaurantDBEntities;
        SqlConnection _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ASIALANDDBSQL"].ConnectionString);
        
        public ItemRepository()
        {
            //_restaurantDBEntities = new RestaurantDBEntities();
            
        }
        public IEnumerable<ItemViewModel> GetAll()
        {
            var _objGetAllItems = new List<ItemViewModel>();
            SqlCommand _sqlCommand = new SqlCommand("select ItemCode,ItemName,FrgnName,OnHand,IsCommited,OnOrder,BuyUnitMsr,NumInBuy from OITM ", _sqlConnection);
            //SqlCommand _sqlCommand = new SqlCommand("select * from Item ", _sqlConnection);

            _sqlCommand.CommandType = System.Data.CommandType.Text;
            _sqlConnection.Open();
            SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                var item = new Item();
                var _selectListItem = new ItemViewModel();
                var _itemViewModel = new ItemViewModel();
                item.ItemCode = _sqlDataReader["ItemCode"].ToString();
                item.ItemName = _sqlDataReader["ItemName"].ToString();
                //item.ItemPrice = decimal.Parse(_sqlDataReader["ItemPrice"].ToString());
                //MapsterMapper
                _itemViewModel.ItemCode = _sqlDataReader["ItemCode"].ToString();
                _itemViewModel.ItemName = _sqlDataReader["ItemName"].ToString();
                _itemViewModel.OnHand = decimal.Parse(_sqlDataReader["OnHand"].ToString());
                _itemViewModel.IsCommited = decimal.Parse(_sqlDataReader["IsCommited"].ToString());
                //_itemViewModel.ItemPrice = item.ItemPrice;
                _itemViewModel.OnOrder = decimal.Parse(_sqlDataReader["OnOrder"].ToString());
                _itemViewModel.BuyUnitMsr = _sqlDataReader["BuyUnitMsr"].ToString();
                _itemViewModel.NumInBuy = _sqlDataReader["NumInBuy"].ToString();

                _objGetAllItems.Add(_itemViewModel);
            }
            return _objGetAllItems;
        }

        
    }
}