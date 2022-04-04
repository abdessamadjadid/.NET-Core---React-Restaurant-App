using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class RestaurantDBContext: DbContext 
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasKey(c => new { c.CustomerId });
        }

        public RestaurantDBContext(DbContextOptions<RestaurantDBContext> options):base(options)
        {
           
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderMaster> OrderMasters { get; set; }

    }
}
