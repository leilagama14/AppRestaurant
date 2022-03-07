using System;
using System.ComponentModel.DataAnnotations;
using AppRestaurant.Models;

namespace AppRestaurant.Models{

    public class TimeDay{

        [Key]
        [Required]
        public int id {get; set;}
        
        [Required(ErrorMessage = "The field time of day is required")]
        public string Description{get; set;}
        
    }
}