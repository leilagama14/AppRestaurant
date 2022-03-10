using AutoMapper;
using AppRestaurant.Models;
using AppRestaurant.Data.DTOs.Order;

namespace AppRestaurant.Profiles
{
    public class OrderProfile : Profile{
        
        public OrderProfile()
        {
            CreateMap<CreateOrderDTO, Order>();
            CreateMap<Order, ReadyOrderDTO>();            
        }
    }


}