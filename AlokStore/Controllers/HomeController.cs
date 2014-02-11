using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlokStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "A Simple Customer Tracking Tools.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description on Home page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Store contact page.";

            return View();
        }
    }
}
