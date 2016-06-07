using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApplication.Controllers
{
    public class DBController : Controller
    {
        // GET: DB
        public ActionResult Index()
        {
            ServiceReference1.ServiceClient sc = new ServiceReference1.ServiceClient();
            return View(sc.GetData());
        }
    }
}