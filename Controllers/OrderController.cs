using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppRestaurant.Models;

namespace AppRestaurant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private static List<Order> orders = new List<Order>();
        // private RestaurantContext _context;
        // private IMapper _mapper;

        // public OrderController(RestaurantContext context, Imapper){

        // }

        [HttpGet]
        public IActionResult RetrieveOrder()
        {
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public Order RetrieveOrdersForId(int id)
        {
            return order.FirstOrDefault(order => order.Id == id);
        }
        
    }
}
