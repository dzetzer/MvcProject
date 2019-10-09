using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Repositories
{
    public class ReviewRepository
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
    }
}
