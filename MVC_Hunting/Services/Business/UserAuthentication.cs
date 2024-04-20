using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Hunting.Models;
using MVC_Hunting.Services.Data;

namespace MVC_Hunting.Services.Business
{

    public class UserAuthentication
    {

        public Boolean isAvailableUser(String strUserName)
        {
            Boolean AvailableYN = false;

            IDataReader dr = SQLHelper.ExcequteReader($"Select UserName From Users where UserName = '{strUserName}'", CommandType.Text);

            if (dr.Read())
            {
                AvailableYN = true;
            }

            return AvailableYN;
        }
        public Boolean CheckValidUser(String UserName,String Password)
        {
            Boolean UserValidYN = false;

            IDataReader dr = Data.SQLHelper.ExcequteReader($"Select UserName from Users where UserName = '{UserName}' and Password = '{Password}'",CommandType.Text);

            if(dr.Read())
            {
                UserValidYN = true;
            }
            return UserValidYN;
        }
        public void InsertNewUser(String UserName,String Password,String UserRole)
        {
            Data.SQLHelper.ExecuteNonQuery($"INSERT INTO [dbo].[Users] ([UserName] ,[Password] ,[ResetDate] ,[inactive] ,[UserRole]) VALUES ('{UserName}' ,'{Password}' ,GETDATE() ,'{false}' ,'{UserRole}')",CommandType.Text);
        }
    }
}