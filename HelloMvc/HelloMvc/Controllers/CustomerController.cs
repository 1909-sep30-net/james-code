using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMvc.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name= "Nick Endersk" },
                new Customer { Id = 1, Name = "Frank Krank" }
            };


            return View();
        }
    }
}