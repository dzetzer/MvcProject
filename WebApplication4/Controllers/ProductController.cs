using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;
using MvcProject.Repositories;

namespace MvcProject.Controllers
{
    public class ProductController : Controller
    {
        IRepository<Product> productRepo;

        public ProductController(IRepository<Product> productRepo)
        {
            this.productRepo = productRepo;
        }

        public ViewResult Index()
        {
            var model = productRepo.GetAll();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = productRepo.GetByID(id);

            return View(model);
        }
    }
}