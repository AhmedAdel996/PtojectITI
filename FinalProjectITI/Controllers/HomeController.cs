using FinalProjectITI.Data;
using FinalProjectITI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectITI.Controllers
{
    public class HomeController : Controller
    {
       // ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}
