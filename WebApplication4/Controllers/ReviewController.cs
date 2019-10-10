using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;
using MvcProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<Review> reviewRepo;

        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Review(int productID)
        {
            var model = reviewRepo.GetByProductID(productID);

            return View(model);
        }

        //public ViewResult Details(int id)
        //{
        //    var model = reviewRepo.GetByID(id);

        //    return View(model);
        //}
    }
}
