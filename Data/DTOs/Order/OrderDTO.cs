using System;
using System.ComponentModel.DataAnnotations;
using AppRestaurant.Models;

namespace AppRestaurant.Data.DTOs.Order{

    public class OrderDTO{
        
        [Required(ErrorMessage = "Dish Name field is required.")]
        public string Name{get; set;}

        [CustomValidation(typeof(CustomValidationModels), nameof(CustomValidationModels.TimeOfDayValidate))]
        [Required(ErrorMessage = "Time of day field is required.")]
        public string TimeOfDay{get; set;}    
    }

}