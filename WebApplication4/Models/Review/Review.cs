using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Models
{
    public class Review
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public string UserName { get; set; }

        public virtual int ProductID { get; set; }

        public virtual Product Product { get; set; }
    }
}
