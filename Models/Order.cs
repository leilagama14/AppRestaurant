using System;
using System.ComponentModel.DataAnnotations;
using AppRestaurant.Models;

namespace AppRestaurant.Models{

    public class Order{

        [Key]
        [Required]
        public int id {get; set;}
        
        [Required(ErrorMessage = "Dish Name field is required")]
        public string Name{get; set;}

        [Required(ErrorMessage = "Dish Name field is Quantity Items")]
        public int QuantityItems {get; set;}
       
        public TimeDay TimeDay {get; set;}

        public DishType DishType {get; set;}

    }
}