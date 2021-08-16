using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProjectITI.Data;
using FinalProjectITI.Models;
using FinalProjectITI.Services;

namespace FinalProjectITI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IBaseService<Product> productservice;
        private readonly IBaseService<Category> categoryservice;
        

        public ProductController(IBaseService<Product> productservice , IBaseService<Category> categoryservice )
        {
            this.productservice = productservice;
            this.categoryservice = categoryservice;
            
        }

        // GET: Admin/Product
        public async Task<IActionResult> Index()
        {
            ViewBag.categ = categoryservice.GetAll();
            
            return View(productservice.GetAll());
        }

        // GET: Admin/Product/Details/5
        public async Task<IActionResult> Details(int id)
        {
            ViewBag.categ = categoryservice.GetAll();

            if (id == null)
            {
                return NotFound();
            }

            return View(productservice.GetByID(id));
        }

        // GET: Admin/Product/Create
        public IActionResult Create()
        {
            // ViewData["Category_ID"] = new SelectList(categoryservice.GetAll());
            //ViewData["Images_ID"] = new SelectList(imageservice.GetAll());

            ViewBag.categ = categoryservice.GetAll();
            return View();
        }

        // POST: Admin/Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Product_ID,Product_Name,Category_ID,Description,Product_Price,Images_ID,Product_Size,Product_Color,Adding_Date,Popularity,Stored_Quantity")] Product product)
        {
            ViewBag.categ = categoryservice.GetAll();
            if (!ModelState.IsValid)
                return View(product);
            try
            {
                productservice.Add(product);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(product);
            }

        }

        // GET: Admin/Product/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.categ = categoryservice.GetAll();
            if (id == null)
            {
                return NotFound();
            }
            var product = productservice.GetByID(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.prods = productservice.GetByID(id);
            return View(product);
        }

        // POST: Admin/Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Product_ID,Product_Name,Category_ID,Description,Product_Price,Images_ID,Product_Size,Product_Color,Adding_Date,Popularity,Stored_Quantity")] Product product)
        {
            ViewBag.categ = categoryservice.GetAll();
            if (id != product.Product_ID)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                try
                {
                    productservice.Update(id, product);
                    //await _context.SaveChangesAsync();
                    //return RedirectToAction("Index");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Product_ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            //ViewData["Category_ID"] = new SelectList(_context.Categories, "Category_ID", "Category_Name", product.Category_ID);

            return View(product);

        }

        // GET: Admin/Product/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            ViewBag.categ = categoryservice.GetAll();
            if (id == null)
            {
                return NotFound();
            }

            var product = productservice.GetByID(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            productservice.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            var check = false;
            var item = productservice.GetByID(id);
            if (item != null)
            {
                check = true;
            }
            return check;
        }
    }
}
