using AdoMvcRam.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AdoMvcRam.DalCustomer;

namespace AdoMvcRam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            CustomerDal custDal = new CustomerDal();
            List<CustomerList> customerLists = new List<CustomerList>();
            customerLists = custDal.Showcust();
            return View(customerLists);
        }
        
        [Route("Home/Insert")]
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        [Route("Home/Inserting")]
        public IActionResult Inserting(CustomerList c)
        {
                string CustomerName = c.CustomerName;
                string EmailId = c.EmailId;
                string MobileNo = c.MobileNo;
            CustomerDal customerDal = new CustomerDal();
            int result = customerDal.putdata(CustomerName,EmailId,MobileNo);
            if(result==1)
            return RedirectToAction("Index");
            else
                return RedirectToAction("Insert");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
