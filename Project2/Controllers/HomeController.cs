using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Price price = new Price();
            return View(price); ;
        }

        [HttpPost]
        public IActionResult Index(Price price)
        {
            if(ModelState.IsValid)
                price.CalculateTotal();

            return View(price);
        }
    }
}