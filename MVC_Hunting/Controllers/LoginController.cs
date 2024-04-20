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

        public ActionResult Login(UserModel myModel)
        {
            //return $"Login Detail\nUserName : {myModel.UserName}\nPassword : {myModel.Password}";
            SecurityService myService = new SecurityService();
            UserAuthentication myUser = new UserAuthentication();
            String UserName = String.Empty;
            String UserPW = String.Empty;
            if (myService.GetUserData(myModel).Count == 2)
            {

                UserName = myService.GetUserData(myModel)[0];
                UserPW = myService.GetUserData(myModel)[1];
            }

            //if (myService.CheckValidUser(myModel))
            //{
               

            //    return View("LoginSuccess", myModel);
            //}
            //else
            //{
            //    return View("LoginFail",myModel);
            //}

            if(myUser.isAvailableUser(UserName))
            {
                if (myUser.CheckValidUser(UserName, UserPW))
                {

                    return View("LoginSuccess", myModel);
                }
                else
                {
                    return View("LoginFail", myModel);
                }
            }
            else
            {
                return View("Signin");
            }
        }
        [HttpPost]
        public ActionResult Signin(UserModel myUserModle)
        {
            UserAuthentication myUser = new UserAuthentication();
            myUser.InsertNewUser(myUserModle.UserName, myUserModle.Password, myUserModle.UserRole);
            return View("Login");
        }
       
    }
}