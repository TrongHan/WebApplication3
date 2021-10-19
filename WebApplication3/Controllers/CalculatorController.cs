using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View("My view");
        }
        public IActionResult chuyendolathanhdong(float a)
        {
            Models.Calculator cal = new Models.Calculator(a);
            cal.chuyendolathanhdong();
            return View("My view",cal);
        }
        
    }
}
