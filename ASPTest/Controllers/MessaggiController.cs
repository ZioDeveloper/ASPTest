using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPTest.Controllers
{
    [Authorize]
    public class MessaggiController : Controller
    {
        // GET: Messaggi
        public ActionResult Index()
        {
            return View();
        }


        // Se voglio far passare un anonimo in una Action...
        [AllowAnonymous]
        public ActionResult Counter()
        {
            // fai qualcosa...
            return View();
        }
    }
}