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

        public ViewResult Review(int id)
        {
            var model = reviewRepo.GetByProductID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Review review)
        {
            reviewRepo.Create(review);
            return RedirectToAction("Review", new { id = review.ProductID });
        }

        [HttpPost]
        public ActionResult Delete(Review review)
        {
            reviewRepo.Delete(review);
            return RedirectToAction("Review", new { id = review.ProductID });
        }

        [HttpPost]
        public ActionResult Edit(Review review)
        {
            reviewRepo.Edit(review);
            return RedirectToAction("Review", new { id = review.ProductID });
        }

        [HttpGet]
        public ViewResult CreateByProductID(int id)
        {
            ViewBag.ProductID = id;
            return View();
        }

        [HttpGet]
        public ViewResult EditByProductID(int id)
        {
            var model = reviewRepo.GetByID(id);           
            return View(model);
        }

        [HttpGet]
        public ViewResult DeleteByProductID(int id)
        {
            var model = reviewRepo.GetByID(id);
            return View(model);
        }

    }

    
}
