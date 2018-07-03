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

    }
}