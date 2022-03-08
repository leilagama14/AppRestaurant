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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder){

            modelBuilder.Entity<DishType>()
            .Property<int>("OrderId");

            builder.Entity<Order>()
            .HasOne(order => order.DishType)
            .HasMany(dishtype => dishtype.Order)            
            .HasForeignKey<DishType>(dishtype => dishtype.OrderId);
        }
              
        public DbSet<DishType> DishTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
    
}