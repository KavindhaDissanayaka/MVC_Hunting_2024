using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Hunting.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //public String Index()
        //{
        //    return "My Name Is Kavinda";
        //}
        public ViewResult Index()
        {
            int ThisHour = System.DateTime.Now.Hour;
            ViewBag.Greeting = ThisHour < 12 ? "Good Morning" : "Good Afternoon";
            ViewBag.MyFirstViewBag = "Well Come to the my World";
            return View();
        }

        public ViewResult RsvpForm()
        {
            return View();
        }
        public ViewResult testPage()
        {
            return View();
        }
    }
}