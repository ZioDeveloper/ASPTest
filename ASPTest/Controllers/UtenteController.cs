using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPTest.Models;

namespace ASPTest.Controllers
{
    public class UtenteController : Controller
    {
        // GET: Utente
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Titel = "";
            return View();
        }

        [HttpPost]
        public ActionResult Login(UtenteLoginModel utente)
        {
            return View();

        }
    }
}