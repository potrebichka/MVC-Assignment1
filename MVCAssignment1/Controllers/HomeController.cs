using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignment1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string input)
        {
            if (input == "sample")
                return File("Sample.pdf", "application/pdf");
            else if (input == "gotoabout")
                return RedirectToAction("About");
            else if (input == "login")
                return View("Login");
            else
                return Content($"You entered: " + input);
        }

        public ActionResult About()
        {
            return Content("About Content here", "text/plain");
        }
    }
}