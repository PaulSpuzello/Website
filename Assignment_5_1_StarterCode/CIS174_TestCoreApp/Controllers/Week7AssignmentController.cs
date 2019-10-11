using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class Week7AssignmentController : Controller
    {
        public IActionResult Index(CreateAccountViewModel model)
        {
            var viewModel = new CreateAccountViewModel();


            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Index", viewModel);
        }
    }
}