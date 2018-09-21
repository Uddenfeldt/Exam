using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpangenbergProject.Models;

namespace SpangenbergProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult ForCompany()
        {
            return View();
        }
        public IActionResult ForPrivate()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BookingForPrivate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BookingForPrivate(int Id, string FirstName, string LastName, string Email, DateTime Dtm, TimeSpan Tme)
        {
            return Content($"Hej {FirstName} {LastName}, din email är {Email}. ni önskade boka tid den {Dtm} klockan {Tme}");
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
