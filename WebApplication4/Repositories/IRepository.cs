using System;
using System.Collections.Generic;
using System.Linq;
using MvcProject.Models;
using System.Threading.Tasks;

namespace MvcProject.Repositories
{
    public interface IRepository<T> where T :class
    {
        IEnumerable<T> GetAll();

        T GetByID(int id);
        T Create(Review review);
        T Delete(Review review);

        IEnumerable<T> GetByProductID(int id);
        
    }
}
