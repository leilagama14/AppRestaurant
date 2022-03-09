using System;
using System.ComponentModel.DataAnnotations;
using AppRestaurant.Models;

namespace AppRestaurant.Data.DTOs.DishType{

    public class CreateDishTypeDTO{
       
        [Required(ErrorMessage = "Dish Name field is required.")]
        public string Name{get; set;}
    }

}