using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AppRestaurant.Models;

namespace AppRestaurant.Models{

    public class ReadMealDTO{

        [Required(ErrorMessage = "Meal name field is required")]
        public string Name{get; set;}

    }
}