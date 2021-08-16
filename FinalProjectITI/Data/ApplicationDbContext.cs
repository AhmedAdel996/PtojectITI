using FinalProjectITI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectITI.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("data source=.;initial catalog=FinalProjectITI;integrated security=True;");
        //}

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product>  Products { get; set; }
        public virtual DbSet<ProductTags> ProductTags { get; set; }
        public virtual DbSet<Shipping> Shippings { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<BlogTags> BlogTags { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<UserWishList> UserWishLists { get; set; }
        public virtual DbSet<Images> Images { get; set; }
    }
}
