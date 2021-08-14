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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-9D1AT3T;initial catalog=FinalProjectITI;integrated security=True;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product>  Products { get; set; }
        public DbSet<ProductTags> ProductTags { get; set; }
        public DbSet<Shipping> Shippings { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogTags> BlogTags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserWishList> UserWishLists { get; set; }
        public DbSet<Images> Images { get; set; }
    }
}
