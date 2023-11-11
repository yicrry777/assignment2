using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Intro ()
        {
            return View();
        }
        public ActionResult Relationship ()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult Index()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult Instro()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


    }
}