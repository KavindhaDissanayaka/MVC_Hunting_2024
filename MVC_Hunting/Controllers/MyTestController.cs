using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Hunting.Controllers
{
    public class MyTestController : Controller
    {
        // GET: MyTest
        public ActionResult Index()
        {
            return View();
        }
        public String Welcome(string Name,int ID =1)
        {
            int hour = System.DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Good morning" : "Good afternoon";
            return HttpUtility.HtmlEncode( $"Hellow {Name}. {Greeting}. Your ID is {ID}");
        }
        public String Welcome1()
        {
            int hour = System.DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Good morning" : "Good afternoon";
            return $"<h1>Hellow {Greeting}.</h1>";
        }
        public String Play()
        {
            int hour = System.DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Good morning" : "Good afternoon";
            return $"<h1>Play {Greeting}.</h1>";
        }
    }
}