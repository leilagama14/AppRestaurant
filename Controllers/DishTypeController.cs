using AutoMapper;
using System.Linq;
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
        private IMapper _mapper;

        public DishTypeController(RestaurantContext context, IMapper mapper){
            _context = context;
             _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddDish([FromBody] CreateDishTypeDTO dishTypeDTO){
            DishType dishtype = _mapper.Map<DishType>(dishTypeDTO);
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
        public IActionResult RecoverDishTypeId(int id)
        {
            DishType dishtype = _context.DishTypes.FirstOrDefault(dishtype => dishtype.Id == id);
            if(dishtype != null){
                return Ok(dishtype);
            }
            return NotFound();
        }

    }
}
