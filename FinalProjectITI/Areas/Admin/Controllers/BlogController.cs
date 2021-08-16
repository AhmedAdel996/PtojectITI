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
    public class BlogController : Controller
    {
        private readonly IBaseService<Blog> blogservice;

        public BlogController(IBaseService<Blog> blogservice)
        {
            this.blogservice = blogservice;
        }

        // GET: Admin/Blog
        public async Task<IActionResult> Index()
        {
            

            return View(blogservice.GetAll());
        }

        // GET: Admin/Blog/Details/5
        public async Task<IActionResult> Details(int id)
        {
           

            if (id == null)
            {
                return NotFound();
            }

            return View(blogservice.GetByID(id));
        }

        // GET: Admin/Blog/Create
        public IActionResult Create()
        {
            
            return View();
        }

        // POST: Admin/Blog/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Blog_ID,Blog_Title,Blog_Content,Blog_Date")] Blog blog)
        {
            
            if (!ModelState.IsValid)
                return View(blog);
            try
            {
                blogservice.Add(blog);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(blog);
            }
        }

        // GET: Admin/Blog/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
           
            if (id == null)
            {
                return NotFound();
            }
            var product = blogservice.GetByID(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.blog = blogservice.GetByID(id);
            return View(product);
        }

        // POST: Admin/Blog/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Blog_ID,Blog_Title,Blog_Content,Blog_Date")] Blog blog)
        {
           
            if (id != blog.Blog_ID)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                try
                {
                    blogservice.Update(id, blog);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogExists(blog.Blog_ID))
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

            return View(blog);

        }

        // GET: Admin/Blog/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
           
            if (id == null)
            {
                return NotFound();
            }

            var blog = blogservice.GetByID(id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // POST: Admin/Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            blogservice.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool BlogExists(int id)
        {
            var check = false;
            var item = blogservice.GetByID(id);
            if (item != null)
            {
                check = true;
            }
            return check;
        }
    }
}
