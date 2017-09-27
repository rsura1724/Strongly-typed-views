using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StronglyTypedViews.Models
{
    public class Register
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string gender { get; set; }
        public string  email { get; set; }
    }
}