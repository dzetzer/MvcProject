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

        public ViewResult Create()
        {
            return View();
        }

        public ActionResult Create(Review review)
        {
            reviewRepo.Create(review);
            return RedirectToAction("Details");
        }

        public ActionResult Delete(Review review)
        {
            reviewRepo.Delete(review);
            return RedirectToAction("Details");
        }

        public ViewResult Delete(int id)
        {
            var model = reviewRepo.GetByProductID(id);
            return View(model);
        }

        public ActionResult Edit()
        {
            return View();
        }

    }
}
