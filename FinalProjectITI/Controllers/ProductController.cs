using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectITI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowCategoris()
        {
            return PartialView("_ViewCategories");
        }


        public IActionResult ShowProducts()
        {
            return PartialView("_ViewProducts");
        }

    }
}
