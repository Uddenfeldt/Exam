﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpangenbergProject.Controllers.Company
{
    public class CompanyController : Controller
    {
        // GET: /<controller>/
        public IActionResult Leadership()
        {
            return View();
        }
        public IActionResult LeadershipDevelopment()
        {
            return View();
        }
        public IActionResult GroupAndTeam()
        {
            return View();
        }

        public IActionResult Organization()
        {
            return View();
        }

        public IActionResult Conflicts()
        {
            return View();
        }
    }
}
