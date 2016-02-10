using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uppgift1.Models;

namespace Uppgift1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var model = new QuizViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(QuizViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", model);
            }
            return View(model);
        }
    }
}