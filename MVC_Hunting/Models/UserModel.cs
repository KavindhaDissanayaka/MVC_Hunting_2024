﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Hunting.Models
{
    public class UserModel
    {
        public String  UserName { get; set; }
        public String Password { get; set; }
        public DateTime ResetDate { get; set; }
        public Boolean inactive { get; set; }
        public String UserRole { get; set; }
    }
}