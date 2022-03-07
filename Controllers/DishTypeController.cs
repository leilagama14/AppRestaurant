using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
