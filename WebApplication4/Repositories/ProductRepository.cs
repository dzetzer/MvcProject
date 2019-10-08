using MvcProject.Models;
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
            carsList = new List<Product>()
            {
            new Product("/Images/mclaren-570s-spider-design-edition.jpg", "McLaren 570 Spyder", 1, "Sports Car",
                "McLaren Automotives", "McClaren", "570 Spyder", "2015 - Present", "This Car Is Super Fast. 5 out of 5."),
            new Product("/Images/ram.jpg", "Ram 1500", 2, "Pickup Truck", "Fiat Chrysler Automobiles", 
                "Ram", "1500", "1981 - Present", "Guts, Glory, Ram. 3.5 out of 5."),
            new Product("/Images/mustang.jpg", "Ford Mustang", 3, "Sport Car", "Ford Motor Company", "Ford",
                "Mustang", "1964 - Present", "Unparralled Performace. 4 out 5."),
            new Product("/Images/camero.jpg", "Chevy Camaro", 4, "Muscle Car", "General Motors", "Chevrolet",
                "Camaro", "1966 - Present", "This car puts the thrill in every ride. 4.5 out of 5."),
            new Product("/Images/prelude.jpg", "Honda Prelude", 5, "90's Ricer Dream!", "Honda Motor Company, Ltd.", "Honda", "Prelude",
                "1978 - 2001", "Sporty Coupe! 3.8 out of 5.")
            };

        }

        public IEnumerable<Product> GetAll()
        {
            return carsList;
        }

        public Product GetByID(int id)
        {
            return carsList.Single(p => p.ID == id);
        }
    }
}
