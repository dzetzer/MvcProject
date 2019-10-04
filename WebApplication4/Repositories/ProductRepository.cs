using MvcProject.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        public List<Product> carsList;

        public ProductRepository()
        {
            carsList = new List<Product>();

            new Product("image", "McLaren 570 Spyder", 1, "Sports Car",
                "McLaren Automotives", "McClaren", "570 Spyder", "2015 - Present", "This Car Is Super Fast");
        }








        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
