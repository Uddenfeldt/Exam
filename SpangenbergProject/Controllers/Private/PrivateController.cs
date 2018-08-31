using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SpangenbergProject.Controllers
{
    public class PrivateController : Controller
    {

        public IActionResult ErikSpangenberg()
        {
            return View();
        }
        public IActionResult LottaWibergSpangenberg()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BookingForPrivate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BookingForPrivate(int ID, string FirstName, string LastName,string email, DateTime dtm, DateTime tme )
        {
            return Content($"Hello {FirstName} {LastName} {email} {dtm} {tme}");
        }

    }
}