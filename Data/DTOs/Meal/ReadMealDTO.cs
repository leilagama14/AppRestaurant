using System.ComponentModel.DataAnnotations;

namespace AppRestaurant.Models
{

    public class ReadMealDTO{

        [Required(ErrorMessage = "Meal name field is required")]
        public string Name{get; set;}

    }
}