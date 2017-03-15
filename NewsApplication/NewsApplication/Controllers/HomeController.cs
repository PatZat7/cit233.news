using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Local()
        {
            ViewBag.Message = "Local";
            return View();
        }

        public ActionResult Weather()
        {
            ViewBag.Message = "Weather";

            return View();
        }
        public ActionResult Entertainment()
        {
            ViewBag.Message = "Entertainment";

            return View();
        }

        public ActionResult Politics()
        {
            ViewBag.Message = "Political";

            return View();
        }
    }
}