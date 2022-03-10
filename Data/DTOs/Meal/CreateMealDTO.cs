using System.ComponentModel.DataAnnotations;

namespace AppRestaurant.Models
{

    public class CreateMealDTO{

        [Required(ErrorMessage = "Meal name field is required")]
        public string Name{get; set;}

    }
}