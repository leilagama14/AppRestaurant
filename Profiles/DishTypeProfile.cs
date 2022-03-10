using AutoMapper;
using AppRestaurant.Models;
using AppRestaurant.Data.DTOs.DishType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRestaurant.Profiles{
    public class DishTypeProfile : Profile{
        
        public DishTypeProfile()
        {
            CreateMap<CreateDishTypeDTO, DishType>();
            CreateMap<DishType, ReadDishTypeDTO>();            
        }
    }


}