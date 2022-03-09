using System.ComponentModel.DataAnnotations;

namespace AppRestaurant.Models
{

    public class DishType{

        [Key]
        [Required]
        public int Id {get; set;}
        
        [Required(ErrorMessage = "Dish Name field is required.")]
        public string Name{get; set;}        

    }

}