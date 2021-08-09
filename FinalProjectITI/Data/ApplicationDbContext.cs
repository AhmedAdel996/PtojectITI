using FinalProjectITI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectITI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryType> CategoryTypes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product>  Products { get; set; }
        public virtual DbSet<ProductCategoryTypes> ProductCategoryTypes { get; set; }
        public virtual DbSet<Shipping> Shippings { get; set; }
        public virtual DbSet<UserProducts> UserProducts { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<BlogCategoryTypes> BlogCategoryTypes { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Paypal> Paypals { get; set; }
        public virtual DbSet<UserWishList> UserWishLists { get; set; }
        public virtual DbSet<Visa> Visas { get; set; }

    }
}
