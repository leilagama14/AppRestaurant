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
    public class DishTypeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<DishType> Get()
        {
            return null;
        }

    }
}
