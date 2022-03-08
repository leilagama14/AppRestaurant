using System;
using AutoMapper;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppRestaurant.Data;
using AppRestaurant.Models;

namespace AppRestaurant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DishTypeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<DishType> RecoverDishType()
        {
            return null;
        }

    }
}
