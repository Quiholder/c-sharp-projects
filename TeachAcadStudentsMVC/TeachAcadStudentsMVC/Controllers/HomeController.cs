using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeachAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        //method called Index(). Analyzing its signature, we see that it accepts no parameters and its return type is a data type called ActionResult.
        //ActionResult is a class defined in the System.Web.Mvc library.
        // think of an ActionResult as “rendered HTML,” although it could be as varied as a “processed file” or “JSON-formatted data.”
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}