using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApplication.Controllers
{
    public class MySiteController : Controller
    {
        // GET: MySite
        public ActionResult Index()
        {
            return View();
        }
    }
}