using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;
using MvcProject.Repositories;

namespace MvcProject.Controllers.FormController
{
    public class FormController : Controller
    {
        IRepository<Product> formRepo;

        public FormController(IRepository<Product> formRepo)
        {
            this.formRepo = formRepo;
        }

        public ViewResult Index()
        {
            var model = formRepo.GetAll();

            return View(model);
        }
    }
}
