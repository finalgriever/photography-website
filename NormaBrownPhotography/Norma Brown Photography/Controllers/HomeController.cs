using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Norma_Brown_Photography.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "How Norma Catpured the World.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us for a quote, or to make a booking.";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Normas Photography Blog";

            return View();
        }

        public ActionResult Events()
        {
            ViewBag.Message = "Upcoming Events.";

            return View();
        }
    }
}