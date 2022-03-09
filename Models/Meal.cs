using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AppRestaurant.Models;

namespace AppRestaurant.Models{

    public class Meal{

        [Key]
        [Required]
        public int Id {get; set;}
        
        [Required(ErrorMessage = "Meal name field is required")]
        public string Name{get; set;}     
        
        public virtual Order Order { get; set; } 

    }
}