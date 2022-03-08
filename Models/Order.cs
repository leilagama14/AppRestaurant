using System;
using System.ComponentModel.DataAnnotations;
using AppRestaurant.Models;

namespace AppRestaurant.Models{

    public class Order{

        [Key]
        [Required]
        public int Id {get; set;}
        
        [Required(ErrorMessage = "Dish Name field is required")]
        public string Name{get; set;}

        [Required(ErrorMessage = "Dish Name field is Quantity Items")]
        public int QuantityItems {get; set;}            

        public virtual DishType DishType {get; set;}

        public int OrderId {get; set;}

    }
}