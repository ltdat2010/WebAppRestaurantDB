using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppRestaurantDB.Models;

namespace WebAppRestaurantDB.Repositories
{
    public interface IPRRepository : IDisposable
    {
        IEnumerable<PR> GetAll();
        PR GetById(string pRNo);
        string GetMaxPRNo();
        void Create(PR pR);
        void Update(PR pR);
        void Delete(string pRNo);
        void Save();
    }
}
