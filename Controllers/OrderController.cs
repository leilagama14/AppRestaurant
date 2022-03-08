using System;
using AutoMapper;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppRestaurant.Models;
using AppRestaurant.Data;

namespace AppRestaurant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private static List<Order> orders = new List<Order>();
        private RestaurantContext _context;

        public OrderController(RestaurantContext context){
            _context = context;
        }

        [HttpGet]
        public IActionResult RetrieveOrder()
        {
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public IActionResult RetrieveOrdersForId(int id)
        {
            Order order = orders.FirstOrDefault(order => order.Id == id);
            if(order != null){
                return Ok(order);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddOrder([FromBody] Order order){
            _context.Orders.Add(order);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RetrieveOrdersForId), new {Id = order.Id}, order);              
        }

        
    }
}
