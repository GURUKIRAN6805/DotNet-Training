using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class CodeController : Controller
    {
        private readonly NorthwindDBEntities _context;
        public CodeController()
        {
            _context = new NorthwindDBEntities();
        }
        public ActionResult CustomersInGermany()
        {
            var customers = _context.Customers
                                    .Where(c => c.Country == "Germany")
                                    .Select(c => new Customers
                                    {
                                        CustomerID = c.CustomerID,
                                        CompanyName = c.CompanyName,
                                        ContactName = c.ContactName,
                                        City = c.City,
                                        Country = c.Country
                                    }).ToList();
            return View(customers);
        }

        public ActionResult CustomerDetailsForOrder()
        {
            var customer = (from o in _context.Orders
                            join c in _context.Customers on o.CustomerID equals c.CustomerID
                            where o.OrderID == 6805
                            select new Customers
                            {
                                CustomerID = c.CustomerID,
                                CompanyName = c.CompanyName,
                                ContactName = c.ContactName,
                                City = c.City,
                                Country = c.Country
                            }).FirstOrDefault();
            return View(customer);
        }
    }
}
