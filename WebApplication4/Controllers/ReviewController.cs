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

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Review review)
        {
            reviewRepo.Create(review);
            return RedirectToAction("Details");
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = reviewRepo.GetByProductID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Review review)
        {
            reviewRepo.Delete(review);
            return RedirectToAction("Details");
        }

        //[HttpGet]
        //public ViewResult Edit
        //{
        //    var model = reviewRepo.GetByProductID(id);
        //    return View(model);
        //}

        //[HttpPost]
        //public ActionResult Edit()
        //{
        //reviewRepo.Edit(review);
        //return RedirectToAction("Details");
        //}
    }

    
}
