using System.ComponentModel.DataAnnotations;
using AppRestaurant.Models;
using System.Collections.Generic;

namespace AppRestaurant.Data.DTOs.Order
{

    public class ReadyOrderDTO{
        
        [Required(ErrorMessage = "Dish Name field is required.")]
        public string Name{get; set;}

        [CustomValidation(typeof(CustomValidationModels), nameof(CustomValidationModels.TimeOfDayValidate))]
        [Required(ErrorMessage = "Time of day field is required.")]
        public string TimeOfDay{get; set;}    

        [Required(ErrorMessage = "Quantity Items field is required.")]
        public int QuantityItems{get; set;}

        public List<Meal> Meals{get; set;}
    }

}