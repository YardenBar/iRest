using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult תפריט()
        {
            ViewBag.Message = "menu";

            return View();
        }

        public ActionResult מועדון()
        {
            ViewBag.Message = "club membership";

            return View();
        }
        public ActionResult מקום ()
        {
            ViewBag.Message = "table reservation";

            return View();
        }
        public ActionResult פרטים()
        {
            ViewBag.Message = "your profile";

            return View();
        }

        public ActionResult ההזמנה_שלך()
        {
            ViewBag.Message = "Your order";

            return View();
        }

        public ActionResult חנות()
        {
            ViewBag.Message = "resturants store";

            return View();
        }

    }
}