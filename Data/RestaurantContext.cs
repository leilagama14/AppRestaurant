using Microsoft.EntityFrameworkCore;
using AppRestaurant.Models;

namespace AppRestaurant.Data
{

    public class RestaurantContext : DbContext{

        public RestaurantContext(DbContextOptions<RestaurantContext> opt) : base (opt)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder){

            builder.Entity<Meal>()
            .HasOne(meal => meal.Order)
            .WithOne(order => order.Meal)
            .HasForeignKey<Order>(order => order.IdMeal);
        }
              
        public DbSet<Order> Orders { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<DishType> DishTypes { get; set; }
    }
    
}