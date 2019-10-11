using MvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private VehicleContext db;

        public ProductRepository(VehicleContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Products.Count();
        }

        public void Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void Delete(Product product)
        {
            db.Products.Remove(product);
            db.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product GetByID(int id)
        {
            return db.Products.Single(p => p.ID == id);
        }

        public IEnumerable<Product> GetByProductID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
