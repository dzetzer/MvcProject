using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Models
{
    public class Product
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public int ID { get; set; }
        public string Category { get; set; }
        public string Manufacturer { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }


        public virtual ICollection<Review> Reviews { get; set; }

        //public string Content { get; set; }

        //public virtual int ReviewID { get; set; }

        //public virtual Review Review { get; set; }

        public Product()
        {
        }

        public Product(string image, string title, int id, string category,
            string manufacter, string make, string model, string year/*, string content*/)
        {
            this.Image = image;
            this.Title = title;
            this.ID = id;
            this.Category = category;
            this.Manufacturer = manufacter;
            this.Make = make;
            this.Model = model;
            this.Year = year;
            //this.Content = content;
        }
    }
}
