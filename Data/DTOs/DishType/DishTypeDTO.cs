using System;
using System.ComponentModel.DataAnnotations;

namespace AppRestaurant.Data.DTOs.DishType{

    public class DishTypeDTO{
        
        [Required(ErrorMessage = "Dish Name field is required.")]
        public string Name{get; set;}

        [CustomValidation(typeof(CustomValidationModels), nameof(CustomValidationModels.TimeOfDayValidate))]
        [Required(ErrorMessage = "Time of day field is required.")]
        public string TimeOfDay{get; set;}    
    }

}