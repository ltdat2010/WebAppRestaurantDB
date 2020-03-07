using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//--
using WebAppRestaurantDB;
using WebAppRestaurantDB.Models;
using System.Configuration;
using System.Data;
using WebAppRestaurantDB.Models;
using WebAppRestaurantDB.ViewModels;

namespace WebAppRestaurantDB.Repositories
   
{
    public class EmployeeRepository
    {
        //RestaurantDBEntities _restaurantDBEntities;
        //Employee _employee;
        //Connection string name : RestaurantDBSQL
        SqlConnection _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RestaurantDBSQL"].ConnectionString);
        

        public EmployeeRepository()
        {
            //_restaurantDBEntities = new RestaurantDBEntities();
            //_employee =new Employee();
            
        }


        //GetAll        
        public IEnumerable<EmployeeViewModel> GetAll()
        {
            List<EmployeeViewModel> _employeeList = new List<EmployeeViewModel>();
            //Store Procedure
            SqlCommand _sqlCommand = new SqlCommand("GetAllEmployee", _sqlConnection);
            _sqlCommand.CommandType = CommandType.StoredProcedure;

            //string content = _sqlCommand.CommandText.ToString();
            //System.IO.File.WriteAllText(@"D:\WebestaurantDB_CommandText_WriteText.txt", content);

            _sqlConnection.Open();
            SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                var _employee = new Employee();
                var _employeeViewModel = new EmployeeViewModel();
                _employee.EmployeeCode = _sqlDataReader["EmployeeCode"].ToString();
                _employee.FirstName = _sqlDataReader["FirstName"].ToString();
                _employee.LastName = _sqlDataReader["LastName"].ToString();
                _employee.EmailID = _sqlDataReader["EmailID"].ToString();
                //_employee.City = _sqlDataReader["City"].ToString();
                //_employee.Country = _sqlDataReader["Country"].ToString();
                //MapsterMapper
                _employeeViewModel.EmployeeCode = _employee.EmployeeCode;
                _employeeViewModel.FirstName = _employee.FirstName;
                _employeeViewModel.LastName = _employee.LastName;
                _employeeViewModel.EmailID = _employee.EmailID;

                _employeeList.Add(_employeeViewModel);                
            }
            _sqlConnection.Close();


            //Entities
            //var _employeeList = _restaurantDBEntities.Employees.ToList();            

            //LINQ to Entities
            //_employeeList = (from obj in _restaurantDBEntities.Employees
            //                 select new SelectListItem()
            //                 {
            //                     Text = obj.FirstName,
            //                          Value= obj.EmployeeCode,
            //                          Selected= true
            //                  }).ToList();

            return _employeeList;
        }

        //GetAll
        public Employee GetByCode(string employeeCode)
        {
            Employee _employee = new Employee();
            //Store Procedure
            SqlCommand _sqlCommand = new SqlCommand("GetAllEmployee", _sqlConnection);
            _sqlCommand.Parameters.AddWithValue("@EmployeeCode", employeeCode);
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            _sqlConnection.Open();
            SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                _employee.EmployeeCode = _sqlDataReader["EmployeeCode"].ToString();
                _employee.FirstName = _sqlDataReader["FirstName"].ToString();
                _employee.LastName = _sqlDataReader["LastName"].ToString();
                _employee.EmailID = _sqlDataReader["EmailID"].ToString();
                //_employee.City = _sqlDataReader["City"].ToString();
                //_employee.Country = _sqlDataReader["Country"].ToString();

                
            }
            _sqlConnection.Close();


            //Entities
            //var _employeeList = _restaurantDBEntities.Employees.ToList();            

            //LINQ to Entities
            //_employeeList = (from obj in _restaurantDBEntities.Employees
            //                 select new SelectListItem()
            //                 {
            //                     Text = obj.FirstName,
            //                          Value= obj.EmployeeCode,
            //                          Selected= true
            //                  }).ToList();

            return _employee;
        }

        //Create
        public void Create(Employee employee)
        {
            //Entities
            //_restaurantDBEntities.Employees.Add(employee);
            //_restaurantDBEntities.SaveChanges();

            //Store procedure
            SqlCommand _sqlCommand = new SqlCommand("CreateEmployee",_sqlConnection);
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            _sqlCommand.Parameters.AddWithValue("@EmployeeCode", employee.EmployeeCode);
            _sqlCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
            _sqlCommand.Parameters.AddWithValue("@LastName", employee.LastName);
            _sqlCommand.Parameters.AddWithValue("@EmailID", employee.EmailID);
            //_sqlcommand.Parameters.AddWithValue("@City", employee.City);
            //_sqlcommand.Parameters.AddWithValue("@Country", employee.Country);
            

            _sqlConnection.Open();
            _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();

        }

        //Update
        public void Update (Employee employee)
        {
            //Entities
            //var _employee = _restaurantDBEntities.Employees.Find(employee.EmployeeCode);
            //_employee.FirstName = employee.FirstName;
            //_employee.LastName = employee.LastName;
            //_employee.EmailID = employee.EmailID;
            //_employee.City = employee.City;
            //_employee.Country = employee.Country;
            //_restaurantDBEntities.SaveChanges();

            //Store procedure
            SqlCommand _sqlcommand = new SqlCommand("UpdateEmployee", _sqlConnection);
            _sqlcommand.CommandType = CommandType.StoredProcedure;
            _sqlcommand.Parameters.AddWithValue("@EmployeeCode", employee.EmployeeCode);
            _sqlcommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
            _sqlcommand.Parameters.AddWithValue("@LastName", employee.LastName);
            _sqlcommand.Parameters.AddWithValue("@EmailID", employee.EmailID);
            //_sqlcommand.Parameters.AddWithValue("@City", employee.City);
            //_sqlcommand.Parameters.AddWithValue("@Country", employee.Country);

            _sqlConnection.Open();
            _sqlcommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        //Delete
        public void Delete(string employee)
        {
            //Entities
            //var _employee = _restaurantDBEntities.Employees.Find("EmployeeCode", employeeCode);
            //_restaurantDBEntities.Employees.Remove(_employee);
            //_restaurantDBEntities.SaveChanges();

            //Store procedure
            SqlCommand _sqlcommand = new SqlCommand("DeleteEmployee", _sqlConnection);
            _sqlcommand.CommandType = CommandType.StoredProcedure;
            _sqlcommand.Parameters.AddWithValue("@EmployeeCode", employee);

            _sqlConnection.Open();
            _sqlcommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }


    }
}