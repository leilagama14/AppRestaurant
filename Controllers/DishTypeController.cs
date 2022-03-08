using System;
using AutoMapper;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppRestaurant.Data;
using AppRestaurant.Data.DTOs.DishType;
using AppRestaurant.Models;

namespace AppRestaurant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DishTypeController : ControllerBase
    {
        private RestaurantContext _context;

        public DishTypeController(RestaurantContext context){
            _context = context;
        }

        [HttpPost]
        public IActionResult AddDish([FromBody] DishType dishtype){
            _context.DishTypes.Add(dishtype);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecoverDishTypeId), new {Id = dishtype.Id}, dishtype);              
        }

        [HttpGet]
        public IActionResult RecoverDishType()
        {
            return Ok(_context.DishTypes);
        }

        [HttpGet("{id}")]
        public DishType RecoverDishTypeId(int id)
        {
            DishType dishtype = _context.DishTypes.FirstOrDefault(dishtype => dishtype.Id == id);
            if(dishtype != null){
                return Ok(dishtype);
            }
            return NotFound();
        }

    }
}
