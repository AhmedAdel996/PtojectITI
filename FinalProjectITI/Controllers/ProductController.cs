using FinalProjectITI.Data;
using FinalProjectITI.Models;
using FinalProjectITI.Services;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectITI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IBaseService<Product> baseService;

        public ProductController(IBaseService<Product> baseService)
        {
            this.baseService = baseService;
        }
        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 16;
            var items = baseService.GetAll().ToPagedList(pageNumber, pageSize);
            return View(items);
        }
        public IActionResult ProductDetails(int id)
        {
            Product product = baseService.GetByID(id);
            return View(product);
        }
    }
}
