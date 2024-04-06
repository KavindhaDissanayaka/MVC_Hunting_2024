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
            ViewBag.MyFirstViewBag = "This is My First View Bag";
            return View();
        }
    }
}