using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAppRestaurantDB.Models;
using WebAppRestaurantDB.ViewModels;

namespace WebAppRestaurantDB.Repositories
{
    public class PRLineRepository
    {
        RestaurantDBEntities _restaurantDBEntities;

        public IEnumerable<PRLine> GetAll()
        {
            _restaurantDBEntities = new RestaurantDBEntities();
            var _listPR =  _restaurantDBEntities.PRLines.ToList();    
            return _listPR;
        }

        public IEnumerable<PRLine> GetById(string pRNo)
        {
            _restaurantDBEntities = new RestaurantDBEntities();
            var _pRLines = _restaurantDBEntities.PRLines.Where(o => o.PRNo == pRNo).ToList();            
            return _pRLines;

        }

        //CRUD-C
        public void Create(PRLine pRLine)
        {
            _restaurantDBEntities = new RestaurantDBEntities();
            _restaurantDBEntities.PRLines.Add(pRLine);
            _restaurantDBEntities.SaveChanges();
        }


        public void Delete(int _pRLineId)
        {
            _restaurantDBEntities = new RestaurantDBEntities();
            var _pRLine = _restaurantDBEntities.PRLines.Find(_pRLineId);
            _restaurantDBEntities.PRLines.Remove(_pRLine);
            _restaurantDBEntities.SaveChanges();
        }
    }
}