using AutoMapper;
using AppRestaurant.Models;

namespace AppRestaurant.Profiles
{
    public class MealProfile : Profile{
        
        public MealProfile()
        {
            CreateMap<CreateMealDTO, Meal>();
            CreateMap<Meal, ReadMealDTO>();            
        }
    }


}