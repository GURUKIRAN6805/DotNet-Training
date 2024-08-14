using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Controllers
{
    public class Customers
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}