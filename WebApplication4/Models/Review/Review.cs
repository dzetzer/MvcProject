using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Models
{
    public class Review
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public int ID { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public string UserName { get; set; }

        public virtual int ProductID { get; set; }

        public virtual Product Product { get; set; }


        public Review()
        {
        }

        public Review(string image, string title, int id, string content,
            int rating, string userName/*, int productID*/)
        {
            this.Title = title;
            this.Image = image;
            this.ID = id;
            this.Content = content;
            this.Rating = rating;
            this.UserName = userName;

            //this.ProductID = productID;
        }
    }


}
