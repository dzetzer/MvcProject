using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Models.Product
{
    public class Product
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }
        public string Category { get; set; }
        public string Manufacturer { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Content { get; set; }

        public Product()
        {
        }
        
        public Product(string Image, string Title, int ID, string Category, string Manufacter, string Make)
        {

        }
}
