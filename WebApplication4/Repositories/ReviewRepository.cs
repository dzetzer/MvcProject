using MvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Repositories
{
    public class ReviewRepository :IRepository<Review>
    {
        private VehicleContext db;

        public ReviewRepository(VehicleContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Reviews.Count();
        }


        public IEnumerable<Review> GetAll()
        {
            return db.Reviews;
        }

        public IEnumerable<Review> GetByProductID(int productID)
        {
            var reviews = db.Reviews.Where(p => p.ProductID == productID);
            return reviews;
        }

        public Review GetByID(int id)
        {
            return db.Reviews.Single(r => r.ID == id);
        }
    }
}
