using MVC_Hunting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Hunting.Services.Data
{
    public class SecurityDAO
    {
        //DAO - Data Access Object
        internal bool FindByUser(UserModel userModel)
        {
            if(userModel.UserName == "Kavinda" && userModel.Password == "ksd1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<String> UserDetails(UserModel myUser)
        {
            List<String> UserDetails = new List<string>
            {
                myUser.UserName,
                myUser.Password
            };

            return UserDetails;
        }
    }
}