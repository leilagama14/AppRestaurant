using System;
using AutoMapper;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppRestaurant.Models;
using AppRestaurant.Data;
using AppRestaurant.Data.DTOs.Order;

namespace AppRestaurant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {        
        private RestaurantContext _context;
        private IMapper _mapper;

        public OrderController(RestaurantContext context, IMapper mapper){
            _context = context;
             _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Order> RetrieveOrder()
        {
            return _context.Orders;
        }

        [HttpGet("{id}")]
        public IActionResult RetrieveOrdersForId(int id)
        {
            Order order = _context.Orders.FirstOrDefault(order => order.Id == id);
            if(order != null){
                ReadyOrderDTO orderDTO = _mapper.Map<ReadyOrderDTO>(order);
                return Ok(orderDTO);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddOrder([FromBody] CreateOrderDTO orderDTO){
            Order order = _mapper.Map<Order>(orderDTO);
            _context.Orders.Add(order);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RetrieveOrdersForId), new {Id = order.Id}, order);              
        }
        
    }
}
