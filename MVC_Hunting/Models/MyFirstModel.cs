using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Hunting.Models
{
    public class MyFirstModel
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
        public Boolean? WillAttend { get; set; }

        public String GuestResponse { get; set; }
    }
}