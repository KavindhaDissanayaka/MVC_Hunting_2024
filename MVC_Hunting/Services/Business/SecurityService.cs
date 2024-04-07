using MVC_Hunting.Models;
using MVC_Hunting.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Hunting.Services.Business
{
    public class SecurityService
    {
        SecurityDAO securityDAO = new SecurityDAO();

        public Boolean CheckValidUser(UserModel userModel)
        {
            return securityDAO.FindByUser(userModel);
        }

        public List<String> GetUserData(UserModel myUser)
        {
            return securityDAO.UserDetails(myUser);
        }

    }
}