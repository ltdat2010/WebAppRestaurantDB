using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAppRestaurantDB.Models;
using WebAppRestaurantDB.ViewModels;

namespace WebAppRestaurantDB.Repositories
{
    public class PRRepository : IPRRepository
    {
        RestaurantDBEntities _restaurantDBEntities;
        
        public PRRepository ()
        {
            _restaurantDBEntities = new RestaurantDBEntities();
        }
        //public IEnumerable<PR> GetAll()
        //{
        //    var _listPR =  _restaurantDBEntities.PRs.ToList();    
        //    return _listPR;

        //}

        //public PR GetById(string pRNo)
        //{
        //    var _pR = _restaurantDBEntities.PRs.Where(s => s.PRNo == "200001").FirstOrDefault<PR>();
        //    var _pRLineRepository = new PRLineRepository();
        //    //_pR.PRLines = _pRLineRepository.GetById(pRNo);
        //    return _pR;

        //}
        public void Create(PR pR)
        {

            try
            {
                _restaurantDBEntities.PRs.Add(pR);
                _restaurantDBEntities.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }

        public void Delete(string pRNo)
        {
            var _pR =  _restaurantDBEntities.PRs.Find(pRNo);
            _restaurantDBEntities.PRs.Remove(_pR);

        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _restaurantDBEntities.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<PR> GetAll()
        {
            return _restaurantDBEntities.PRs.ToList();
        }

        public PR GetById(string pRNo)
        {
            return _restaurantDBEntities.PRs.Find(pRNo);
        }

        public void Save()
        {
            _restaurantDBEntities.SaveChanges();
        }

        public void Update(PR pR)
        {
            _restaurantDBEntities.Entry(pR).State = EntityState.Modified;
        }

        public string GetMaxPRNo()
        {
            //return object<string>
            var _pRNo = (int.Parse(_restaurantDBEntities.GetMaxPRNo().FirstOrDefault())+1).ToString();
            //convert to string using FirstOrDefault()
            return _pRNo;
        }
    }
}