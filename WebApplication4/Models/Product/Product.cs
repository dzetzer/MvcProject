﻿using System;
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

        public Product()
        {
        }

        
    }
}
