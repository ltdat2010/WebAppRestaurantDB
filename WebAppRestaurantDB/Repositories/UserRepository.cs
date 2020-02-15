using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAppRestaurantDB.Models;

namespace WebAppRestaurantDB.Repositories
{
    public class UserRepository
    {
        User _user;
        //Connection string name : RestaurantDBSQL
        SqlConnection _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RestaurantDBSQL"].ConnectionString);
        
        public UserRepository ()
        {
            _user = new User();
        }

        public string LoginUser(string userName)
        {

            SqlCommand _sqlCommand = new SqlCommand("LoginUser", _sqlConnection);
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            _sqlCommand.Parameters.AddWithValue("@UserName", userName);
            _sqlConnection.Open();
            SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                _user.PassWord = _sqlDataReader["PassWord"].ToString();
            }
            _sqlConnection.Close();
            return _user.PassWord;

        }

        public void RegisterUser(User user)
        {
            SqlCommand _sqlCommand = new SqlCommand("RegisterUser", _sqlConnection);
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            _sqlCommand.Parameters.AddWithValue("@UserName", user.UserName);
            _sqlCommand.Parameters.AddWithValue("@PassWord", user.PassWord);
            _sqlConnection.Open();
            _sqlCommand.ExecuteNonQuery();          
            _sqlConnection.Close();

        }




    }
}