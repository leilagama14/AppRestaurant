using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppRestaurant.Models;

namespace AppRestaurant.Data{

    public class RestaurantContext : DbContext{

        public RestaurantContext(DbContextOptions<RestaurantContext> opt) : base (opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<DishType>()
            .HasOne(dishtype => dishtype.Order)
            .WithOne(order => order.DishType)
            .HasForeignKey<Order>(order => order.OrderId);
        }
              
        public DbSet<DishType> DishTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
    
}