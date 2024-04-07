using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Hunting.Models;
using MVC_Hunting.Services.Business;

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
            //return $"Login Detail\nUserName : {myModel.UserName}\nPassword : {myModel.Password}";
            SecurityService myService = new SecurityService();
            String UserName = String.Empty;
            String UserPW = String.Empty;
            if (myService.GetUserData(myModel).Count == 2)
            {

                UserName = myService.GetUserData(myModel)[0];
                UserPW = myService.GetUserData(myModel)[1];
            }

            if (myService.CheckValidUser(myModel))
            {
               

                return $"User Login Success..!. Your User name is {UserName} and Your password is {UserPW}";
            }
            else
            {
                return $"Invalid Username or Password...! You Entered your UserName as {UserName} And Passwors as {UserPW}. Please check and enter a Valid User Credintial.";
            }

        }
     
    }
}