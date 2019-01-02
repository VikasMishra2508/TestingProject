using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestingProject.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page Modified.";

            return View();
        }

        public ActionResult CheckTestCase(int id)
        {
            if (id < 10) throw new Exception("This Is an Error");
            ViewBag.Message = "This is a new Function";
           // return View();
        }
    }
}