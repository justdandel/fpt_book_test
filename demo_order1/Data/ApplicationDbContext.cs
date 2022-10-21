using demo_order1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace demo_order1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Laptopcs> Laptopcs { get; set; }
        public DbSet<Order> orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Laptopcs>().HasData(
                new Laptopcs
                {
                    Id = 1, 
                    Name = "loz",
                    Price = 5,
                    Img = "https://upload.wikimedia.org/wikipedia/commons/3/3c/IMG_logo_%282017%29.svg",
                    Quantity = 10
                },
                new Laptopcs
                {
                    Id = 2, 
                    Name = "loz 1",
                    Price = 5,
                    Img = "https://upload.wikimedia.org/wikipedia/commons/3/3c/IMG_logo_%282017%29.svg",
                    Quantity = 10
                }
                );
        }
    }
}
