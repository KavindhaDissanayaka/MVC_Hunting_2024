using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Hunting.Models;
namespace MVC_Hunting.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }

        public string Login(UserModel myModel)
        {
            return $"Login Detail\nUserName : {myModel.UserName}\nPassword : {myModel.Password}";
        }
     
    }
}