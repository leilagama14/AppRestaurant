using System;
using System.ComponentModel.DataAnnotations;
using AppRestaurant.Models;

namespace AppRestaurant.Models{

    public class CustomValidationModels{

        public static ValidationResult TimeOfDayValidate(object input)
        {
            var result = ValidationResult.Success;

            if (input?.ToString()?.ToUpperInvariant() != "MORNING" || input?.ToString()?.ToUpperInvariant() != "NIGHT")
            {
                result = new ValidationResult("Time of day are not allowed.");
            }

            return result;
        }

    }
}