using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        

        public ActionResult About()
        {
            ViewBag.Message = "Sorry, not yet implmented";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contatti.";

            return View();
        }
    }
}